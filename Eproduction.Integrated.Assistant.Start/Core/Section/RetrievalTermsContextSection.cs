using Eproduction.Integrated.Assistant.Common;
using System;
using System.Configuration;

namespace Eproduction.Integrated.Assistant.Start.Core.Section {
    public class RetrievalTermsContextSection : ConfigurationSection {
        [ConfigurationProperty("retrievalTermsSettings", IsRequired = true)]
        public RetrievalTermsSettingElement Settings {
            get => (RetrievalTermsSettingElement)base["retrievalTermsSettings"];
            set => base["retrievalTermsSettings"] = value;
        }
    }
    public class RetrievalTermsSettingElement : ConfigurationElement {
        [ConfigurationProperty("chsEntry", IsRequired = true)]
        public string ChsEntry {
            get => base["chsEntry"].ToString();
            set => base["chsEntry"] = value;
        }
        [ConfigurationProperty("fuzzy", IsRequired = true)]
        public bool Fuzzy {
            get => Convert.ToBoolean(base["fuzzy"]);
            set => base["fuzzy"] = value;
        }
        [ConfigurationProperty("EpIAConnection", IsRequired = true)]
        public string EpIAConnectionString {
            get => base["EpIAConnection"].ToString().ToStringDecoding();
            set => base["EpIAConnection"] = value.ToStringEncoding();
        }
    }
}
