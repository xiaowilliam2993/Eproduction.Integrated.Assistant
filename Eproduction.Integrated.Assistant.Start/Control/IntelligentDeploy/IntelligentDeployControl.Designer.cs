namespace Eproduction.Integrated.Assistant.Start.Control {
    partial class IntelligentDeployControl {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IntelligentDeployControl));
            this.tabContainer = new System.Windows.Forms.TabControl();
            this.pageBaseParamsSetting = new System.Windows.Forms.TabPage();
            this.tboxE10Version = new Eproduction.Integrated.Assistant.Common.Control.TextBoxEx();
            this.lblE10Version = new System.Windows.Forms.Label();
            this.lblTypeKeyPrompt = new System.Windows.Forms.Label();
            this.tboxTypeKey = new Eproduction.Integrated.Assistant.Common.Control.TextBoxEx();
            this.lblTypeKey = new System.Windows.Forms.Label();
            this.tboxExportPath = new Eproduction.Integrated.Assistant.Common.Control.TextBoxEx();
            this.tboxEnvironmentPath = new Eproduction.Integrated.Assistant.Common.Control.TextBoxEx();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lnkSelectExportPath = new System.Windows.Forms.LinkLabel();
            this.lnkExportPath = new System.Windows.Forms.LinkLabel();
            this.lnkSelectEnvironmentPath = new System.Windows.Forms.LinkLabel();
            this.lnkEnvironmentPath = new System.Windows.Forms.LinkLabel();
            this.lnkSelectVersion = new System.Windows.Forms.LinkLabel();
            this.pageComplieAndDeploy = new System.Windows.Forms.TabPage();
            this.tabDeployAdvancedSetting = new System.Windows.Forms.TabControl();
            this.pageDeployAdvancedSetting = new System.Windows.Forms.TabPage();
            this.gboxDeployVersionTargets = new System.Windows.Forms.GroupBox();
            this.rdoBusinessPackage = new System.Windows.Forms.RadioButton();
            this.rdoCustomization = new System.Windows.Forms.RadioButton();
            this.rdoIndustry = new System.Windows.Forms.RadioButton();
            this.rdoBase = new System.Windows.Forms.RadioButton();
            this.cboxDeployEnUSResources = new System.Windows.Forms.CheckBox();
            this.cboxDeployToClient = new System.Windows.Forms.CheckBox();
            this.cboxDeployZhCHTResources = new System.Windows.Forms.CheckBox();
            this.cboxDeployToServer = new System.Windows.Forms.CheckBox();
            this.cboxDeployWebServer = new System.Windows.Forms.CheckBox();
            this.pageComplieAdvancedSetting = new System.Windows.Forms.TabPage();
            this.btnComplie = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.tboxComplieCommandText = new Eproduction.Integrated.Assistant.Common.Control.TextBoxEx();
            this.lblComplieCommandText = new System.Windows.Forms.Label();
            this.lnkLocateVsDevCmdbat = new System.Windows.Forms.LinkLabel();
            this.lblLocateVsDevCmdbat = new System.Windows.Forms.Label();
            this.lblLocateVsDevCmdbatTitle = new System.Windows.Forms.Label();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.pageEnvironmentSetting = new System.Windows.Forms.TabPage();
            this.tabEnvrionmentSetting = new System.Windows.Forms.TabControl();
            this.pageE10EnvrionmentSetting = new System.Windows.Forms.TabPage();
            this.cboxKillEprocess = new System.Windows.Forms.CheckBox();
            this.lnkAccountSettingView = new System.Windows.Forms.LinkLabel();
            this.cboxKillClientProcess = new System.Windows.Forms.CheckBox();
            this.lnkExtractRuntimeResources = new System.Windows.Forms.LinkLabel();
            this.cboxAutoDeploy = new System.Windows.Forms.CheckBox();
            this.lnkImportConfigurationArchives = new System.Windows.Forms.LinkLabel();
            this.gboxParamsSetting = new System.Windows.Forms.GroupBox();
            this.lblClientParamsCustom = new System.Windows.Forms.Label();
            this.cbboxStartClientParamsType = new System.Windows.Forms.ComboBox();
            this.lblServerParamsCustom = new System.Windows.Forms.Label();
            this.cbboxStartServerParamsType = new System.Windows.Forms.ComboBox();
            this.tboxClientParams = new Eproduction.Integrated.Assistant.Common.Control.TextBoxEx();
            this.tboxServerParams = new Eproduction.Integrated.Assistant.Common.Control.TextBoxEx();
            this.lblClientParams = new System.Windows.Forms.Label();
            this.lblServerParams = new System.Windows.Forms.Label();
            this.pageEsClientEnvrionmentSetting = new System.Windows.Forms.TabPage();
            this.pageJoinCMMangement = new System.Windows.Forms.TabPage();
            this.tabJoinCMMangement = new System.Windows.Forms.TabControl();
            this.pageDeployServerResources = new System.Windows.Forms.TabPage();
            this.cboxApplyciBeenPutInStorage = new System.Windows.Forms.CheckBox();
            this.cboxBeforeDeployementKillEprocess = new System.Windows.Forms.CheckBox();
            this.cboxExcludeProgramInfo = new System.Windows.Forms.CheckBox();
            this.tboxApplyciDocs = new Eproduction.Integrated.Assistant.Common.Control.TextBoxEx();
            this.lblApplyciDocs = new System.Windows.Forms.Label();
            this.pageCMManagmenet = new System.Windows.Forms.TabPage();
            this.lnkKillCMProcess = new System.Windows.Forms.LinkLabel();
            this.lblCMClientParams = new System.Windows.Forms.Label();
            this.lnkLocationCMClient = new System.Windows.Forms.LinkLabel();
            this.lblLocationCMClient = new System.Windows.Forms.Label();
            this.lblLocationCMClientTitle = new System.Windows.Forms.Label();
            this.btnStartCMClient = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.tboxCMClientParams = new Eproduction.Integrated.Assistant.Common.Control.TextBoxEx();
            this.tabPrinter = new System.Windows.Forms.TabControl();
            this.pageDetails = new System.Windows.Forms.TabPage();
            this.pnlDetailsToolbar = new System.Windows.Forms.Panel();
            this.btnView = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.btnClear = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.btnWordWarp = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.richboxPrint = new System.Windows.Forms.RichTextBox();
            this.DeployWorker = new System.ComponentModel.BackgroundWorker();
            this.DeployementWorker = new System.ComponentModel.BackgroundWorker();
            this.CheckReferencesWorker = new System.ComponentModel.BackgroundWorker();
            this.ComplieWorker = new System.ComponentModel.BackgroundWorker();
            this.TrushpdbArchivesWorker = new System.ComponentModel.BackgroundWorker();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BindingSourceToCMSetting = new System.Windows.Forms.BindingSource(this.components);
            this.ExtractWorker = new System.ComponentModel.BackgroundWorker();
            this.ImportConfigurationWorker = new System.ComponentModel.BackgroundWorker();
            this.BindingSourceToComplie = new System.Windows.Forms.BindingSource(this.components);
            this.lblDeployTitle = new System.Windows.Forms.Label();
            this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnlWorkFlow = new Eproduction.Integrated.Assistant.Common.Control.PanelEx();
            this.btnKillEprocess = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.btnCheckReferences = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.btnDeployement = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.btnStartClient = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.btnStartServer = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.btnDeploy = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.tabContainer.SuspendLayout();
            this.pageBaseParamsSetting.SuspendLayout();
            this.pageComplieAndDeploy.SuspendLayout();
            this.tabDeployAdvancedSetting.SuspendLayout();
            this.pageDeployAdvancedSetting.SuspendLayout();
            this.gboxDeployVersionTargets.SuspendLayout();
            this.pageComplieAdvancedSetting.SuspendLayout();
            this.pageEnvironmentSetting.SuspendLayout();
            this.tabEnvrionmentSetting.SuspendLayout();
            this.pageE10EnvrionmentSetting.SuspendLayout();
            this.gboxParamsSetting.SuspendLayout();
            this.pageJoinCMMangement.SuspendLayout();
            this.tabJoinCMMangement.SuspendLayout();
            this.pageDeployServerResources.SuspendLayout();
            this.pageCMManagmenet.SuspendLayout();
            this.tabPrinter.SuspendLayout();
            this.pageDetails.SuspendLayout();
            this.pnlDetailsToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceToCMSetting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceToComplie)).BeginInit();
            this.pnlWorkFlow.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabContainer
            // 
            this.tabContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabContainer.Controls.Add(this.pageBaseParamsSetting);
            this.tabContainer.Controls.Add(this.pageComplieAndDeploy);
            this.tabContainer.Controls.Add(this.pageEnvironmentSetting);
            this.tabContainer.Controls.Add(this.pageJoinCMMangement);
            this.tabContainer.ImageList = this.ImageList;
            this.tabContainer.Location = new System.Drawing.Point(13, 24);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.SelectedIndex = 0;
            this.tabContainer.Size = new System.Drawing.Size(638, 244);
            this.tabContainer.TabIndex = 0;
            // 
            // pageBaseParamsSetting
            // 
            this.pageBaseParamsSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pageBaseParamsSetting.Controls.Add(this.tboxE10Version);
            this.pageBaseParamsSetting.Controls.Add(this.lblE10Version);
            this.pageBaseParamsSetting.Controls.Add(this.lblTypeKeyPrompt);
            this.pageBaseParamsSetting.Controls.Add(this.tboxTypeKey);
            this.pageBaseParamsSetting.Controls.Add(this.lblTypeKey);
            this.pageBaseParamsSetting.Controls.Add(this.tboxExportPath);
            this.pageBaseParamsSetting.Controls.Add(this.tboxEnvironmentPath);
            this.pageBaseParamsSetting.Controls.Add(this.lblVersion);
            this.pageBaseParamsSetting.Controls.Add(this.lnkSelectExportPath);
            this.pageBaseParamsSetting.Controls.Add(this.lnkExportPath);
            this.pageBaseParamsSetting.Controls.Add(this.lnkSelectEnvironmentPath);
            this.pageBaseParamsSetting.Controls.Add(this.lnkEnvironmentPath);
            this.pageBaseParamsSetting.Controls.Add(this.lnkSelectVersion);
            this.pageBaseParamsSetting.ImageKey = "params.png";
            this.pageBaseParamsSetting.Location = new System.Drawing.Point(4, 26);
            this.pageBaseParamsSetting.Name = "pageBaseParamsSetting";
            this.pageBaseParamsSetting.Padding = new System.Windows.Forms.Padding(3);
            this.pageBaseParamsSetting.Size = new System.Drawing.Size(630, 214);
            this.pageBaseParamsSetting.TabIndex = 0;
            this.pageBaseParamsSetting.Text = "基本参数设定";
            // 
            // tboxE10Version
            // 
            this.tboxE10Version.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxE10Version.BorderColor = System.Drawing.Color.Silver;
            this.tboxE10Version.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxE10Version.HotColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tboxE10Version.Location = new System.Drawing.Point(129, 146);
            this.tboxE10Version.Name = "tboxE10Version";
            this.tboxE10Version.Size = new System.Drawing.Size(478, 23);
            this.tboxE10Version.TabIndex = 12;
            this.tboxE10Version.Tag = "E10Version";
            // 
            // lblE10Version
            // 
            this.lblE10Version.AutoSize = true;
            this.lblE10Version.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblE10Version.Location = new System.Drawing.Point(8, 148);
            this.lblE10Version.Name = "lblE10Version";
            this.lblE10Version.Size = new System.Drawing.Size(77, 17);
            this.lblE10Version.TabIndex = 11;
            this.lblE10Version.Text = "E10版本名称";
            // 
            // lblTypeKeyPrompt
            // 
            this.lblTypeKeyPrompt.AutoSize = true;
            this.lblTypeKeyPrompt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTypeKeyPrompt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTypeKeyPrompt.Location = new System.Drawing.Point(120, 124);
            this.lblTypeKeyPrompt.Name = "lblTypeKeyPrompt";
            this.lblTypeKeyPrompt.Size = new System.Drawing.Size(200, 17);
            this.lblTypeKeyPrompt.TabIndex = 10;
            this.lblTypeKeyPrompt.Text = "（多个TypeKey之间用逗号[,]连接）";
            // 
            // tboxTypeKey
            // 
            this.tboxTypeKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxTypeKey.BorderColor = System.Drawing.Color.Silver;
            this.tboxTypeKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxTypeKey.HotColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tboxTypeKey.Location = new System.Drawing.Point(129, 98);
            this.tboxTypeKey.Name = "tboxTypeKey";
            this.tboxTypeKey.Size = new System.Drawing.Size(478, 23);
            this.tboxTypeKey.TabIndex = 9;
            this.tboxTypeKey.Tag = "TypeKey";
            // 
            // lblTypeKey
            // 
            this.lblTypeKey.AutoSize = true;
            this.lblTypeKey.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTypeKey.Location = new System.Drawing.Point(28, 100);
            this.lblTypeKey.Name = "lblTypeKey";
            this.lblTypeKey.Size = new System.Drawing.Size(57, 17);
            this.lblTypeKey.TabIndex = 8;
            this.lblTypeKey.Text = "TypeKey";
            // 
            // tboxExportPath
            // 
            this.tboxExportPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxExportPath.BorderColor = System.Drawing.Color.Silver;
            this.tboxExportPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxExportPath.HotColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tboxExportPath.Location = new System.Drawing.Point(129, 69);
            this.tboxExportPath.Name = "tboxExportPath";
            this.tboxExportPath.Size = new System.Drawing.Size(478, 23);
            this.tboxExportPath.TabIndex = 7;
            this.tboxExportPath.Tag = "ExportPath";
            // 
            // tboxEnvironmentPath
            // 
            this.tboxEnvironmentPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxEnvironmentPath.BorderColor = System.Drawing.Color.Silver;
            this.tboxEnvironmentPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxEnvironmentPath.HotColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tboxEnvironmentPath.Location = new System.Drawing.Point(129, 40);
            this.tboxEnvironmentPath.Name = "tboxEnvironmentPath";
            this.tboxEnvironmentPath.Size = new System.Drawing.Size(478, 23);
            this.tboxEnvironmentPath.TabIndex = 6;
            this.tboxEnvironmentPath.Tag = "EnvironmentPath";
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblVersion.Location = new System.Drawing.Point(129, 17);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(55, 17);
            this.lblVersion.TabIndex = 5;
            this.lblVersion.Text = "Version";
            // 
            // lnkSelectExportPath
            // 
            this.lnkSelectExportPath.AutoSize = true;
            this.lnkSelectExportPath.Location = new System.Drawing.Point(91, 71);
            this.lnkSelectExportPath.Name = "lnkSelectExportPath";
            this.lnkSelectExportPath.Size = new System.Drawing.Size(32, 17);
            this.lnkSelectExportPath.TabIndex = 4;
            this.lnkSelectExportPath.TabStop = true;
            this.lnkSelectExportPath.Text = "选择";
            // 
            // lnkExportPath
            // 
            this.lnkExportPath.AccessibleDescription = "";
            this.lnkExportPath.AutoSize = true;
            this.lnkExportPath.Location = new System.Drawing.Point(15, 71);
            this.lnkExportPath.Name = "lnkExportPath";
            this.lnkExportPath.Size = new System.Drawing.Size(70, 17);
            this.lnkExportPath.TabIndex = 3;
            this.lnkExportPath.TabStop = true;
            this.lnkExportPath.Text = "Export路径";
            // 
            // lnkSelectEnvironmentPath
            // 
            this.lnkSelectEnvironmentPath.AutoSize = true;
            this.lnkSelectEnvironmentPath.Location = new System.Drawing.Point(91, 43);
            this.lnkSelectEnvironmentPath.Name = "lnkSelectEnvironmentPath";
            this.lnkSelectEnvironmentPath.Size = new System.Drawing.Size(32, 17);
            this.lnkSelectEnvironmentPath.TabIndex = 2;
            this.lnkSelectEnvironmentPath.TabStop = true;
            this.lnkSelectEnvironmentPath.Text = "选择";
            // 
            // lnkEnvironmentPath
            // 
            this.lnkEnvironmentPath.AutoSize = true;
            this.lnkEnvironmentPath.Location = new System.Drawing.Point(29, 43);
            this.lnkEnvironmentPath.Name = "lnkEnvironmentPath";
            this.lnkEnvironmentPath.Size = new System.Drawing.Size(56, 17);
            this.lnkEnvironmentPath.TabIndex = 1;
            this.lnkEnvironmentPath.TabStop = true;
            this.lnkEnvironmentPath.Tag = "";
            this.lnkEnvironmentPath.Text = "环境路径";
            // 
            // lnkSelectVersion
            // 
            this.lnkSelectVersion.AutoSize = true;
            this.lnkSelectVersion.Image = global::Eproduction.Integrated.Assistant.Start.Properties.Resources.setting;
            this.lnkSelectVersion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkSelectVersion.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkSelectVersion.Location = new System.Drawing.Point(9, 17);
            this.lnkSelectVersion.Name = "lnkSelectVersion";
            this.lnkSelectVersion.Size = new System.Drawing.Size(76, 17);
            this.lnkSelectVersion.TabIndex = 0;
            this.lnkSelectVersion.TabStop = true;
            this.lnkSelectVersion.Text = "     版本设定";
            this.lnkSelectVersion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkSelectVersion_LinkClicked);
            // 
            // pageComplieAndDeploy
            // 
            this.pageComplieAndDeploy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pageComplieAndDeploy.Controls.Add(this.tabDeployAdvancedSetting);
            this.pageComplieAndDeploy.ImageKey = "deploy.png";
            this.pageComplieAndDeploy.Location = new System.Drawing.Point(4, 26);
            this.pageComplieAndDeploy.Name = "pageComplieAndDeploy";
            this.pageComplieAndDeploy.Padding = new System.Windows.Forms.Padding(3);
            this.pageComplieAndDeploy.Size = new System.Drawing.Size(630, 214);
            this.pageComplieAndDeploy.TabIndex = 1;
            this.pageComplieAndDeploy.Text = "编译与部署";
            // 
            // tabDeployAdvancedSetting
            // 
            this.tabDeployAdvancedSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabDeployAdvancedSetting.Controls.Add(this.pageDeployAdvancedSetting);
            this.tabDeployAdvancedSetting.Controls.Add(this.pageComplieAdvancedSetting);
            this.tabDeployAdvancedSetting.ImageList = this.ImageList;
            this.tabDeployAdvancedSetting.Location = new System.Drawing.Point(6, 6);
            this.tabDeployAdvancedSetting.Name = "tabDeployAdvancedSetting";
            this.tabDeployAdvancedSetting.SelectedIndex = 0;
            this.tabDeployAdvancedSetting.Size = new System.Drawing.Size(618, 202);
            this.tabDeployAdvancedSetting.TabIndex = 6;
            // 
            // pageDeployAdvancedSetting
            // 
            this.pageDeployAdvancedSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pageDeployAdvancedSetting.Controls.Add(this.gboxDeployVersionTargets);
            this.pageDeployAdvancedSetting.Controls.Add(this.cboxDeployEnUSResources);
            this.pageDeployAdvancedSetting.Controls.Add(this.cboxDeployToClient);
            this.pageDeployAdvancedSetting.Controls.Add(this.cboxDeployZhCHTResources);
            this.pageDeployAdvancedSetting.Controls.Add(this.cboxDeployToServer);
            this.pageDeployAdvancedSetting.Controls.Add(this.cboxDeployWebServer);
            this.pageDeployAdvancedSetting.ImageKey = "deploy_advanced.png";
            this.pageDeployAdvancedSetting.Location = new System.Drawing.Point(4, 26);
            this.pageDeployAdvancedSetting.Name = "pageDeployAdvancedSetting";
            this.pageDeployAdvancedSetting.Padding = new System.Windows.Forms.Padding(3);
            this.pageDeployAdvancedSetting.Size = new System.Drawing.Size(610, 172);
            this.pageDeployAdvancedSetting.TabIndex = 1;
            this.pageDeployAdvancedSetting.Text = "部署";
            // 
            // gboxDeployVersionTargets
            // 
            this.gboxDeployVersionTargets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxDeployVersionTargets.Controls.Add(this.rdoBusinessPackage);
            this.gboxDeployVersionTargets.Controls.Add(this.rdoCustomization);
            this.gboxDeployVersionTargets.Controls.Add(this.rdoIndustry);
            this.gboxDeployVersionTargets.Controls.Add(this.rdoBase);
            this.gboxDeployVersionTargets.Location = new System.Drawing.Point(13, 6);
            this.gboxDeployVersionTargets.Name = "gboxDeployVersionTargets";
            this.gboxDeployVersionTargets.Size = new System.Drawing.Size(585, 51);
            this.gboxDeployVersionTargets.TabIndex = 0;
            this.gboxDeployVersionTargets.TabStop = false;
            this.gboxDeployVersionTargets.Text = "版本性质设定";
            // 
            // rdoBusinessPackage
            // 
            this.rdoBusinessPackage.AutoSize = true;
            this.rdoBusinessPackage.Location = new System.Drawing.Point(261, 20);
            this.rdoBusinessPackage.Name = "rdoBusinessPackage";
            this.rdoBusinessPackage.Size = new System.Drawing.Size(74, 21);
            this.rdoBusinessPackage.TabIndex = 3;
            this.rdoBusinessPackage.TabStop = true;
            this.rdoBusinessPackage.Text = "服务商品";
            this.rdoBusinessPackage.UseVisualStyleBackColor = true;
            // 
            // rdoCustomization
            // 
            this.rdoCustomization.AutoSize = true;
            this.rdoCustomization.Location = new System.Drawing.Point(179, 20);
            this.rdoCustomization.Name = "rdoCustomization";
            this.rdoCustomization.Size = new System.Drawing.Size(62, 21);
            this.rdoCustomization.TabIndex = 2;
            this.rdoCustomization.TabStop = true;
            this.rdoCustomization.Text = "个案包";
            this.rdoCustomization.UseVisualStyleBackColor = true;
            // 
            // rdoIndustry
            // 
            this.rdoIndustry.AutoSize = true;
            this.rdoIndustry.Location = new System.Drawing.Point(97, 20);
            this.rdoIndustry.Name = "rdoIndustry";
            this.rdoIndustry.Size = new System.Drawing.Size(62, 21);
            this.rdoIndustry.TabIndex = 1;
            this.rdoIndustry.TabStop = true;
            this.rdoIndustry.Text = "行业版";
            this.rdoIndustry.UseVisualStyleBackColor = true;
            // 
            // rdoBase
            // 
            this.rdoBase.AutoSize = true;
            this.rdoBase.Location = new System.Drawing.Point(24, 20);
            this.rdoBase.Name = "rdoBase";
            this.rdoBase.Size = new System.Drawing.Size(50, 21);
            this.rdoBase.TabIndex = 0;
            this.rdoBase.TabStop = true;
            this.rdoBase.Text = "基版";
            this.rdoBase.UseVisualStyleBackColor = true;
            // 
            // cboxDeployEnUSResources
            // 
            this.cboxDeployEnUSResources.AutoSize = true;
            this.cboxDeployEnUSResources.Location = new System.Drawing.Point(359, 89);
            this.cboxDeployEnUSResources.Name = "cboxDeployEnUSResources";
            this.cboxDeployEnUSResources.Size = new System.Drawing.Size(181, 21);
            this.cboxDeployEnUSResources.TabIndex = 5;
            this.cboxDeployEnUSResources.Text = "部署英文*.resources.dll文件";
            this.cboxDeployEnUSResources.UseVisualStyleBackColor = true;
            // 
            // cboxDeployToClient
            // 
            this.cboxDeployToClient.AutoSize = true;
            this.cboxDeployToClient.Location = new System.Drawing.Point(37, 68);
            this.cboxDeployToClient.Name = "cboxDeployToClient";
            this.cboxDeployToClient.Size = new System.Drawing.Size(151, 21);
            this.cboxDeployToClient.TabIndex = 1;
            this.cboxDeployToClient.Text = "部署*.dll文件到CLIENT";
            this.cboxDeployToClient.UseVisualStyleBackColor = true;
            // 
            // cboxDeployZhCHTResources
            // 
            this.cboxDeployZhCHTResources.AutoSize = true;
            this.cboxDeployZhCHTResources.Location = new System.Drawing.Point(359, 68);
            this.cboxDeployZhCHTResources.Name = "cboxDeployZhCHTResources";
            this.cboxDeployZhCHTResources.Size = new System.Drawing.Size(181, 21);
            this.cboxDeployZhCHTResources.TabIndex = 4;
            this.cboxDeployZhCHTResources.Text = "部署繁体*.resources.dll文件";
            this.cboxDeployZhCHTResources.UseVisualStyleBackColor = true;
            // 
            // cboxDeployToServer
            // 
            this.cboxDeployToServer.AutoSize = true;
            this.cboxDeployToServer.Location = new System.Drawing.Point(37, 88);
            this.cboxDeployToServer.Name = "cboxDeployToServer";
            this.cboxDeployToServer.Size = new System.Drawing.Size(154, 21);
            this.cboxDeployToServer.TabIndex = 2;
            this.cboxDeployToServer.Text = "部署*.dll文件到SERVER";
            this.cboxDeployToServer.UseVisualStyleBackColor = true;
            // 
            // cboxDeployWebServer
            // 
            this.cboxDeployWebServer.AutoSize = true;
            this.cboxDeployWebServer.Location = new System.Drawing.Point(37, 108);
            this.cboxDeployWebServer.Name = "cboxDeployWebServer";
            this.cboxDeployWebServer.Size = new System.Drawing.Size(181, 21);
            this.cboxDeployWebServer.TabIndex = 3;
            this.cboxDeployWebServer.Text = "部署*.dll文件到WEBSERVER";
            this.cboxDeployWebServer.UseVisualStyleBackColor = true;
            // 
            // pageComplieAdvancedSetting
            // 
            this.pageComplieAdvancedSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pageComplieAdvancedSetting.Controls.Add(this.btnComplie);
            this.pageComplieAdvancedSetting.Controls.Add(this.tboxComplieCommandText);
            this.pageComplieAdvancedSetting.Controls.Add(this.lblComplieCommandText);
            this.pageComplieAdvancedSetting.Controls.Add(this.lnkLocateVsDevCmdbat);
            this.pageComplieAdvancedSetting.Controls.Add(this.lblLocateVsDevCmdbat);
            this.pageComplieAdvancedSetting.Controls.Add(this.lblLocateVsDevCmdbatTitle);
            this.pageComplieAdvancedSetting.ImageKey = "complie_advanced.png";
            this.pageComplieAdvancedSetting.Location = new System.Drawing.Point(4, 26);
            this.pageComplieAdvancedSetting.Name = "pageComplieAdvancedSetting";
            this.pageComplieAdvancedSetting.Padding = new System.Windows.Forms.Padding(3);
            this.pageComplieAdvancedSetting.Size = new System.Drawing.Size(610, 172);
            this.pageComplieAdvancedSetting.TabIndex = 2;
            this.pageComplieAdvancedSetting.Text = "编译";
            // 
            // btnComplie
            // 
            this.btnComplie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnComplie.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnComplie.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnComplie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComplie.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnComplie.Location = new System.Drawing.Point(499, 136);
            this.btnComplie.Name = "btnComplie";
            this.btnComplie.Size = new System.Drawing.Size(96, 28);
            this.btnComplie.TabIndex = 10;
            this.btnComplie.Text = "编译(M)";
            this.btnComplie.UseVisualStyleBackColor = false;
            this.btnComplie.Click += new System.EventHandler(this.btnComplie_Click);
            // 
            // tboxComplieCommandText
            // 
            this.tboxComplieCommandText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxComplieCommandText.BorderColor = System.Drawing.Color.Silver;
            this.tboxComplieCommandText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxComplieCommandText.HotColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tboxComplieCommandText.Location = new System.Drawing.Point(16, 89);
            this.tboxComplieCommandText.Multiline = true;
            this.tboxComplieCommandText.Name = "tboxComplieCommandText";
            this.tboxComplieCommandText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tboxComplieCommandText.Size = new System.Drawing.Size(579, 41);
            this.tboxComplieCommandText.TabIndex = 4;
            // 
            // lblComplieCommandText
            // 
            this.lblComplieCommandText.AutoSize = true;
            this.lblComplieCommandText.Location = new System.Drawing.Point(15, 69);
            this.lblComplieCommandText.Name = "lblComplieCommandText";
            this.lblComplieCommandText.Size = new System.Drawing.Size(80, 17);
            this.lblComplieCommandText.TabIndex = 3;
            this.lblComplieCommandText.Text = "设定编译命令";
            // 
            // lnkLocateVsDevCmdbat
            // 
            this.lnkLocateVsDevCmdbat.AutoSize = true;
            this.lnkLocateVsDevCmdbat.Image = global::Eproduction.Integrated.Assistant.Start.Properties.Resources.locate;
            this.lnkLocateVsDevCmdbat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkLocateVsDevCmdbat.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkLocateVsDevCmdbat.Location = new System.Drawing.Point(330, 12);
            this.lnkLocateVsDevCmdbat.Name = "lnkLocateVsDevCmdbat";
            this.lnkLocateVsDevCmdbat.Size = new System.Drawing.Size(48, 17);
            this.lnkLocateVsDevCmdbat.TabIndex = 2;
            this.lnkLocateVsDevCmdbat.TabStop = true;
            this.lnkLocateVsDevCmdbat.Text = "    定位";
            // 
            // lblLocateVsDevCmdbat
            // 
            this.lblLocateVsDevCmdbat.AutoSize = true;
            this.lblLocateVsDevCmdbat.BackColor = System.Drawing.Color.Silver;
            this.lblLocateVsDevCmdbat.Location = new System.Drawing.Point(15, 32);
            this.lblLocateVsDevCmdbat.Name = "lblLocateVsDevCmdbat";
            this.lblLocateVsDevCmdbat.Size = new System.Drawing.Size(394, 17);
            this.lblLocateVsDevCmdbat.TabIndex = 1;
            this.lblLocateVsDevCmdbat.Text = "C:\\Program Files (x86)\\Microsoft Visual Studio 9.0\\VC\\vcvarsall.bat";
            // 
            // lblLocateVsDevCmdbatTitle
            // 
            this.lblLocateVsDevCmdbatTitle.AutoSize = true;
            this.lblLocateVsDevCmdbatTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLocateVsDevCmdbatTitle.Location = new System.Drawing.Point(15, 12);
            this.lblLocateVsDevCmdbatTitle.Name = "lblLocateVsDevCmdbatTitle";
            this.lblLocateVsDevCmdbatTitle.Size = new System.Drawing.Size(309, 17);
            this.lblLocateVsDevCmdbatTitle.TabIndex = 0;
            this.lblLocateVsDevCmdbatTitle.Text = ">>定位 Visual Studio Develop Command 批处理文件";
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "params.png");
            this.ImageList.Images.SetKeyName(1, "deploy.png");
            this.ImageList.Images.SetKeyName(2, "container.png");
            this.ImageList.Images.SetKeyName(3, "deployement.png");
            this.ImageList.Images.SetKeyName(4, "details.png");
            this.ImageList.Images.SetKeyName(5, "complie_advanced.png");
            this.ImageList.Images.SetKeyName(6, "deploy_advanced.png");
            this.ImageList.Images.SetKeyName(7, "deploy-plus.png");
            this.ImageList.Images.SetKeyName(8, "management.png");
            // 
            // pageEnvironmentSetting
            // 
            this.pageEnvironmentSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pageEnvironmentSetting.Controls.Add(this.tabEnvrionmentSetting);
            this.pageEnvironmentSetting.ImageKey = "container.png";
            this.pageEnvironmentSetting.Location = new System.Drawing.Point(4, 26);
            this.pageEnvironmentSetting.Name = "pageEnvironmentSetting";
            this.pageEnvironmentSetting.Padding = new System.Windows.Forms.Padding(3);
            this.pageEnvironmentSetting.Size = new System.Drawing.Size(630, 214);
            this.pageEnvironmentSetting.TabIndex = 2;
            this.pageEnvironmentSetting.Text = "环境设置";
            // 
            // tabEnvrionmentSetting
            // 
            this.tabEnvrionmentSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabEnvrionmentSetting.Controls.Add(this.pageE10EnvrionmentSetting);
            this.tabEnvrionmentSetting.Controls.Add(this.pageEsClientEnvrionmentSetting);
            this.tabEnvrionmentSetting.Location = new System.Drawing.Point(3, 3);
            this.tabEnvrionmentSetting.Name = "tabEnvrionmentSetting";
            this.tabEnvrionmentSetting.SelectedIndex = 0;
            this.tabEnvrionmentSetting.Size = new System.Drawing.Size(624, 208);
            this.tabEnvrionmentSetting.TabIndex = 7;
            // 
            // pageE10EnvrionmentSetting
            // 
            this.pageE10EnvrionmentSetting.AutoScroll = true;
            this.pageE10EnvrionmentSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pageE10EnvrionmentSetting.Controls.Add(this.cboxKillEprocess);
            this.pageE10EnvrionmentSetting.Controls.Add(this.lnkAccountSettingView);
            this.pageE10EnvrionmentSetting.Controls.Add(this.cboxKillClientProcess);
            this.pageE10EnvrionmentSetting.Controls.Add(this.lnkExtractRuntimeResources);
            this.pageE10EnvrionmentSetting.Controls.Add(this.cboxAutoDeploy);
            this.pageE10EnvrionmentSetting.Controls.Add(this.lnkImportConfigurationArchives);
            this.pageE10EnvrionmentSetting.Controls.Add(this.gboxParamsSetting);
            this.pageE10EnvrionmentSetting.Location = new System.Drawing.Point(4, 26);
            this.pageE10EnvrionmentSetting.Name = "pageE10EnvrionmentSetting";
            this.pageE10EnvrionmentSetting.Padding = new System.Windows.Forms.Padding(3);
            this.pageE10EnvrionmentSetting.Size = new System.Drawing.Size(616, 178);
            this.pageE10EnvrionmentSetting.TabIndex = 0;
            this.pageE10EnvrionmentSetting.Text = "E10";
            // 
            // cboxKillEprocess
            // 
            this.cboxKillEprocess.AutoSize = true;
            this.cboxKillEprocess.Location = new System.Drawing.Point(6, 6);
            this.cboxKillEprocess.Name = "cboxKillEprocess";
            this.cboxKillEprocess.Size = new System.Drawing.Size(177, 21);
            this.cboxKillEprocess.TabIndex = 0;
            this.cboxKillEprocess.Text = "启动SERVER时关闭E10进程";
            this.cboxKillEprocess.UseVisualStyleBackColor = true;
            // 
            // lnkAccountSettingView
            // 
            this.lnkAccountSettingView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkAccountSettingView.AutoSize = true;
            this.lnkAccountSettingView.Location = new System.Drawing.Point(530, 46);
            this.lnkAccountSettingView.Name = "lnkAccountSettingView";
            this.lnkAccountSettingView.Size = new System.Drawing.Size(80, 17);
            this.lnkAccountSettingView.TabIndex = 5;
            this.lnkAccountSettingView.TabStop = true;
            this.lnkAccountSettingView.Tag = "";
            this.lnkAccountSettingView.Text = "预览配置文件";
            this.lnkAccountSettingView.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAccountSettingView_LinkClicked);
            // 
            // cboxKillClientProcess
            // 
            this.cboxKillClientProcess.AutoSize = true;
            this.cboxKillClientProcess.Location = new System.Drawing.Point(6, 27);
            this.cboxKillClientProcess.Name = "cboxKillClientProcess";
            this.cboxKillClientProcess.Size = new System.Drawing.Size(189, 21);
            this.cboxKillClientProcess.TabIndex = 1;
            this.cboxKillClientProcess.Text = "启动CLIENT时关闭客户端进程";
            this.cboxKillClientProcess.UseVisualStyleBackColor = true;
            // 
            // lnkExtractRuntimeResources
            // 
            this.lnkExtractRuntimeResources.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkExtractRuntimeResources.AutoSize = true;
            this.lnkExtractRuntimeResources.Location = new System.Drawing.Point(481, 26);
            this.lnkExtractRuntimeResources.Name = "lnkExtractRuntimeResources";
            this.lnkExtractRuntimeResources.Size = new System.Drawing.Size(129, 17);
            this.lnkExtractRuntimeResources.TabIndex = 4;
            this.lnkExtractRuntimeResources.TabStop = true;
            this.lnkExtractRuntimeResources.Tag = "";
            this.lnkExtractRuntimeResources.Text = "提取TypeKey运行文件";
            this.lnkExtractRuntimeResources.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkExtractRuntimeResources_LinkClicked);
            // 
            // cboxAutoDeploy
            // 
            this.cboxAutoDeploy.AutoSize = true;
            this.cboxAutoDeploy.Location = new System.Drawing.Point(6, 48);
            this.cboxAutoDeploy.Name = "cboxAutoDeploy";
            this.cboxAutoDeploy.Size = new System.Drawing.Size(121, 21);
            this.cboxAutoDeploy.TabIndex = 2;
            this.cboxAutoDeploy.Text = "自动部署*.dll文件";
            this.cboxAutoDeploy.UseVisualStyleBackColor = true;
            // 
            // lnkImportConfigurationArchives
            // 
            this.lnkImportConfigurationArchives.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkImportConfigurationArchives.AutoSize = true;
            this.lnkImportConfigurationArchives.Location = new System.Drawing.Point(530, 7);
            this.lnkImportConfigurationArchives.Name = "lnkImportConfigurationArchives";
            this.lnkImportConfigurationArchives.Size = new System.Drawing.Size(80, 17);
            this.lnkImportConfigurationArchives.TabIndex = 3;
            this.lnkImportConfigurationArchives.TabStop = true;
            this.lnkImportConfigurationArchives.Tag = "";
            this.lnkImportConfigurationArchives.Text = "导入配置文件";
            this.lnkImportConfigurationArchives.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkImportConfigurationArchives_LinkClicked);
            // 
            // gboxParamsSetting
            // 
            this.gboxParamsSetting.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxParamsSetting.Controls.Add(this.lblClientParamsCustom);
            this.gboxParamsSetting.Controls.Add(this.cbboxStartClientParamsType);
            this.gboxParamsSetting.Controls.Add(this.lblServerParamsCustom);
            this.gboxParamsSetting.Controls.Add(this.cbboxStartServerParamsType);
            this.gboxParamsSetting.Controls.Add(this.tboxClientParams);
            this.gboxParamsSetting.Controls.Add(this.tboxServerParams);
            this.gboxParamsSetting.Controls.Add(this.lblClientParams);
            this.gboxParamsSetting.Controls.Add(this.lblServerParams);
            this.gboxParamsSetting.Location = new System.Drawing.Point(6, 72);
            this.gboxParamsSetting.Name = "gboxParamsSetting";
            this.gboxParamsSetting.Size = new System.Drawing.Size(604, 90);
            this.gboxParamsSetting.TabIndex = 6;
            this.gboxParamsSetting.TabStop = false;
            this.gboxParamsSetting.Text = "启动参数设置";
            // 
            // lblClientParamsCustom
            // 
            this.lblClientParamsCustom.AutoSize = true;
            this.lblClientParamsCustom.Location = new System.Drawing.Point(294, 55);
            this.lblClientParamsCustom.Name = "lblClientParamsCustom";
            this.lblClientParamsCustom.Size = new System.Drawing.Size(44, 17);
            this.lblClientParamsCustom.TabIndex = 6;
            this.lblClientParamsCustom.Text = "自定义";
            // 
            // cbboxStartClientParamsType
            // 
            this.cbboxStartClientParamsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxStartClientParamsType.FormattingEnabled = true;
            this.cbboxStartClientParamsType.Items.AddRange(new object[] {
            "0.自定义",
            "1.不加参数",
            "2.调试模式（d /l）"});
            this.cbboxStartClientParamsType.Location = new System.Drawing.Point(76, 51);
            this.cbboxStartClientParamsType.Name = "cbboxStartClientParamsType";
            this.cbboxStartClientParamsType.Size = new System.Drawing.Size(212, 25);
            this.cbboxStartClientParamsType.TabIndex = 5;
            // 
            // lblServerParamsCustom
            // 
            this.lblServerParamsCustom.AutoSize = true;
            this.lblServerParamsCustom.Location = new System.Drawing.Point(294, 26);
            this.lblServerParamsCustom.Name = "lblServerParamsCustom";
            this.lblServerParamsCustom.Size = new System.Drawing.Size(44, 17);
            this.lblServerParamsCustom.TabIndex = 2;
            this.lblServerParamsCustom.Text = "自定义";
            // 
            // cbboxStartServerParamsType
            // 
            this.cbboxStartServerParamsType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxStartServerParamsType.FormattingEnabled = true;
            this.cbboxStartServerParamsType.Items.AddRange(new object[] {
            "0.自定义",
            "1.全启动（不加参数）",
            "2.全启动+修复模式（/r）",
            "3.调试模式（/d）",
            "4.调试模式+修复模式（/r /d）",
            "5.升级模式（/u）"});
            this.cbboxStartServerParamsType.Location = new System.Drawing.Point(76, 22);
            this.cbboxStartServerParamsType.Name = "cbboxStartServerParamsType";
            this.cbboxStartServerParamsType.Size = new System.Drawing.Size(212, 25);
            this.cbboxStartServerParamsType.TabIndex = 1;
            // 
            // tboxClientParams
            // 
            this.tboxClientParams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxClientParams.BorderColor = System.Drawing.Color.Silver;
            this.tboxClientParams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxClientParams.HotColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tboxClientParams.Location = new System.Drawing.Point(344, 53);
            this.tboxClientParams.Name = "tboxClientParams";
            this.tboxClientParams.Size = new System.Drawing.Size(235, 23);
            this.tboxClientParams.TabIndex = 7;
            // 
            // tboxServerParams
            // 
            this.tboxServerParams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxServerParams.BorderColor = System.Drawing.Color.Silver;
            this.tboxServerParams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxServerParams.HotColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tboxServerParams.Location = new System.Drawing.Point(344, 24);
            this.tboxServerParams.Name = "tboxServerParams";
            this.tboxServerParams.Size = new System.Drawing.Size(235, 23);
            this.tboxServerParams.TabIndex = 3;
            // 
            // lblClientParams
            // 
            this.lblClientParams.AutoSize = true;
            this.lblClientParams.Location = new System.Drawing.Point(20, 55);
            this.lblClientParams.Name = "lblClientParams";
            this.lblClientParams.Size = new System.Drawing.Size(50, 17);
            this.lblClientParams.TabIndex = 4;
            this.lblClientParams.Text = "CLIENT";
            // 
            // lblServerParams
            // 
            this.lblServerParams.AutoSize = true;
            this.lblServerParams.Location = new System.Drawing.Point(17, 26);
            this.lblServerParams.Name = "lblServerParams";
            this.lblServerParams.Size = new System.Drawing.Size(53, 17);
            this.lblServerParams.TabIndex = 0;
            this.lblServerParams.Text = "SERVER";
            // 
            // pageEsClientEnvrionmentSetting
            // 
            this.pageEsClientEnvrionmentSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pageEsClientEnvrionmentSetting.Location = new System.Drawing.Point(4, 26);
            this.pageEsClientEnvrionmentSetting.Name = "pageEsClientEnvrionmentSetting";
            this.pageEsClientEnvrionmentSetting.Padding = new System.Windows.Forms.Padding(3);
            this.pageEsClientEnvrionmentSetting.Size = new System.Drawing.Size(616, 178);
            this.pageEsClientEnvrionmentSetting.TabIndex = 1;
            this.pageEsClientEnvrionmentSetting.Text = "驻派员";
            // 
            // pageJoinCMMangement
            // 
            this.pageJoinCMMangement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pageJoinCMMangement.Controls.Add(this.tabJoinCMMangement);
            this.pageJoinCMMangement.ImageKey = "deployement.png";
            this.pageJoinCMMangement.Location = new System.Drawing.Point(4, 26);
            this.pageJoinCMMangement.Name = "pageJoinCMMangement";
            this.pageJoinCMMangement.Padding = new System.Windows.Forms.Padding(3);
            this.pageJoinCMMangement.Size = new System.Drawing.Size(630, 214);
            this.pageJoinCMMangement.TabIndex = 3;
            this.pageJoinCMMangement.Text = "衔接CM系统";
            // 
            // tabJoinCMMangement
            // 
            this.tabJoinCMMangement.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabJoinCMMangement.Controls.Add(this.pageDeployServerResources);
            this.tabJoinCMMangement.Controls.Add(this.pageCMManagmenet);
            this.tabJoinCMMangement.ImageList = this.ImageList;
            this.tabJoinCMMangement.Location = new System.Drawing.Point(3, 3);
            this.tabJoinCMMangement.Name = "tabJoinCMMangement";
            this.tabJoinCMMangement.SelectedIndex = 0;
            this.tabJoinCMMangement.Size = new System.Drawing.Size(624, 208);
            this.tabJoinCMMangement.TabIndex = 5;
            // 
            // pageDeployServerResources
            // 
            this.pageDeployServerResources.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pageDeployServerResources.Controls.Add(this.cboxApplyciBeenPutInStorage);
            this.pageDeployServerResources.Controls.Add(this.cboxBeforeDeployementKillEprocess);
            this.pageDeployServerResources.Controls.Add(this.cboxExcludeProgramInfo);
            this.pageDeployServerResources.Controls.Add(this.tboxApplyciDocs);
            this.pageDeployServerResources.Controls.Add(this.lblApplyciDocs);
            this.pageDeployServerResources.ImageKey = "deploy-plus.png";
            this.pageDeployServerResources.Location = new System.Drawing.Point(4, 26);
            this.pageDeployServerResources.Name = "pageDeployServerResources";
            this.pageDeployServerResources.Padding = new System.Windows.Forms.Padding(3);
            this.pageDeployServerResources.Size = new System.Drawing.Size(616, 178);
            this.pageDeployServerResources.TabIndex = 0;
            this.pageDeployServerResources.Text = "部署资源";
            // 
            // cboxApplyciBeenPutInStorage
            // 
            this.cboxApplyciBeenPutInStorage.AutoSize = true;
            this.cboxApplyciBeenPutInStorage.Location = new System.Drawing.Point(19, 6);
            this.cboxApplyciBeenPutInStorage.Name = "cboxApplyciBeenPutInStorage";
            this.cboxApplyciBeenPutInStorage.Size = new System.Drawing.Size(111, 21);
            this.cboxApplyciBeenPutInStorage.TabIndex = 0;
            this.cboxApplyciBeenPutInStorage.Text = "签出单号已入库";
            this.cboxApplyciBeenPutInStorage.UseVisualStyleBackColor = true;
            // 
            // cboxBeforeDeployementKillEprocess
            // 
            this.cboxBeforeDeployementKillEprocess.AutoSize = true;
            this.cboxBeforeDeployementKillEprocess.Location = new System.Drawing.Point(19, 48);
            this.cboxBeforeDeployementKillEprocess.Name = "cboxBeforeDeployementKillEprocess";
            this.cboxBeforeDeployementKillEprocess.Size = new System.Drawing.Size(132, 21);
            this.cboxBeforeDeployementKillEprocess.TabIndex = 2;
            this.cboxBeforeDeployementKillEprocess.Text = "部署前关闭E10进程";
            this.cboxBeforeDeployementKillEprocess.UseVisualStyleBackColor = true;
            // 
            // cboxExcludeProgramInfo
            // 
            this.cboxExcludeProgramInfo.AutoSize = true;
            this.cboxExcludeProgramInfo.Location = new System.Drawing.Point(19, 27);
            this.cboxExcludeProgramInfo.Name = "cboxExcludeProgramInfo";
            this.cboxExcludeProgramInfo.Size = new System.Drawing.Size(209, 21);
            this.cboxExcludeProgramInfo.TabIndex = 1;
            this.cboxExcludeProgramInfo.Text = "部署过程中排除ProgramInfo文件";
            this.cboxExcludeProgramInfo.UseVisualStyleBackColor = true;
            // 
            // tboxApplyciDocs
            // 
            this.tboxApplyciDocs.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxApplyciDocs.BorderColor = System.Drawing.Color.Silver;
            this.tboxApplyciDocs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxApplyciDocs.HotColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tboxApplyciDocs.Location = new System.Drawing.Point(19, 98);
            this.tboxApplyciDocs.Multiline = true;
            this.tboxApplyciDocs.Name = "tboxApplyciDocs";
            this.tboxApplyciDocs.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tboxApplyciDocs.Size = new System.Drawing.Size(573, 69);
            this.tboxApplyciDocs.TabIndex = 4;
            // 
            // lblApplyciDocs
            // 
            this.lblApplyciDocs.AutoSize = true;
            this.lblApplyciDocs.Location = new System.Drawing.Point(16, 78);
            this.lblApplyciDocs.Name = "lblApplyciDocs";
            this.lblApplyciDocs.Size = new System.Drawing.Size(199, 17);
            this.lblApplyciDocs.TabIndex = 3;
            this.lblApplyciDocs.Text = "签出单号（单号之间用逗号[,]连接）";
            // 
            // pageCMManagmenet
            // 
            this.pageCMManagmenet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pageCMManagmenet.Controls.Add(this.lnkKillCMProcess);
            this.pageCMManagmenet.Controls.Add(this.lblCMClientParams);
            this.pageCMManagmenet.Controls.Add(this.lnkLocationCMClient);
            this.pageCMManagmenet.Controls.Add(this.lblLocationCMClient);
            this.pageCMManagmenet.Controls.Add(this.lblLocationCMClientTitle);
            this.pageCMManagmenet.Controls.Add(this.btnStartCMClient);
            this.pageCMManagmenet.Controls.Add(this.tboxCMClientParams);
            this.pageCMManagmenet.ImageKey = "management.png";
            this.pageCMManagmenet.Location = new System.Drawing.Point(4, 26);
            this.pageCMManagmenet.Name = "pageCMManagmenet";
            this.pageCMManagmenet.Padding = new System.Windows.Forms.Padding(3);
            this.pageCMManagmenet.Size = new System.Drawing.Size(616, 178);
            this.pageCMManagmenet.TabIndex = 1;
            this.pageCMManagmenet.Text = "系统管理";
            // 
            // lnkKillCMProcess
            // 
            this.lnkKillCMProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkKillCMProcess.AutoSize = true;
            this.lnkKillCMProcess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkKillCMProcess.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkKillCMProcess.Location = new System.Drawing.Point(437, 138);
            this.lnkKillCMProcess.Name = "lnkKillCMProcess";
            this.lnkKillCMProcess.Size = new System.Drawing.Size(56, 17);
            this.lnkKillCMProcess.TabIndex = 6;
            this.lnkKillCMProcess.TabStop = true;
            this.lnkKillCMProcess.Text = "关闭进程";
            this.lnkKillCMProcess.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkKillCMProcess_LinkClicked);
            // 
            // lblCMClientParams
            // 
            this.lblCMClientParams.AutoSize = true;
            this.lblCMClientParams.Location = new System.Drawing.Point(17, 83);
            this.lblCMClientParams.Name = "lblCMClientParams";
            this.lblCMClientParams.Size = new System.Drawing.Size(80, 17);
            this.lblCMClientParams.TabIndex = 3;
            this.lblCMClientParams.Text = "设定启动参数";
            // 
            // lnkLocationCMClient
            // 
            this.lnkLocationCMClient.AutoSize = true;
            this.lnkLocationCMClient.Image = global::Eproduction.Integrated.Assistant.Start.Properties.Resources.locate;
            this.lnkLocationCMClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkLocationCMClient.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkLocationCMClient.Location = new System.Drawing.Point(335, 15);
            this.lnkLocationCMClient.Name = "lnkLocationCMClient";
            this.lnkLocationCMClient.Size = new System.Drawing.Size(48, 17);
            this.lnkLocationCMClient.TabIndex = 2;
            this.lnkLocationCMClient.TabStop = true;
            this.lnkLocationCMClient.Text = "    定位";
            // 
            // lblLocationCMClient
            // 
            this.lblLocationCMClient.AutoSize = true;
            this.lblLocationCMClient.BackColor = System.Drawing.Color.Silver;
            this.lblLocationCMClient.Location = new System.Drawing.Point(17, 35);
            this.lblLocationCMClient.Name = "lblLocationCMClient";
            this.lblLocationCMClient.Size = new System.Drawing.Size(480, 17);
            this.lblLocationCMClient.TabIndex = 1;
            this.lblLocationCMClient.Text = "C:\\Digiwin Workspace\\E10\\CM Client\\Shared\\Digiwin.Mars.Deployment.Client.exe";
            // 
            // lblLocationCMClientTitle
            // 
            this.lblLocationCMClientTitle.AutoSize = true;
            this.lblLocationCMClientTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblLocationCMClientTitle.Location = new System.Drawing.Point(17, 15);
            this.lblLocationCMClientTitle.Name = "lblLocationCMClientTitle";
            this.lblLocationCMClientTitle.Size = new System.Drawing.Size(312, 17);
            this.lblLocationCMClientTitle.TabIndex = 0;
            this.lblLocationCMClientTitle.Text = ">>定位 Digiwin.Mars.Deployment.Client.exe 程序路径";
            // 
            // btnStartCMClient
            // 
            this.btnStartCMClient.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartCMClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnStartCMClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnStartCMClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartCMClient.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartCMClient.Location = new System.Drawing.Point(504, 132);
            this.btnStartCMClient.Name = "btnStartCMClient";
            this.btnStartCMClient.Size = new System.Drawing.Size(96, 28);
            this.btnStartCMClient.TabIndex = 5;
            this.btnStartCMClient.Text = "启动(O)";
            this.btnStartCMClient.UseVisualStyleBackColor = false;
            this.btnStartCMClient.Click += new System.EventHandler(this.btnStartCMClient_Click);
            // 
            // tboxCMClientParams
            // 
            this.tboxCMClientParams.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxCMClientParams.BorderColor = System.Drawing.Color.Silver;
            this.tboxCMClientParams.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxCMClientParams.HotColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tboxCMClientParams.Location = new System.Drawing.Point(18, 103);
            this.tboxCMClientParams.Name = "tboxCMClientParams";
            this.tboxCMClientParams.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tboxCMClientParams.Size = new System.Drawing.Size(582, 23);
            this.tboxCMClientParams.TabIndex = 4;
            // 
            // tabPrinter
            // 
            this.tabPrinter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPrinter.Controls.Add(this.pageDetails);
            this.tabPrinter.ImageList = this.ImageList;
            this.tabPrinter.Location = new System.Drawing.Point(13, 271);
            this.tabPrinter.Name = "tabPrinter";
            this.tabPrinter.SelectedIndex = 0;
            this.tabPrinter.Size = new System.Drawing.Size(818, 155);
            this.tabPrinter.TabIndex = 37;
            // 
            // pageDetails
            // 
            this.pageDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pageDetails.Controls.Add(this.pnlDetailsToolbar);
            this.pageDetails.Controls.Add(this.richboxPrint);
            this.pageDetails.ImageKey = "details.png";
            this.pageDetails.Location = new System.Drawing.Point(4, 26);
            this.pageDetails.Name = "pageDetails";
            this.pageDetails.Padding = new System.Windows.Forms.Padding(3);
            this.pageDetails.Size = new System.Drawing.Size(810, 125);
            this.pageDetails.TabIndex = 0;
            this.pageDetails.Text = "输出";
            // 
            // pnlDetailsToolbar
            // 
            this.pnlDetailsToolbar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlDetailsToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.pnlDetailsToolbar.Controls.Add(this.btnView);
            this.pnlDetailsToolbar.Controls.Add(this.btnClear);
            this.pnlDetailsToolbar.Controls.Add(this.btnWordWarp);
            this.pnlDetailsToolbar.Location = new System.Drawing.Point(1, 1);
            this.pnlDetailsToolbar.Name = "pnlDetailsToolbar";
            this.pnlDetailsToolbar.Size = new System.Drawing.Size(27, 123);
            this.pnlDetailsToolbar.TabIndex = 17;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnView.Image = global::Eproduction.Integrated.Assistant.Start.Properties.Resources.view;
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(1, 53);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(25, 25);
            this.btnView.TabIndex = 13;
            this.ToolTip.SetToolTip(this.btnView, "检视");
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.Image = global::Eproduction.Integrated.Assistant.Start.Properties.Resources.clear;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(1, 25);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(25, 25);
            this.btnClear.TabIndex = 12;
            this.ToolTip.SetToolTip(this.btnClear, "清理");
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnWordWarp
            // 
            this.btnWordWarp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnWordWarp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnWordWarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWordWarp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWordWarp.Image = global::Eproduction.Integrated.Assistant.Start.Properties.Resources.word_warp;
            this.btnWordWarp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWordWarp.Location = new System.Drawing.Point(1, 1);
            this.btnWordWarp.Name = "btnWordWarp";
            this.btnWordWarp.Size = new System.Drawing.Size(25, 25);
            this.btnWordWarp.TabIndex = 11;
            this.ToolTip.SetToolTip(this.btnWordWarp, "换行");
            this.btnWordWarp.UseVisualStyleBackColor = false;
            this.btnWordWarp.Click += new System.EventHandler(this.btnWordWarp_Click);
            // 
            // richboxPrint
            // 
            this.richboxPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richboxPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.richboxPrint.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richboxPrint.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richboxPrint.Location = new System.Drawing.Point(31, 3);
            this.richboxPrint.Name = "richboxPrint";
            this.richboxPrint.ReadOnly = true;
            this.richboxPrint.Size = new System.Drawing.Size(776, 119);
            this.richboxPrint.TabIndex = 16;
            this.richboxPrint.Text = "";
            this.richboxPrint.WordWrap = false;
            // 
            // DeployWorker
            // 
            this.DeployWorker.WorkerReportsProgress = true;
            this.DeployWorker.WorkerSupportsCancellation = true;
            // 
            // DeployementWorker
            // 
            this.DeployementWorker.WorkerReportsProgress = true;
            this.DeployementWorker.WorkerSupportsCancellation = true;
            // 
            // CheckReferencesWorker
            // 
            this.CheckReferencesWorker.WorkerReportsProgress = true;
            this.CheckReferencesWorker.WorkerSupportsCancellation = true;
            // 
            // ComplieWorker
            // 
            this.ComplieWorker.WorkerReportsProgress = true;
            this.ComplieWorker.WorkerSupportsCancellation = true;
            // 
            // TrushpdbArchivesWorker
            // 
            this.TrushpdbArchivesWorker.WorkerReportsProgress = true;
            this.TrushpdbArchivesWorker.WorkerSupportsCancellation = true;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProvider.ContainerControl = this;
            // 
            // ExtractWorker
            // 
            this.ExtractWorker.WorkerReportsProgress = true;
            this.ExtractWorker.WorkerSupportsCancellation = true;
            // 
            // ImportConfigurationWorker
            // 
            this.ImportConfigurationWorker.WorkerReportsProgress = true;
            this.ImportConfigurationWorker.WorkerSupportsCancellation = true;
            // 
            // lblDeployTitle
            // 
            this.lblDeployTitle.AutoSize = true;
            this.lblDeployTitle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lblDeployTitle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDeployTitle.Location = new System.Drawing.Point(14, 4);
            this.lblDeployTitle.Name = "lblDeployTitle";
            this.lblDeployTitle.Size = new System.Drawing.Size(95, 17);
            this.lblDeployTitle.TabIndex = 38;
            this.lblDeployTitle.Text = "Version Name";
            // 
            // pnlWorkFlow
            // 
            this.pnlWorkFlow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWorkFlow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlWorkFlow.BorderColor = System.Drawing.Color.Black;
            this.pnlWorkFlow.BorderWidth = 1;
            this.pnlWorkFlow.Controls.Add(this.btnKillEprocess);
            this.pnlWorkFlow.Controls.Add(this.btnCheckReferences);
            this.pnlWorkFlow.Controls.Add(this.btnDeployement);
            this.pnlWorkFlow.Controls.Add(this.btnStartClient);
            this.pnlWorkFlow.Controls.Add(this.btnStartServer);
            this.pnlWorkFlow.Controls.Add(this.btnDeploy);
            this.pnlWorkFlow.Location = new System.Drawing.Point(657, 49);
            this.pnlWorkFlow.Name = "pnlWorkFlow";
            this.pnlWorkFlow.Size = new System.Drawing.Size(171, 218);
            this.pnlWorkFlow.TabIndex = 6;
            // 
            // btnKillEprocess
            // 
            this.btnKillEprocess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnKillEprocess.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnKillEprocess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKillEprocess.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnKillEprocess.ForeColor = System.Drawing.Color.Red;
            this.btnKillEprocess.Location = new System.Drawing.Point(10, 181);
            this.btnKillEprocess.Name = "btnKillEprocess";
            this.btnKillEprocess.Size = new System.Drawing.Size(151, 28);
            this.btnKillEprocess.TabIndex = 10;
            this.btnKillEprocess.Text = "关闭E10进程(K)";
            this.btnKillEprocess.UseVisualStyleBackColor = false;
            this.btnKillEprocess.Click += new System.EventHandler(this.btnKillEprocess_Click);
            // 
            // btnCheckReferences
            // 
            this.btnCheckReferences.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnCheckReferences.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnCheckReferences.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckReferences.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCheckReferences.Location = new System.Drawing.Point(10, 147);
            this.btnCheckReferences.Name = "btnCheckReferences";
            this.btnCheckReferences.Size = new System.Drawing.Size(151, 28);
            this.btnCheckReferences.TabIndex = 9;
            this.btnCheckReferences.Text = "检查引用(I)";
            this.btnCheckReferences.UseVisualStyleBackColor = false;
            this.btnCheckReferences.Click += new System.EventHandler(this.btnCheckReferences_Click);
            // 
            // btnDeployement
            // 
            this.btnDeployement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnDeployement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnDeployement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeployement.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeployement.Location = new System.Drawing.Point(10, 113);
            this.btnDeployement.Name = "btnDeployement";
            this.btnDeployement.Size = new System.Drawing.Size(151, 28);
            this.btnDeployement.TabIndex = 8;
            this.btnDeployement.Text = "部署提交资源(R)";
            this.btnDeployement.UseVisualStyleBackColor = false;
            this.btnDeployement.Click += new System.EventHandler(this.btnDeployement_Click);
            // 
            // btnStartClient
            // 
            this.btnStartClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnStartClient.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnStartClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartClient.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartClient.Location = new System.Drawing.Point(10, 79);
            this.btnStartClient.Name = "btnStartClient";
            this.btnStartClient.Size = new System.Drawing.Size(151, 28);
            this.btnStartClient.TabIndex = 7;
            this.btnStartClient.Text = "启动CLIENT(C)";
            this.btnStartClient.UseVisualStyleBackColor = false;
            this.btnStartClient.Click += new System.EventHandler(this.btnStartClient_Click);
            // 
            // btnStartServer
            // 
            this.btnStartServer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnStartServer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnStartServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartServer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStartServer.Location = new System.Drawing.Point(10, 45);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(151, 28);
            this.btnStartServer.TabIndex = 6;
            this.btnStartServer.Text = "启动SERVER(S)";
            this.btnStartServer.UseVisualStyleBackColor = false;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // btnDeploy
            // 
            this.btnDeploy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnDeploy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnDeploy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeploy.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDeploy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(180)))), ((int)(((byte)(148)))));
            this.btnDeploy.Location = new System.Drawing.Point(10, 11);
            this.btnDeploy.Name = "btnDeploy";
            this.btnDeploy.Size = new System.Drawing.Size(151, 28);
            this.btnDeploy.TabIndex = 5;
            this.btnDeploy.Text = "部署(D)";
            this.btnDeploy.UseVisualStyleBackColor = false;
            this.btnDeploy.Click += new System.EventHandler(this.btnDeploy_Click);
            // 
            // IntelligentDeployControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblDeployTitle);
            this.Controls.Add(this.tabPrinter);
            this.Controls.Add(this.pnlWorkFlow);
            this.Controls.Add(this.tabContainer);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "IntelligentDeployControl";
            this.Size = new System.Drawing.Size(842, 436);
            this.Load += new System.EventHandler(this.IntelligentDeployControl_Load);
            this.tabContainer.ResumeLayout(false);
            this.pageBaseParamsSetting.ResumeLayout(false);
            this.pageBaseParamsSetting.PerformLayout();
            this.pageComplieAndDeploy.ResumeLayout(false);
            this.tabDeployAdvancedSetting.ResumeLayout(false);
            this.pageDeployAdvancedSetting.ResumeLayout(false);
            this.pageDeployAdvancedSetting.PerformLayout();
            this.gboxDeployVersionTargets.ResumeLayout(false);
            this.gboxDeployVersionTargets.PerformLayout();
            this.pageComplieAdvancedSetting.ResumeLayout(false);
            this.pageComplieAdvancedSetting.PerformLayout();
            this.pageEnvironmentSetting.ResumeLayout(false);
            this.tabEnvrionmentSetting.ResumeLayout(false);
            this.pageE10EnvrionmentSetting.ResumeLayout(false);
            this.pageE10EnvrionmentSetting.PerformLayout();
            this.gboxParamsSetting.ResumeLayout(false);
            this.gboxParamsSetting.PerformLayout();
            this.pageJoinCMMangement.ResumeLayout(false);
            this.tabJoinCMMangement.ResumeLayout(false);
            this.pageDeployServerResources.ResumeLayout(false);
            this.pageDeployServerResources.PerformLayout();
            this.pageCMManagmenet.ResumeLayout(false);
            this.pageCMManagmenet.PerformLayout();
            this.tabPrinter.ResumeLayout(false);
            this.pageDetails.ResumeLayout(false);
            this.pnlDetailsToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceToCMSetting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceToComplie)).EndInit();
            this.pnlWorkFlow.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabContainer;
        private System.Windows.Forms.TabPage pageBaseParamsSetting;
        private System.Windows.Forms.TabPage pageComplieAndDeploy;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.TabPage pageJoinCMMangement;
        private Common.Control.ButtonEx btnDeploy;
        private Common.Control.PanelEx pnlWorkFlow;
        private Common.Control.ButtonEx btnKillEprocess;
        private Common.Control.ButtonEx btnCheckReferences;
        private Common.Control.ButtonEx btnDeployement;
        private Common.Control.ButtonEx btnStartClient;
        private Common.Control.ButtonEx btnStartServer;
        private System.Windows.Forms.TabControl tabPrinter;
        private System.Windows.Forms.TabPage pageDetails;
        private System.Windows.Forms.Panel pnlDetailsToolbar;
        private System.Windows.Forms.RichTextBox richboxPrint;
        private Common.Control.ButtonEx btnWordWarp;
        private Common.Control.ButtonEx btnView;
        private Common.Control.ButtonEx btnClear;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.LinkLabel lnkSelectExportPath;
        private System.Windows.Forms.LinkLabel lnkExportPath;
        private System.Windows.Forms.LinkLabel lnkSelectEnvironmentPath;
        private System.Windows.Forms.LinkLabel lnkEnvironmentPath;
        private System.Windows.Forms.LinkLabel lnkSelectVersion;
        private Common.Control.TextBoxEx tboxTypeKey;
        private System.Windows.Forms.Label lblTypeKey;
        private Common.Control.TextBoxEx tboxExportPath;
        private Common.Control.TextBoxEx tboxEnvironmentPath;
        private System.Windows.Forms.GroupBox gboxDeployVersionTargets;
        private System.Windows.Forms.RadioButton rdoBusinessPackage;
        private System.Windows.Forms.RadioButton rdoCustomization;
        private System.Windows.Forms.RadioButton rdoIndustry;
        private System.Windows.Forms.RadioButton rdoBase;
        private System.Windows.Forms.CheckBox cboxDeployEnUSResources;
        private System.Windows.Forms.CheckBox cboxDeployZhCHTResources;
        private System.Windows.Forms.CheckBox cboxDeployWebServer;
        private System.Windows.Forms.CheckBox cboxDeployToServer;
        private System.Windows.Forms.CheckBox cboxDeployToClient;
        private Common.Control.TextBoxEx tboxApplyciDocs;
        private System.Windows.Forms.Label lblApplyciDocs;
        private System.Windows.Forms.CheckBox cboxExcludeProgramInfo;
        private System.Windows.Forms.CheckBox cboxApplyciBeenPutInStorage;
        private System.Windows.Forms.BindingSource BindingSource;
        private System.ComponentModel.BackgroundWorker DeployWorker;
        private System.ComponentModel.BackgroundWorker DeployementWorker;
        private System.ComponentModel.BackgroundWorker CheckReferencesWorker;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Label lblTypeKeyPrompt;
        private Common.Control.TextBoxEx tboxE10Version;
        private System.Windows.Forms.Label lblE10Version;
        private System.Windows.Forms.CheckBox cboxBeforeDeployementKillEprocess;
        private System.Windows.Forms.TabControl tabDeployAdvancedSetting;
        private System.Windows.Forms.TabPage pageDeployAdvancedSetting;
        private System.Windows.Forms.TabPage pageComplieAdvancedSetting;
        private System.Windows.Forms.Label lblLocateVsDevCmdbatTitle;
        private System.Windows.Forms.Label lblLocateVsDevCmdbat;
        private System.Windows.Forms.LinkLabel lnkLocateVsDevCmdbat;
        private Common.Control.ButtonEx btnComplie;
        private Common.Control.TextBoxEx tboxComplieCommandText;
        private System.Windows.Forms.Label lblComplieCommandText;
        private System.ComponentModel.BackgroundWorker ComplieWorker;
        private System.ComponentModel.BackgroundWorker TrushpdbArchivesWorker;
        private System.Windows.Forms.TabControl tabJoinCMMangement;
        private System.Windows.Forms.TabPage pageDeployServerResources;
        private System.Windows.Forms.TabPage pageCMManagmenet;
        private Common.Control.TextBoxEx tboxCMClientParams;
        private System.Windows.Forms.Label lblCMClientParams;
        private System.Windows.Forms.LinkLabel lnkLocationCMClient;
        private System.Windows.Forms.Label lblLocationCMClient;
        private System.Windows.Forms.Label lblLocationCMClientTitle;
        private Common.Control.ButtonEx btnStartCMClient;
        private System.Windows.Forms.BindingSource BindingSourceToCMSetting;
        private System.Windows.Forms.LinkLabel lnkKillCMProcess;
        private System.ComponentModel.BackgroundWorker ExtractWorker;
        private System.ComponentModel.BackgroundWorker ImportConfigurationWorker;
        private System.Windows.Forms.BindingSource BindingSourceToComplie;
        private System.Windows.Forms.Label lblDeployTitle;
        private System.Windows.Forms.ToolTip ToolTip;
        private System.Windows.Forms.TabPage pageEnvironmentSetting;
        private System.Windows.Forms.TabControl tabEnvrionmentSetting;
        private System.Windows.Forms.TabPage pageE10EnvrionmentSetting;
        private System.Windows.Forms.TabPage pageEsClientEnvrionmentSetting;
        private System.Windows.Forms.LinkLabel lnkAccountSettingView;
        private System.Windows.Forms.LinkLabel lnkExtractRuntimeResources;
        private System.Windows.Forms.LinkLabel lnkImportConfigurationArchives;
        private System.Windows.Forms.GroupBox gboxParamsSetting;
        private System.Windows.Forms.Label lblClientParamsCustom;
        private System.Windows.Forms.ComboBox cbboxStartClientParamsType;
        private System.Windows.Forms.Label lblServerParamsCustom;
        private System.Windows.Forms.ComboBox cbboxStartServerParamsType;
        private Common.Control.TextBoxEx tboxClientParams;
        private Common.Control.TextBoxEx tboxServerParams;
        private System.Windows.Forms.Label lblClientParams;
        private System.Windows.Forms.Label lblServerParams;
        private System.Windows.Forms.CheckBox cboxAutoDeploy;
        private System.Windows.Forms.CheckBox cboxKillClientProcess;
        private System.Windows.Forms.CheckBox cboxKillEprocess;
    }
}
