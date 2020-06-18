using System;
using System.Linq;
using System.Windows.Forms;
using Eproduction.Integrated.Assistant.Common.Worker;

namespace Eproduction.Integrated.Assistant.Common.Core {
    public enum ServerSource {
        Local = 0,
        Remotely = 1
    }
    public enum IdentityType {
        Windows = 0,
        SQLServer = 1
    }
    public class SqlServerDbContext {
        public SqlServerDbContext() {
            DbServerSource = 0;
        }
        public int DbServerSource { get; set; }
        public ServerSource DbServerSourceType {
            get {
                if (Server.IsIPAddress()){
                    if (Networker.GetAddressIP().Concat(new[] { Networker.Localhost }).Contains(Server)) {
                        return ServerSource.Local;
                    } else {
                        return ServerSource.Remotely;
                    }
                } else {
                    return (ServerSource)DbServerSource;
                }
            }
        }
        public string Server { get; set; }
        public int IdentityVerify { get; set; }
        public IdentityType IdentityVerifyType { get { return (IdentityType)IdentityVerify; } }
        public string DbServerSourceCaption {
            get {
                string caption = "";
                switch (DbServerSourceType) {
                    case ServerSource.Local:
                        caption = "本地服务器";
                        break;
                    case ServerSource.Remotely:
                        caption = "远程服务器";
                        break;
                }
                return caption;
            }
        }
        public string Username { get; set; }
        public string Passport { get; set; }
        public string Catalog { get; set; }
        public bool Exists { get; set; }
        public string SecurityConnectionString {
            get {
                string _connection = string.Empty;
                switch (IdentityVerifyType) {
                    case IdentityType.Windows:
                        _connection = string.Format("data source={0};initial catalog={1};Integrated Security=True;MultipleActiveResultSets=True;App=EntityFramework", Server, Catalog);
                        break;
                    case IdentityType.SQLServer:
                        _connection = string.Format("data source={0};initial catalog={1};user id={2};password={3};MultipleActiveResultSets=True;App=EntityFramework", Server, Catalog, Username, Passport.ToStringEncoding());
                        break;
                }
                return _connection;
            }
        }
        public string ConnectionString {
            get {
                string _connection = string.Empty;
                switch (IdentityVerifyType) {
                    case IdentityType.Windows:
                        _connection = string.Format("data source={0};initial catalog={1};Integrated Security=True;MultipleActiveResultSets=True;App=EntityFramework", Server, Catalog);
                        break;
                    case IdentityType.SQLServer:
                        _connection = string.Format("data source={0};initial catalog={1};user id={2};password={3};MultipleActiveResultSets=True;App=EntityFramework", Server, Catalog, Username, Passport);
                        break;
                }
                return _connection;
            }
        }
        public string MasterDbConnectionString {
            get {
                string _connection = string.Empty;
                switch (IdentityVerifyType) {
                    case IdentityType.Windows:
                        _connection = string.Format("data source={0};initial catalog=master;Integrated Security=True;MultipleActiveResultSets=True;App=EntityFramework", Server);
                        break;
                    case IdentityType.SQLServer:
                        _connection = string.Format("data source={0};initial catalog=master;user id={1};password={2};MultipleActiveResultSets=True;App=EntityFramework", Server, Username, Passport);
                        break;
                }
                return _connection;
            }
        }
        public void Analyze(string connectionString) {
            if (!string.IsNullOrEmpty(connectionString)) {
                try {
                    var parts = connectionString.Split(';');
                    if (parts[0].StartsWith("data", StringComparison.OrdinalIgnoreCase)) {
                        string content = parts[0];
                        string server = content.Substring(content.IndexOf("=") + 1);
                        if (!string.IsNullOrEmpty(server)) Server = server;
                    }
                    if (parts[1].StartsWith("initial", StringComparison.OrdinalIgnoreCase)) {
                        string content = parts[1];
                        string catalog = content.Substring(content.IndexOf("=") + 1);
                        if (!string.IsNullOrEmpty(catalog)) Catalog = catalog;
                    }
                    if (parts[2].StartsWith("user", StringComparison.OrdinalIgnoreCase)) {
                        string content = parts[2];
                        string userName = content.Substring(content.IndexOf("=") + 1);
                        if (!string.IsNullOrEmpty(userName)) Username = userName;

                        content = parts[3];
                        string password = content.Substring(content.IndexOf("=") + 1);
                        if (!string.IsNullOrEmpty(password)) Passport = password;

                        IdentityVerify = 1;
                    } else {
                        IdentityVerify = 0;
                    }
                } catch (Exception) { throw; }
            }
        }
        public bool VerifyWithGetDbList() {
            bool success = true;
            if (string.IsNullOrEmpty(Server) || (IdentityVerifyType == IdentityType.SQLServer && (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Passport)))) {
                MessageBox.Show("请确保所有信息录入完成后再尝试！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                success = false;
            }
            return success;
        }
        public virtual bool VerifyWithTestConnect() {
            bool success = true;
            if (string.IsNullOrEmpty(Server) || string.IsNullOrEmpty(Catalog) ||
                (IdentityVerifyType == IdentityType.SQLServer && (string.IsNullOrEmpty(Username) || string.IsNullOrEmpty(Passport)))) {
                success = false;
                MessageBox.Show("请确保所有信息录入完成后再尝试！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return success;
        }
    }
}