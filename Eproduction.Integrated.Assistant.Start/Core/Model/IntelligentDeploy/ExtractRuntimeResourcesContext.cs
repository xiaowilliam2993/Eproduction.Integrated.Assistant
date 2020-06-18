namespace Eproduction.Integrated.Assistant.Start.Core {
    public class ExtractRuntimeResourcesContext {
        public ExtractRuntimeResourcesContext(string typeKey) {
            _typeKey = typeKey;
        }
        private string _typeKey = string.Empty;
        private string _outputPath = string.Empty;
        private int _deployType = (int)DeployTarget.Base;
        private bool _includeDllResources = true;
        private bool _includeConfigurationResources = true;
        private bool _includeProgramInfoResources = true;

        public string TypeKey {
            get => _typeKey;
            set => _typeKey = value;
        }

        public string OutputPath {
            get => _outputPath;
            set => _outputPath = value;
        }

        public int DeployType {
            get => _deployType;
            set => _deployType = value;
        }

        public DeployTarget DeployTarget {
            get => (DeployTarget)_deployType;
        }

        public bool IncludeDllResources {
            get => _includeDllResources;
            set => _includeDllResources = value;
        }

        public bool IncludeConfigurationResources {
            get => _includeConfigurationResources;
            set => _includeConfigurationResources = value;
        }

        public bool IncludeProgramInfoResources {
            get => _includeProgramInfoResources;
            set => _includeProgramInfoResources = value;
        }
    }
}
