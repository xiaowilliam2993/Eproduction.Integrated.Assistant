namespace Eproduction.Integrated.Assistant.Start {
    partial class ExtractRuntimeResourcesForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtractRuntimeResourcesForm));
            this.lblTypeKey = new System.Windows.Forms.Label();
            this.tboxTypeKey = new Eproduction.Integrated.Assistant.Common.Control.TextBoxEx();
            this.lnkOutputPath = new System.Windows.Forms.LinkLabel();
            this.lnkSelectOutputPath = new System.Windows.Forms.LinkLabel();
            this.tboxOutputPath = new Eproduction.Integrated.Assistant.Common.Control.TextBoxEx();
            this.cboxIncludeDllResources = new System.Windows.Forms.CheckBox();
            this.cboxIncludeConfigurationResources = new System.Windows.Forms.CheckBox();
            this.pnlFooter = new Eproduction.Integrated.Assistant.Common.Control.PanelEx();
            this.btnExit = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.btnConfirm = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.cboxIncludeProgramInfoResources = new System.Windows.Forms.CheckBox();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gboxTargets = new System.Windows.Forms.GroupBox();
            this.lblTypeKeyPrompt = new System.Windows.Forms.Label();
            this.gboxDeployVersionTargets = new System.Windows.Forms.GroupBox();
            this.rdoCustomization = new System.Windows.Forms.RadioButton();
            this.rdoIndustry = new System.Windows.Forms.RadioButton();
            this.rdoBase = new System.Windows.Forms.RadioButton();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.gboxTargets.SuspendLayout();
            this.gboxDeployVersionTargets.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTypeKey
            // 
            this.lblTypeKey.AutoSize = true;
            this.lblTypeKey.Location = new System.Drawing.Point(28, 24);
            this.lblTypeKey.Name = "lblTypeKey";
            this.lblTypeKey.Size = new System.Drawing.Size(57, 17);
            this.lblTypeKey.TabIndex = 0;
            this.lblTypeKey.Text = "TypeKey";
            // 
            // tboxTypeKey
            // 
            this.tboxTypeKey.BorderColor = System.Drawing.Color.Silver;
            this.tboxTypeKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxTypeKey.HotColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tboxTypeKey.Location = new System.Drawing.Point(133, 22);
            this.tboxTypeKey.Name = "tboxTypeKey";
            this.tboxTypeKey.Size = new System.Drawing.Size(448, 23);
            this.tboxTypeKey.TabIndex = 1;
            // 
            // lnkOutputPath
            // 
            this.lnkOutputPath.AutoSize = true;
            this.lnkOutputPath.Location = new System.Drawing.Point(29, 71);
            this.lnkOutputPath.Name = "lnkOutputPath";
            this.lnkOutputPath.Size = new System.Drawing.Size(56, 17);
            this.lnkOutputPath.TabIndex = 3;
            this.lnkOutputPath.TabStop = true;
            this.lnkOutputPath.Text = "输出路径";
            // 
            // lnkSelectOutputPath
            // 
            this.lnkSelectOutputPath.AutoSize = true;
            this.lnkSelectOutputPath.Location = new System.Drawing.Point(91, 71);
            this.lnkSelectOutputPath.Name = "lnkSelectOutputPath";
            this.lnkSelectOutputPath.Size = new System.Drawing.Size(32, 17);
            this.lnkSelectOutputPath.TabIndex = 4;
            this.lnkSelectOutputPath.TabStop = true;
            this.lnkSelectOutputPath.Text = "选择";
            // 
            // tboxOutputPath
            // 
            this.tboxOutputPath.BorderColor = System.Drawing.Color.Silver;
            this.tboxOutputPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxOutputPath.HotColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tboxOutputPath.Location = new System.Drawing.Point(133, 68);
            this.tboxOutputPath.Name = "tboxOutputPath";
            this.tboxOutputPath.Size = new System.Drawing.Size(448, 23);
            this.tboxOutputPath.TabIndex = 5;
            // 
            // cboxIncludeDllResources
            // 
            this.cboxIncludeDllResources.AutoSize = true;
            this.cboxIncludeDllResources.Location = new System.Drawing.Point(16, 24);
            this.cboxIncludeDllResources.Name = "cboxIncludeDllResources";
            this.cboxIncludeDllResources.Size = new System.Drawing.Size(97, 21);
            this.cboxIncludeDllResources.TabIndex = 11;
            this.cboxIncludeDllResources.Text = "提取*.dll资源";
            this.cboxIncludeDllResources.UseVisualStyleBackColor = true;
            // 
            // cboxIncludeConfigurationResources
            // 
            this.cboxIncludeConfigurationResources.AutoSize = true;
            this.cboxIncludeConfigurationResources.Location = new System.Drawing.Point(16, 45);
            this.cboxIncludeConfigurationResources.Name = "cboxIncludeConfigurationResources";
            this.cboxIncludeConfigurationResources.Size = new System.Drawing.Size(99, 21);
            this.cboxIncludeConfigurationResources.TabIndex = 12;
            this.cboxIncludeConfigurationResources.Text = "提取配置资源";
            this.cboxIncludeConfigurationResources.UseVisualStyleBackColor = true;
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
            this.pnlFooter.Location = new System.Drawing.Point(-1, 275);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(612, 50);
            this.pnlFooter.TabIndex = 14;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(523, 11);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 27);
            this.btnExit.TabIndex = 16;
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
            this.btnConfirm.Location = new System.Drawing.Point(442, 11);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 27);
            this.btnConfirm.TabIndex = 15;
            this.btnConfirm.Text = "确定(C)";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cboxIncludeProgramInfoResources
            // 
            this.cboxIncludeProgramInfoResources.AutoSize = true;
            this.cboxIncludeProgramInfoResources.Location = new System.Drawing.Point(16, 66);
            this.cboxIncludeProgramInfoResources.Name = "cboxIncludeProgramInfoResources";
            this.cboxIncludeProgramInfoResources.Size = new System.Drawing.Size(251, 21);
            this.cboxIncludeProgramInfoResources.TabIndex = 13;
            this.cboxIncludeProgramInfoResources.Text = "包含ProgramInfoContainerElement资源";
            this.cboxIncludeProgramInfoResources.UseVisualStyleBackColor = true;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProvider.ContainerControl = this;
            this.ErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProvider.Icon")));
            // 
            // gboxTargets
            // 
            this.gboxTargets.Controls.Add(this.cboxIncludeDllResources);
            this.gboxTargets.Controls.Add(this.cboxIncludeProgramInfoResources);
            this.gboxTargets.Controls.Add(this.cboxIncludeConfigurationResources);
            this.gboxTargets.Location = new System.Drawing.Point(32, 154);
            this.gboxTargets.Name = "gboxTargets";
            this.gboxTargets.Size = new System.Drawing.Size(549, 99);
            this.gboxTargets.TabIndex = 10;
            this.gboxTargets.TabStop = false;
            this.gboxTargets.Text = "设定提取目标";
            // 
            // lblTypeKeyPrompt
            // 
            this.lblTypeKeyPrompt.AutoSize = true;
            this.lblTypeKeyPrompt.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTypeKeyPrompt.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblTypeKeyPrompt.Location = new System.Drawing.Point(130, 48);
            this.lblTypeKeyPrompt.Name = "lblTypeKeyPrompt";
            this.lblTypeKeyPrompt.Size = new System.Drawing.Size(200, 17);
            this.lblTypeKeyPrompt.TabIndex = 2;
            this.lblTypeKeyPrompt.Text = "（多个TypeKey之间用逗号[,]连接）";
            // 
            // gboxDeployVersionTargets
            // 
            this.gboxDeployVersionTargets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxDeployVersionTargets.Controls.Add(this.rdoCustomization);
            this.gboxDeployVersionTargets.Controls.Add(this.rdoIndustry);
            this.gboxDeployVersionTargets.Controls.Add(this.rdoBase);
            this.gboxDeployVersionTargets.Location = new System.Drawing.Point(31, 97);
            this.gboxDeployVersionTargets.Name = "gboxDeployVersionTargets";
            this.gboxDeployVersionTargets.Size = new System.Drawing.Size(550, 51);
            this.gboxDeployVersionTargets.TabIndex = 6;
            this.gboxDeployVersionTargets.TabStop = false;
            this.gboxDeployVersionTargets.Text = "版本性质设定";
            // 
            // rdoCustomization
            // 
            this.rdoCustomization.AutoSize = true;
            this.rdoCustomization.Location = new System.Drawing.Point(179, 20);
            this.rdoCustomization.Name = "rdoCustomization";
            this.rdoCustomization.Size = new System.Drawing.Size(62, 21);
            this.rdoCustomization.TabIndex = 9;
            this.rdoCustomization.TabStop = true;
            this.rdoCustomization.Tag = "2";
            this.rdoCustomization.Text = "个案包";
            this.rdoCustomization.UseVisualStyleBackColor = true;
            // 
            // rdoIndustry
            // 
            this.rdoIndustry.AutoSize = true;
            this.rdoIndustry.Location = new System.Drawing.Point(97, 20);
            this.rdoIndustry.Name = "rdoIndustry";
            this.rdoIndustry.Size = new System.Drawing.Size(62, 21);
            this.rdoIndustry.TabIndex = 8;
            this.rdoIndustry.TabStop = true;
            this.rdoIndustry.Tag = "1";
            this.rdoIndustry.Text = "行业版";
            this.rdoIndustry.UseVisualStyleBackColor = true;
            // 
            // rdoBase
            // 
            this.rdoBase.AutoSize = true;
            this.rdoBase.Location = new System.Drawing.Point(24, 20);
            this.rdoBase.Name = "rdoBase";
            this.rdoBase.Size = new System.Drawing.Size(50, 21);
            this.rdoBase.TabIndex = 7;
            this.rdoBase.TabStop = true;
            this.rdoBase.Tag = "0";
            this.rdoBase.Text = "基版";
            this.rdoBase.UseVisualStyleBackColor = true;
            // 
            // ExtractRuntimeResourcesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 324);
            this.Controls.Add(this.gboxDeployVersionTargets);
            this.Controls.Add(this.lblTypeKeyPrompt);
            this.Controls.Add(this.gboxTargets);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.tboxOutputPath);
            this.Controls.Add(this.lnkSelectOutputPath);
            this.Controls.Add(this.lnkOutputPath);
            this.Controls.Add(this.tboxTypeKey);
            this.Controls.Add(this.lblTypeKey);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExtractRuntimeResourcesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "提取TypeKey运行文件";
            this.Load += new System.EventHandler(this.ExtractRuntimeResourcesForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExtractRuntimeResourcesForm_KeyDown);
            this.pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.gboxTargets.ResumeLayout(false);
            this.gboxTargets.PerformLayout();
            this.gboxDeployVersionTargets.ResumeLayout(false);
            this.gboxDeployVersionTargets.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTypeKey;
        private Common.Control.TextBoxEx tboxTypeKey;
        private System.Windows.Forms.LinkLabel lnkOutputPath;
        private System.Windows.Forms.LinkLabel lnkSelectOutputPath;
        private Common.Control.TextBoxEx tboxOutputPath;
        private System.Windows.Forms.CheckBox cboxIncludeDllResources;
        private System.Windows.Forms.CheckBox cboxIncludeConfigurationResources;
        private Common.Control.PanelEx pnlFooter;
        private Common.Control.ButtonEx btnExit;
        private Common.Control.ButtonEx btnConfirm;
        private System.Windows.Forms.CheckBox cboxIncludeProgramInfoResources;
        private System.Windows.Forms.BindingSource BindingSource;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.GroupBox gboxTargets;
        private System.Windows.Forms.Label lblTypeKeyPrompt;
        private System.Windows.Forms.GroupBox gboxDeployVersionTargets;
        private System.Windows.Forms.RadioButton rdoCustomization;
        private System.Windows.Forms.RadioButton rdoIndustry;
        private System.Windows.Forms.RadioButton rdoBase;
    }
}