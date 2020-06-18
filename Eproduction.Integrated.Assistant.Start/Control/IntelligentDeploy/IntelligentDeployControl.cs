using Eproduction.Integrated.Assistant.Start.Core;
using Eproduction.Integrated.Assistant.Start.Worker;
using Eproduction.Integrated.Assistant.Common;
using System;
using System.Linq;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Xml;
using System.Text;
using System.Configuration;

namespace Eproduction.Integrated.Assistant.Start.Control {
    public partial class IntelligentDeployControl : UserControl {
        private EpIAContext _EpIAContext = null;
        private DeployParametersContext _deployContext = null;
        private DeployVersionContext _selectedVersionContext = null;
        private ExtractRuntimeResourcesContext _extractContext = null;
        private ConfigurationContext _importConfigurationContext = null;
        public EpIAContext EpIAContext { get => _EpIAContext; }
        public IntelligentDeployContext Context { get => EpIAContext.IntelligentDeployContext; }
        public DeployParametersContext DeployContext {
            get {
                if (_deployContext == null) {
                    _deployContext = new DeployParametersContext();
                }
                return _deployContext;
            }
            set => _deployContext = value;
        }
        public DeployVersionContext SelectedVersion {
            get => _selectedVersionContext;
            private set => _selectedVersionContext = value;
        }
        public ExtractRuntimeResourcesContext ExtractContext {
            get => _extractContext;
            private set => _extractContext = value;
        }
        public ConfigurationContext ImportConfigurationContext {
            get {
                if (_importConfigurationContext == null) {
                    _importConfigurationContext = new ConfigurationContext();
                }
                return _importConfigurationContext;
            }
            private set => _importConfigurationContext = value;
        }
        public string SelectedPath { get; set; }

        private readonly Color _WindowText = SystemColors.WindowText;
        private readonly Color _Green = Color.FromArgb(15, 180, 148);
        private const string _Client = "Client";
        private const string _Server = "Server";
        private const string _WebServer = "WebServer";
        private const string _Industry = "Industry";
        private const string _Customization = "Customization";
        private IEnumerable<IComponent> _EnabledComponents = null;
        private IEnumerable<IComponent> _VisibleComponents = null;
        private IList<DeployModel> DeployModels = new List<DeployModel>();

        private EnabledComponentsProxy _enabledComponentsProxy = null;
        private delegate void EnabledComponentsProxy(IEnumerable<IComponent> components, bool enabled);
        private VisibleComponentsProxy _visibleComponentsProxy = null;
        private delegate void VisibleComponentsProxy(IEnumerable<IComponent> components, bool visible);
        private PrintDetailsProxy _printDetailsProxy = null;
        private delegate void PrintDetailsProxy(RichTextBox richboxDetails, string message, bool clear, Color fontColor);
        private RefreshStatusContainerProxy _refreshStatusContainerProxy = null;
        private delegate void RefreshStatusContainerProxy(SysStatusComponentContainer statusContainer);
        [DllImport("user32.dll", EntryPoint = "FindWindow")]
        public static extern int FindWindow(string lpClassName, string lpWindowName);
        public IntelligentDeployControl(EpIAContext context) {
            _enabledComponentsProxy = new EnabledComponentsProxy(delegate (IEnumerable<IComponent> components, bool enabled) {
                IComponentUtils.RefreshStatus(components, enabled);
            });
            _visibleComponentsProxy = new VisibleComponentsProxy(delegate (IEnumerable<IComponent> components, bool visible) {
                IComponentUtils.VisibleComponents(components, visible);
            });
            _printDetailsProxy = new PrintDetailsProxy(delegate (RichTextBox richboxDetails, string message, bool clear, Color fontColor) {
                if (clear) {
                    richboxPrint.Clear();
                } else {
                    if (!string.IsNullOrEmpty(richboxDetails.Text)) {
                        message = Environment.NewLine + message;
                    }
                    richboxDetails.AppendText(message);

                    int startPosition = richboxDetails.TextLength - message.Length;
                    if (richboxDetails.Lines.Length > 1) {
                        startPosition += 1;
                    }
                    richboxDetails.Select(startPosition, message.Length);
                    richboxDetails.SelectionColor = fontColor;

                    richboxDetails.SelectionLength = richboxDetails.TextLength;
                    richboxDetails.ScrollToCaret();
                }
            });
            _refreshStatusContainerProxy = new RefreshStatusContainerProxy(delegate (SysStatusComponentContainer statusContainer) {
                statusContainer.Refresh();
            });
            InitializeComponent();

            _EpIAContext = context;

            Dock = DockStyle.Fill;
            
            Func<string, string> ChooseFolderPath =  (string _) => {
                string selectedPath = string.Empty;
                using (var browserDialog = new FolderBrowserDialog()) {
                    browserDialog.RootFolder = Environment.SpecialFolder.Desktop;
                    browserDialog.Description = _;
                    if (!string.IsNullOrEmpty(SelectedPath)) {
                        browserDialog.SelectedPath = SelectedPath;
                    }
                    if (browserDialog.ShowDialog() == DialogResult.OK) {
                        selectedPath = browserDialog.SelectedPath;
                        SelectedPath = selectedPath;
                    }
                }
                return selectedPath;
            };

            Func<string, string> ChooseFilePath = (string _) => {
                string filePath = string.Empty;
                using (var fileDialog = new OpenFileDialog()) {
                    fileDialog.Title = _;
                    fileDialog.InitialDirectory = SelectedPath;
                    fileDialog.Multiselect = false;
                    if (fileDialog.ShowDialog() == DialogResult.OK) {
                        FileInfo fileInfo = new FileInfo(fileDialog.FileName);
                        SelectedPath = fileInfo.DirectoryName;
                        filePath = fileInfo.FullName;
                    }
                    return filePath;
                }
            };

            EventHandler PathLinkClickHandler = (o, v) => {
                var sender = (LinkLabel)o;
                var tag = sender.Tag;
                if (tag != null && tag is TextBox) {
                    var owner = (TextBox)tag;
                    var path = owner.Text;
                    if (Directory.Exists(path)) {
                        Process.Start(path);
                    }
                }
            };

            EventHandler TextChangedEventHandler = (o, v) => {
                var sender = (TextBox)o;
                var tag = sender.Tag;
                var key = tag == null ? string.Empty : tag.ToString();
                var text = sender.Text;

                if (!string.IsNullOrEmpty(key)) {
                    string message = string.Empty;
                    switch (key) {
                        case "EnvironmentPath":
                            if (string.IsNullOrEmpty(text)) {
                                message = "[环境路径不可空白]";
                            } else {
                                if(!Directory.Exists(text)) {
                                    message = "[环境路径无效或不存在]";
                                } else {
                                    message = string.Empty;
                                }
                            }
                            ErrorProvider.SetError(tboxEnvironmentPath, message);
                            break;
                        case "ExportPath":
                            if (string.IsNullOrEmpty(text)) {
                                message = "[Export路径不可空白]";
                            } else {
                                if (!Directory.Exists(text)) {
                                    message = "[Export路径无效]";
                                } else {
                                    message = string.Empty;
                                }
                            }
                            ErrorProvider.SetError(tboxExportPath, message);
                            break;
                        case "TypeKey":
                            if (string.IsNullOrEmpty(text)) {
                                message = "[Export路径不可空白]";
                            } else {
                                message = string.Empty;
                            }
                            ErrorProvider.SetError(tboxExportPath, message);
                            break;
                        case "E10Version":
                            if (string.IsNullOrEmpty(text)) {
                                message = "[E10Version不可空白]";
                            } else {
                                message = string.Empty;
                            }
                            ErrorProvider.SetError(tboxE10Version, message);
                            break;
                    }
                }
            };

            //
            // lnkSelectEnvironmentPath
            //
            lnkSelectEnvironmentPath.Click += (o, v) => {
                string selectedPath = ChooseFolderPath("选择环境路径");
                if (!string.IsNullOrEmpty(selectedPath)) {
                    tboxEnvironmentPath.Text = selectedPath;
                }
            };
            //
            // lnkSelectExportPath
            //
            lnkSelectExportPath.Click += (o, v) => {
                string selectedPath = ChooseFolderPath("选择Export路径");
                if (!string.IsNullOrEmpty(selectedPath)) {
                    tboxExportPath.Text = selectedPath;
                }
            };
            //
            // lnkEnvironmentPath
            //
            lnkEnvironmentPath.Click += PathLinkClickHandler;
            lnkEnvironmentPath.Tag = tboxEnvironmentPath;
            //
            // lnkExportPath
            //
            lnkExportPath.Click += PathLinkClickHandler;
            lnkExportPath.Tag = tboxExportPath;
            //
            // tboxEnvironmentPath
            //
            tboxEnvironmentPath.TextChanged += TextChangedEventHandler;
            //
            // tboxExportPath
            //
            tboxExportPath.TextChanged += TextChangedEventHandler;
            //
            // tboxTypeKey
            //
            tboxTypeKey.TextChanged += TextChangedEventHandler;
            //
            // lnkLocateVsDevCmdbat
            //
            lnkLocateVsDevCmdbat.Click += (o, v) => {
                var filePath = ChooseFilePath("选择 Visual Studio Develop Command 批处理程序");
                if (!string.IsNullOrEmpty(filePath)) {
                    lblLocateVsDevCmdbat.Text = filePath;
                }
            };
            //
            // lnkLocationCMClient
            //
            lnkLocationCMClient.Click += (o, v) => {
                var filePath = ChooseFilePath("选择 Digiwin.Mars.Deployment.Client.exe 程序");
                if (!string.IsNullOrEmpty(filePath)) {
                    lblLocationCMClient.Text = filePath;
                }
            };
            //
            // cbboxStartServerParamsType
            //
            cbboxStartServerParamsType.SelectedIndexChanged += (o, v) => {
                var sender = (ComboBox)o;
                var selectedIndex = sender.SelectedIndex;
                var paramsType = (ServerParamsType)selectedIndex;
                switch (paramsType) {
                    default:
                    case ServerParamsType.All:
                        SelectedVersion.ServerParams = "";
                        break;
                    case ServerParamsType.AllAndRepair:
                        SelectedVersion.ServerParams = "/r";
                        break;
                    case ServerParamsType.Debug:
                        SelectedVersion.ServerParams = "/d";
                        break;
                    case ServerParamsType.DebugAndRepair:
                        SelectedVersion.ServerParams = "/r /d";
                        break;
                    case ServerParamsType.Upgrade:
                        SelectedVersion.ServerParams = "/r";
                        break;
                }
                tboxServerParams.ReadOnly = paramsType != ServerParamsType.Custom;
            };
            //
            // cbboxStartClientParamsType
            //
            cbboxStartClientParamsType.SelectedIndexChanged += (o, v) => {
                var sender = (ComboBox)o;
                var selectedIndex = sender.SelectedIndex;
                var paramsType = (ClientParamsType)selectedIndex;
                switch (paramsType) {
                    default:
                    case ClientParamsType.All:
                        SelectedVersion.ClientParams = "";
                        break;
                    case ClientParamsType.Debug:
                        SelectedVersion.ClientParams = "d /l";
                        break;
                }
                tboxClientParams.ReadOnly = paramsType != ClientParamsType.Custom;
            };
            //
            // lblDeployTitle
            //
            lblDeployTitle.Click += (o, v) => { tabContainer.SelectedTab = pageBaseParamsSetting; };

            //定义BackgroundWorker运行过程中需管控可用状态的界面组件
            _EnabledComponents = new System.Windows.Forms.Control[] {
                lnkSelectVersion, lnkEnvironmentPath, tboxEnvironmentPath, lnkExportPath, tboxExportPath, tboxTypeKey,
                rdoBase, rdoIndustry, rdoCustomization, cboxDeployToClient, cboxDeployToServer, cboxDeployWebServer, cboxDeployZhCHTResources, cboxDeployEnUSResources, lnkLocateVsDevCmdbat, tboxComplieCommandText, btnComplie,
                cboxKillEprocess, cboxKillClientProcess, cboxAutoDeploy, tboxServerParams, tboxClientParams, cboxApplyciBeenPutInStorage, cboxExcludeProgramInfo, cboxBeforeDeployementKillEprocess, tboxApplyciDocs, 
                btnDeploy, btnStartServer, btnStartClient, btnDeployement, btnCheckReferences, btnKillEprocess
            };
            //定义BackgroundWorker运行过程中需管控显示状态的界面组件
            _VisibleComponents = new System.Windows.Forms.Control[] {
                //pnlDetailsToolbar
            };
            
            //
            // DeployWorker
            //
            DeployWorker.DoWork += (o, v) => {
                RefreshSysStatusContainer("正在部署");
                Invoke(_enabledComponentsProxy, new object[] { _EnabledComponents, false });
                Invoke(_visibleComponentsProxy, new object[] { _VisibleComponents, false });
                DeployProxy();
            };
            DeployWorker.RunWorkerCompleted += (o, v) => {
                RefreshSysStatusContainer(string.Empty);
                Invoke(_enabledComponentsProxy, new object[] { _EnabledComponents, true });
                Invoke(_visibleComponentsProxy, new object[] { _VisibleComponents, true });
            };
            //
            // DeployementWorker
            //
            DeployementWorker.DoWork += (o, v) => {
                RefreshSysStatusContainer("正在部署提交资源");
                Invoke(_enabledComponentsProxy, new object[] { _EnabledComponents, false });
                Invoke(_visibleComponentsProxy, new object[] { _VisibleComponents, false });
                DeployementProxy();
            };
            DeployementWorker.RunWorkerCompleted += (o, v) => {
                RefreshSysStatusContainer(string.Empty);
                Invoke(_enabledComponentsProxy, new object[] { _EnabledComponents, true });
                Invoke(_visibleComponentsProxy, new object[] { _VisibleComponents, true });
            };
            //
            // CheckReferencesWorker
            //
            CheckReferencesWorker.DoWork += (o, v) => {
                RefreshSysStatusContainer("正在检查引用");
                Invoke(_enabledComponentsProxy, new object[] { _EnabledComponents, false });
                Invoke(_visibleComponentsProxy, new object[] { _VisibleComponents, false });
                CheckReferencesProxy();
            };
            CheckReferencesWorker.RunWorkerCompleted += (o, v) => {
                RefreshSysStatusContainer(string.Empty);
                Invoke(_enabledComponentsProxy, new object[] { _EnabledComponents, true });
                Invoke(_visibleComponentsProxy, new object[] { _VisibleComponents, true });
            };
            //
            // ComplieWorker
            //
            ComplieWorker.DoWork += (o, v) => {
                RefreshSysStatusContainer("正在编译");
                Invoke(_enabledComponentsProxy, new object[] { _EnabledComponents, false });
                Invoke(_visibleComponentsProxy, new object[] { _VisibleComponents, false });
                ComplieProxy();
            };
            ComplieWorker.RunWorkerCompleted += (o, v) => {
                RefreshSysStatusContainer(string.Empty);
                Invoke(_enabledComponentsProxy, new object[] { _EnabledComponents, true });
                Invoke(_visibleComponentsProxy, new object[] { _VisibleComponents, true });
            };
            //
            // TrushpdbArchivesWorker
            //
            TrushpdbArchivesWorker.DoWork += (o, v) => {
                Invoke(_enabledComponentsProxy, new object[] { _EnabledComponents, false });
                TrushpdbArchivesProxy();
            };
            TrushpdbArchivesWorker.RunWorkerCompleted += (o, v) => {
                Invoke(_enabledComponentsProxy, new object[] { _EnabledComponents, true });
            };
            //
            // ExtractWorker
            //
            ExtractWorker.DoWork += (o, v) => {
                RefreshSysStatusContainer("正在提取TypeKey运行文件");
                Invoke(_enabledComponentsProxy, new object[] { _EnabledComponents, false });
                Invoke(_visibleComponentsProxy, new object[] { _VisibleComponents, false });
                ExtractProxy();
            };
            ExtractWorker.RunWorkerCompleted += (o, v) => {
                RefreshSysStatusContainer(string.Empty);
                Invoke(_enabledComponentsProxy, new object[] { _EnabledComponents, true });
                Invoke(_visibleComponentsProxy, new object[] { _VisibleComponents, true });
            };
            //
            // ImportConfigurationWorker
            //
            ImportConfigurationWorker.DoWork += (o, v) => {
                RefreshSysStatusContainer("正在导入配置文件");
                Invoke(_enabledComponentsProxy, new object[] { _EnabledComponents, false });
                Invoke(_visibleComponentsProxy, new object[] { _VisibleComponents, false });
                ImportConfigurationProxy();
            };
            ImportConfigurationWorker.RunWorkerCompleted += (o, v) => {
                RefreshSysStatusContainer(string.Empty);
                Invoke(_enabledComponentsProxy, new object[] { _EnabledComponents, true });
                Invoke(_visibleComponentsProxy, new object[] { _VisibleComponents, true });
            };
        }

