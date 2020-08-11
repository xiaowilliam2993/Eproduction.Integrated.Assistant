namespace Eproduction.Integrated.Assistant.Start {
    partial class ImportConfigurationForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImportConfigurationForm));
            this.gboxTargets = new System.Windows.Forms.GroupBox();
            this.lblArchivePathPrompt6 = new System.Windows.Forms.Label();
            this.cboxIncludeBusinessPackage_dcxml = new System.Windows.Forms.CheckBox();
            this.lblArchivePathPrompt5 = new System.Windows.Forms.Label();
            this.cboxIncludeWeb_config = new System.Windows.Forms.CheckBox();
            this.lblArchivePathPrompt4 = new System.Windows.Forms.Label();
            this.cboxIncludeUpdate_config = new System.Windows.Forms.CheckBox();
            this.lblArchivePathPrompt3 = new System.Windows.Forms.Label();
            this.lblArchivePathPrompt2 = new System.Windows.Forms.Label();
            this.lblArchivePathPrompt1 = new System.Windows.Forms.Label();
            this.cboxIncludeAccountSetsConfiguration_dcxml = new System.Windows.Forms.CheckBox();
            this.cboxIncludeDefault_dcc = new System.Windows.Forms.CheckBox();
            this.cboxIncludeAutoRunClient_dcxml = new System.Windows.Forms.CheckBox();
            this.pnlFooter = new Eproduction.Integrated.Assistant.Common.Control.PanelEx();
            this.btnExit = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.btnConfirm = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.tboxSourceEnvironmentPath = new Eproduction.Integrated.Assistant.Common.Control.TextBoxEx();
            this.lnkSelectSourceEnvironmentPath = new System.Windows.Forms.LinkLabel();
            this.lnkSourceEnvironmentPath = new System.Windows.Forms.LinkLabel();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gboxTargets.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // gboxTargets
            // 
            this.gboxTargets.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxTargets.Controls.Add(this.lblArchivePathPrompt6);
            this.gboxTargets.Controls.Add(this.cboxIncludeBusinessPackage_dcxml);
            this.gboxTargets.Controls.Add(this.lblArchivePathPrompt5);
            this.gboxTargets.Controls.Add(this.cboxIncludeWeb_config);
            this.gboxTargets.Controls.Add(this.lblArchivePathPrompt4);
            this.gboxTargets.Controls.Add(this.cboxIncludeUpdate_config);
            this.gboxTargets.Controls.Add(this.lblArchivePathPrompt3);
            this.gboxTargets.Controls.Add(this.lblArchivePathPrompt2);
            this.gboxTargets.Controls.Add(this.lblArchivePathPrompt1);
            this.gboxTargets.Controls.Add(this.cboxIncludeAccountSetsConfiguration_dcxml);
            this.gboxTargets.Controls.Add(this.cboxIncludeDefault_dcc);
            this.gboxTargets.Controls.Add(this.cboxIncludeAutoRunClient_dcxml);
            this.gboxTargets.Location = new System.Drawing.Point(31, 49);
            this.gboxTargets.Name = "gboxTargets";
            this.gboxTargets.Size = new System.Drawing.Size(578, 162);
            this.gboxTargets.TabIndex = 15;
            this.gboxTargets.TabStop = false;
            this.gboxTargets.Text = "设定导入目标";
            // 
            // lblArchivePathPrompt6
            // 
            this.lblArchivePathPrompt6.AutoSize = true;
            this.lblArchivePathPrompt6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblArchivePathPrompt6.Location = new System.Drawing.Point(259, 133);
            this.lblArchivePathPrompt6.Name = "lblArchivePathPrompt6";
            this.lblArchivePathPrompt6.Size = new System.Drawing.Size(163, 17);
            this.lblArchivePathPrompt6.TabIndex = 17;
            this.lblArchivePathPrompt6.Text = "PATH={Environment_Path}\\";
            // 
            // cboxIncludeBusinessPackage_dcxml
            // 
            this.cboxIncludeBusinessPackage_dcxml.AutoSize = true;
            this.cboxIncludeBusinessPackage_dcxml.Location = new System.Drawing.Point(16, 132);
            this.cboxIncludeBusinessPackage_dcxml.Name = "cboxIncludeBusinessPackage_dcxml";
            this.cboxIncludeBusinessPackage_dcxml.Size = new System.Drawing.Size(163, 21);
            this.cboxIncludeBusinessPackage_dcxml.TabIndex = 16;
            this.cboxIncludeBusinessPackage_dcxml.Text = "BusinessPackage.dcxml";
            this.cboxIncludeBusinessPackage_dcxml.UseVisualStyleBackColor = true;
            // 
            // lblArchivePathPrompt5
            // 
            this.lblArchivePathPrompt5.AutoSize = true;
            this.lblArchivePathPrompt5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblArchivePathPrompt5.Location = new System.Drawing.Point(259, 110);
            this.lblArchivePathPrompt5.Name = "lblArchivePathPrompt5";
            this.lblArchivePathPrompt5.Size = new System.Drawing.Size(232, 17);
            this.lblArchivePathPrompt5.TabIndex = 15;
            this.lblArchivePathPrompt5.Text = "PATH={Environment_Path}\\WebServer\\";
            // 
            // cboxIncludeWeb_config
            // 
            this.cboxIncludeWeb_config.AutoSize = true;
            this.cboxIncludeWeb_config.Location = new System.Drawing.Point(16, 109);
            this.cboxIncludeWeb_config.Name = "cboxIncludeWeb_config";
            this.cboxIncludeWeb_config.Size = new System.Drawing.Size(93, 21);
            this.cboxIncludeWeb_config.TabIndex = 14;
            this.cboxIncludeWeb_config.Text = "Web.config";
            this.cboxIncludeWeb_config.UseVisualStyleBackColor = true;
            // 
            // lblArchivePathPrompt4
            // 
            this.lblArchivePathPrompt4.AutoSize = true;
            this.lblArchivePathPrompt4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblArchivePathPrompt4.Location = new System.Drawing.Point(259, 88);
            this.lblArchivePathPrompt4.Name = "lblArchivePathPrompt4";
            this.lblArchivePathPrompt4.Size = new System.Drawing.Size(292, 17);
            this.lblArchivePathPrompt4.TabIndex = 13;
            this.lblArchivePathPrompt4.Text = "PATH={Environment_Path}\\DeployServer\\Shared\\";
            // 
            // cboxIncludeUpdate_config
            // 
            this.cboxIncludeUpdate_config.AutoSize = true;
            this.cboxIncludeUpdate_config.Location = new System.Drawing.Point(16, 87);
            this.cboxIncludeUpdate_config.Name = "cboxIncludeUpdate_config";
            this.cboxIncludeUpdate_config.Size = new System.Drawing.Size(109, 21);
            this.cboxIncludeUpdate_config.TabIndex = 12;
            this.cboxIncludeUpdate_config.Text = "Update.config";
            this.cboxIncludeUpdate_config.UseVisualStyleBackColor = true;
            // 
            // lblArchivePathPrompt3
            // 
            this.lblArchivePathPrompt3.AutoSize = true;
            this.lblArchivePathPrompt3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblArchivePathPrompt3.Location = new System.Drawing.Point(259, 67);
            this.lblArchivePathPrompt3.Name = "lblArchivePathPrompt3";
            this.lblArchivePathPrompt3.Size = new System.Drawing.Size(292, 17);
            this.lblArchivePathPrompt3.TabIndex = 11;
            this.lblArchivePathPrompt3.Text = "PATH={Environment_Path}\\DeployServer\\Shared\\";
            // 
            // lblArchivePathPrompt2
            // 
            this.lblArchivePathPrompt2.AutoSize = true;
            this.lblArchivePathPrompt2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblArchivePathPrompt2.Location = new System.Drawing.Point(259, 46);
            this.lblArchivePathPrompt2.Name = "lblArchivePathPrompt2";
            this.lblArchivePathPrompt2.Size = new System.Drawing.Size(292, 17);
            this.lblArchivePathPrompt2.TabIndex = 10;
            this.lblArchivePathPrompt2.Text = "PATH={Environment_Path}\\DeployServer\\Shared\\";
            // 
            // lblArchivePathPrompt1
            // 
            this.lblArchivePathPrompt1.AutoSize = true;
            this.lblArchivePathPrompt1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblArchivePathPrompt1.Location = new System.Drawing.Point(259, 25);
            this.lblArchivePathPrompt1.Name = "lblArchivePathPrompt1";
            this.lblArchivePathPrompt1.Size = new System.Drawing.Size(253, 17);
            this.lblArchivePathPrompt1.TabIndex = 9;
            this.lblArchivePathPrompt1.Text = "PATH={Environment_Path}\\Server\\Control\\";
            // 
            // cboxIncludeAccountSetsConfiguration_dcxml
            // 
            this.cboxIncludeAccountSetsConfiguration_dcxml.AutoSize = true;
            this.cboxIncludeAccountSetsConfiguration_dcxml.Location = new System.Drawing.Point(16, 24);
            this.cboxIncludeAccountSetsConfiguration_dcxml.Name = "cboxIncludeAccountSetsConfiguration_dcxml";
            this.cboxIncludeAccountSetsConfiguration_dcxml.Size = new System.Drawing.Size(199, 21);
            this.cboxIncludeAccountSetsConfiguration_dcxml.TabIndex = 6;
            this.cboxIncludeAccountSetsConfiguration_dcxml.Text = "AccountSetsConfiguration.xml";
            this.cboxIncludeAccountSetsConfiguration_dcxml.UseVisualStyleBackColor = true;
            // 
            // cboxIncludeDefault_dcc
            // 
            this.cboxIncludeDefault_dcc.AutoSize = true;
            this.cboxIncludeDefault_dcc.Location = new System.Drawing.Point(16, 66);
            this.cboxIncludeDefault_dcc.Name = "cboxIncludeDefault_dcc";
            this.cboxIncludeDefault_dcc.Size = new System.Drawing.Size(91, 21);
            this.cboxIncludeDefault_dcc.TabIndex = 8;
            this.cboxIncludeDefault_dcc.Text = "Default.dcc";
            this.cboxIncludeDefault_dcc.UseVisualStyleBackColor = true;
            // 
            // cboxIncludeAutoRunClient_dcxml
            // 
            this.cboxIncludeAutoRunClient_dcxml.AutoSize = true;
            this.cboxIncludeAutoRunClient_dcxml.Location = new System.Drawing.Point(16, 45);
            this.cboxIncludeAutoRunClient_dcxml.Name = "cboxIncludeAutoRunClient_dcxml";
            this.cboxIncludeAutoRunClient_dcxml.Size = new System.Drawing.Size(148, 21);
            this.cboxIncludeAutoRunClient_dcxml.TabIndex = 7;
            this.cboxIncludeAutoRunClient_dcxml.Text = "AutoRun.Client.dcxml";
            this.cboxIncludeAutoRunClient_dcxml.UseVisualStyleBackColor = true;
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
            this.pnlFooter.Location = new System.Drawing.Point(-1, 230);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(640, 50);
            this.pnlFooter.TabIndex = 16;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(551, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 27);
            this.btnExit.TabIndex = 11;
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
            this.btnConfirm.Location = new System.Drawing.Point(470, 11);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 27);
            this.btnConfirm.TabIndex = 10;
            this.btnConfirm.Text = "确定(C)";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tboxSourceEnvironmentPath
            // 
            this.tboxSourceEnvironmentPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxSourceEnvironmentPath.BorderColor = System.Drawing.Color.Silver;
            this.tboxSourceEnvironmentPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxSourceEnvironmentPath.HotColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tboxSourceEnvironmentPath.Location = new System.Drawing.Point(153, 20);
            this.tboxSourceEnvironmentPath.Name = "tboxSourceEnvironmentPath";
            this.tboxSourceEnvironmentPath.Size = new System.Drawing.Size(456, 23);
            this.tboxSourceEnvironmentPath.TabIndex = 14;
            // 
            // lnkSelectSourceEnvironmentPath
            // 
            this.lnkSelectSourceEnvironmentPath.AutoSize = true;
            this.lnkSelectSourceEnvironmentPath.Location = new System.Drawing.Point(115, 23);
            this.lnkSelectSourceEnvironmentPath.Name = "lnkSelectSourceEnvironmentPath";
            this.lnkSelectSourceEnvironmentPath.Size = new System.Drawing.Size(32, 17);
            this.lnkSelectSourceEnvironmentPath.TabIndex = 13;
            this.lnkSelectSourceEnvironmentPath.TabStop = true;
            this.lnkSelectSourceEnvironmentPath.Text = "选择";
            // 
            // lnkSourceEnvironmentPath
            // 
            this.lnkSourceEnvironmentPath.AutoSize = true;
            this.lnkSourceEnvironmentPath.Location = new System.Drawing.Point(29, 23);
            this.lnkSourceEnvironmentPath.Name = "lnkSourceEnvironmentPath";
            this.lnkSourceEnvironmentPath.Size = new System.Drawing.Size(80, 17);
            this.lnkSourceEnvironmentPath.TabIndex = 12;
            this.lnkSourceEnvironmentPath.TabStop = true;
            this.lnkSourceEnvironmentPath.Text = "来源环境路径";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProvider.ContainerControl = this;
            // 
            // ImportConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 279);
            this.Controls.Add(this.gboxTargets);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.tboxSourceEnvironmentPath);
            this.Controls.Add(this.lnkSelectSourceEnvironmentPath);
            this.Controls.Add(this.lnkSourceEnvironmentPath);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ImportConfigurationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "导入配置文件";
            this.Load += new System.EventHandler(this.ImportConfigurationForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ImportConfigurationForm_KeyDown);
            this.gboxTargets.ResumeLayout(false);
            this.gboxTargets.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxTargets;
        private System.Windows.Forms.Label lblArchivePathPrompt5;
        private System.Windows.Forms.CheckBox cboxIncludeWeb_config;
        private System.Windows.Forms.Label lblArchivePathPrompt4;
        private System.Windows.Forms.CheckBox cboxIncludeUpdate_config;
        private System.Windows.Forms.Label lblArchivePathPrompt3;
        private System.Windows.Forms.Label lblArchivePathPrompt2;
        private System.Windows.Forms.Label lblArchivePathPrompt1;
        private System.Windows.Forms.CheckBox cboxIncludeAccountSetsConfiguration_dcxml;
        private System.Windows.Forms.CheckBox cboxIncludeDefault_dcc;
        private System.Windows.Forms.CheckBox cboxIncludeAutoRunClient_dcxml;
        private Common.Control.PanelEx pnlFooter;
        private Common.Control.ButtonEx btnExit;
        private Common.Control.ButtonEx btnConfirm;
        private Common.Control.TextBoxEx tboxSourceEnvironmentPath;
        private System.Windows.Forms.LinkLabel lnkSelectSourceEnvironmentPath;
        private System.Windows.Forms.LinkLabel lnkSourceEnvironmentPath;
        private System.Windows.Forms.BindingSource BindingSource;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Label lblArchivePathPrompt6;
        private System.Windows.Forms.CheckBox cboxIncludeBusinessPackage_dcxml;
    }
}