using Eproduction.Integrated.Assistant.Common.Core;
using Eproduction.Integrated.Assistant.Common.Implement.Interface;
using Eproduction.Integrated.Assistant.Start.Core.Section;
using System.Configuration;

namespace Eproduction.Integrated.Assistant.Start.Core {
    public class RetrievalTermsContext : ISectionService {
        private string _chsEntry = string.Empty;
        private bool _fuzzy = false;
        private string _EpIAConnectionString = string.Empty;
        private SqlServerDbContext _sqlServerDbContext = null;
        public bool DisplayPassword { get; set; }
        public string ChsEntry {
            get => _chsEntry;
            set {
                _chsEntry = value;

                RetrievalTermsContextSection section = GetRetrievalTermsContextSection(out Configuration configuration);
                section.Settings.ChsEntry = _chsEntry;
                configuration.Save();
            }
        }
        public bool Fuzzy {
            get => _fuzzy;
            set {
                _fuzzy = value;

                RetrievalTermsContextSection section = GetRetrievalTermsContextSection(out Configuration configuration);
                section.Settings.Fuzzy = _fuzzy;
                configuration.Save();
            }
        }
        public string EpIAConnectionString {
            get => _EpIAConnectionString;
            set {
                _EpIAConnectionString = value;

                RetrievalTermsContextSection section = GetRetrievalTermsContextSection(out Configuration configuration);
                section.Settings.EpIAConnectionString = _EpIAConnectionString;
                configuration.Save();
            }
        }
        public SqlServerDbContext SqlServerDbContext {
            get {
                if (_sqlServerDbContext == null) {
                    _sqlServerDbContext = new SqlServerDbContext();
                }
                return _sqlServerDbContext;
            }
            set {
                _sqlServerDbContext = value;

                EpIAConnectionString = _sqlServerDbContext.ConnectionString;
            }
        }
        public RetrievalTermsContextSection GetRetrievalTermsContextSection(out Configuration configuration) {
            configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            return (RetrievalTermsContextSection)configuration.GetSection(GetSectionName());
        }

        public string GetSectionName() {
            return "retrievalTermsSection";
        }
    }
}
