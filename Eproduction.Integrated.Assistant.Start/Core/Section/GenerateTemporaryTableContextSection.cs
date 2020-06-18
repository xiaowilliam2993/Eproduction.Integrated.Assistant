using System;
using System.Configuration;

namespace Eproduction.Integrated.Assistant.Start.Core.Section {
    public class GenerateTemporaryTableContextSection : ConfigurationSection {
        [ConfigurationProperty("generateTemporaryTableSetting", IsRequired = true)]
        public GenerateTemporaryTableSettingElement Settings {
            get => (GenerateTemporaryTableSettingElement)base["generateTemporaryTableSetting"];
            set => base["generateTemporaryTableSetting"] = value;
        }
    }
    public class GenerateTemporaryTableSettingElement : ConfigurationElement {
        [ConfigurationProperty("generateFunctionHeader", IsRequired = true)]
        public bool GenerateFunctionHeader {
            get => Convert.ToBoolean(base["generateFunctionHeader"]);
            set => base["generateFunctionHeader"] = value;
        }
        [ConfigurationProperty("generateRemark", IsRequired = true)]
        public bool GenerateRemark {
            get => Convert.ToBoolean(base["generateRemark"]);
            set => base["generateRemark"] = value;
        }
        [ConfigurationProperty("firstPropertyGeneratePrimaryKey", IsRequired = true)]
        public bool FirstPropertyGeneratePrimaryKey {
            get => Convert.ToBoolean(base["firstPropertyGeneratePrimaryKey"]);
            set => base["firstPropertyGeneratePrimaryKey"] = value;
        }
        [ConfigurationProperty("specification", IsRequired = true)]
        public string Specification {
            get => base["specification"].ToString();
            set => base["specification"] = value;
        }
    }
}
