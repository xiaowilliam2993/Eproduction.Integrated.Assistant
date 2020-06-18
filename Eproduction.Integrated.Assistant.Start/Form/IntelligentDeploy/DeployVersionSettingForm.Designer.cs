namespace Eproduction.Integrated.Assistant.Start {
    partial class DeployVersionSettingForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeployVersionSettingForm));
            this.pnlEditor = new Eproduction.Integrated.Assistant.Common.Control.PanelEx();
            this.lblTypeKeyPrompt = new System.Windows.Forms.Label();
            this.tboxE10Version = new Eproduction.Integrated.Assistant.Common.Control.TextBoxEx();
            this.lblE10VersionTitle = new System.Windows.Forms.Label();
            this.tboxTypeKey = new Eproduction.Integrated.Assistant.Common.Control.TextBoxEx();
            this.tboxExportPath = new Eproduction.Integrated.Assistant.Common.Control.TextBoxEx();
            this.tboxEnvrionmentPath = new Eproduction.Integrated.Assistant.Common.Control.TextBoxEx();
            this.lblVersionName = new System.Windows.Forms.Label();
            this.lnkEditVersionName = new System.Windows.Forms.LinkLabel();
            this.lblTypeKey = new System.Windows.Forms.Label();
            this.lnkSelectExportPath = new System.Windows.Forms.LinkLabel();
            this.lnkExportPath = new System.Windows.Forms.LinkLabel();
            this.lnkSelectEnvrionmentPath = new System.Windows.Forms.LinkLabel();
            this.lnkEnvrionmentPath = new System.Windows.Forms.LinkLabel();
            this.lblVersionNameTitle = new System.Windows.Forms.Label();
            this.pnlVersionList = new Eproduction.Integrated.Assistant.Common.Control.PanelEx();
            this.pnlFooter = new Eproduction.Integrated.Assistant.Common.Control.PanelEx();
            this.btnExit = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.btnConfirm = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbtnCreate = new System.Windows.Forms.ToolStripButton();
            this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlEditor.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlEditor
            // 
            this.pnlEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlEditor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(235)))), ((int)(((byte)(235)))));
            this.pnlEditor.BorderColor = System.Drawing.Color.Black;
            this.pnlEditor.BorderWidth = 1;
            this.pnlEditor.Controls.Add(this.lblTypeKeyPrompt);
            this.pnlEditor.Controls.Add(this.tboxE10Version);
            this.pnlEditor.Controls.Add(this.lblE10VersionTitle);
            this.pnlEditor.Controls.Add(this.tboxTypeKey);
            this.pnlEditor.Controls.Add(this.tboxExportPath);
            this.pnlEditor.Controls.Add(this.tboxEnvrionmentPath);
            this.pnlEditor.Controls.Add(this.lblVersionName);
            this.pnlEditor.Controls.Add(this.lnkEditVersionName);
            this.pnlEditor.Controls.Add(this.lblTypeKey);
            this.pnlEditor.Controls.Add(this.lnkSelectExportPath);
            this.pnlEditor.Controls.Add(this.lnkExportPath);
            this.pnlEditor.Controls.Add(this.lnkSelectEnvrionmentPath);
            this.pnlEditor.Controls.Add(this.lnkEnvrionmentPath);
            this.pnlEditor.Controls.Add(this.lblVersionNameTitle);
            this.pnlEditor.Location = new System.Drawing.Point(12, 34);
            this.pnlEditor.Name = "pnlEditor";
            this.pnlEditor.Size = new System.Drawing.Size(479, 234);
            this.pnlEditor.TabIndex = 0;
            // 
            // lblTypeKeyPrompt
            // 
            this.lblTypeKeyPrompt.AutoSize = true;
            this.lblTypeKeyPrompt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTypeKeyPrompt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTypeKeyPrompt.Location = new System.Drawing.Point(138, 125);
            this.lblTypeKeyPrompt.Name = "lblTypeKeyPrompt";
            this.lblTypeKeyPrompt.Size = new System.Drawing.Size(200, 17);
            this.lblTypeKeyPrompt.TabIndex = 13;
            this.lblTypeKeyPrompt.Text = "（多个TypeKey之间用逗号[,]连接）";
            // 
            // tboxE10Version
            // 
            this.tboxE10Version.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxE10Version.BorderColor = System.Drawing.Color.Silver;
            this.tboxE10Version.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxE10Version.HotColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tboxE10Version.Location = new System.Drawing.Point(148, 148);
            this.tboxE10Version.Name = "tboxE10Version";
            this.tboxE10Version.Size = new System.Drawing.Size(302, 23);
            this.tboxE10Version.TabIndex = 12;
            // 
            // lblE10VersionTitle
            // 
            this.lblE10VersionTitle.AutoSize = true;
            this.lblE10VersionTitle.Location = new System.Drawing.Point(14, 150);
            this.lblE10VersionTitle.Name = "lblE10VersionTitle";
            this.lblE10VersionTitle.Size = new System.Drawing.Size(77, 17);
            this.lblE10VersionTitle.TabIndex = 11;
            this.lblE10VersionTitle.Text = "E10版本名称";
            // 
            // tboxTypeKey
            // 
            this.tboxTypeKey.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxTypeKey.BorderColor = System.Drawing.Color.Silver;
            this.tboxTypeKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxTypeKey.HotColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tboxTypeKey.Location = new System.Drawing.Point(148, 98);
            this.tboxTypeKey.Name = "tboxTypeKey";
            this.tboxTypeKey.Size = new System.Drawing.Size(302, 23);
            this.tboxTypeKey.TabIndex = 10;
            // 
            // tboxExportPath
            // 
            this.tboxExportPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxExportPath.BorderColor = System.Drawing.Color.Silver;
            this.tboxExportPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxExportPath.HotColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tboxExportPath.Location = new System.Drawing.Point(148, 71);
            this.tboxExportPath.Name = "tboxExportPath";
            this.tboxExportPath.Size = new System.Drawing.Size(302, 23);
            this.tboxExportPath.TabIndex = 8;
            // 
            // tboxEnvrionmentPath
            // 
            this.tboxEnvrionmentPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxEnvrionmentPath.BorderColor = System.Drawing.Color.Silver;
            this.tboxEnvrionmentPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxEnvrionmentPath.HotColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tboxEnvrionmentPath.Location = new System.Drawing.Point(148, 44);
            this.tboxEnvrionmentPath.Name = "tboxEnvrionmentPath";
            this.tboxEnvrionmentPath.Size = new System.Drawing.Size(302, 23);
            this.tboxEnvrionmentPath.TabIndex = 5;
            // 
            // lblVersionName
            // 
            this.lblVersionName.AutoSize = true;
            this.lblVersionName.Location = new System.Drawing.Point(145, 20);
            this.lblVersionName.Name = "lblVersionName";
            this.lblVersionName.Size = new System.Drawing.Size(44, 17);
            this.lblVersionName.TabIndex = 2;
            this.lblVersionName.Text = "（空）";
            // 
            // lnkEditVersionName
            // 
            this.lnkEditVersionName.AutoSize = true;
            this.lnkEditVersionName.Location = new System.Drawing.Point(98, 20);
            this.lnkEditVersionName.Name = "lnkEditVersionName";
            this.lnkEditVersionName.Size = new System.Drawing.Size(32, 17);
            this.lnkEditVersionName.TabIndex = 1;
            this.lnkEditVersionName.TabStop = true;
            this.lnkEditVersionName.Text = "编辑";
            this.lnkEditVersionName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTypeKey
            // 
            this.lblTypeKey.AutoSize = true;
            this.lblTypeKey.Location = new System.Drawing.Point(34, 100);
            this.lblTypeKey.Name = "lblTypeKey";
            this.lblTypeKey.Size = new System.Drawing.Size(57, 17);
            this.lblTypeKey.TabIndex = 9;
            this.lblTypeKey.Text = "TypeKey";
            // 
            // lnkSelectExportPath
            // 
            this.lnkSelectExportPath.AutoSize = true;
            this.lnkSelectExportPath.Location = new System.Drawing.Point(98, 73);
            this.lnkSelectExportPath.Name = "lnkSelectExportPath";
            this.lnkSelectExportPath.Size = new System.Drawing.Size(32, 17);
            this.lnkSelectExportPath.TabIndex = 5;
            this.lnkSelectExportPath.TabStop = true;
            this.lnkSelectExportPath.Text = "选择";
            this.lnkSelectExportPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lnkExportPath
            // 
            this.lnkExportPath.AutoSize = true;
            this.lnkExportPath.Location = new System.Drawing.Point(21, 73);
            this.lnkExportPath.Name = "lnkExportPath";
            this.lnkExportPath.Size = new System.Drawing.Size(70, 17);
            this.lnkExportPath.TabIndex = 5;
            this.lnkExportPath.TabStop = true;
            this.lnkExportPath.Text = "Export路径";
            this.lnkExportPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lnkSelectEnvrionmentPath
            // 
            this.lnkSelectEnvrionmentPath.AutoSize = true;
            this.lnkSelectEnvrionmentPath.Location = new System.Drawing.Point(98, 46);
            this.lnkSelectEnvrionmentPath.Name = "lnkSelectEnvrionmentPath";
            this.lnkSelectEnvrionmentPath.Size = new System.Drawing.Size(32, 17);
            this.lnkSelectEnvrionmentPath.TabIndex = 4;
            this.lnkSelectEnvrionmentPath.TabStop = true;
            this.lnkSelectEnvrionmentPath.Text = "选择";
            this.lnkSelectEnvrionmentPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lnkEnvrionmentPath
            // 
            this.lnkEnvrionmentPath.AutoSize = true;
            this.lnkEnvrionmentPath.Location = new System.Drawing.Point(35, 46);
            this.lnkEnvrionmentPath.Name = "lnkEnvrionmentPath";
            this.lnkEnvrionmentPath.Size = new System.Drawing.Size(56, 17);
            this.lnkEnvrionmentPath.TabIndex = 3;
            this.lnkEnvrionmentPath.TabStop = true;
            this.lnkEnvrionmentPath.Text = "环境路径";
            this.lnkEnvrionmentPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVersionNameTitle
            // 
            this.lblVersionNameTitle.AutoSize = true;
            this.lblVersionNameTitle.Location = new System.Drawing.Point(35, 20);
            this.lblVersionNameTitle.Name = "lblVersionNameTitle";
            this.lblVersionNameTitle.Size = new System.Drawing.Size(56, 17);
            this.lblVersionNameTitle.TabIndex = 0;
            this.lblVersionNameTitle.Text = "版本名称";
            // 
            // pnlVersionList
            // 
            this.pnlVersionList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlVersionList.AutoScroll = true;
            this.pnlVersionList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnlVersionList.BorderColor = System.Drawing.Color.Black;
            this.pnlVersionList.BorderWidth = 1;
            this.pnlVersionList.Location = new System.Drawing.Point(497, 34);
            this.pnlVersionList.Name = "pnlVersionList";
            this.pnlVersionList.Size = new System.Drawing.Size(236, 234);
            this.pnlVersionList.TabIndex = 1;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFooter.BorderColor = System.Drawing.Color.Silver;
            this.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFooter.BorderWidth = 1;
            this.pnlFooter.Controls.Add(this.btnExit);
            this.pnlFooter.Controls.Add(this.btnConfirm);
            this.pnlFooter.Location = new System.Drawing.Point(-1, 274);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(747, 50);
            this.pnlFooter.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(658, 10);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 27);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "退出(E)";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConfirm.Location = new System.Drawing.Point(518, 10);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(134, 27);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "确定，带回选中项(C)";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnCreate,
            this.tsbtnDelete});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(745, 25);
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsbtnCreate
            // 
            this.tsbtnCreate.Image = global::Eproduction.Integrated.Assistant.Start.Properties.Resources.plus;
            this.tsbtnCreate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnCreate.Name = "tsbtnCreate";
            this.tsbtnCreate.Size = new System.Drawing.Size(52, 22);
            this.tsbtnCreate.Text = "创建";
            this.tsbtnCreate.Click += new System.EventHandler(this.tsbtnCreate_Click);
            // 
            // tsbtnDelete
            // 
            this.tsbtnDelete.Image = global::Eproduction.Integrated.Assistant.Start.Properties.Resources.trush;
            this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnDelete.Name = "tsbtnDelete";
            this.tsbtnDelete.Size = new System.Drawing.Size(52, 22);
            this.tsbtnDelete.Text = "删除";
            this.tsbtnDelete.Click += new System.EventHandler(this.tsbtnDelete_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProvider.ContainerControl = this;
            this.ErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProvider.Icon")));
            // 
            // DeployVersionSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 323);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.pnlVersionList);
            this.Controls.Add(this.pnlEditor);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "DeployVersionSettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "维护部署版本信息";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DeployVersionSettingForm_FormClosed);
            this.Load += new System.EventHandler(this.DeployVersionSettingForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DeployVersionSettingForm_KeyDown);
            this.pnlEditor.ResumeLayout(false);
            this.pnlEditor.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Common.Control.PanelEx pnlEditor;
        private Common.Control.PanelEx pnlVersionList;
        private Common.Control.PanelEx pnlFooter;
        private Common.Control.TextBoxEx tboxTypeKey;
        private Common.Control.TextBoxEx tboxExportPath;
        private Common.Control.TextBoxEx tboxEnvrionmentPath;
        private System.Windows.Forms.Label lblVersionName;
        private System.Windows.Forms.LinkLabel lnkEditVersionName;
        private System.Windows.Forms.Label lblTypeKey;
        private System.Windows.Forms.LinkLabel lnkSelectExportPath;
        private System.Windows.Forms.LinkLabel lnkExportPath;
        private System.Windows.Forms.LinkLabel lnkSelectEnvrionmentPath;
        private System.Windows.Forms.LinkLabel lnkEnvrionmentPath;
        private System.Windows.Forms.Label lblVersionNameTitle;
        private Common.Control.ButtonEx btnExit;
        private Common.Control.ButtonEx btnConfirm;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbtnCreate;
        private System.Windows.Forms.BindingSource BindingSource;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private Common.Control.TextBoxEx tboxE10Version;
        private System.Windows.Forms.Label lblE10VersionTitle;
        private System.Windows.Forms.Label lblTypeKeyPrompt;
    }
}