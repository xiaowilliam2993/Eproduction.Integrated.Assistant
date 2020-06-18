using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Eproduction.Integrated.Assistant.Common.Worker {
    public enum DataSourceType {
        All = 0,
        E10 = 1,
        SqlServer = 2,
        MySql = 3,
        Oracle = 4,
        Excel = 5
    }
    public static class SqlServerWorker {
        public const string Local = "(local)";
        public static bool IsInstalledv2014() {
            try {
                var registryKey = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Microsoft SQL Server");
                if (registryKey != null) {
                    return registryKey.GetSubKeyNames().Any(_ => _.Contains("12"));
                }
            } catch (Exception) { throw; }
            return false;
        }
        public static Version GetVersion(string connectionString) {
            Version version = null;
            SqlConnection connection = null;
            try {
                using (connection = new SqlConnection("data source=.;initial catalog=master;Integrated Security=True;MultipleActiveResultSets=True;App=EntityFramework")) {
                    connection.Open();
                    version = new Version(connection.ServerVersion);
                }
            } catch (Exception) { throw; } finally {
                if (connection != null && connection.State == ConnectionState.Open) {
                    connection.Close();
                    connection.Dispose();
                }
            }
            return version;
        }
        public static object TestExecute(string connectionString) {
            if (string.IsNullOrEmpty(connectionString)) {
                return null;
            }

            string sql = "SELECT 1 AS A";
            SqlConnection connection = null;
            try {
                using (connection = new SqlConnection(connectionString)) {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection)) {
                        command.CommandType = CommandType.Text;
                        return command.ExecuteScalar();
                    }
                }
            } catch (Exception) { throw; } finally {
                if(connection != null && connection.State == ConnectionState.Open) {
                    connection.Close();
                    connection.Dispose();
                }
            }
        }
        public static string[] GetDatabaseList(string connectionString) {
            List<string> databaseList = new List<string>();
            if (string.IsNullOrEmpty(connectionString)) {
                return databaseList.ToArray();
            }

            try {
                string sql = "SELECT [name] FROM [master]..[sysdatabases]";
                DataTable dbTable = Execute(connectionString, sql);
                databaseList = dbTable.Rows.Cast<DataRow>().Select(_ => _["name"].ToString()).ToList();
                databaseList.Sort();
                return databaseList.ToArray();
            } catch (Exception) {
                throw;
            }
        }

        public static int ExecuteNonQuery(string connectionString, string commandText) {
            if(string.IsNullOrEmpty(connectionString) || string.IsNullOrEmpty(commandText)) {
                return 0;
            }

            SqlConnection connection = null;
            try {
                using (connection = new SqlConnection(connectionString)) {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(commandText, connection)) {
                        return command.ExecuteNonQuery();
                    }
                }
            } catch(Exception) { throw; } finally {
                if (connection != null && connection.State == ConnectionState.Open) {
                    connection.Close();
                    connection.Dispose();
                }
            }
        }

        public static DataTable Execute(string connectionString, string commandText) {
            DataTable dataSource = null;
            if (string.IsNullOrEmpty(connectionString) || string.IsNullOrEmpty(commandText)) return dataSource;

            dataSource = new DataTable("DataSource");
            try {
                using (var adapter = new SqlDataAdapter(commandText, connectionString)) {
                    adapter.Fill(dataSource);
                }
                return dataSource;
            } catch (Exception) { throw; }
        }

        public static DataTable ExecuteIncludego(string connectionString, IEnumerable<string> commandLines) {
            DataTable dataSource = null;
            if (string.IsNullOrEmpty(connectionString) || commandLines == null || commandLines.Count() == 0) return dataSource;

            dataSource = new DataTable("DataSource");
            SqlConnection connection = null;
            try {
                using (connection = new SqlConnection(connectionString)) {
                    connection.Open();
                    using (var command = new SqlCommand()) {
                        command.CommandType = CommandType.Text;
                        command.Connection = connection;
                        StringBuilder commandText = new StringBuilder();
                        bool outputFlag = false;
                        foreach (var line in commandLines) {
                            if (line.StartsWith("--")) continue;
                            if (line.Trim().ToLower() != "go") {
                                if (line.ToLower().Contains("output_sql")) {
                                    outputFlag = true;
                                } else {
                                    commandText.AppendLine(line);
                                }
                            } else {
                                command.CommandText = commandText.ToString();
                                if (outputFlag) {
                                    using (var adapter = new SqlDataAdapter(command)) {
                                        adapter.Fill(dataSource);
                                    }
                                    outputFlag = false;
                                } else {
                                    command.ExecuteNonQuery();
                                }
                                commandText = new StringBuilder();
                            }
                        }
                    }
                }
                return dataSource;
            } catch (Exception) { throw; } finally {
                if (connection != null && connection.State == ConnectionState.Open) {
                    connection.Close();
                }
            }
        }

        public static object ExecuteScalar(string connectionString, string commandText) {
            object instance = new object();
            if (string.IsNullOrEmpty(connectionString) || string.IsNullOrEmpty(commandText)) return instance;

            SqlConnection connection = null;
            try {
                using (connection = new SqlConnection(connectionString)) {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(commandText, connection)) {
                        instance = command.ExecuteScalar();
                    }
                }
            } catch (Exception) { throw; } finally {
                if (connection != null && connection.State == ConnectionState.Open) {
                    connection.Close();
                    connection.Dispose();
                }
            }
            return instance;
        }
        //public static string[] GetAvailableSQLServers() {
        //    try {
        //        IList<string> names = new List<string>();
        //        SQLDMO.Application sqlapp = new SQLDMO.Application();
        //        SQLDMO.NameList namelist = sqlapp.ListAvailableSQLServers();
        //        if (namelist.Count > 0) {
        //            for (int i = 1; i <= namelist.Count; i++) {
        //                names.Add(namelist.Item(i));
        //            }
        //        }
        //        return names.ToArray();
        //    } catch (Exception) { throw; }
        //}
        /// <summary>
        /// 备份数据库
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="dbName"></param>
        /// <param name="diskpath"></param>
        public static void BackupDataSource(string connectionString, string dbName, string diskpath) {
            string commandText = string.Format("backup database {0} to disk='{1}'", dbName, diskpath);
            ExecuteNonQuery(connectionString, commandText);
        }
        /// <summary>
        /// 还原数据库
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="dbName"></param>
        /// <param name="diskpath"></param>
        public static void RestoreDataSource(string connectionString, string dbName, string diskpath) {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine(string.Format("alter database {0} set offline with rollback immediate", dbName));
            builder.AppendLine(string.Format("restore database {0} from disk='{1}'", dbName, diskpath));
            builder.AppendLine(string.Format("alter database {0} set online with rollback immediate", dbName));
            ExecuteNonQuery(connectionString, builder.ToString());
        }
        public static void DisconnectionDatabase(string connectionString, string dbName) {
            string commandText = string.Format("SELECT spid FROM master.sys.sysprocesses WHERE [dbid] = db_id('{0}')", dbName);
            object scalar = ExecuteScalar(connectionString, commandText);
            string spid = scalar == null ? string.Empty : scalar.ToString();
            if (!string.IsNullOrEmpty(spid)) {
                commandText = string.Format("EXEC('KILL {0}')", spid);
                ExecuteNonQuery(connectionString, commandText);
            }
        }
        /// <summary>
        /// 获取营运监控平台标准模板工作表列表
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="dataSourceType"></param>
        /// <returns></returns>
        public static DataTable GetDataSource(string connectionString, DataSourceType dataSourceType) {
            return GetDataSource(connectionString, dataSourceType, 0);
        }
        /// <summary>
        /// 获取营运监控平台标准模板工作表列表(支持Top)
        /// </summary>
        /// <param name="connectionString"></param>
        /// <param name="dataSourceType"></param>
        /// <param name="top"></param>
        /// <returns></returns>
        public static DataTable GetDataSource(string connectionString, DataSourceType dataSourceType, int top) {
            string topText = string.Empty;
            string filterText = string.Empty;
            if (top > 0) {
                topText = " TOP " + top;
            }
            if (dataSourceType != DataSourceType.All) {
                if (dataSourceType == DataSourceType.E10) {
                    filterText = " AND ([T1].[Type] = " + (int)dataSourceType + " OR [T1].[Type] = 4)";
                } else {
                    filterText = " AND [T1].[Type] = " + (int)dataSourceType;
                }
            }
            string commandText = string.Format(@"
SELECT{0} [T1].[DataSourceId], 
        ROW_NUMBER() OVER(ORDER BY [T2].[Name], [T1].[Name]) AS [Sequence], 
        [T2].[Name] AS [ProjectName], 
        [T1].[Name], 
        [T1].[Connection], 
        [T1].[Type] 
FROM [DataSource] [T1] WITH(NOLOCK) 
LEFT JOIN [DataSource] [T2] WITH(NOLOCK) ON [T1].[ProjectId] = [T2].[DataSourceId] 
WHERE [T1].[ProjectId] IS NOT NULL{1} 
ORDER BY [T1].[Type], [T2].[Name], [T1].[Name]", topText, filterText);
            var dataSources = Execute(connectionString, commandText);
            foreach (DataRow item in dataSources.Rows) {
                string connection = item["Connection"].ToString();
                item["Connection"] = connection.ToStringDecoding();
            }
            return dataSources;
        }
    }
}
