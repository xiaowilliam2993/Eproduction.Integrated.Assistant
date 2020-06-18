using Eproduction.Integrated.Assistant.Common.Control;
using Eproduction.Integrated.Assistant.Start.Control;
using Eproduction.Integrated.Assistant.Start.Core;
using Eproduction.Integrated.Assistant.Start.Core.Section;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Eproduction.Integrated.Assistant.Start {
    public partial class MainForm : Form {
        private EpIAContext _context = null;
        public EpIAContext Context {
            get {
                if (_context == null) {
                    _context = new EpIAContext();
                }
                return _context;
            }
            private set => _context = value;
        }
        private readonly Color _SELECT_BACKCOLOR = Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(180)))), ((int)(((byte)(212)))));
        private readonly Color _UNSELECT_BACKCOLOR = Color.Gainsboro;
        public IEnumerable<Button> WorkFlowButtons {
            get => pnlWorkFlow.Controls.Cast<System.Windows.Forms.Control>().Where(_ => _ is Button).Select(_ => _ as Button);
        }
        private AssemblyModulesProxy _assemblyModulesProxy = null;
        private delegate void AssemblyModulesProxy(Panel pnlContainer);
        private RefreshStatusContainerProxy _refreshStatusContainerProxy = null;
        private delegate void RefreshStatusContainerProxy(SysStatusComponentContainer statusContainer);
        public MainForm() {
            _assemblyModulesProxy = new AssemblyModulesProxy(delegate (Panel pnlContainer) {
                foreach (var module in Context.Modules) {
                    switch (module.Type) {
                        case ModuleType.IntelligentDeploy:
                            module.Control = new IntelligentDeployControl(Context);
                            break;
                        case ModuleType.GenerateTemporaryTable:
                            module.Control = new GenerateTemporaryTableControl(Context);
                            break;
                        case ModuleType.CompressAndDecomporess:
                            module.Control = new CompressAndDecomporessControl(Context);
                            break;
                        case ModuleType.RetrievalTerms:
                            module.Control = new RetrievalTermsControl(Context);
                            break;
                        case ModuleType.ExtractInsertProperty:
                            module.Control = new ExtractInsertPropertyControl(Context);
                            break;
                        case ModuleType.EscloudIntegrate:
                            module.Control = new EscloudIntegrateControl(Context);
                            break;
                    }
                    pnlContainer.Controls.Add(module.Control);
                }
                Context.SelectedModule.Control.BringToFront();
            });
            _refreshStatusContainerProxy = new RefreshStatusContainerProxy(delegate (SysStatusComponentContainer statusContainer) {
                statusContainer.Refresh();
            });
            InitializeComponent();

            //
            // logoControl
            //
            var logoControl = new LogoControl();
            logoControl.Name = "LogoControl";
            logoControl.Size = new Size(177, 49);
            logoControl.Location = new Point(829, 6);
            logoControl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnlWorkFlow.Controls.Add(logoControl);

            //刷新系统状态
            var RefreshSysStatusContainer = new Action<string>((string _) => {
                var container = Context.StatusContainer;
                container.StatusMessage = _;
                Invoke(_refreshStatusContainerProxy, new object[] { container });
            });

            //
            // LoadingWorker
            //
            LoadingWorker.DoWork += (o, v) => {
                RefreshSysStatusContainer("正在初始化");
                Invoke(_assemblyModulesProxy, new object[] { pnlContainer });
            };
            LoadingWorker.RunWorkerCompleted += (o, v) => {
                RefreshSysStatusContainer("就绪");
            };
        }

        private void MainForm_Load(object sender, EventArgs e) {
            EpIAContextSection EpIASection = Context.GetEpIAContextSection(out Configuration configuration);
            string modules = EpIASection.Settings.Modules;
            if (string.IsNullOrEmpty(modules)) {
                Context.SaveModulesSetting();
            }
            Context.RecoveryModulesSetting(modules, EpIASection.Settings.SelectedModule);
            GrerateOrRefreshWorkFlow();

            Context.StatusContainer.TsslblStatus = tsslblStatus;
            Context.StatusContainer.TspbarProgress = tspbarProgress;
            Context.StatusContainer.TsslblProgressMessage = tsslblProgressMessage;
            
            LoadingWorker.RunWorkerAsync();
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.Alt && e.KeyCode == Keys.F12) {
                tsmiModuleSelector_Click(tsmiModuleSelector, new EventArgs());
            } else if (e.Alt && e.KeyCode == Keys.F10) {
                if (Context.SelectedModule.Type == ModuleType.IntelligentDeploy) {
                    ((IntelligentDeployControl)Context.SelectedModule.Control).TrushpdbArchives();
                }
            }
        }

        private void tsmiExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void tsmiModuleSelector_Click(object sender, EventArgs e) {
            //还原模组选择器所做的数据更改
            Action ReductionModulesSetting = delegate () {
                foreach (var module in Context.Modules) {
                    module.Visible = WorkFlowButtons.Any(_ => (ModuleType)((int)_.Tag) == module.Type);
                }
            };
            using (var modulesForm = new ModulesForm(Context)) {
                if (modulesForm.ShowDialog() == DialogResult.OK) {
                    if (Context.Modules.Any(_ => !_.Visible && _.Type == Context.SelectedModule.Type)) {
                        var inetlligentDeployModule = Context.Modules.FirstOrDefault(_ => _.Type == ModuleType.IntelligentDeploy);
                        if(MessageBox.Show(Context.SelectedModule.Text + " 为当前工作模组，移除后将自动为您切换到 " + inetlligentDeployModule.Text + " 模组，确定要继续吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) {
                            ReductionModulesSetting();
                            return;
                        } else {
                            Context.SelectedModule.IsSelected = false;

                            var selectedModule = inetlligentDeployModule;
                            selectedModule.IsSelected = true;//自动切换至 智能部署 模组
                            selectedModule.Control.BringToFront();

                            Context.SaveSelectedModule();
                        }
                    }
                    GrerateOrRefreshWorkFlow();
                    Context.SaveModulesSetting();
                } else {
                    ReductionModulesSetting();
                }
            }
        }

        private void tsmiAbout_Click(object sender, EventArgs e) {
            using (var aboutForm = new AboutForm()) {
                aboutForm.ShowDialog();
            }
        }

        /// <summary>
        /// 将MethodInfo转换为EventHandler，为宿主组件添加事件订阅
        /// </summary>
        //private void BindingComponentEventHandler(System.Windows.Forms.Control component, string invokeName) {
        //    if (!string.IsNullOrEmpty(invokeName)) {
        //        var method = GetType().GetMethod(invokeName);
        //        if (method != null) {
        //            object target = this;
        //            var handler = Delegate.CreateDelegate(typeof(EventHandler), target, method) as EventHandler;
        //            if (handler != null) {
        //                component.Click += handler;
        //            }
        //        }
        //    }
        //}

        /// <summary>
        /// 生成或刷新工作流组件
        /// </summary>
        private void GrerateOrRefreshWorkFlow() {
            try {
                SuspendLayout();

                if (WorkFlowButtons.Count() > 0) {
                    int count = WorkFlowButtons.Count();
                    for (int i = count - 1; i >= 0; i--) {
                        pnlWorkFlow.Controls.Remove(WorkFlowButtons.ToArray()[i]);
                    }
                }

                int index = 0;
                int padding = 10;
                int x_point = padding;
                foreach (var module in Context.Modules.Where(_ => _.Visible)) {
                    //
                    // moduleElement
                    //
                    var moduleElement = new ButtonEx {
                        Name = "btn_" + module.Key,
                        Text = "\r\n" + module.Text,
                        Size = new Size(module.FlowWidth, 44),
                        BackColor = module.IsSelected ? _SELECT_BACKCOLOR : _UNSELECT_BACKCOLOR,
                        Font = new Font("微软雅黑", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(134))),
                        ForeColor = SystemColors.ControlText,
                        UseVisualStyleBackColor = false,
                        Image = module.ImageSmall,
                        ImageAlign = ContentAlignment.TopCenter,
                        Location = new Point(x_point, padding),
                        FlatStyle = FlatStyle.Flat
                    };
                    moduleElement.FlatAppearance.BorderSize = 1;
                    moduleElement.FlatAppearance.BorderColor = _UNSELECT_BACKCOLOR;
                    moduleElement.Tag = (int)module.Type;
                    moduleElement.Click += Module_Click;
                    pnlWorkFlow.Controls.Add(moduleElement);
                    sysToolTip.SetToolTip(moduleElement, module.Description);
                    index++;
                    x_point += moduleElement.Width + padding;
                }

                pnlWorkFlow.Invalidate();
                pnlWorkFlow.Refresh();

                ResumeLayout();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "程序错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 选择模组相关业务处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Module_Click(object sender, EventArgs e) {
            var owner = (Button)sender;
            if (owner.Tag != null) {
                int moduleIndex = (int)owner.Tag;
                var moduleType = (ModuleType)moduleIndex;
                if (Context.SelectedModule.Type != moduleType) {

                    //设置背景颜色
                    foreach (var component in WorkFlowButtons) {
                        var tag = component.Tag;
                        if (tag != null) {
                            var module = Context.Modules.FirstOrDefault(_ => (int)_.Type == (int)tag);
                            if ((int)tag == moduleIndex) {
                                module.IsSelected = true;
                                component.BackColor = _SELECT_BACKCOLOR;
                                Context.SaveSelectedModule();
                            } else {
                                module.IsSelected = false;
                                component.BackColor = _UNSELECT_BACKCOLOR;
                            }
                        }
                    }

                    //载入模组自定义控件
                    Context.SelectedModule.Control.BringToFront();
                }
            }
        }

        /// <summary>
        /// 调整窗体大小时，记录窗体状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Resize(object sender, EventArgs e) {
            try {
                var configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configuration.AppSettings.Settings;
                if (settings.AllKeys.Contains("form-state") && settings.AllKeys.Contains("form-size")) {
                    settings["form-state"].Value = WindowState.ToString();
                    settings["form-size"].Value = $"{Size.Width},{Size.Height}";
                    configuration.Save();
                    ConfigurationManager.RefreshSection("appSettings");
                }
            } catch (Exception) { }
        }

        /// <summary>
        /// 主画面第一次显示完全时，载入窗体大小配置，还原窗体状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Shown(object sender, EventArgs e) {
            try {
                var configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var settings = configuration.AppSettings.Settings;
                if (settings.AllKeys.Contains("form-state") && settings.AllKeys.Contains("form-size")) {
                    WindowState = (FormWindowState)Enum.Parse(typeof(FormWindowState), settings["form-state"].Value);
                    if (WindowState == FormWindowState.Normal) {
                        var size = settings["form-size"].Value;
                        var sizeProperties = size.Split(',');
                        var width = Convert.ToInt32(sizeProperties[0], CultureInfo.CurrentCulture);
                        var height = Convert.ToInt32(sizeProperties[1], CultureInfo.CurrentCulture);
                        Size = new Size(width, height);
                    }
                }
            } catch (Exception) { }
        }
    }
}
