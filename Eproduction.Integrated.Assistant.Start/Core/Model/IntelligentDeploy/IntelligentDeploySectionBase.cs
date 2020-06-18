using Eproduction.Integrated.Assistant.Common.Implement.Interface;
using Eproduction.Integrated.Assistant.Start.Core.Section;
using System.Configuration;

namespace Eproduction.Integrated.Assistant.Start.Core {
    public abstract class IntelligentDeploySectionBase : ISectionService {
        public string GetSectionName() {
            return "intelligentDeploySection";
        }
        public virtual IntelligentDeployContextSection GetIntelligentDeployContextSection(out Configuration configuration) {
            configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            return (IntelligentDeployContextSection)configuration.GetSection(GetSectionName());
        }
    }
}
