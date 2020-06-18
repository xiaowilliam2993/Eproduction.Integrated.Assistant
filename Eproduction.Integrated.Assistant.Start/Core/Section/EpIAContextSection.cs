using System.Configuration;

namespace Eproduction.Integrated.Assistant.Start.Core.Section {
    public class EpIAContextSection : ConfigurationSection {
        [ConfigurationProperty("EpIASettings", IsRequired = true)]
        public EpIAContextElement Settings {
            get => (EpIAContextElement)base["EpIASettings"];
        }
    }
    public class EpIAContextElement : ConfigurationElement {
        [ConfigurationProperty("selectedModule", IsRequired = true)]
        public string SelectedModule {
            get => base["selectedModule"].ToString();
            set => base["selectedModule"] = value;
        }
        [ConfigurationProperty("modules", IsRequired = true)]
        public string Modules {
            get => base["modules"].ToString();
            set => base["modules"] = value;
        }
    }
}