        private void IntelligentDeployControl_Load(object sender, EventArgs e) {
            EpIAContext.IntelligentDeployContext.DeployVersions = IntelligentDeployWorker.GetDeployVersionList();
            SelectedVersion = Context.SelectedDeployVersion;
            if (SelectedVersion == null) {
                //初始化自动部署默认版本信息
                var context = new DeployVersionContext() {
                    IsSelected = true,
                };
                EpIAContext.IntelligentDeployContext.DeployVersions.Add(context);
                SelectedVersion = EpIAContext.IntelligentDeployContext.SelectedDeployVersion;
                
                //保存设置
                IntelligentDeployWorker.CreateDeployVersion(context);
            }
            var intelligentDeploySection = Context.GetIntelligentDeployContextSection(out Configuration configuration);
            Context.CMSettings.LocateCMClient = intelligentDeploySection.CMSettings.LocateCMClient;
            Context.CMSettings.CMClientParams = intelligentDeploySection.CMSettings.CMClientParams;
            if (string.IsNullOrEmpty(intelligentDeploySection.ComplieSettings.LocateVsDevCmdbat)) intelligentDeploySection.ComplieSettings.LocateVsDevCmdbat = @"C:\Program Files (x86)\Microsoft Visual Studio 9.0\VC\vcvarsall.bat";
            if (string.IsNullOrEmpty(intelligentDeploySection.ComplieSettings.ComplieCommandText)) intelligentDeploySection.ComplieSettings.ComplieCommandText = @"devenv {sln-url} /rebuild ""Debug|AnyCPU""";
            Context.ComplieSettings.LocateVsDevCmdbat = intelligentDeploySection.ComplieSettings.LocateVsDevCmdbat;
            Context.ComplieSettings.ComplieCommandText = intelligentDeploySection.ComplieSettings.ComplieCommandText;

            BindingSource.DataSource = SelectedVersion;
            lblVersion.DataBindings.Add(new Binding("Text", BindingSource, "Name", false, DataSourceUpdateMode.OnPropertyChanged));
            tboxEnvironmentPath.DataBindings.Add(new Binding("Text", BindingSource, "EnvrionmentPath", false, DataSourceUpdateMode.OnPropertyChanged));
            tboxExportPath.DataBindings.Add(new Binding("Text", BindingSource, "ExportPath", false, DataSourceUpdateMode.OnPropertyChanged));
            tboxTypeKey.DataBindings.Add(new Binding("Text", BindingSource, "TypeKey", false, DataSourceUpdateMode.OnPropertyChanged));
            tboxE10Version.DataBindings.Add(new Binding("Text", BindingSource, "E10Version", false, DataSourceUpdateMode.OnPropertyChanged));

            switch (SelectedVersion.DeployTarget) {
                case DeployTarget.Base:
                    rdoBase.Checked = true;
                    break;
                case DeployTarget.Industry:
                    rdoIndustry.Checked = true;
                    break;
                case DeployTarget.Customization:
                    rdoCustomization.Checked = true;
                    break;
            }

            cboxDeployToClient.DataBindings.Add(new Binding("Checked", BindingSource, "DeployToClient", false, DataSourceUpdateMode.OnPropertyChanged));
            cboxDeployToServer.DataBindings.Add(new Binding("Checked", BindingSource, "DeployToServer", false, DataSourceUpdateMode.OnPropertyChanged));
            cboxDeployWebServer.DataBindings.Add(new Binding("Checked", BindingSource, "DeployToWebServer", false, DataSourceUpdateMode.OnPropertyChanged));
            cboxDeployZhCHTResources.DataBindings.Add(new Binding("Checked", BindingSource, "DeployZhCHTResources", false, DataSourceUpdateMode.OnPropertyChanged));
            cboxDeployEnUSResources.DataBindings.Add(new Binding("Checked", BindingSource, "DeployEnUSResources", false, DataSourceUpdateMode.OnPropertyChanged));

            cboxKillEprocess.DataBindings.Add(new Binding("Checked", BindingSource, "KillEprocess", false, DataSourceUpdateMode.OnPropertyChanged));
            cboxKillClientProcess.DataBindings.Add(new Binding("Checked", BindingSource, "KillClientProcess", false, DataSourceUpdateMode.OnPropertyChanged));
            cboxAutoDeploy.DataBindings.Add(new Binding("Checked", BindingSource, "AutoDeploy", false, DataSourceUpdateMode.OnPropertyChanged));
            cbboxStartServerParamsType.DataBindings.Add(new Binding("SelectedIndex", BindingSource, "ServerParamsType", false, DataSourceUpdateMode.OnPropertyChanged));
            tboxServerParams.DataBindings.Add(new Binding("Text", BindingSource, "ServerParams", false, DataSourceUpdateMode.OnPropertyChanged));
            cbboxStartClientParamsType.DataBindings.Add(new Binding("SelectedIndex", BindingSource, "ClientParamsType", false, DataSourceUpdateMode.OnPropertyChanged));
            tboxClientParams.DataBindings.Add(new Binding("Text", BindingSource, "ClientParams", false, DataSourceUpdateMode.OnPropertyChanged));

            cboxApplyciBeenPutInStorage.DataBindings.Add(new Binding("Checked", BindingSource, "ApplyciBeenPutInStorage", false, DataSourceUpdateMode.OnPropertyChanged));
            cboxExcludeProgramInfo.DataBindings.Add(new Binding("Checked", BindingSource, "ExcludeProgramInfo", false, DataSourceUpdateMode.OnPropertyChanged));
            cboxBeforeDeployementKillEprocess.DataBindings.Add(new Binding("Checked", BindingSource, "BeforeDeployementKillEprocess", false, DataSourceUpdateMode.OnPropertyChanged));
            tboxApplyciDocs.DataBindings.Add(new Binding("Text", BindingSource, "ApplyciDocs", false, DataSourceUpdateMode.OnPropertyChanged));

            BindingSourceToComplie.DataSource = Context.ComplieSettings;
            lblLocateVsDevCmdbat.DataBindings.Add(new Binding("Text", BindingSourceToComplie, "LocateVsDevCmdbat", false, DataSourceUpdateMode.OnPropertyChanged));
            tboxComplieCommandText.DataBindings.Add(new Binding("Text", BindingSourceToComplie, "ComplieCommandText", false, DataSourceUpdateMode.OnPropertyChanged));

            BindingSourceToCMSetting.DataSource = Context.CMSettings;
            lblLocationCMClient.DataBindings.Add(new Binding("Text", BindingSourceToCMSetting, "LocateCMClient", false, DataSourceUpdateMode.OnPropertyChanged));
            tboxCMClientParams.DataBindings.Add(new Binding("Text", BindingSourceToCMSetting, "CMClientParams", false, DataSourceUpdateMode.OnPropertyChanged));

            SetDeployTitle();
        }

