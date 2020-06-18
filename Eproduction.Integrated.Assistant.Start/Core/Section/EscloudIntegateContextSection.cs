using System.Configuration;

namespace Eproduction.Integrated.Assistant.Start.Core.Section {
    public class EscloudIntegateContextSection : ConfigurationSection {
        [ConfigurationProperty("escloudIntegateSettings", IsRequired = true)]
        public EscloudIntegrateContextElement Settings {
            get => (EscloudIntegrateContextElement)base["escloudIntegateSettings"];
            set => base["escloudIntegateSettings"] = value;
        }
    }
    public class EscloudIntegrateContextElement : ConfigurationElement {
        [ConfigurationProperty("dbConnection", IsRequired = true)]
        public EscloudDbConnectionContextElement DbConnection {
            get => (EscloudDbConnectionContextElement)base["dbConnection"];
            set => base["dbConnection"] = value;
        }
        [ConfigurationProperty("queryableDefinition", IsRequired = true)]
        public EscloudQueryableDefinitionContextElement QueryableDefinition {
            get => (EscloudQueryableDefinitionContextElement)base["queryableDefinition"];
            set => base["queryableDefinition"] = value;
        }
    }
    public class EscloudDbConnectionContextElement : ConfigurationElement {
        [ConfigurationProperty("escloudDbConnection", IsRequired = true)]
        public string EscloudDbConnection {
            get => base["escloudDbConnection"].ToString();
            set => base["escloudDbConnection"] = value;
        }
        [ConfigurationProperty("diagramDbConnection", IsRequired = true)]
        public string DiagramDbConnection {
            get => base["diagramDbConnection"].ToString();
            set => base["diagramDbConnection"] = value;
        }
        [ConfigurationProperty("customerLogDbConnection", IsRequired = true)]
        public string CustomerLogDbConnection {
            get => base["customerLogDbConnection"].ToString();
            set => base["customerLogDbConnection"] = value;
        }
    }
    public class EscloudQueryableDefinitionContextElement : ConfigurationElement {
        [ConfigurationProperty("queryCustomerInfoSqlDefinition", IsRequired = true)]
        public string QueryCustomerInfoSqlDefinition {
            get => base["queryCustomerInfoSqlDefinition"].ToString();
            set => base["queryCustomerInfoSqlDefinition"] = value;
        }
        [ConfigurationProperty("queryDeviceInfoSqlDefinition", IsRequired = true)]
        public string QueryDeviceInfoSqlDefinition {
            get => base["queryDeviceInfoSqlDefinition"].ToString();
            set => base["queryDeviceInfoSqlDefinition"] = value;
        }
        [ConfigurationProperty("querySubscriptionSqlDefinition", IsRequired = true)]
        public string QuerySubscriptionSqlDefinition {
            get => base["querySubscriptionSqlDefinition"].ToString();
            set => base["querySubscriptionSqlDefinition"] = value;
        }
        [ConfigurationProperty("queryMQInfoSqlDefinition", IsRequired = true)]
        public string QueryMQInfoSqlDefinition {
            get => base["queryMQInfoSqlDefinition"].ToString();
            set => base["queryMQInfoSqlDefinition"] = value;
        }
        [ConfigurationProperty("queryCustomizeReportDataSqlDefinition", IsRequired = true)]
        public string QueryCustomizeReportDataSqlDefinition {
            get => base["queryCustomizeReportDataSqlDefinition"].ToString();
            set => base["queryCustomizeReportDataSqlDefinition"] = value;
        }
        [ConfigurationProperty("queryPublishInfoSqlDefinition", IsRequired = true)]
        public string QueryPublishInfoSqlDefinition {
            get => base["queryPublishInfoSqlDefinition"].ToString();
            set => base["queryPublishInfoSqlDefinition"] = value;
        }
        [ConfigurationProperty("queryBrowseHistorySqlDefinition", IsRequired = true)]
        public string QueryBrowseHistorySqlDefinition {
            get => base["queryBrowseHistorySqlDefinition"].ToString();
            set => base["queryBrowseHistorySqlDefinition"] = value;
        }
        [ConfigurationProperty("queryScreensSqlDefinition", IsRequired = true)]
        public string QueryScreensSqlDefinition {
            get => base["queryScreensSqlDefinition"].ToString();
            set => base["queryScreensSqlDefinition"] = value;
        }
        [ConfigurationProperty("queryTriggerSqlDefinition", IsRequired = true)]
        public string QueryTriggerSqlDefinition {
            get => base["queryTriggerSqlDefinition"].ToString();
            set => base["queryTriggerSqlDefinition"] = value;
        }
    }
}
