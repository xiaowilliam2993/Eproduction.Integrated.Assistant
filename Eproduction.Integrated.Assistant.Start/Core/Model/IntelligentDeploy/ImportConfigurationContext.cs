using System.IO;

namespace Eproduction.Integrated.Assistant.Start.Core {
    public class ConfigurationContext {
        public string SourceEnvironmentPath { get; set; } = string.Empty;
        public bool IncludeAccountSetsConfiguration_dcxml { get; set; }
        public bool IncludeAutoRunClient_dcxml { get; set; }
        public bool IncludeDefault_dcc { get; set; }
        public bool IncludeUpdate_config { get; set; }
        public bool IncludeWeb_config { get; set; }
        public bool IncludeBusinessPackage_dxml { get; set; }
        public string AccountSetsConfiguration_dcxml_CombinePath { get => @"Server\Control\AccountSetsConfiguration.xml"; }
        public string AccountSetsConfiguration_dcxml_Path { get => Path.Combine(SourceEnvironmentPath, AccountSetsConfiguration_dcxml_CombinePath); }
        public string AutoRunClient_dcxml_CombinePath { get => @"DeployServer\Shared\AutoRun.Client.dcxml"; }
        public string AutoRunClient_dcxml_Path { get => Path.Combine(SourceEnvironmentPath, AutoRunClient_dcxml_CombinePath); }
        public string Default_dcc_CombinePath { get => @"DeployServer\Shared\Default.dcc"; }
        public string Default_dcc_Path { get => Path.Combine(SourceEnvironmentPath, Default_dcc_CombinePath); }
        public string Update_config_CombinePath { get => @"DeployServer\Shared\Update.config"; }
        public string Update_config_Path { get => Path.Combine(SourceEnvironmentPath, Update_config_CombinePath); }
        public string Web_config_CombinePath { get => @"WebServer\Web.config"; }
        public string Web_config_Path { get => Path.Combine(SourceEnvironmentPath, Web_config_CombinePath); }
        public string BusinessPackage_dcxml_CombinePath { get => "BusinessPackage.dcxml"; }
        public string BusinessPackage_dcxml_Path { get => Path.Combine(SourceEnvironmentPath, BusinessPackage_dcxml_CombinePath); }
    }
}
