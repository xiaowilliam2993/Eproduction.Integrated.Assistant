using Eproduction.Integrated.Assistant.Common.Implement.Interface;
using Eproduction.Integrated.Assistant.Start.Core.Section;
using System.Configuration;

namespace Eproduction.Integrated.Assistant.Start.Core {
    public class GenerateTempoarayTableContext : ISectionService {
        private bool _generateFunctionHeader = false;
        private bool _generateRemark = false;
        private bool _firstPropertyGeneratePrimaryKey = false;
        private string _specifiaction = string.Empty;
        private string[] _specificationLines = null;
        private string _sources = string.Empty;
        public bool GenerateFunctionHeader {
            get => _generateFunctionHeader;
            set {
                _generateFunctionHeader = value;

                GenerateTemporaryTableContextSection section = GetGenerateTemporaryTableSection(out Configuration configuration);
                section.Settings.GenerateFunctionHeader = _generateFunctionHeader;
                configuration.Save();
            }
        }
        public bool GenerateRemark {
            get => _generateRemark;
            set {
                _generateRemark = value;

                GenerateTemporaryTableContextSection section = GetGenerateTemporaryTableSection(out Configuration configuration);
                section.Settings.GenerateRemark = _generateRemark;
                configuration.Save();
            }
        }
        public bool FirstPropertyGeneratePrimaryKey {
            get => _firstPropertyGeneratePrimaryKey;
            set {
                _firstPropertyGeneratePrimaryKey = value;

                GenerateTemporaryTableContextSection section = GetGenerateTemporaryTableSection(out Configuration configuration);
                section.Settings.FirstPropertyGeneratePrimaryKey = _firstPropertyGeneratePrimaryKey;
                configuration.Save();
            }
        }
        public string Specification {
            get => _specifiaction;
            set {
                _specifiaction = value;

                GenerateTemporaryTableContextSection section = GetGenerateTemporaryTableSection(out Configuration configuration);
                section.Settings.Specification = _specifiaction;
                configuration.Save();
            }
        }
        public string[] SpecificationLines {
            get {
                if (_specificationLines == null) {
                    _specificationLines = new string[] { };
                }
                return _specificationLines;
            }
            set => _specificationLines = value;
        }
        public string Sources {
            get => _sources;
            set => _sources = value;
        }
        public GenerateTemporaryTableContextSection GetGenerateTemporaryTableSection(out Configuration configuration) {
            configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            return (GenerateTemporaryTableContextSection)configuration.GetSection(GetSectionName());
        }

        public string GetSectionName() {
            return "generateTemporaryTableSection";
        }
    }
}
