using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;

namespace Eproduction.Integrated.Assistant.Start.Core.Section {
    public class IntelligentDeployContextSection : ConfigurationSection {
        [ConfigurationProperty("deployeSettings", IsRequired = true)]
        public DeployeVersionSettingElementCollection DeploySettings {
            get => (DeployeVersionSettingElementCollection)base["deployeSettings"];
            set => base["deployeSettings"] = value;
        }
        [ConfigurationProperty("complieSettings", IsRequired = true)]
        public ComplieSettingElement ComplieSettings {
            get => (ComplieSettingElement)base["complieSettings"];
            set => base["complieSettings"] = value;
        }
        [ConfigurationProperty("CMSettings", IsRequired = true)]
        public IntegratedCMSystemElement CMSettings {
            get => (IntegratedCMSystemElement)base["CMSettings"];
            set => base["CMSettings"] = value;
        }
    }
    public class DeployeVersionSettingElementCollection : ConfigurationElementCollection {
        private IList<DeployeVersionSettingElement> _settings = null;
        protected override ConfigurationElement CreateNewElement() {
            return new DeployeVersionSettingElement();
        }
        protected override object GetElementKey(ConfigurationElement element) {
            DeployeVersionSettingElement instance = (DeployeVersionSettingElement)element;
            return instance.Name;
        }
        protected override string ElementName => base.ElementName;
        public IList<DeployeVersionSettingElement> Collection {
            get {
                if (_settings == null) {
                    _settings = new List<DeployeVersionSettingElement>();
                    foreach (DeployeVersionSettingElement element in this) {
                        _settings.Add(element);
                    }
                }
                return _settings;
            }
        }
        public void Add(DeployeVersionSettingElement element) {
            BaseAdd(element, true);
        }
        public void Clear() {
            BaseClear();
            Collection.Clear();
        }
        public void Remove(string name) {
            var element = this[name];
            if (element != null) {
                BaseRemove(name);
            }
        }
        public new DeployeVersionSettingElement this[string name] {
            get => Collection.FirstOrDefault(_ => _.Name == name);
        }
    }
    public class DeployeVersionSettingElement : ConfigurationElement {
        [ConfigurationProperty("name", IsRequired = true)]
        public string Name {
            get => base["name"].ToString();
            set => base["name"] = value;
        }
        [ConfigurationProperty("isSelected", IsRequired = true)]
        public bool IsSelected {
            get => Convert.ToBoolean(base["isSelected"]);
            set => base["isSelected"] = value;
        }
        [ConfigurationProperty("envrionmentPath", IsRequired = true)]
        public string EnvrionmentPath {
            get => base["envrionmentPath"].ToString();
            set => base["envrionmentPath"] = value;
        }
        [ConfigurationProperty("exportPath", IsRequired = true)]
        public string ExportPath {
            get => base["exportPath"].ToString();
            set => base["exportPath"] = value;
        }
        [ConfigurationProperty("typeKey", IsRequired = true)]
        public string TypeKey {
            get => base["typeKey"].ToString();
            set => base["typeKey"] = value;
        }
        [ConfigurationProperty("E10Version", IsRequired = true)]
        public string E10Version {
            get => base["E10Version"].ToString();
            set => base["E10Version"] = value;
        }
        [ConfigurationProperty("targetType", IsRequired = true)]
        public int TargetType {
            get => Convert.ToInt32(base["targetType"]);
            set => base["targetType"] = value;
        }
        [ConfigurationProperty("deployToClient", IsRequired = true)]
        public bool DeployToClient {
            get => Convert.ToBoolean(base["deployToClient"]);
            set => base["deployToClient"] = value;
        }
        [ConfigurationProperty("deployToServer", IsRequired = true)]
        public bool DeployToServer {
            get => Convert.ToBoolean(base["deployToServer"]);
            set => base["deployToServer"] = value;
        }
        [ConfigurationProperty("deployToWebServer", IsRequired = true)]
        public bool DeployToWebServer {
            get => Convert.ToBoolean(base["deployToWebServer"]);
            set => base["deployToWebServer"] = value;
        }
        [ConfigurationProperty("deployZhCHTResources", IsRequired = true)]
        public bool DeployZhCHTResources {
            get => Convert.ToBoolean(base["deployZhCHTResources"]);
            set => base["deployZhCHTResources"] = value;
        }
        [ConfigurationProperty("deployEnUSResources", IsRequired = true)]
        public bool DeployEnUSResources {
            get => Convert.ToBoolean(base["deployEnUSResources"]);
            set => base["deployEnUSResources"] = value;
        }
        [ConfigurationProperty("KillEprocess", IsRequired = true)]
        public bool KillEprocess {
            get => Convert.ToBoolean(base["KillEprocess"]);
            set => base["KillEprocess"] = value;
        }
        [ConfigurationProperty("KillClientProcess", IsRequired = true)]
        public bool KillClientProcess {
            get => Convert.ToBoolean(base["KillClientProcess"]);
            set => base["KillClientProcess"] = value;
        }
        [ConfigurationProperty("autoDeploy", IsRequired = true)]
        public bool AutoDeploy {
            get => Convert.ToBoolean(base["autoDeploy"]);
            set => base["autoDeploy"] = value;
        }
        [ConfigurationProperty("serverParamsType")]
        public int ServerParamsType {
            get => Convert.ToInt32(base["serverParamsType"].ToString(), CultureInfo.CurrentCulture);
            set => base["serverParamsType"] = value;
        }
        [ConfigurationProperty("serverParams", IsRequired = true)]
        public string ServerParams {
            get => base["serverParams"].ToString();
            set => base["serverParams"] = value;
        }
        [ConfigurationProperty("clientParamsType")]
        public int ClientParamsType {
            get => Convert.ToInt32(base["clientParamsType"].ToString(), CultureInfo.CurrentCulture);
            set => base["clientParamsType"] = value;
        }
        [ConfigurationProperty("clientParams", IsRequired = true)]
        public string ClientParams {
            get => base["clientParams"].ToString();
            set => base["clientParams"] = value;
        }
        [ConfigurationProperty("applyciBeenPutInStorage", IsRequired = true)]
        public bool ApplyciBeenPutInStorage {
            get => Convert.ToBoolean(base["applyciBeenPutInStorage"]);
            set => base["applyciBeenPutInStorage"] = value;
        }
        [ConfigurationProperty("excludeProgramInfo", IsRequired = true)]
        public bool ExcludeProgramInfo {
            get => Convert.ToBoolean(base["excludeProgramInfo"]);
            set => base["excludeProgramInfo"] = value;
        }
        [ConfigurationProperty("beforeDeployementKillEprocess", IsRequired = true)]
        public bool BeforeDeployementKillEprocess {
            get => Convert.ToBoolean(base["beforeDeployementKillEprocess"]);
            set => base["beforeDeployementKillEprocess"] = value;
        }
        [ConfigurationProperty("applyciDocs", IsRequired = true)]
        public string ApplyciDocs {
            get => base["applyciDocs"].ToString();
            set => base["applyciDocs"] = value;
        }
    }
    public class ComplieSettingElement : ConfigurationElement {
        [ConfigurationProperty("locateVsDevCmdbat", IsRequired = true)]
        public string LocateVsDevCmdbat {
            get => base["locateVsDevCmdbat"].ToString();
            set => base["locateVsDevCmdbat"] = value;
        }
        [ConfigurationProperty("complieCommandText", IsRequired = true)]
        public string ComplieCommandText {
            get => base["complieCommandText"].ToString();
            set => base["complieCommandText"] = value;
        }
    }
    public class IntegratedCMSystemElement : ConfigurationElement{
        [ConfigurationProperty("locateCMClient", IsRequired = true)]
        public string LocateCMClient {
            get => base["locateCMClient"].ToString();
            set => base["locateCMClient"] = value;
        }
        [ConfigurationProperty("CMClientParams", IsRequired = true)]
        public string CMClientParams {
            get => base["CMClientParams"].ToString();
            set => base["CMClientParams"] = value;
        }
    }
}
