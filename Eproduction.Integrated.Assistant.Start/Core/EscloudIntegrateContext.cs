using Eproduction.Integrated.Assistant.Common.Implement.Interface;
using Eproduction.Integrated.Assistant.Start.Core.Section;
using System.Configuration;

namespace Eproduction.Integrated.Assistant.Start.Core {
    public class EscloudIntegrateContextBase : ISectionService {
        public EscloudIntegateContextSection GetEscloudIntegateContextSection(out Configuration configuration) {
            configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            return (EscloudIntegateContextSection)configuration.GetSection(GetSectionName());
        }
        public string GetSectionName() {
            return "escloudIntegrateSection";
        }
    }
    public class EscloudIntegrateContext : EscloudIntegrateContextBase {
        public EscloudIntegrateContext() {
            DbConnectionContext = new EscloudDbConnectionContext();
            QueryableDefinition = new EscloudQueryableDefinitionContext();
        }
        public EscloudDbConnectionContext DbConnectionContext { get; set; }
        public EscloudQueryableDefinitionContext QueryableDefinition { get; set; }
    }
    public class EscloudDbConnectionContext : EscloudIntegrateContextBase {
        private string _escloudDbConnection = string.Empty;
        private string _diagramDbConnection = string.Empty;
        private string _customerLogDbConnection = string.Empty;
        public string EscloudDbConnection {
            get => _escloudDbConnection;
            set {
                _escloudDbConnection = value;

                EscloudIntegateContextSection section = GetEscloudIntegateContextSection(out Configuration configuration);
                section.Settings.DbConnection.EscloudDbConnection = _escloudDbConnection;
                configuration.Save();
            }
        }
        public string DiagramDbConnection {
            get => _diagramDbConnection;
            set {
                _diagramDbConnection = value;

                EscloudIntegateContextSection section = GetEscloudIntegateContextSection(out Configuration configuration);
                section.Settings.DbConnection.DiagramDbConnection = _diagramDbConnection;
                configuration.Save();
            }
        }
        public string CustomerLogDbConnection {
            get => _customerLogDbConnection;
            set {
                _customerLogDbConnection = value;

                EscloudIntegateContextSection section = GetEscloudIntegateContextSection(out Configuration configuration);
                section.Settings.DbConnection.CustomerLogDbConnection = _customerLogDbConnection;
                configuration.Save();
            }
        }
    }
    public class EscloudQueryableDefinitionContext : EscloudIntegrateContextBase {
        private string _queryCustomerInfoSqlDefinition = string.Empty;
        private string _queryDeviceInfoSqlDefinition = string.Empty;
        private string _querySubscriptionSqlDefinition = string.Empty;
        private string _queryMQInfoSqlDefinition = string.Empty;
        private string _queryCustomizeReportDataSqlDefinition = string.Empty;
        private string _queryPublishInfoSqlDefinition = string.Empty;
        private string _queryBrowseHistorySqlDefinition = string.Empty;
        private string _queryScreensSqlDefinition = string.Empty;
        private string _queryTriggerSqlDefinition = string.Empty;
        public string QueryCustomerInfoSqlDefinition {
            get => _queryCustomerInfoSqlDefinition;
            set {
                _queryCustomerInfoSqlDefinition = value;

                EscloudIntegateContextSection section = GetEscloudIntegateContextSection(out Configuration configuration);
                section.Settings.QueryableDefinition.QueryCustomerInfoSqlDefinition = _queryCustomerInfoSqlDefinition;
                configuration.Save();
            }
        }
        public string QueryDeviceInfoSqlDefinition {
            get => _queryDeviceInfoSqlDefinition;
            set {
                _queryDeviceInfoSqlDefinition = value;

                EscloudIntegateContextSection section = GetEscloudIntegateContextSection(out Configuration configuration);
                section.Settings.QueryableDefinition.QueryDeviceInfoSqlDefinition = _queryDeviceInfoSqlDefinition;
                configuration.Save();
            }
        }
        public string QuerySubscriptionSqlDefinition {
            get => _querySubscriptionSqlDefinition;
            set {
                _querySubscriptionSqlDefinition = value;

                EscloudIntegateContextSection section = GetEscloudIntegateContextSection(out Configuration configuration);
                section.Settings.QueryableDefinition.QuerySubscriptionSqlDefinition = _querySubscriptionSqlDefinition;
                configuration.Save();
            }
        }
        public string QueryMQInfoSqlDefinition {
            get => _queryMQInfoSqlDefinition;
            set {
                _queryMQInfoSqlDefinition = value;

                EscloudIntegateContextSection section = GetEscloudIntegateContextSection(out Configuration configuration);
                section.Settings.QueryableDefinition.QueryMQInfoSqlDefinition = _queryMQInfoSqlDefinition;
                configuration.Save();
            }
        }
        public string QueryCustomizeReportDataSqlDefinition {
            get => _queryCustomizeReportDataSqlDefinition;
            set {
                _queryCustomizeReportDataSqlDefinition = value;

                EscloudIntegateContextSection section = GetEscloudIntegateContextSection(out Configuration configuration);
                section.Settings.QueryableDefinition.QueryCustomizeReportDataSqlDefinition = _queryCustomizeReportDataSqlDefinition;
                configuration.Save();
            }
        }
        public string QueryBrowseHistorySqlDefinition {
            get => _queryBrowseHistorySqlDefinition;
            set {
                _queryBrowseHistorySqlDefinition = value;

                EscloudIntegateContextSection section = GetEscloudIntegateContextSection(out Configuration configuration);
                section.Settings.QueryableDefinition.QueryBrowseHistorySqlDefinition = _queryBrowseHistorySqlDefinition;
                configuration.Save();
            }
        }
        public string QueryScreensSqlDefinition {
            get => _queryScreensSqlDefinition;
            set {
                _queryScreensSqlDefinition = value;

                EscloudIntegateContextSection section = GetEscloudIntegateContextSection(out Configuration configuration);
                section.Settings.QueryableDefinition.QueryScreensSqlDefinition = _queryScreensSqlDefinition;
                configuration.Save();
            }
        }
        public string QueryTriggerSqlDefinition {
            get => _queryTriggerSqlDefinition;
            set {
                _queryTriggerSqlDefinition = value;

                EscloudIntegateContextSection section = GetEscloudIntegateContextSection(out Configuration configuration);
                section.Settings.QueryableDefinition.QueryTriggerSqlDefinition = _queryTriggerSqlDefinition;
                configuration.Save();
            }
        }
    }
}