        private void lnkSelectVersion_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (var versionSettingForm = new DeployVersionSettingForm(Context.DeployVersions)) {
                versionSettingForm.ShowDialog();
                SelectedVersion = versionSettingForm.SelectedVersion;
                BindingSource.DataSource = SelectedVersion;
                SetDeployTitle();
            }
        }

        private void btnWordWarp_Click(object sender, EventArgs e) {
            richboxPrint.WordWrap = !richboxPrint.WordWrap;
        }

        private void btnClear_Click(object sender, EventArgs e) {
            richboxPrint.Clear();
        }

        private void btnView_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(richboxPrint.Rtf)) {
                using (var viewForm = new ViewForm(richboxPrint.Rtf)) {
                    viewForm.ShowDialog();
                }
            }
        }

        /// <summary>
        /// 关闭E10进程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        [STAThread]
        private void btnKillEprocess_Click(object sender, EventArgs e) {
            //关闭E10进程校验逻辑
            Func<bool> Validator = () => {
                bool successfully = true;
                string message = string.Empty;

                if (string.IsNullOrEmpty(SelectedVersion.EnvrionmentPath)) {
                    message = "[环境路径不可空白]";
                    successfully = false;
                } else {
                    if (!Directory.Exists(SelectedVersion.EnvrionmentPath)) {
                        message = "[环境路径无效或不存在]";
                        successfully = false;
                    } else {
                        message = string.Empty;
                    }
                }
                if (!successfully) {
                    tabContainer.SelectedTab = pageBaseParamsSetting;
                //} else {
                //    tabContainer.SelectedTab = pageEnvironmentSetting;
                }
                ErrorProvider.SetError(tboxEnvironmentPath, message);

                return successfully;
            };

            if (Validator()) {
                RefreshSysStatusContainer(string.Empty);

                var targetPaths = new string[] {
                    Path.Combine(SelectedVersion.EnvrionmentPath, @"Server\Control\Digiwin.Mars.ServerStart.exe"),
                    Path.Combine(SelectedVersion.EnvrionmentPath, @"Server\Application\Digiwin.Mars.AccountSetStart.exe"),
                    Path.Combine(SelectedVersion.EnvrionmentPath, @"DeployServer\Shared\Digiwin.Mars.ClientStart.exe"),
                };
                var processes = Process.GetProcesses().Where(_ =>
                        _.ProcessName == "Digiwin.Mars.ClientStart" ||
                        _.ProcessName == "Digiwin.Mars.ServerStart" ||
                        _.ProcessName == "Digiwin.Mars.AccountSetStart")
                    .OrderBy(_ => _.ProcessName);
                if (!processes.Any(_ => targetPaths.Contains(_.MainModule.FileName))) {
                    PrintProxy(" >> 未找到匹配的进程", Color.Purple);
                } else {
                    foreach (var proc in processes) {
                        if (targetPaths.Contains(proc.MainModule.FileName)) {
                            try {
                                proc.Kill();
                                PrintProxy($"{DateTime.Now.ToStandardDateTimeString()} >> 终止进程：ProcessId={proc.Id}, ProcessName={proc.ProcessName}", Color.Purple);
                            } catch (Exception) {
                                PrintProxy($"{DateTime.Now.ToStandardDateTimeString()} >> 终止进程 {proc.ProcessName} 失败，请以管理员权限启动该程序，再尝试此操作", Color.Red);
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 检查引用
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckReferences_Click(object sender, EventArgs e) {
            //检查引用校验逻辑
            Func<bool> Validator = () => {
                bool successfully = true;
                string message = string.Empty;

                if (string.IsNullOrEmpty(SelectedVersion.ExportPath)) {
                    message = "[Export路径不可空白]";
                    successfully = false;
                } else {
                    if (!Directory.Exists(SelectedVersion.ExportPath)) {
                        message = "[Export路径无效]";
                        successfully = false;
                    } else {
                        message = string.Empty;
                    }
                }
                ErrorProvider.SetError(tboxExportPath, message);

                if (string.IsNullOrEmpty(SelectedVersion.TypeKey)) {
                    message = "[TypeKey不可空白]";
                    successfully = false;
                } else {
                    message = string.Empty;
                }
                ErrorProvider.SetError(tboxTypeKey, message);

                if (string.IsNullOrEmpty(SelectedVersion.E10Version)) {
                    message = "[E10版本名称不可空白]";
                    successfully = false;
                } else {
                    message = string.Empty;
                }
                ErrorProvider.SetError(tboxTypeKey, message);

                tabContainer.SelectedTab = pageBaseParamsSetting;

                return successfully;
            };

            if (Validator()) {
                CheckReferencesWorker.RunWorkerAsync();
            }
        }

        /// <summary>
        /// 部署提交资源
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeployement_Click(object sender, EventArgs e) {
            //部署提交资源校验逻辑
            Func<bool> Validator = () => {
                bool successfully = true;
                string message = string.Empty;

                if (string.IsNullOrEmpty(SelectedVersion.EnvrionmentPath)) {
                    message = "[环境路径不可空白]";
                    successfully = false;
                } else {
                    if (!Directory.Exists(SelectedVersion.EnvrionmentPath)) {
                        message = "[环境路径无效或不存在]";
                        successfully = false;
                    } else {
                        message = string.Empty;
                    }
                }
                ErrorProvider.SetError(tboxEnvironmentPath, message);

                if (string.IsNullOrEmpty(SelectedVersion.E10Version)) {
                    message = "[E10版本名称不可空白]";
                    successfully = false;
                } else {
                    message = string.Empty;
                }
                ErrorProvider.SetError(tboxE10Version, message);
                
                if (successfully) {
                    if (string.IsNullOrEmpty(SelectedVersion.ApplyciDocs)) {
                        message = "[签出单号不可空白]";
                        successfully = false;

                        tabContainer.SelectedTab = pageJoinCMMangement;
                    } else {
                        message = string.Empty;
                    }
                    ErrorProvider.SetError(tboxApplyciDocs, message);

                    tabContainer.SelectedTab = pageJoinCMMangement;
                    tabJoinCMMangement.SelectedTab = pageDeployServerResources;
                } else {
                    tabContainer.SelectedTab = pageBaseParamsSetting;
                }

                return successfully;
            };

            if (Validator()) {
                if (SelectedVersion.BeforeDeployementKillEprocess) {
                    btnKillEprocess_Click(btnStartServer, e);
                }
                DeployementWorker.RunWorkerAsync();
            }
        }

        /// <summary>
        /// 启动CLIENT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        [STAThread]
        private void btnStartClient_Click(object sender, EventArgs e) {
            //启动CLIENT校验逻辑
            Func<bool> Validator = () => {
                bool successfully = true;
                string message = string.Empty;

                if (string.IsNullOrEmpty(SelectedVersion.EnvrionmentPath)) {
                    message = "[环境路径不可空白]";
                    successfully = false;
                } else {
                    if (!Directory.Exists(SelectedVersion.EnvrionmentPath)) {
                        message = "[环境路径无效或不存在]";
                        successfully = false;
                    } else {
                        message = string.Empty;
                    }
                }
                ErrorProvider.SetError(tboxEnvironmentPath, message);

                if (!successfully) {
                    tabContainer.SelectedTab = pageBaseParamsSetting;
                //} else {
                //    tabContainer.SelectedTab = pageEnvironmentSetting;
                }

                return successfully;
            };

            if (Validator()) {
                RefreshSysStatusContainer(string.Empty);

                string clientPath = Path.Combine(SelectedVersion.EnvrionmentPath, @"DeployServer\Shared\Digiwin.Mars.ClientStart.exe");

                bool abortStartProcess = false;
                if (SelectedVersion.KillClientProcess) {
                    var processes = Process.GetProcesses().Where(_ => _.ProcessName == "Digiwin.Mars.ClientStart");
                    foreach (Process proc in processes) {
                        if (proc.ProcessName == "Digiwin.Mars.ClientStart") {
                            try {
                                if (proc.MainModule.FileName == clientPath) {
                                    proc.Kill();
                                    PrintProxy($"{DateTime.Now.ToStandardDateTimeString()} >> 终止进程：ProcessId={proc.Id}, ProcessName={proc.ProcessName}", Color.Purple);
                                }
                            } catch (Exception ex) {
                                abortStartProcess = true;
                                PrintProxy($"{DateTime.Now.ToStandardDateTimeString()} >> 程序异常，终止进程失败，错误信息：{ex.Message}", Color.Red);
                                break;
                            }
                        }
                    }
                }
                if (!abortStartProcess && File.Exists(clientPath)) {
                    string clientParams = string.Empty;
                    if (SelectedVersion.ClientParamsEnum == ClientParamsType.Custom) {
                        clientParams = SelectedVersion.ClientParams;
                    } else {
                        switch (SelectedVersion.ClientParamsEnum) {
                            case ClientParamsType.Debug:
                                clientParams = "d /l";
                                break;
                        }
                    }
                    StartProcess(clientPath, clientParams, "CLIENT");

                    if (SelectedVersion.AutoDeploy) {
                        DeployContext.DeployToClient = true;
                        DeployWorker.RunWorkerAsync();
                    }
                }
            }
        }

        /// <summary>
        /// 启动SERVER
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        [STAThread]
        private void btnStartServer_Click(object sender, EventArgs e) {
            //启动SERVER校验逻辑
            Func<bool> Validator = () => {
                bool successfully = true;
                string message = string.Empty;

                if (string.IsNullOrEmpty(SelectedVersion.EnvrionmentPath)) {
                    message = "[环境路径不可空白]";
                    successfully = false;
                } else {
                    if (!Directory.Exists(SelectedVersion.EnvrionmentPath)) {
                        message = "[环境路径无效或不存在]";
                        successfully = false;
                    } else {
                        message = string.Empty;
                    }
                }
                ErrorProvider.SetError(tboxEnvironmentPath, message);

                if (!successfully) {
                    tabContainer.SelectedTab = pageBaseParamsSetting;
                //} else {
                //    tabContainer.SelectedTab = pageEnvironmentSetting;
                }

                return successfully;
            };

            if (Validator()) {
                RefreshSysStatusContainer(string.Empty);

                string serverPath = Path.Combine(SelectedVersion.EnvrionmentPath, @"Server\Control\Digiwin.Mars.ServerStart.exe");
                bool abortStartProcess = false;
                if (SelectedVersion.KillEprocess) {
                    string[] targetPaths = new string[] {
                        serverPath,
                        Path.Combine(SelectedVersion.EnvrionmentPath, @"DeployServer\Shared\Digiwin.Mars.ClientStart.exe"),
                    };
                    var processes = Process.GetProcesses().Where(_ =>
                            _.ProcessName == "Digiwin.Mars.ClientStart" ||
                            _.ProcessName == "Digiwin.Mars.ServerStart" ||
                            _.ProcessName == "Digiwin.Mars.AccountSetStart")
                        .OrderBy(_ => _.ProcessName);
                    foreach (Process proc in processes) {
                        try {
                            if (targetPaths.Contains(proc.MainModule.FileName)) {
                                proc.Kill();
                                PrintProxy($"{DateTime.Now.ToStandardDateTimeString()} >> 终止进程：ProcessId={proc.Id}, ProcessName={proc.ProcessName}", Color.Purple);
                            }
                        } catch (Exception ex) {
                            abortStartProcess = true;
                            PrintProxy($"{DateTime.Now.ToStandardDateTimeString()} >> 程序异常，终止进程失败，错误信息：{ex.Message}", Color.Red);
                            break;
                        }
                    }
                }

                if (!abortStartProcess && File.Exists(serverPath)) {
                    string serverParams = string.Empty;
                    if (SelectedVersion.ServerParamsEnum == ServerParamsType.Custom) {
                        serverParams = SelectedVersion.ServerParams;
                    } else {
                        switch (SelectedVersion.ServerParamsEnum) {
                            case ServerParamsType.AllAndRepair:
                                serverParams = "/r";
                                break;
                            case ServerParamsType.Debug:
                                serverParams = "/d";
                                break;
                            case ServerParamsType.DebugAndRepair:
                                serverParams = "/d /r";
                                break;
                            case ServerParamsType.Upgrade:
                                serverParams = "/u";
                                break;
                        }
                    }
                    StartProcess(serverPath, serverParams, "SERVER");

                    if (SelectedVersion.AutoDeploy) {
                        DeployContext.DeployToClient = true;
                        DeployContext.DeployToServer = true;
                        DeployWorker.RunWorkerAsync();
                    }
                }
            }
        }

        /// <summary>
        /// 部署
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeploy_Click(object sender, EventArgs e) {
            //部署校验逻辑
            Func<bool> Validator = () => {
                bool successfully = true;
                string message = string.Empty;

                if (string.IsNullOrEmpty(SelectedVersion.EnvrionmentPath)) {
                    message = "[环境路径不可空白]";
                    successfully = false;
                } else {
                    if (!Directory.Exists(SelectedVersion.EnvrionmentPath)) {
                        message = "[环境路径无效或不存在]";
                        successfully = false;
                    } else {
                        message = string.Empty;
                    }
                }
                ErrorProvider.SetError(tboxEnvironmentPath, message);

                if (string.IsNullOrEmpty(SelectedVersion.ExportPath)) {
                    message = "[Export路径不可空白]";
                    successfully = false;
                } else {
                    if (!Directory.Exists(SelectedVersion.ExportPath)) {
                        message = "[Export路径无效]";
                        successfully = false;
                    } else {
                        message = string.Empty;
                    }
                }
                ErrorProvider.SetError(tboxExportPath, message);

                if (string.IsNullOrEmpty(SelectedVersion.TypeKey)) {
                    message = "[TypeKey不可空白]";
                    successfully = false;
                } else {
                    message = string.Empty;
                }
                ErrorProvider.SetError(tboxTypeKey, message);

                if (!successfully) {
                    tabContainer.SelectedTab = pageBaseParamsSetting;
                } else {
                    tabContainer.SelectedTab = pageComplieAndDeploy;
                    tabDeployAdvancedSetting.SelectedTab = pageDeployAdvancedSetting;
                }

                return successfully;
            };

            if (Validator()) {
                DeployContext.DeployToClient = true;
                DeployContext.DeployToServer = true;
                DeployWorker.RunWorkerAsync();
            }
        }

        /// <summary>
        /// 编译
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnComplie_Click(object sender, EventArgs e) {
            //编译校验逻辑
            Func<bool> Validator = () => {
                bool successfully = true;
                string message = string.Empty;

                if (string.IsNullOrEmpty(SelectedVersion.ExportPath)) {
                    message = "[Export路径不可空白]";
                    successfully = false;
                } else {
                    if (!Directory.Exists(SelectedVersion.ExportPath)) {
                        message = "[Export路径无效]";
                        successfully = false;
                    } else {
                        message = string.Empty;
                    }
                }
                ErrorProvider.SetError(tboxExportPath, message);

                if (string.IsNullOrEmpty(SelectedVersion.TypeKey)) {
                    message = "[TypeKey不可空白]";
                    successfully = false;
                } else {
                    message = string.Empty;
                }
                ErrorProvider.SetError(tboxTypeKey, message);

                if (successfully) {
                    if (string.IsNullOrEmpty(Context.ComplieSettings.LocateVsDevCmdbat)) {
                        message = "[Visual Studio Develop Command 批处理文件不可空白]";
                        successfully = false;
                    } else {
                        if (!File.Exists(Context.ComplieSettings.LocateVsDevCmdbat)) {
                            message = "[Visual Studio Develop Command 批处理文件无效或不存在]";
                            successfully = false;
                        } else {
                            message = string.Empty;
                        }
                    }
                    ErrorProvider.SetError(lblLocateVsDevCmdbatTitle, message);

                    if (string.IsNullOrEmpty(Context.ComplieSettings.ComplieCommandText)) {
                        message = "[编译命令不可空白]";
                        successfully = false;
                    } else {
                        message = string.Empty;
                    }
                    ErrorProvider.SetError(tboxComplieCommandText, message);

                    tabContainer.SelectedTab = pageComplieAndDeploy;
                    tabDeployAdvancedSetting.SelectedTab = pageComplieAdvancedSetting;
                } else {
                    tabContainer.SelectedTab = pageBaseParamsSetting;
                }

                return successfully;
            };

            if (Validator()) {
                ComplieWorker.RunWorkerAsync();
            }
        }

        /// <summary>
        /// 启动 CM Client 程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStartCMClient_Click(object sender, EventArgs e) {
            //启动CM程序校验
            Func<bool> Validator = () => {
                bool successfully = true;
                string message = string.Empty;
                
                if (string.IsNullOrEmpty(Context.CMSettings.LocateCMClient) || !File.Exists(Context.CMSettings.LocateCMClient)) {
                    message = "[Digiwin.Mars.Deployment.Client.exe 程序路径无效]";
                    successfully = false;
                } else {
                    message = string.Empty;
                }
                ErrorProvider.SetError(lblLocationCMClientTitle, message);

                return successfully;
            };

            if (Validator()) {
                RefreshSysStatusContainer(string.Empty);

                StartProcess(Context.CMSettings.LocateCMClient, SelectedVersion.ClientParams, "CM CLIENT");
            }
        }

        /// <summary>
        /// 关闭 CM Client 进程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        [STAThread]
        private void lnkKillCMProcess_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            //关闭CM程序校验
            Func<bool> Validator = () => {
                bool successfully = true;

                if (string.IsNullOrEmpty(Context.CMSettings.LocateCMClient) || !File.Exists(Context.CMSettings.LocateCMClient)) {
                    successfully = false;
                }

                return successfully;
            };

            if (Validator()) {
                bool killAbort = true;
                string message = string.Empty;
                var locateFileInfo = new FileInfo(Context.CMSettings.LocateCMClient);
                var processes = Process.GetProcesses().Where(_ => _.ProcessName == "Digiwin.Mars.ClientStart");
                foreach (var proc in processes) {
                    try {
                        var procFileInfo = new FileInfo(proc.MainModule.FileName);
                        if (procFileInfo.Directory.FullName == locateFileInfo.Directory.FullName) {
                            proc.Kill();
                            killAbort = false;
                            PrintProxy($"{DateTime.Now.ToStandardDateTimeString()} >> 终止进程：ProcessId={proc.Id}, ProcessName={proc.ProcessName}", Color.Purple);
                        }
                    } catch (Exception ex) {
                        message += ex.Message;
                    }
                }
                if(killAbort) {
                    PrintProxy($" >> 未找到与CM程序路径相匹配的进程", Color.OrangeRed);
                    if (!string.IsNullOrEmpty(message)) {
                        PrintProxy($" >> 异常消息：{message}", Color.Red);
                    }
                }
            }
        }

        /// <summary>
        /// 导入配置文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkImportConfigurationArchives_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            //导入前校验逻辑
            Func<bool> Validator = () => {
                bool successfully = true;
                string message = string.Empty;

                if (string.IsNullOrEmpty(SelectedVersion.EnvrionmentPath)) {
                    message = "[环境路径不可空白]";
                    successfully = false;
                } else {
                    if (!Directory.Exists(SelectedVersion.EnvrionmentPath)) {
                        message = "[环境路径无效或不存在]";
                        successfully = false;
                    } else {
                        message = string.Empty;
                    }
                }
                if (!successfully) {
                    tabContainer.SelectedTab = pageBaseParamsSetting;
                }
                ErrorProvider.SetError(tboxEnvironmentPath, message);

                return successfully;
            };

            if (Validator()) {
                using (var importForm = new ImportConfigurationForm()) {
                    importForm.SelectedPath = SelectedPath;
                    if (importForm.ShowDialog() == DialogResult.OK) {
                        _importConfigurationContext = importForm.Context;
                        ImportConfigurationWorker.RunWorkerAsync();
                    }
                }
            }
        }

        /// <summary>
        /// 提取TypeKey运行文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkExtractRuntimeResources_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            //提取前校验逻辑
            Func<bool> Validator = () => {
                bool successfully = true;
                string message = string.Empty;

                if (string.IsNullOrEmpty(SelectedVersion.EnvrionmentPath)) {
                    message = "[环境路径不可空白]";
                    successfully = false;
                } else {
                    if (!Directory.Exists(SelectedVersion.EnvrionmentPath)) {
                        message = "[环境路径无效或不存在]";
                        successfully = false;
                    } else {
                        message = string.Empty;
                    }
                }
                ErrorProvider.SetError(tboxEnvironmentPath, message);
                if (!successfully) {
                    tabContainer.SelectedTab = pageBaseParamsSetting;
                }

                return successfully;
            };

            if (Validator()) {
                using (var extractForm = new ExtractRuntimeResourcesForm(SelectedVersion.TypeKey)) {
                    extractForm.SelectedPath = SelectedPath;
                    if (extractForm.ShowDialog() == DialogResult.OK) {
                        _extractContext = extractForm.Context;
                        ExtractWorker.RunWorkerAsync();
                    }
                }
            }
        }

        /// <summary>
        /// 预览账套配置文件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lnkAccountSettingView_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            Func<bool> Validator = () => {
                bool successfully = true;
                string message = string.Empty;

                if (string.IsNullOrEmpty(SelectedVersion.EnvrionmentPath)) {
                    message = "[环境路径不可空白]";
                    successfully = false;
                } else {
                    if (!Directory.Exists(SelectedVersion.EnvrionmentPath)) {
                        message = "[环境路径无效或不存在]";
                        successfully = false;
                    } else {
                        message = string.Empty;
                    }
                }
                ErrorProvider.SetError(tboxEnvironmentPath, message);
                if (!successfully) {
                    tabContainer.SelectedTab = pageBaseParamsSetting;
                }

                return successfully;
            };

            if (Validator()) {
                using (var accountSetPerviewForm = new AccountSetPerviewForm()) {
                    accountSetPerviewForm.Context.SourceEnvironmentPath = SelectedVersion.EnvrionmentPath;
                    accountSetPerviewForm.ShowDialog();
                }
            }
        }

        /// <summary>
        /// 用于协同窗体KeyDown事件相关的业务处理：批量删除*.pdb文件
        /// </summary>
        public void TrushpdbArchives() {
            //批量删除pdb文件校验逻辑
            Func<bool> Validator = () => {
                bool successfully = true;

                if (string.IsNullOrEmpty(SelectedVersion.EnvrionmentPath) || !Directory.Exists(SelectedVersion.EnvrionmentPath)) {
                    successfully = false;
                }

                return successfully;
            };

            if(Validator()) {
                if (MessageBox.Show("执行此操作将删除环境目录下的*.pdb文件，确定要进行吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK) {
                    TrushpdbArchivesWorker.RunWorkerAsync();
                }
            } else {
                MessageBox.Show("环境路径不是有效的路径，无法执行此操作！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartProcess(string programPath, string arguments, string targetName) {
            try {
                FileInfo fileInfo = new FileInfo(programPath);
                ProcessStartInfo startInfo = new ProcessStartInfo(programPath, arguments) {
                    WorkingDirectory = fileInfo.Directory.FullName,
                    Verb = "runas",
                };
                Process.Start(startInfo);

                PrintProxy($"{DateTime.Now.ToStandardDateTimeString()} >> {targetName}已启动" + (string.IsNullOrEmpty(arguments) ? string.Empty : ", 启动参数为" + arguments), Color.Blue);
            } catch (Exception ex) {
                PrintProxy($"{DateTime.Now.ToStandardDateTimeString()} >> 运行{targetName}端失败: {ex.Message}", Color.Red);
            }
        }

        private void PrintProxy(string message) {
            PrintProxy(message, _WindowText);
        }
        private void PrintProxy(bool clear) {
            PrintProxy(string.Empty, _WindowText, true);
        }
        private void PrintProxy(string message, Color fontColor) {
            PrintProxy(message, fontColor, false);
        }
        private void PrintProxy(string message, Color fontColor, bool clear = false) {
            Invoke(_printDetailsProxy, new object[] { richboxPrint, message, clear, fontColor });
        }

        private void SetDeployTitle() {
            string envrionmentPath = string.IsNullOrEmpty(SelectedVersion.EnvrionmentPath) ? "Envrionment path is empty." : SelectedVersion.EnvrionmentPath;
            lblDeployTitle.Text = $"{SelectedVersion.Name} ({envrionmentPath})";
        }

        /// <summary>
        /// 刷新系统状态
        /// </summary>
        /// <param name="statusMessage"></param>
        private void RefreshSysStatusContainer(string statusMessage) {
            var container = EpIAContext.StatusContainer;
            container.StatusMessage = statusMessage;
            Invoke(_refreshStatusContainerProxy, new object[] { container });
        }
        
        /// <summary>
        /// 部署代理
        /// </summary>
        private void DeployProxy() {
            //PrintProxy(true);

            //获取中间部署路径
            Func<string> GetMiddlePath = () => {
                string middlePath = string.Empty;
                switch (SelectedVersion.DeployTarget) {
                    case DeployTarget.Industry:
                        middlePath = _Industry;
                        break;
                    case DeployTarget.Customization:
                        middlePath = _Customization;
                        break;
                }
                return middlePath;
            };

            //复制文件到环境目标路径下
            var CopyToEnvrionment = new Action<FileInfo, string, string>((FileInfo sourceFileInfo, string destinationPath, string targetName) => {
                var deployModel = new DeployModel() { Dll = sourceFileInfo, TargetName = targetName };
                string targetDllFullPath = string.Empty;
                switch (sourceFileInfo.Directory.Name) {
                    case "Export":
                        targetDllFullPath = Path.Combine(destinationPath, sourceFileInfo.Name);
                        break;
                    case "Zh-CHT":
                        if (SelectedVersion.DeployZhCHTResources) targetDllFullPath = Path.Combine(destinationPath, sourceFileInfo.Directory.Name, sourceFileInfo.Name);
                        break;
                    case "en-US":
                        if (SelectedVersion.DeployEnUSResources) targetDllFullPath = Path.Combine(destinationPath, sourceFileInfo.Directory.Name, sourceFileInfo.Name);
                        break;
                }
                if (!string.IsNullOrEmpty(targetDllFullPath)) {
                    try {
                        sourceFileInfo.CopyTo(targetDllFullPath, true);
                        PrintProxy($"{DateTime.Now.ToStandardDateTimeString()} >> 拷贝文件 {sourceFileInfo.FullName} 到 {targetDllFullPath}");
                        deployModel.Successfully = true;
                    } catch (Exception ex) {
                        PrintProxy($"{DateTime.Now.ToStandardDateTimeString()} >> 复制失败: {ex.Message}", Color.Red);
                    }
                    DeployModels.Add(deployModel);
                }
            });

            //部署到CLIENT
            var DeployToClient = new Action<IEnumerable<FileInfo>>((IEnumerable<FileInfo> dlls) => {
                var targets = dlls.Where(_ => _.Name.EndsWith(".Business.dll", StringComparison.OrdinalIgnoreCase) | _.Name.EndsWith(".Business.resources.dll", StringComparison.OrdinalIgnoreCase) |
                                _.Name.EndsWith(".UI.dll", StringComparison.OrdinalIgnoreCase) | _.Name.EndsWith(".UI.resources.dll", StringComparison.OrdinalIgnoreCase) |
                                _.Name.EndsWith(".UI.Implement.dll", StringComparison.OrdinalIgnoreCase) | _.Name.EndsWith(".UI.Implement.resources.dll", StringComparison.OrdinalIgnoreCase) |
                                _.Name.EndsWith(".UI.Implement.Report.dll", StringComparison.OrdinalIgnoreCase) | _.Name.EndsWith(".UI.Implement.Report.resources.dll", StringComparison.OrdinalIgnoreCase) |
                                _.Name.EndsWith(".Common.Utils.dll", StringComparison.OrdinalIgnoreCase) | _.Name.EndsWith("Common.Utils.resources.dll", StringComparison.OrdinalIgnoreCase));
                if (targets.Count() > 0) {
                    string middlePath = GetMiddlePath();
                    string combinePath = Path.Combine(@"DeployServer\Shared", middlePath, "Programs");
                    string destinationPath = Path.Combine(SelectedVersion.EnvrionmentPath, combinePath);
                    foreach (var dll in targets) {
                        CopyToEnvrionment(dll, destinationPath, _Client);
                    }
                }

                var excelReportFormulaDll = dlls.FirstOrDefault(_ => _.Name.EndsWith("CommonFinance.ExcelReportFormula.UI.Implement.dll", StringComparison.OrdinalIgnoreCase));
                if (excelReportFormulaDll != null) {
                    string destinationPath = Path.Combine(SelectedVersion.EnvrionmentPath, @"DeployServer\Shared");
                    string targetDllFullPath = Path.Combine(destinationPath, excelReportFormulaDll.Name);
                    excelReportFormulaDll.CopyTo(targetDllFullPath, true);
                }
            });

            //部署到SERVER
            var DeployToServer = new Action<IEnumerable<FileInfo>>((IEnumerable<FileInfo> dlls) => {
                var targets = dlls.Where(_ => _.Name.EndsWith(".Business.dll", StringComparison.OrdinalIgnoreCase) | _.Name.EndsWith(".Business.resources.dll", StringComparison.OrdinalIgnoreCase) |
                                _.Name.EndsWith(".Business.Implement.dll", StringComparison.OrdinalIgnoreCase) | _.Name.EndsWith(".Business.Implement.resources.dll", StringComparison.OrdinalIgnoreCase) |
                                _.Name.EndsWith(".Common.Utils.dll", StringComparison.OrdinalIgnoreCase) | _.Name.EndsWith("Common.Utils.resources.dll", StringComparison.OrdinalIgnoreCase));
                if (targets.Count() > 0) {
                    string middlePath = GetMiddlePath();
                    string combinePath = Path.Combine(@"Server\Application", middlePath, "Programs");
                    string destinationPath = Path.Combine(SelectedVersion.EnvrionmentPath, combinePath);
                    foreach (var dll in targets) {
                        CopyToEnvrionment(dll, destinationPath, _Server);
                    }
                }

                var filldataDlls = dlls.Where(_ => _.Name.StartsWith("filedata_", StringComparison.OrdinalIgnoreCase));
                if (filldataDlls.Count() > 0) {
                    string combinePath = @"Server\Application\UpgradeData\FILLDATA";
                    string destinationPath = Path.Combine(SelectedVersion.EnvrionmentPath, combinePath);
                    foreach (var dll in filldataDlls) {
                        CopyToEnvrionment(dll, destinationPath, _Server);
                    }
                }
            });

            //部署到WEBSERVER
            var DeployToWebServer = new Action<IEnumerable<FileInfo>>((IEnumerable<FileInfo> dlls) => {
                var targets = dlls.Where(_ => _.Name.EndsWith(".Business.dll", StringComparison.OrdinalIgnoreCase) | _.Name.EndsWith(".Business.resources.dll", StringComparison.OrdinalIgnoreCase) |
                                _.Name.EndsWith(".UI.dll", StringComparison.OrdinalIgnoreCase) | _.Name.EndsWith(".UI.resources.dll", StringComparison.OrdinalIgnoreCase) |
                                _.Name.EndsWith(".UI.Implement.dll", StringComparison.OrdinalIgnoreCase) | _.Name.EndsWith(".UI.Implement.resources.dll", StringComparison.OrdinalIgnoreCase) |
                                _.Name.EndsWith(".UI.Implement.Report.dll", StringComparison.OrdinalIgnoreCase) | _.Name.EndsWith(".UI.Implement.Report.resources.dll", StringComparison.OrdinalIgnoreCase) |
                                _.Name.EndsWith(".Common.Utils.dll", StringComparison.OrdinalIgnoreCase) | _.Name.EndsWith("Common.Utils.resources.dll", StringComparison.OrdinalIgnoreCase) |
                                _.Name.EndsWith(".WebUI.Implement.dll", StringComparison.OrdinalIgnoreCase) | _.Name.EndsWith(".WebUI.Implement.resources.dll", StringComparison.OrdinalIgnoreCase));
                if (targets.Count() > 0) {
                    string middlePath = GetMiddlePath();
                    string combinePath = Path.Combine(@"WebServer\bin", middlePath, "Programs");
                    string destinationPath = Path.Combine(SelectedVersion.EnvrionmentPath, combinePath);
                    foreach (var dll in targets) {
                        CopyToEnvrionment(dll, destinationPath, _WebServer);
                    }
                }
            });

            //部署主体逻辑
            var Deploy = new Action<string>((string _) => {
                string pattern = "Digiwin.ERP." + _ + ".*.dll";
                if (_.StartsWith("filldata", StringComparison.OrdinalIgnoreCase)) {
                    pattern = _ + ".dll";
                }

                PrintProxy($"查找Export路径 {SelectedVersion.ExportPath}, 目标: {pattern}", Color.Blue);

                DirectoryInfo exportDirectory = new DirectoryInfo(SelectedVersion.ExportPath);
                IEnumerable<FileInfo> dlls = exportDirectory.GetFiles(pattern, SearchOption.TopDirectoryOnly);
                if (SelectedVersion.DeployZhCHTResources) {
                    string zhCHTPattern = pattern;
                    if (_.StartsWith("filldata", StringComparison.OrdinalIgnoreCase)) {
                        zhCHTPattern = _ + ".*.dll";
                    }
                    DirectoryInfo zhCHTDirectory = new DirectoryInfo(Path.Combine(exportDirectory.FullName, "Zh-CHT"));
                    dlls = dlls.Concat(zhCHTDirectory.GetFiles(zhCHTPattern, SearchOption.TopDirectoryOnly));
                }
                if (SelectedVersion.DeployEnUSResources) {
                    string enUSPattern = pattern;
                    if (_.StartsWith("filldata", StringComparison.OrdinalIgnoreCase)) {
                        enUSPattern = _ + ".*.dll";
                    }
                    DirectoryInfo enUSDirectory = new DirectoryInfo(Path.Combine(exportDirectory.FullName, "en-US"));
                    dlls = dlls.Concat(enUSDirectory.GetFiles(pattern, SearchOption.TopDirectoryOnly));
                }

                if (dlls.Count() == 0) {
                    PrintProxy($"{DateTime.Now.ToStandardDateTimeString()} >> 部署失败, Export路径 {SelectedVersion.ExportPath} 下未找到 TypeKey = {_} 的dll文件", Color.Red);
                } else {
                    if (DeployContext.DeployToClient && SelectedVersion.DeployToClient) DeployToClient(dlls);
                    if (DeployContext.DeployToServer && SelectedVersion.DeployToServer) DeployToServer(dlls);
                    if (DeployContext.DeployToClient && SelectedVersion.DeployToWebServer) DeployToWebServer(dlls);
                }
            });

            //打印部署明细
            var PrintDeployDetails = new Action(() => {
                PrintProxy("-----------------------------------------------------------------------------");
                var deploySuccessList = DeployModels.Where(_ => _.Successfully);
                var deployFailList = DeployModels.Where(_ => !_.Successfully);
                foreach (var model in deploySuccessList) {
                    PrintProxy($">> 部署成功, {model.Dll.FullName} 拷贝至 {model.TargetName}, 最后修改时间: {model.Dll.LastAccessTime.ToStandardDateTimeString()}");
                }
                foreach (var model in deployFailList) {
                    PrintProxy($">> 部署失败, 文件全路径 {model.Dll.FullName}, 最后修改时间: {model.Dll.LastAccessTime.ToStandardDateTimeString()}", Color.Red);
                }

                bool deploySuccess = deployFailList.Count() == 0;
                PrintProxy("========== 部署" + (deploySuccess ? "成功" : "失败") + $", {deploySuccessList.Count()} 个文件部署成功, {deployFailList.Count()} 个文件部署失败 ==========", deploySuccess ? _Green : Color.Red);
            });

            foreach (var typeKey in SelectedVersion.TypeKey.Split(',')) {
                if (!string.IsNullOrEmpty(typeKey)) {
                    Deploy(typeKey.Trim());
                }
            }

            PrintDeployDetails();

            //清理部署结果
            DeployModels = new List<DeployModel>();
            DeployContext.Initialize();
        }
        
        /// <summary>
        /// 部署提交资源代理
        /// </summary>
        private void DeployementProxy() {
            string serverName = @"\\172.16.1.204";
            string combinePath = string.Empty;
            if (SelectedVersion.ApplyciBeenPutInStorage) {
                combinePath = Path.Combine(serverName, "Deploy_temp_BAK", SelectedVersion.E10Version);
            } else {
                combinePath = Path.Combine(serverName, "Deploy_temp", SelectedVersion.E10Version);
            }
            if (Directory.Exists(combinePath)) {
                PrintProxy($"成功连接服务器 {serverName}，开始部署提交资源...", _Green);

                //复制文件夹
                Action<string, string, bool> CopyDirectory = null;
                CopyDirectory = new Action<string, string, bool>((string sourceFolder, string destFolder, bool overwrite) => {
                    try {
                        var sourceFilesPath = Directory.GetFileSystemEntries(sourceFolder);
                        for (int i = 0; i < sourceFilesPath.Length; i++) {
                            var sourceFilePath = sourceFilesPath[i];
                            var directoryName = Path.GetDirectoryName(sourceFilePath);
                            var forlders = directoryName.Split('\\');
                            var lastDirectory = forlders[forlders.Length - 1];
                            var dest = Path.Combine(destFolder, lastDirectory);
                            if (File.Exists(sourceFilePath)) {
                                var sourceFileName = Path.GetFileName(sourceFilePath);
                                if (!Directory.Exists(dest)) {
                                    Directory.CreateDirectory(dest);
                                }
                                if (sourceFileName.Contains("ProgramInfoContainer") && !SelectedVersion.ExcludeProgramInfo) continue;
                                File.Copy(sourceFilePath, Path.Combine(dest, sourceFileName), overwrite);
                                PrintProxy($" >> copy {sourceFilePath} to {dest}");
                            } else {
                                CopyDirectory(sourceFilePath, dest, overwrite);
                            }
                        }
                    } catch (Exception ex) {
                        PrintProxy("部署失败，程序发生异常，错误信息：" + ex.Message);
                    }
                });

                DirectoryInfo tempDirectory = new DirectoryInfo(combinePath);
                foreach (var docNo in SelectedVersion.ApplyciDocs.Split(',')) {
                    if(!string.IsNullOrEmpty(docNo)) {
                        var achives = tempDirectory.GetDirectories(docNo + "*", SearchOption.TopDirectoryOnly);
                        if (achives.Length == 0) {
                            PrintProxy($">> 部署失败，路径 {combinePath} 下未找到 {docNo} 的记录", Color.Red);
                        } else {
                            foreach (var achive in achives) {
                                PrintProxy($" >> 部署提交资源，来源地址 {achive.FullName} 至 {SelectedVersion.EnvrionmentPath}");
                                foreach (var directory in achive.GetDirectories("*.*", SearchOption.TopDirectoryOnly)) {
                                    CopyDirectory(directory.FullName, SelectedVersion.EnvrionmentPath, true);
                                }
                            }
                        }
                    }
                }

                PrintProxy("========== 部署提交资源已完成 ==========");
            } else {
                PrintProxy($"远程路径 {serverName} 访问失败", Color.Red);
            }
        }

        /// <summary>
        /// 检查引用代理
        /// </summary>
        private void CheckReferencesProxy() {
            string serverName = @"\\172.16.1.204";
            string serverPath = $@"{serverName}\WaitTest";
            string sourcePath = Path.Combine(serverPath, $@"DF_{SelectedVersion.E10Version}\WD_PR\SRC\Export");
            if (Directory.Exists(sourcePath)) {
                PrintProxy($"成功连接服务器 {serverName}，开始执行检查代理...", Color.Blue);

                //检查缺省引用
                Func<IEnumerable<string>> CheckMissingReference = () => {
                    IList<string> missingReferences = new List<string>();
                    DirectoryInfo exportDirectory = new DirectoryInfo(SelectedVersion.ExportPath);
                    foreach (var typeKey in SelectedVersion.TypeKey.Split(',')) {
                        if (!string.IsNullOrEmpty(typeKey)) {
                            string realTypeKey = typeKey.Trim();
                            DirectoryInfo sourceDirectory = new DirectoryInfo(Path.Combine(exportDirectory.Parent.FullName, "Digiwin.ERP." + realTypeKey));
                            var csprojs = sourceDirectory.GetFiles("*.csproj", SearchOption.AllDirectories);

                            foreach (var csproj in csprojs) {
                                PrintProxy($"正在检测项目 {csproj.Name}", Color.Purple);
                                var document = new XmlDocument();
                                document.Load(csproj.FullName);

                                var references = document.GetElementsByTagName("Reference");
                                var digiwinErpReferences = references.Cast<XmlNode>().Where(_ => _.Attributes["Include"].InnerText.StartsWith("Digiwin.ERP."));
                                foreach (var reference in digiwinErpReferences) {
                                    var include = reference.Attributes["Include"].InnerText;
                                    var referenceName = include.Split(',').FirstOrDefault();
                                    if (referenceName.Contains(typeKey)) continue;

                                    var pattern = referenceName + ".dll";
                                    var dlls = exportDirectory.GetFiles(pattern, SearchOption.TopDirectoryOnly);
                                    if (dlls.Length == 0) {
                                        missingReferences.Add(pattern);
                                        PrintProxy($"{DateTime.Now.ToStandardDateTimeString()} >> 检测到缺失的引用文件 {pattern}", Color.Orange);
                                    }
                                }
                            }
                        }
                    }
                    return missingReferences;
                };

                IEnumerable<string> targetReferences = CheckMissingReference();
                if (targetReferences.Count() == 0) {
                    PrintProxy("未检测到缺失的引用文件", _Green);
                } else {
                    if (!Directory.Exists(SelectedVersion.ExportPath)) {
                        Directory.CreateDirectory(SelectedVersion.ExportPath);
                    }
                    DirectoryInfo sourceDirectory = new DirectoryInfo(sourcePath);
                    foreach (var reference in targetReferences) {
                        string destinationPath = Path.Combine(SelectedVersion.ExportPath, reference);
                        if (File.Exists(destinationPath)) continue;

                        FileInfo targetFileInfo = new FileInfo(Path.Combine(sourcePath, reference));
                        if (targetFileInfo.Exists) {
                            try {
                                targetFileInfo.CopyTo(destinationPath, true);
                                PrintProxy($"{DateTime.Now.ToStandardDateTimeString()} >> 成功拷贝文件 {targetFileInfo.FullName} 至 {destinationPath}");
                            } catch (Exception ex) {
                                PrintProxy($" >> 复制文件 {targetFileInfo.FullName} 至 {destinationPath} 发生错误，异常信息：{ex.Message}", Color.Red);
                            }
                        } else {
                            PrintProxy($"服务器路径下 {sourcePath} 缺少目标文件 {reference}", Color.Red);
                        }
                    }
                    PrintProxy("========== 检查引用已完成 ==========");
                }
            } else {
                PrintProxy($"远程路径 {sourcePath} 访问失败，请检查E10版本名称 '{SelectedVersion.E10Version}' 设置是否正确", Color.Red);
            }
        }

        /// <summary>
        /// 编译代理
        /// </summary>
        private void ComplieProxy() {
            //执行cmd命令
            var ExecuteCommand = new Func<IEnumerable<string>, Process>((IEnumerable<string> commandTexts) => {
                Process process = null;
                if (commandTexts != null && commandTexts.Count() > 0) {
                    process = Process.Start(new ProcessStartInfo() {
                        FileName = "cmd.exe",
                        Verb = "runas",
                        UseShellExecute = false,
                        RedirectStandardError = true,
                        RedirectStandardInput = true,
                        RedirectStandardOutput = true,
                        StandardOutputEncoding = Encoding.Default,
                        StandardErrorEncoding = Encoding.Default,
                        CreateNoWindow = true
                    });
                    process.OutputDataReceived += (o, v) => { PrintProxy(v.Data); };
                    process.ErrorDataReceived += (o, v) => { PrintProxy(v.Data, Color.Red); };
                    process.BeginOutputReadLine();
                    process.BeginErrorReadLine();
                    foreach (var item in commandTexts) {
                        if (item == "exit") {
                            if (process.Responding) {
                                while (!process.WaitForExit(5000)) {
                                    break;
                                }
                            }
                        }
                        process.StandardInput.WriteLine(item);
                    }
                }
                return process;
            });

            //等待命令执行结束
            var WaitingProcessExited = new Func<Process, BackgroundWorker, bool>((Process process, BackgroundWorker worker) => {
                bool abort = false;
                if (process != null) {

                    //如果BackgroundWorker已请求取消后台操作，则强制终止cmd.exe进程
                    Func<bool> WorkerIsCancelled = () => {
                        bool handler = worker != null && worker.CancellationPending;
                        if (handler) {
                            process.CancelOutputRead();
                            process.CancelErrorRead();
                            process.Kill();
                            process.Close();
                            process = null;

                            //RefreshProgress(100);
                            PrintProxy(">>编译流程已被强制终止");
                        }
                        return handler;
                    };

                    if (!WorkerIsCancelled()) {
                        while (!process.WaitForExit(5000) && process != null) {
                            if (WorkerIsCancelled()) {
                                abort = true;
                                break;
                            }
                            if (process.HasExited) {
                                process.WaitForExit(5000);//cmd主进程退出之前，多等待一会，确保输出流已完整的打印
                                process.Close();
                                process.Dispose();
                                process = null;
                                break;
                            }
                        }
                    } else {
                        abort = true;
                    }
                }
                return abort;
            });

            //判断工作磁盘是否为C盘，并获得当前工作磁盘
            var TransferDiskCommandHandler = new Func<DirectoryInfo, string>((DirectoryInfo workingDirectory) => {
                string commandLine = string.Empty;
                if (workingDirectory != null && workingDirectory.Exists && workingDirectory.Root.Name != @"C:\") {
                    commandLine = workingDirectory.Root.Name.Replace(@"\", "");
                }
                return commandLine;
            });

            DirectoryInfo exportDirectory = new DirectoryInfo(SelectedVersion.ExportPath);
            IList<string> commands = new List<string>();
            foreach (var typeKey in SelectedVersion.TypeKey.Split(',')) {
                if (!string.IsNullOrEmpty(typeKey)) {
                    DirectoryInfo sourceDirectory = new DirectoryInfo(Path.Combine(exportDirectory.Parent.FullName, "Digiwin.ERP." + typeKey));
                    if (sourceDirectory.Exists) {
                        var solutionArchives = sourceDirectory.GetFiles("*.sln", SearchOption.TopDirectoryOnly);
                        if (solutionArchives.Length > 0) {
                            foreach (var solution in solutionArchives) {
                                string transferDiskCommand = TransferDiskCommandHandler(sourceDirectory);
                                if (!string.IsNullOrEmpty(transferDiskCommand)) {
                                    commands.Add("cd " + transferDiskCommand);
                                }
                                commands.Add(string.Format(@"%comspec% /k ""{0}""", Context.ComplieSettings.LocateVsDevCmdbat));
                                commands.Add(Context.ComplieSettings.ComplieCommandText.Replace("{sln-url}", solution.FullName));
                                commands.Add("exit");
                                commands.Add("exit");
                                var process = ExecuteCommand(commands);
                                if (WaitingProcessExited(process, ComplieWorker)) return;

                                commands.Clear();
                            }
                        } else {
                            PrintProxy($" >> 目标Typekey= {typeKey} 源代码路径下未找到有效的解决方案", Color.Red);
                        }
                    } else {
                        PrintProxy($" >> 源代码路径 {sourceDirectory.FullName} 不存在", Color.Red);
                    }
                }
            }
        }

        /// <summary>
        /// 批量删除pdb文件代理
        /// </summary>
        private void TrushpdbArchivesProxy() {
            var container = EpIAContext.StatusContainer;
            container.StatusMessage = "正在删除pdb文件";
            container.ProgressVisible = true;
            container.ProgressValue = 0;
            container.ProgressMessage = string.Empty;
            Invoke(_refreshStatusContainerProxy, new object[] { container });
            
            DirectoryInfo envrionmentDirectory = new DirectoryInfo(SelectedVersion.EnvrionmentPath);
            var pdbList = envrionmentDirectory.GetFiles("*.pdb", SearchOption.AllDirectories);
            if (pdbList.Length > 0) {
                double progressValue = 100 / pdbList.Length;
                foreach (var archive in pdbList) {
                    archive.Delete();

                    container.ProgressValue += progressValue;
                    container.ProgressMessage = archive.FullName;
                    Invoke(_refreshStatusContainerProxy, new object[] { container });
                }
            } else {
                container.ProgressMessage = "未找到*.pdb文件";
                Invoke(_refreshStatusContainerProxy, new object[] { container });
            }
            container.StatusMessage = "删除pdb文件已完成";
            container.ProgressVisible = false;
            Invoke(_refreshStatusContainerProxy, new object[] { container });
        }

        /// <summary>
        /// 提取TypeKey运行文件代理
        /// </summary>
        private void ExtractProxy() {
            PrintProxy(" >> 开始提取TypeKey运行文件");

            //复制*.dll文件到输出路径
            var CopyDll = new Action<string, string>((string typeKey, string combinePath) => {
                DirectoryInfo sourceDirectory = new DirectoryInfo(Path.Combine(SelectedVersion.EnvrionmentPath, combinePath));
                var dlls = sourceDirectory.GetFiles(string.Format("Digiwin.ERP.{0}.*.dll", typeKey), SearchOption.TopDirectoryOnly);
                if (dlls.Length > 0) {
                    DirectoryInfo destinationDirectory = new DirectoryInfo(Path.Combine(ExtractContext.OutputPath, combinePath));
                    if (!destinationDirectory.Exists) {
                        destinationDirectory.Create();
                    }
                    foreach (var dll in dlls) {
                        string destinationPath = Path.Combine(destinationDirectory.FullName, dll.Name);
                        dll.CopyTo(destinationPath, true);
                        PrintProxy("copy file: " + destinationPath);
                    }

                    string[] languages = new string[] { "en-US", "zh-CHT" };
                    foreach (var lang in languages) {
                        sourceDirectory = new DirectoryInfo(Path.Combine(sourceDirectory.FullName, lang));
                        if (sourceDirectory.Exists) {
                            dlls = sourceDirectory.GetFiles(string.Format("Digiwin.ERP.{0}.*.resources.dll", typeKey));
                            if (dlls.Length > 0) {
                                destinationDirectory = new DirectoryInfo(Path.Combine(destinationDirectory.FullName, sourceDirectory.Name));
                                if (!destinationDirectory.Exists) {
                                    destinationDirectory.Create();
                                }
                                foreach (var dll in dlls) {
                                    string destinationPath = Path.Combine(destinationDirectory.FullName, dll.Name);
                                    dll.CopyTo(destinationPath, true);
                                    PrintProxy("copy file: " + destinationPath);
                                }
                            }
                        }
                    }
                }
            });
            //复制配置资源
            Action<DirectoryInfo, DirectoryInfo, bool> CopyDirectory = null;
            CopyDirectory = new Action<DirectoryInfo, DirectoryInfo, bool>((DirectoryInfo sourceDirectory, DirectoryInfo destinationDirectory, bool overwrite) => {
                var resources = sourceDirectory.GetFiles("*.*", SearchOption.TopDirectoryOnly);
                if (resources.Length > 0) {
                    if (!destinationDirectory.Exists) {
                        destinationDirectory.Create();
                    }
                    foreach (var configuration in resources) {
                        string destinationPath = Path.Combine(destinationDirectory.FullName, configuration.Name);
                        configuration.CopyTo(destinationPath, overwrite);
                        PrintProxy(" >> copy file: " + destinationPath);
                    }
                }
                var directories = sourceDirectory.GetDirectories("*.*", SearchOption.TopDirectoryOnly);
                if (directories.Length > 0) {
                    foreach (var directory in directories) {
                        CopyDirectory(directory, new DirectoryInfo(Path.Combine(destinationDirectory.FullName, directory.Name)), overwrite);
                    }
                }
            });
            //提取*.dll资源
            var ExtractDllProxy = new Action<string>((string typeKey) => {
                var targetCombinePaths = new string[] {
                    @"DeployServer\Shared\Programs",
                    @"Server\Application\Programs",
                    @"WebServer\bin\Programs",
                };

                foreach (var combinePath in targetCombinePaths) {
                    CopyDll(typeKey, combinePath);
                }
            });
            //获取中间部署路径
            Func<string> GetMiddlePath = () => {
                string middlePath = string.Empty;
                switch (ExtractContext.DeployTarget) {
                    case DeployTarget.Industry:
                        middlePath = _Industry + @"\";
                        break;
                    case DeployTarget.Customization:
                        middlePath = _Customization + @"\";
                        break;
                }
                return middlePath;
            };
            //提取配置资源
            var ExtractConfigurationProxy = new Action<string>((string typeKey) => {
                var targetPaths = new string[] {
                    @"DeployServer\Shared",
                    @"Server\Application",
                    @"WebServer\bin",
                };
                var subTargetPaths = new string[] {
                    "BatchObjects",
                    "BusinessObjects",
                    "BusinessQueryObjects",
                    "ExcelReportFormulaObjects",
                    "ExcelReports",
                    "ReportObjects",
                };
                foreach (var targetPath in targetPaths) {
                    foreach (var subTargetPath in subTargetPaths) {
                        string combinePath = Path.Combine(targetPath, GetMiddlePath() + subTargetPath);
                        DirectoryInfo sourceDirectory = new DirectoryInfo(Path.Combine(SelectedVersion.EnvrionmentPath, combinePath));
                        if (sourceDirectory.Exists) {
                            var configurations = sourceDirectory.GetDirectories(typeKey, SearchOption.TopDirectoryOnly);
                            if (configurations.Length > 0) {
                                foreach (var conf in configurations) {
                                    DirectoryInfo destinationDirectory = new DirectoryInfo(Path.Combine(ExtractContext.OutputPath, combinePath, conf.Name));
                                    CopyDirectory(conf, destinationDirectory, true);
                                }
                            }
                        }
                    }
                }
            });
            //提取ProgramInfoContainerElement资源
            var ExtractProgramInfoProxy = new Action(() => {
                var targetPaths = new string[] {
                    @"DeployServer\Shared\BusinessObjects\ProgramInfoContainerElement",
                    @"Server\Application\BusinessObjects\ProgramInfoContainerElement",
                    @"WebServer\bin\BusinessObjects\ProgramInfoContainerElement",
                };
                foreach (var combinePath in targetPaths) {
                    DirectoryInfo sourceDirectory = new DirectoryInfo(Path.Combine(SelectedVersion.EnvrionmentPath, combinePath));
                    if (sourceDirectory.Exists) {
                        DirectoryInfo destinationDirectory = new DirectoryInfo(Path.Combine(ExtractContext.OutputPath, combinePath));
                        CopyDirectory(sourceDirectory, destinationDirectory, true);
                    }
                }
            });

            foreach (var typeKey in ExtractContext.TypeKey.Split(',')) {
                if (ExtractContext.IncludeDllResources) {
                    PrintProxy(" >> 提取*.dll资源，TypeKey=" + typeKey);
                    ExtractDllProxy(typeKey);
                }
                if (ExtractContext.IncludeConfigurationResources) {
                    PrintProxy(" >> 提取配置资源，TypeKey=" + typeKey);
                    ExtractConfigurationProxy(typeKey);
                }
            }
            if (ExtractContext.IncludeProgramInfoResources) {
                PrintProxy(" >> 提取ProgramInfoContainerElement资源");
                ExtractProgramInfoProxy();
            }
            PrintProxy("========== 提取TypeKey运行文件已完成 ==========");
        }

        /// <summary>
        /// 导入配置文件代理
        /// </summary>
        private void ImportConfigurationProxy() {
            PrintProxy($" >> {DateTime.Now.ToString("HH:mm:ss")}，正在从目标环境路径 {ImportConfigurationContext.SourceEnvironmentPath} 导入配置文件");
            
            var ImportConfiguration = new Action<string>((string configurationCombinePath) => {
                FileInfo sourceFile = null;
                try {
                    sourceFile = new FileInfo(Path.Combine(ImportConfigurationContext.SourceEnvironmentPath, configurationCombinePath));
                    if (!sourceFile.Exists) {
                        PrintProxy($" >> 导入配置文件 {sourceFile.Name} 失败，源文件不存在", Color.Red);
                    } else {
                        string destinationPath = Path.Combine(SelectedVersion.EnvrionmentPath, configurationCombinePath);
                        sourceFile.CopyTo(destinationPath, true);
                        PrintProxy($"import config file: {sourceFile.Name}, source path = {sourceFile.FullName}", _Green);
                    }
                } catch (Exception ex) {
                    PrintProxy($" >> 导入配置文件 {sourceFile.Name} 发生错误: {ex.Message}", Color.Red);
                }
            });

            if (ImportConfigurationContext.IncludeAccountSetsConfiguration_dcxml) ImportConfiguration(ImportConfigurationContext.AccountSetsConfiguration_dcxml_CombinePath);
            if (ImportConfigurationContext.IncludeAutoRunClient_dcxml) ImportConfiguration(ImportConfigurationContext.AutoRunClient_dcxml_CombinePath);
            if (ImportConfigurationContext.IncludeDefault_dcc) ImportConfiguration(ImportConfigurationContext.Default_dcc_CombinePath);
            if (ImportConfigurationContext.IncludeUpdate_config) ImportConfiguration(ImportConfigurationContext.Update_config_CombinePath);
            if (ImportConfigurationContext.IncludeWeb_config) ImportConfiguration(ImportConfigurationContext.Web_config_CombinePath);
            if (ImportConfigurationContext.IncludeBusinessPackage_dxml) ImportConfiguration(ImportConfigurationContext.BusinessPackage_dcxml_CombinePath);
            
            PrintProxy("========== 导入配置文件已完成 ==========");
        }
    }
}
