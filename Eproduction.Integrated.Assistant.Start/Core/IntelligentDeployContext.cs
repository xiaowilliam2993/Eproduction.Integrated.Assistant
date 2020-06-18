using Eproduction.Integrated.Assistant.Start.Core.Section;
using Eproduction.Integrated.Assistant.Start.Control;
using Eproduction.Integrated.Assistant.Common.Implement.Interface;
using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.IO;

namespace Eproduction.Integrated.Assistant.Start.Core {
    public enum DeployTarget {
        /// <summary>
        /// 基版
        /// </summary>
        Base = 0,
        /// <summary>
        /// 行业版
        /// </summary>
        Industry = 1,
        /// <summary>
        /// 个案包
        /// </summary>
        Customization = 2
    }
    /// <summary>
    /// 自动部署原型定义
    /// </summary>
    public class IntelligentDeployContext : IntelligentDeploySectionBase {
        private IList<DeployVersionContext> _deployVersions = null;
        private IntegratedCMSystemContext _CMSettings = null;
        private ComplieSettingContext _complieSettings = null;
        public IList<DeployVersionContext> DeployVersions {
            get {
                if (_deployVersions == null) {
                    _deployVersions = new List<DeployVersionContext>();
                }
                return _deployVersions;
            }
            set => _deployVersions = value;
        }
        public IntegratedCMSystemContext CMSettings {
            get {
                if (_CMSettings == null) {
                    _CMSettings = new IntegratedCMSystemContext();
                }
                return _CMSettings;
            }
            set => _CMSettings = value;
        }
        public ComplieSettingContext ComplieSettings {
            get {
                if (_complieSettings == null) {
                    _complieSettings = new ComplieSettingContext();
                }
                return _complieSettings;
            }
            set => _complieSettings = value;
        }
        public DeployVersionContext SelectedDeployVersion { get => DeployVersions.FirstOrDefault(_ => _.IsSelected); }
    }
    /// <summary>
    /// 自动部署版本信息原型定义
    /// </summary>
    public class DeployVersionContext :IntelligentDeploySectionBase {
        private string _name = string.Empty;
        private bool _isSelected = false;
        private string _envrionmentPath = string.Empty;
        private string _exportPath = string.Empty;
        private string _typeKey = string.Empty;
        private string _E10Version = string.Empty;
        private int _targetType = 0;
        private bool _deployToClient = true;
        private bool _deployToServer = true;
        private bool _deployToWebServer = false;
        private bool _deployZhCHTResources = false;
        private bool _deployEnUSResources = false;
        private bool _killEprocess = true;
        private bool _killClientProcess = true;
        private bool _autoDeploy = false;
        private int _serverParamsType = 0;
        private string _serverParams = string.Empty;
        private int _clientParamsType = 0;
        private string _clientParams = string.Empty;
        private bool _applyciBeenPutInStorage = false;
        private bool _excludeProgramInfo = false;
        private bool _beforeDeployementKillEprocess = false;
        private string _applyciDocs = string.Empty;
        private DeployVerionItemControl _versionItemControl = null;
        /// <summary>
        /// 部署版本名称（唯一标识）
        /// </summary>
        public string Name {
            get => _name;
            set {
                string oldVersionName = _name;

                _name = value;

                if (!string.IsNullOrEmpty(_name)) {
                    IntelligentDeployContextSection section = GetIntelligentDeployContextSection(out Configuration configuration);
                    var element = section.DeploySettings[oldVersionName];
                    if (element != null) {
                        element.Name = _name;
                        configuration.Save();
                    }
                }
            }
        }
        /// <summary>
        /// 标识是否被选中
        /// </summary>
        public bool IsSelected {
            get => _isSelected;
            set {
                _isSelected = value;

                if (!string.IsNullOrEmpty(Name)) {
                    IntelligentDeployContextSection section = GetIntelligentDeployContextSection(out Configuration configuration);
                    var element = section.DeploySettings[Name];
                    if (element != null) {
                        element.IsSelected = _isSelected;
                        configuration.Save();
                    }
                }
            }
        }
        /// <summary>
        /// 环境路径
        /// </summary>
        public string EnvrionmentPath {
            get => _envrionmentPath;
            set {
                _envrionmentPath = value;

                if (!string.IsNullOrEmpty(Name)) {
                    IntelligentDeployContextSection section = GetIntelligentDeployContextSection(out Configuration configuration);
                    var element = section.DeploySettings[Name];
                    if (element != null) {
                        element.EnvrionmentPath = _envrionmentPath;
                        configuration.Save();
                    }
                }
            }
        }
        /// <summary>
        /// Export路径
        /// </summary>
        public string ExportPath {
            get => _exportPath;
            set {
                _exportPath = value;

                if (!string.IsNullOrEmpty(Name)) {
                    IntelligentDeployContextSection section = GetIntelligentDeployContextSection(out Configuration configuration);
                    var element = section.DeploySettings[Name];
                    if (element != null) {
                        element.ExportPath = _exportPath;
                        configuration.Save();
                    }
                }
            }
        }
        /// <summary>
        /// TypeKey列表（多个TypeKey之间用逗号[,]相连）
        /// </summary>
        public string TypeKey {
            get => _typeKey;
            set {
                _typeKey = value;

                if (!string.IsNullOrEmpty(Name)) {
                    IntelligentDeployContextSection section = GetIntelligentDeployContextSection(out Configuration configuration);
                    var element = section.DeploySettings[Name];
                    if (element != null) {
                        element.TypeKey = _typeKey;
                        configuration.Save();
                    }
                }
            }
        }
        /// <summary>
        /// E10版本名称
        /// </summary>
        public string E10Version {
            get => _E10Version;
            set {
                _E10Version = value;

                if (!string.IsNullOrEmpty(Name)) {
                    IntelligentDeployContextSection section = GetIntelligentDeployContextSection(out Configuration configuration);
                    var element = section.DeploySettings[Name];
                    if (element != null) {
                        element.E10Version = _E10Version;
                        configuration.Save();
                    }
                }
            }
        }
        /// <summary>
        /// 部署目标值
        /// </summary>
        public int TargetType {
            get => _targetType;
            set {
                _targetType = value;

                if (!string.IsNullOrEmpty(Name)) {
                    IntelligentDeployContextSection section = GetIntelligentDeployContextSection(out Configuration configuration);
                    var element = section.DeploySettings[Name];
                    if (element != null) {
                        element.TargetType = _targetType;
                        configuration.Save();
                    }
                }
            }
        }
        /// <summary>
        /// 部署目标类别
        /// </summary>
        public DeployTarget DeployTarget { get => (DeployTarget)TargetType; }
        /// <summary>
        /// 部署*.dll文件到CLIENT
        /// </summary>
        public bool DeployToClient {
            get => _deployToClient;
            set {
                _deployToClient = value;

                if (!string.IsNullOrEmpty(Name)) {
                    IntelligentDeployContextSection section = GetIntelligentDeployContextSection(out Configuration configuration);
                    var element = section.DeploySettings[Name];
                    if (element != null) {
                        element.DeployToClient = _deployToClient;
                        configuration.Save();
                    }
                }
            }
        }
        /// <summary>
        /// 部署*.dll文件到SERVER
        /// </summary>
        public bool DeployToServer {
            get => _deployToServer;
            set {
                _deployToServer = value;

                if (!string.IsNullOrEmpty(Name)) {
                    IntelligentDeployContextSection section = GetIntelligentDeployContextSection(out Configuration configuration);
                    var element = section.DeploySettings[Name];
                    if (element != null) {
                        element.DeployToServer = _deployToServer;
                        configuration.Save();
                    }
                }
            }
        }
        /// <summary>
        /// 部署*.dll文件到WEBSERVER
        /// </summary>
        public bool DeployToWebServer {
            get => _deployToWebServer;
            set {
                _deployToWebServer = value;

                if (!string.IsNullOrEmpty(Name)) {
                    IntelligentDeployContextSection section = GetIntelligentDeployContextSection(out Configuration configuration);
                    var element = section.DeploySettings[Name];
                    if (element != null) {
                        element.DeployToWebServer = _deployToWebServer;
                        configuration.Save();
                    }
                }
            }
        }
        /// <summary>
        /// 部署繁体*.resources.dll文件
        /// </summary>
        public bool DeployZhCHTResources {
            get => _deployZhCHTResources;
            set {
                _deployZhCHTResources = value;

                if (!string.IsNullOrEmpty(Name)) {
                    IntelligentDeployContextSection section = GetIntelligentDeployContextSection(out Configuration configuration);
                    var element = section.DeploySettings[Name];
                    if (element != null) {
                        element.DeployZhCHTResources = _deployZhCHTResources;
                        configuration.Save();
                    }
                }
            }
        }
        /// <summary>
        /// 部署英文*.resources.dll文件
        /// </summary>
        public bool DeployEnUSResources {
            get => _deployEnUSResources;
            set {
                _deployEnUSResources = value;

                if (!string.IsNullOrEmpty(Name)) {
                    IntelligentDeployContextSection section = GetIntelligentDeployContextSection(out Configuration configuration);
                    var element = section.DeploySettings[Name];
                    if (element != null) {
                        element.DeployEnUSResources = _deployEnUSResources;
                        configuration.Save();
                    }
                }
            }
        }
        /// <summary>
        /// 启动SERVER时关闭E10所有进程
        /// </summary>
        public bool KillEprocess {
            get => _killEprocess;
            set {
                _killEprocess = value;

                if (!string.IsNullOrEmpty(Name)) {
                    IntelligentDeployContextSection section = GetIntelligentDeployContextSection(out Configuration configuration);
                    var element = section.DeploySettings[Name];
                    if (element != null) {
                        element.KillEprocess = _killEprocess;
                        configuration.Save();
                    }
                }
            }
        }
        /// <summary>
        /// 启动CLIENT时关闭客户端进程
        /// </summary>
        public bool KillClientProcess {
            get => _killClientProcess;
            set {
                _killClientProcess = value;

                if (!string.IsNullOrEmpty(Name)) {
                    IntelligentDeployContextSection section = GetIntelligentDeployContextSection(out Configuration configuration);
                    var element = section.DeploySettings[Name];
                    if (element != null) {
                        element.KillClientProcess = _killClientProcess;
                        configuration.Save();
                    }
                }
            }
        }
        /// <summary>
        /// 自动部署*.dll文件
        /// </summary>
        public bool AutoDeploy {
            get => _autoDeploy;
            set {
                _autoDeploy = value;

                if (!string.IsNullOrEmpty(Name)) {
                    IntelligentDeployContextSection section = GetIntelligentDeployContextSection(out Configuration configuration);
                    var element = section.DeploySettings[Name];
                    if (element != null) {
                        element.AutoDeploy = _autoDeploy;
                        configuration.Save();
                    }
                }
            }
        }
        public int ServerParamsType {
            get => _serverParamsType;
            set {
                _serverParamsType = value;

                IntelligentDeployContextSection section = GetIntelligentDeployContextSection(out Configuration configuration);
                var element = section.DeploySettings[Name];
                if (element != null) {
                    element.ServerParamsType = _serverParamsType;
                    configuration.Save();
                }
            }
        }
        public ServerParamsType ServerParamsEnum { get => (ServerParamsType)ServerParamsType; }
        /// <summary>
        /// SERVER启动参数
        /// </summary>
        public string ServerParams {
            get => _serverParams;
            set {
                _serverParams = value;

                if (!string.IsNullOrEmpty(Name)) {
                    IntelligentDeployContextSection section = GetIntelligentDeployContextSection(out Configuration configuration);
                    var element = section.DeploySettings[Name];
                    if (element != null) {
                        element.ServerParams = _serverParams;
                        configuration.Save();
                    }
                }
            }
        }
        public ClientParamsType ClientParamsEnum { get => (ClientParamsType)ClientParamsType; }
        public int ClientParamsType {
            get => _clientParamsType;
            set {
                _clientParamsType = value;

                IntelligentDeployContextSection section = GetIntelligentDeployContextSection(out Configuration configuration);
                var element = section.DeploySettings[Name];
                if (element != null) {
                    element.ClientParamsType = _clientParamsType;
                    configuration.Save();
                }
            }
        }
        /// <summary>
        /// CLIENT启动参数
        /// </summary>
        public string ClientParams {
            get => _clientParams;
            set {
                _clientParams = value;

                if (!string.IsNullOrEmpty(Name)) {
                    IntelligentDeployContextSection section = GetIntelligentDeployContextSection(out Configuration configuration);
                    var element = section.DeploySettings[Name];
                    if (element != null) {
                        element.ClientParams = _clientParams;
                        configuration.Save();
                    }
                }
            }
        }
        /// <summary>
        /// 签出入单已入库
        /// </summary>
        public bool ApplyciBeenPutInStorage {
            get => _applyciBeenPutInStorage;
            set {
                _applyciBeenPutInStorage = value;

                if (!string.IsNullOrEmpty(Name)) {
                    IntelligentDeployContextSection section = GetIntelligentDeployContextSection(out Configuration configuration);
                    var element = section.DeploySettings[Name];
                    if (element != null) {
                        element.ApplyciBeenPutInStorage = _applyciBeenPutInStorage;
                        configuration.Save();
                    }
                }
            }
        }
        /// <summary>
        /// 部署过程中排除ProgramInfo文件
        /// </summary>
        public bool ExcludeProgramInfo {
            get => _excludeProgramInfo;
            set {
                _excludeProgramInfo = value;

                if (!string.IsNullOrEmpty(Name)) {
                    IntelligentDeployContextSection section = GetIntelligentDeployContextSection(out Configuration configuration);
                    var element = section.DeploySettings[Name];
                    if (element != null) {
                        element.ExcludeProgramInfo = _excludeProgramInfo;
                        configuration.Save();
                    }
                }
            }
        }
        /// <summary>
        /// 部署提交资源前关闭E10进程
        /// </summary>
        public bool BeforeDeployementKillEprocess {
            get => _beforeDeployementKillEprocess;
            set {
                _beforeDeployementKillEprocess = value;

                if (!string.IsNullOrEmpty(Name)) {
                    IntelligentDeployContextSection section = GetIntelligentDeployContextSection(out Configuration configuration);
                    var element = section.DeploySettings[Name];
                    if (element != null) {
                        element.BeforeDeployementKillEprocess = _beforeDeployementKillEprocess;
                        configuration.Save();
                    }
                }
            }
        }
        /// <summary>
        /// 签出单号（单号之间用逗号[,]连接）
        /// </summary>
        public string ApplyciDocs {
            get => _applyciDocs;
            set {
                _applyciDocs = value;

                if (!string.IsNullOrEmpty(Name)) {
                    IntelligentDeployContextSection section = GetIntelligentDeployContextSection(out Configuration configuration);
                    var element = section.DeploySettings[Name];
                    if (element != null) {
                        element.ApplyciDocs = _applyciDocs;
                        configuration.Save();
                    }
                }
            }
        }
        public DeployVerionItemControl VersionItemControl {
            get => _versionItemControl;
            set => _versionItemControl = value;
        }
    }
    public class ComplieSettingContext : IntelligentDeploySectionBase {
        private string _locateVsDevCmdbat = string.Empty;
        private string _complieCommandText = string.Empty;
        /// <summary>
        /// 定位 Visual Studio Develop Command 批处理文件
        /// </summary>
        public string LocateVsDevCmdbat {
            get => _locateVsDevCmdbat;
            set {
                _locateVsDevCmdbat = value;

                IntelligentDeployContextSection section = GetIntelligentDeployContextSection(out Configuration configuration);
                section.ComplieSettings.LocateVsDevCmdbat = _locateVsDevCmdbat;
                configuration.Save();
            }
        }
        /// <summary>
        /// 编译命令
        /// </summary>
        public string ComplieCommandText {
            get => _complieCommandText;
            set {
                _complieCommandText = value;

                IntelligentDeployContextSection section = GetIntelligentDeployContextSection(out Configuration configuration);
                section.ComplieSettings.ComplieCommandText = _complieCommandText;
                configuration.Save();
            }
        }
    }
    public class IntegratedCMSystemContext : IntelligentDeploySectionBase {
        private string _locateCMClient = string.Empty;
        private string _CMClientParams = string.Empty;
        /// <summary>
        /// CM启动程序路径
        /// </summary>
        public string LocateCMClient {
            get => _locateCMClient;
            set {
                _locateCMClient = value;

                IntelligentDeployContextSection section = GetIntelligentDeployContextSection(out Configuration configuration);
                section.CMSettings.LocateCMClient = _locateCMClient;
                configuration.Save();
            }
        }
        /// <summary>
        /// CM启动程序启动参数
        /// </summary>
        public string CMClientParams {
            get => _CMClientParams;
            set {
                _CMClientParams = value;

                IntelligentDeployContextSection section = GetIntelligentDeployContextSection(out Configuration configuration);
                section.CMSettings.CMClientParams = _CMClientParams;
                configuration.Save();
            }
        }
    }

    /// <summary>
    /// 部署参数上下文
    /// </summary>
    public class DeployParametersContext {
        /// <summary>
        /// 标识是否需要部署CLIENT资源
        /// </summary>
        public bool DeployToClient { get; set; } = false;
        /// <summary>
        /// 标识是否需要部署SERVER资源
        /// </summary>
        public bool DeployToServer { get; set; } = false;
        /// <summary>
        /// 执行参数上下文初始化动作，所有参数都将恢复初始值
        /// </summary>
        public void Initialize() {
            DeployToClient = false;
            DeployToServer = false;
        }
    }
    public class DeployModel {
        /// <summary>
        /// 目标dll文件
        /// </summary>
        public FileInfo Dll { get; set; }
        /// <summary>
        /// 部署目标名称
        /// </summary>
        public string TargetName { get; set; }
        /// <summary>
        /// 标识部署是否成功
        /// </summary>
        public bool Successfully { get; set; } = false;
    }
    public enum ServerParamsType {
        Custom = 0,
        All = 1,
        AllAndRepair = 2,
        Debug = 3,
        DebugAndRepair = 4,
        Upgrade = 5
    }
    public enum ClientParamsType {
        Custom = 0,
        All = 1,
        Debug = 2
    }
}
