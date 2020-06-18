using Eproduction.Integrated.Assistant.Common.Implement.Interface;
using Eproduction.Integrated.Assistant.Start.Core.Section;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Eproduction.Integrated.Assistant.Start.Core {
    /// <summary>
    /// 模组类别
    /// </summary>
    public enum ModuleType {
        /// <summary>
        /// 智能部署
        /// </summary>
        IntelligentDeploy = 0,
        /// <summary>
        /// 生成临时表
        /// </summary>
        GenerateTemporaryTable = 1,
        /// <summary>
        /// 字符串压缩与解压缩
        /// </summary>
        CompressAndDecomporess = 2,
        /// <summary>
        /// 检索词条
        /// </summary>
        RetrievalTerms = 3,
        /// <summary>
        /// 提取INSERT属性
        /// </summary>
        ExtractInsertProperty = 4,
        /// <summary>
        /// 服务云集成
        /// </summary>
        EscloudIntegrate = 5
    }
    /// <summary>
    /// EpIA上下文定义
    /// </summary>
    public class EpIAContext : ISectionService {
        /// <summary>
        /// 模组元数据定义
        /// </summary>
        private IList<Module> _modules = new List<Module> {
            new Module() {
                Key = "intelligent_deploy",
                Text = "E10智能部署",
                Visible = true,
                IsSelected = true,
                ImageSmall = Properties.Resources.deploy_small,
                ImageLarger = Properties.Resources.deploy_larger,
                Description = "自动部署解决方案至目标环境，提供环境操作便捷入口\r\n（系统默认模组，不可移除）",
                Type = ModuleType.IntelligentDeploy,
            },
            new Module() {
                Key = "generate_temporary_table",
                Text = "生成临时表",
                Visible =  true,
                RemoveReadonly = true,
                ImageSmall = Properties.Resources.temporary_small,
                ImageLarger = Properties.Resources.temporary_larger,
                Description = "自动翻译规格源为C#代码，提供个性化参数选项",
                Type = ModuleType.GenerateTemporaryTable,
            },
            new Module() {
                Key = "compress_and_decomporess",
                Text = "字符串压缩与解压缩",
                RemoveReadonly = true,
                ImageSmall = Properties.Resources.compress_small,
                ImageLarger = Properties.Resources.compress_larger,
                Description = "提供字符串压缩与解压缩的功能",
                Type = ModuleType.CompressAndDecomporess,
                FlowWidth = 130
            },
            new Module() {
                Key = "retrieval_terms",
                Text = "检索词条",
                RemoveReadonly = true,
                ImageSmall = Properties.Resources.retrieval_small,
                ImageLarger = Properties.Resources.retrieval_larger,
                Description = "检索CM数据库中已存在的目标词条",
                Type = ModuleType.RetrievalTerms,
            },
            new Module() {
                Key = "extract_insert_property",
                Text = "提取插入属性",
                RemoveReadonly = true,
                ImageSmall = Properties.Resources.extract_small,
                ImageLarger = Properties.Resources.extract_larger,
                Description = "提取规格源中的批量插入属性，并转换为C#格式文本",
                Type = ModuleType.ExtractInsertProperty,
            },
            //new Module() {
            //    Key = "escloud_integrate",
            //    Text = "服务云集成",
            //    RemoveReadonly = true,
            //    ImageSmall = Properties.Resources.escloud_small,
            //    ImageLarger = Properties.Resources.escloud_larger,
            //    Description = "集成了服务云一些常用的查询功能，例如查询客户资料、\r\n高层指标项目等等",
            //    Type = ModuleType.EscloudIntegrate
            //}
        };
        private IntelligentDeployContext _intelligentDeployContext = null;
        private GenerateTempoarayTableContext _generateTemparayTableContext = null;
        private RetrievalTermsContext _retrievalTermsContext = null;
        private EscloudIntegrateContext _escloudIntegrateContext = null;
        private SysStatusComponentContainer _statusContainer = null;
        /// <summary>
        /// 模组列表
        /// </summary>
        public IList<Module> Modules { get => _modules; }
        /// <summary>
        /// 获取当前工作模组
        /// </summary>
        public Module SelectedModule { get => Modules.FirstOrDefault(_ => _.IsSelected); }
        /// <summary>
        /// 获取载入模组
        /// </summary>
        public string VisibleModules { get => string.Join(",", _modules.Where(_ => _.Visible).Select(__ => __.Key)); }
        /// <summary>
        /// 保存载入模组设置
        /// </summary>
        public void SaveModulesSetting() {
            Configuration configuration = null;
            EpIAContextSection EpIASection = GetEpIAContextSection(out configuration);
            EpIASection.Settings.Modules = VisibleModules;
            configuration.Save();
        }
        /// <summary>
        /// 保存选择模组设置
        /// </summary>
        public void SaveSelectedModule() {
            Configuration configuration = null;
            EpIAContextSection EpIASection = GetEpIAContextSection(out configuration);
            EpIASection.Settings.SelectedModule = SelectedModule.Key;
            configuration.Save();
        }
        /// <summary>
        /// 复原模组设置
        /// </summary>
        /// <param name="modules"></param>
        /// <param name="selectedModule"></param>
        public void RecoveryModulesSetting(string modules, string selectedModule = "") {
            if (!string.IsNullOrEmpty(modules)) {
                foreach (var item in modules.Split(',')) {
                    var module = Modules.FirstOrDefault(_ => _.Key == item);
                    if (module != null) {
                        module.Visible = true;
                    }
                }
            }
            if (!string.IsNullOrEmpty(selectedModule)) {
                foreach (var module in Modules) {
                    module.IsSelected = module.Key == selectedModule;
                }
            }
        }

        /// <summary>
        /// 自动部署上下文
        /// </summary>
        public IntelligentDeployContext IntelligentDeployContext {
            get {
                if (_intelligentDeployContext == null) {
                    _intelligentDeployContext = new IntelligentDeployContext();
                }
                return _intelligentDeployContext;
            }
            set => _intelligentDeployContext = value;
        }

        /// <summary>
        /// 生成临时表上下文
        /// </summary>
        public GenerateTempoarayTableContext GenerateTempoarayTableContext {
            get {
                if (_generateTemparayTableContext == null) {
                    _generateTemparayTableContext = new GenerateTempoarayTableContext();
                }
                return _generateTemparayTableContext;
            }
            set => _generateTemparayTableContext = value;
        }

        /// <summary>
        /// 检索词条上下文
        /// </summary>
        public RetrievalTermsContext RetrievalTermsContext {
            get {
                if (_retrievalTermsContext == null) {
                    _retrievalTermsContext = new RetrievalTermsContext();
                }
                return _retrievalTermsContext;
            }
            set => _retrievalTermsContext = value;
        }

        /// <summary>
        /// 服务云集成上下文
        /// </summary>
        public EscloudIntegrateContext EscloudIntegrateContext {
            get {
                if (_escloudIntegrateContext == null) {
                    _escloudIntegrateContext = new EscloudIntegrateContext();
                }
                return _escloudIntegrateContext;
            }
            set => _escloudIntegrateContext = value;
        }

        public EpIAContextSection GetEpIAContextSection(out Configuration configuration) {
            configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            return (EpIAContextSection)configuration.GetSection(GetSectionName());
        }

        public string GetSectionName() {
            return "EpIASection";
        }
        /// <summary>
        /// 系统状态容器
        /// </summary>
        public SysStatusComponentContainer StatusContainer {
            get {
                if (_statusContainer == null) {
                    _statusContainer = new SysStatusComponentContainer();
                }
                return _statusContainer;
            }
            set => _statusContainer = value;
        }
    }
    /// <summary>
    /// 模组原型定义
    /// </summary>
    public class Module {
        /// <summary>
        /// 模组键值
        /// </summary>
        public string Key { get; set; }
        /// <summary>
        /// 模组显示文本
        /// </summary>
        public string Text { get; set; }
        /// <summary>
        /// 标识模组是否可见
        /// </summary>
        public bool Visible { get; set; }
        /// <summary>
        /// 标识模组是否被选中
        /// </summary>
        public bool IsSelected { get; set; }
        /// <summary>
        /// 标识模组是否可以动态移除
        /// </summary>
        public bool RemoveReadonly { get; set; }
        /// <summary>
        /// 模组在WorkFlow显示的图标，16x16
        /// </summary>
        public Image ImageSmall { get; set; }
        /// <summary>
        /// 模组在选择器显示的图标，32x32
        /// </summary>
        public Image ImageLarger { get; set; }
        /// <summary>
        /// 模组在导航条的显示宽度，默认值100px
        /// </summary>
        public int FlowWidth { get; set; } = 100;
        /// <summary>
        /// 模组类别
        /// </summary>
        public ModuleType Type { get; set; }
        /// <summary>
        /// 模组描述信息
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// UI模型
        /// </summary>
        public UserControl Control { get; set; }
    }
    /// <summary>
    /// 系统状态容器
    /// </summary>
    public class SysStatusComponentContainer {
        private double _progressValue = 0;
        /// <summary>
        /// 状态标签
        /// </summary>
        public ToolStripStatusLabel TsslblStatus { get; set; }
        /// <summary>
        /// 状态信息
        /// </summary>
        public string StatusMessage { get; set; }
        /// <summary>
        /// 进度条
        /// </summary>
        public ToolStripProgressBar TspbarProgress { get; set; }
        /// <summary>
        /// 进度值
        /// </summary>
        public double ProgressValue {
            get {
                if (_progressValue > 100) {
                    _progressValue = 100;
                }
                return _progressValue;
            }
            set => _progressValue = value;
        }
        /// <summary>
        /// 进度组件显示标识
        /// </summary>
        public bool ProgressVisible { get; set; }
        /// <summary>
        /// 进度标签
        /// </summary>
        public ToolStripStatusLabel TsslblProgressMessage { get; set; }
        /// <summary>
        /// 进度信息
        /// </summary>
        public string ProgressMessage { get; set; }
        /// <summary>
        /// 刷新状态容器
        /// </summary>
        public void Refresh() {
            if (!string.IsNullOrEmpty(StatusMessage)) {
                TsslblStatus.Text = StatusMessage;
            } else {
                TsslblStatus.Text = "就绪";
            }
            if (ProgressVisible) {
                TspbarProgress.Value = Convert.ToInt32(ProgressValue);
                TspbarProgress.Visible = true;
                TsslblProgressMessage.Text = ProgressMessage;
                TsslblProgressMessage.Visible = true;
            } else {
                ProgressValue = 0;
                ProgressMessage = string.Empty;
                TspbarProgress.Value = Convert.ToInt32(ProgressValue);
                TspbarProgress.Visible = false;
                TsslblProgressMessage.Text = ProgressMessage;
                TsslblProgressMessage.Visible = false;
            }
        }
    }
}
