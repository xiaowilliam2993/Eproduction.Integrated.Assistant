/*
 * <Author>FuWei</Author>
 * <CreateDate>2016/11/30</CreateDate>
 * <Description>数据查询服务</Description>
 **/
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using Eproduction.Integrated.Assistant.Common.Core.Implement.Interface;

namespace Eproduction.Integrated.Assistant.Common.Core.Implement {

    [Description("数据查询服务实现")]
    public class QueryService : IQueryService {

        static string _publicConnecionString = string.Empty;
        /*
         * 数据库连接
         **/
        static string ConnectionString {
            get {
                try {
                    string connectionString = string.Empty;
                    if (!string.IsNullOrEmpty(_publicConnecionString)) {
                        connectionString = _publicConnecionString;
                    } else {
                        throw new NotImplementedException();
                    }
                    return connectionString;
                } catch (Exception) {
                    throw;
                }
            }
        }

        #region IQueryService 成员

        /*
         * 查询获取数据源
         **/
        public DataTable Execute(string sql, params SqlParameter[] parameters) {
            if (string.IsNullOrEmpty(sql)) {
                throw new ArgumentNullException("sql");
            }

            SqlConnection connection = null;
            try {
                using (connection = new SqlConnection(ConnectionString)) {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection)) {
                        command.CommandType = CommandType.Text;
                        if (parameters != null && parameters.Length > 0) {
                            command.Parameters.AddRange(parameters);
                        }
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command)) {
                            DataSet dataSet = new DataSet();
                            adapter.Fill(dataSet);
                            return dataSet.Tables[0];
                        }
                    }
                }
            } catch (Exception) {
                throw;
            } finally {
                if (connection != null && connection.State == ConnectionState.Open) {
                    connection.Close();
                }
            }
        }

        /*
         * 查询获取数据源(公开数据库连接)
         **/
        public DataTable ExecuteWithPublicConnect(string connectionString, string sql, params SqlParameter[] parameters) {
            if (string.IsNullOrEmpty(connectionString)) {
                throw new ArgumentNullException("connectionString");
            }

            try {
                _publicConnecionString = connectionString;
                return Execute(sql, parameters);
            } catch (Exception) {
                throw;
            } finally {
                _publicConnecionString = string.Empty;
            }
        }

        /*
         * 查询获取数据源(多个结果集)
         **/
        public DataSet ExecuteWithDataSet(string sql, params SqlParameter[] parameters) {
            if (string.IsNullOrEmpty(sql)) {
                throw new ArgumentNullException("sql");
            }

            SqlConnection connection = null;
            try {
                using (connection = new SqlConnection(ConnectionString)) {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection)) {
                        command.CommandType = CommandType.Text;
                        if (parameters != null && parameters.Length > 0) {
                            command.Parameters.AddRange(parameters);
                        }
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command)) {
                            DataSet dataSet = new DataSet();
                            adapter.Fill(dataSet);
                            return dataSet;
                        }
                    }
                }
            } catch (Exception) {
                throw;
            } finally {
                if (connection != null && connection.State == ConnectionState.Open) {
                    connection.Close();
                }
            }
        }

        /*
         * 查询获取第一维度数据源
         **/
        public object ExecteScalar(string sql, params SqlParameter[] parameters) {
            if (string.IsNullOrEmpty(sql)) {
                throw new ArgumentNullException("sql");
            }

            SqlConnection connection = null;
            try {
                using (connection = new SqlConnection(ConnectionString)) {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection)) {
                        command.CommandType = CommandType.Text;
                        if (parameters != null && parameters.Length > 0) {
                            command.Parameters.AddRange(parameters);
                        }
                        return command.ExecuteScalar();
                    }
                }
            } catch (Exception) {
                throw;
            } finally {
                if (connection != null && connection.State == ConnectionState.Open) {
                    connection.Close();
                }
            }
        }

        /*
         * 查询获取第一维度数据源(公开数据库连接)
         **/
        public object ExecuteScalarWithPublicConnect(string connectionString, string sql, params SqlParameter[] parameters) {
            if (string.IsNullOrEmpty(connectionString)) {
                throw new ArgumentNullException("connectionString");
            }

            try {
                _publicConnecionString = connectionString;
                return ExecteScalar(sql);
            } catch (Exception) {
                throw;
            } finally {
                _publicConnecionString = string.Empty;
            }
        }

        /*
         * 执行对DB有影响的SQL
         **/
        public int ExecuteNonQuery(string sql, params SqlParameter[] parameters) {
            if (string.IsNullOrEmpty(sql)) {
                throw new ArgumentNullException("sql");
            }

            SqlConnection connection = null;
            try {
                using (connection = new SqlConnection(ConnectionString)) {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection)) {
                        command.CommandType = CommandType.Text;
                        if (parameters != null && parameters.Length > 0) {
                            command.Parameters.AddRange(parameters);
                        }
                        return command.ExecuteNonQuery();
                    }
                }
            } catch (Exception) {
                throw;
            } finally {
                if (connection != null && connection.State == ConnectionState.Open) {
                    connection.Close();
                }
            }
        }

        /*
         * 执行对DB有影响的SQL(公开数据库连接)
         **/
        public int ExecuteNonQueryWithPublicConnect(string connectionString, string sql, params SqlParameter[] parameters) {
            if (string.IsNullOrEmpty(connectionString)) {
                throw new ArgumentNullException("connectionString");
            }

            try {
                _publicConnecionString = connectionString;
                return ExecuteNonQuery(sql, parameters);
            } catch (Exception) {
                throw;
            } finally {
                _publicConnecionString = string.Empty;
            }
        }

        #endregion
    }
}