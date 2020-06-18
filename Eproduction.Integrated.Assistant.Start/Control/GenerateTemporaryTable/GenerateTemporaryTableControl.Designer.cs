namespace Eproduction.Integrated.Assistant.Start.Control {
    partial class GenerateTemporaryTableControl {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateTemporaryTableControl));
            this.tabContainer = new System.Windows.Forms.TabControl();
            this.pageBaseParamsSetting = new System.Windows.Forms.TabPage();
            this.lnkStandardExample = new System.Windows.Forms.LinkLabel();
            this.cboxFirstPropertyGeneratePrimaryKey = new System.Windows.Forms.CheckBox();
            this.cboxGenerateRemark = new System.Windows.Forms.CheckBox();
            this.cboxGenerateFunctionHeader = new System.Windows.Forms.CheckBox();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.pnlWorkFlow = new Eproduction.Integrated.Assistant.Common.Control.PanelEx();
            this.btnGenerate = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.richboxSpecification = new System.Windows.Forms.RichTextBox();
            this.pnlSpecificationLineNo = new System.Windows.Forms.Panel();
            this.lblSpecification = new System.Windows.Forms.Label();
            this.pnlSourcesToolbar = new System.Windows.Forms.Panel();
            this.btnCopy = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.btnView = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.btnClear = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.btnWordWarp = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.richboxSources = new System.Windows.Forms.RichTextBox();
            this.pnlSourcesLineNo = new System.Windows.Forms.Panel();
            this.lblSources = new System.Windows.Forms.Label();
            this.GenerateWorker = new System.ComponentModel.BackgroundWorker();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabContainer.SuspendLayout();
            this.pageBaseParamsSetting.SuspendLayout();
            this.pnlWorkFlow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.pnlSourcesToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabContainer
            // 
            this.tabContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabContainer.Controls.Add(this.pageBaseParamsSetting);
            this.tabContainer.ImageList = this.ImageList;
            this.tabContainer.Location = new System.Drawing.Point(13, 12);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.SelectedIndex = 0;
            this.tabContainer.Size = new System.Drawing.Size(638, 117);
            this.tabContainer.TabIndex = 0;
            // 
            // pageBaseParamsSetting
            // 
            this.pageBaseParamsSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pageBaseParamsSetting.Controls.Add(this.lnkStandardExample);
            this.pageBaseParamsSetting.Controls.Add(this.cboxFirstPropertyGeneratePrimaryKey);
            this.pageBaseParamsSetting.Controls.Add(this.cboxGenerateRemark);
            this.pageBaseParamsSetting.Controls.Add(this.cboxGenerateFunctionHeader);
            this.pageBaseParamsSetting.ImageKey = "params.png";
            this.pageBaseParamsSetting.Location = new System.Drawing.Point(4, 26);
            this.pageBaseParamsSetting.Name = "pageBaseParamsSetting";
            this.pageBaseParamsSetting.Padding = new System.Windows.Forms.Padding(3);
            this.pageBaseParamsSetting.Size = new System.Drawing.Size(630, 87);
            this.pageBaseParamsSetting.TabIndex = 0;
            this.pageBaseParamsSetting.Text = "基本选项";
            // 
            // lnkStandardExample
            // 
            this.lnkStandardExample.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkStandardExample.AutoSize = true;
            this.lnkStandardExample.Location = new System.Drawing.Point(558, 13);
            this.lnkStandardExample.Name = "lnkStandardExample";
            this.lnkStandardExample.Size = new System.Drawing.Size(56, 17);
            this.lnkStandardExample.TabIndex = 3;
            this.lnkStandardExample.TabStop = true;
            this.lnkStandardExample.Text = "参考范例";
            this.lnkStandardExample.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkStandardExample_LinkClicked);
            // 
            // cboxFirstPropertyGeneratePrimaryKey
            // 
            this.cboxFirstPropertyGeneratePrimaryKey.AutoSize = true;
            this.cboxFirstPropertyGeneratePrimaryKey.Location = new System.Drawing.Point(12, 54);
            this.cboxFirstPropertyGeneratePrimaryKey.Name = "cboxFirstPropertyGeneratePrimaryKey";
            this.cboxFirstPropertyGeneratePrimaryKey.Size = new System.Drawing.Size(159, 21);
            this.cboxFirstPropertyGeneratePrimaryKey.TabIndex = 2;
            this.cboxFirstPropertyGeneratePrimaryKey.Text = "将第一个属性设置为主键";
            this.cboxFirstPropertyGeneratePrimaryKey.UseVisualStyleBackColor = true;
            // 
            // cboxGenerateRemark
            // 
            this.cboxGenerateRemark.AutoSize = true;
            this.cboxGenerateRemark.Location = new System.Drawing.Point(12, 33);
            this.cboxGenerateRemark.Name = "cboxGenerateRemark";
            this.cboxGenerateRemark.Size = new System.Drawing.Size(75, 21);
            this.cboxGenerateRemark.TabIndex = 1;
            this.cboxGenerateRemark.Text = "生成注释";
            this.cboxGenerateRemark.UseVisualStyleBackColor = true;
            // 
            // cboxGenerateFunctionHeader
            // 
            this.cboxGenerateFunctionHeader.AutoSize = true;
            this.cboxGenerateFunctionHeader.Location = new System.Drawing.Point(12, 12);
            this.cboxGenerateFunctionHeader.Name = "cboxGenerateFunctionHeader";
            this.cboxGenerateFunctionHeader.Size = new System.Drawing.Size(87, 21);
            this.cboxGenerateFunctionHeader.TabIndex = 0;
            this.cboxGenerateFunctionHeader.Text = "生成方法头";
            this.cboxGenerateFunctionHeader.UseVisualStyleBackColor = true;
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "params.png");
            // 
            // pnlWorkFlow
            // 
            this.pnlWorkFlow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWorkFlow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlWorkFlow.BorderColor = System.Drawing.Color.Black;
            this.pnlWorkFlow.BorderWidth = 1;
            this.pnlWorkFlow.Controls.Add(this.btnGenerate);
            this.pnlWorkFlow.Location = new System.Drawing.Point(657, 37);
            this.pnlWorkFlow.Name = "pnlWorkFlow";
            this.pnlWorkFlow.Size = new System.Drawing.Size(171, 90);
            this.pnlWorkFlow.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnGenerate.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGenerate.Location = new System.Drawing.Point(10, 9);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(151, 28);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "生成(G)";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // SplitContainer
            // 
            this.SplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SplitContainer.Location = new System.Drawing.Point(13, 131);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SplitContainer.Panel1.Controls.Add(this.richboxSpecification);
            this.SplitContainer.Panel1.Controls.Add(this.pnlSpecificationLineNo);
            this.SplitContainer.Panel1.Controls.Add(this.lblSpecification);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.SplitContainer.Panel2.Controls.Add(this.pnlSourcesToolbar);
            this.SplitContainer.Panel2.Controls.Add(this.richboxSources);
            this.SplitContainer.Panel2.Controls.Add(this.pnlSourcesLineNo);
            this.SplitContainer.Panel2.Controls.Add(this.lblSources);
            this.SplitContainer.Size = new System.Drawing.Size(815, 321);
            this.SplitContainer.SplitterDistance = 392;
            this.SplitContainer.TabIndex = 2;
            // 
            // richboxSpecification
            // 
            this.richboxSpecification.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richboxSpecification.BackColor = System.Drawing.Color.Gainsboro;
            this.richboxSpecification.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richboxSpecification.EnableAutoDragDrop = true;
            this.richboxSpecification.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richboxSpecification.HideSelection = false;
            this.richboxSpecification.Location = new System.Drawing.Point(40, 30);
            this.richboxSpecification.Name = "richboxSpecification";
            this.richboxSpecification.Size = new System.Drawing.Size(349, 288);
            this.richboxSpecification.TabIndex = 4;
            this.richboxSpecification.Text = "";
            this.richboxSpecification.WordWrap = false;
            // 
            // pnlSpecificationLineNo
            // 
            this.pnlSpecificationLineNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSpecificationLineNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlSpecificationLineNo.Location = new System.Drawing.Point(4, 30);
            this.pnlSpecificationLineNo.Name = "pnlSpecificationLineNo";
            this.pnlSpecificationLineNo.Size = new System.Drawing.Size(35, 288);
            this.pnlSpecificationLineNo.TabIndex = 3;
            // 
            // lblSpecification
            // 
            this.lblSpecification.AutoSize = true;
            this.lblSpecification.Image = global::Eproduction.Integrated.Assistant.Start.Properties.Resources.specification;
            this.lblSpecification.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSpecification.Location = new System.Drawing.Point(37, 10);
            this.lblSpecification.Name = "lblSpecification";
            this.lblSpecification.Size = new System.Drawing.Size(64, 17);
            this.lblSpecification.TabIndex = 0;
            this.lblSpecification.Text = "     规格源";
            // 
            // pnlSourcesToolbar
            // 
            this.pnlSourcesToolbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSourcesToolbar.BackColor = System.Drawing.Color.Transparent;
            this.pnlSourcesToolbar.Controls.Add(this.btnCopy);
            this.pnlSourcesToolbar.Controls.Add(this.btnView);
            this.pnlSourcesToolbar.Controls.Add(this.btnClear);
            this.pnlSourcesToolbar.Controls.Add(this.btnWordWarp);
            this.pnlSourcesToolbar.Location = new System.Drawing.Point(178, 2);
            this.pnlSourcesToolbar.Name = "pnlSourcesToolbar";
            this.pnlSourcesToolbar.Size = new System.Drawing.Size(239, 27);
            this.pnlSourcesToolbar.TabIndex = 18;
            this.pnlSourcesToolbar.Visible = false;
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnCopy.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCopy.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCopy.Image = global::Eproduction.Integrated.Assistant.Start.Properties.Resources.copy;
            this.btnCopy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCopy.Location = new System.Drawing.Point(1, 1);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(59, 25);
            this.btnCopy.TabIndex = 14;
            this.btnCopy.Text = "    复制";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnView.Image = global::Eproduction.Integrated.Assistant.Start.Properties.Resources.view;
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(178, 1);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(59, 25);
            this.btnView.TabIndex = 13;
            this.btnView.Text = "    检视";
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
            this.btnClear.Location = new System.Drawing.Point(119, 1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(59, 25);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "    清理";
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
            this.btnWordWarp.Location = new System.Drawing.Point(60, 1);
            this.btnWordWarp.Name = "btnWordWarp";
            this.btnWordWarp.Size = new System.Drawing.Size(59, 25);
            this.btnWordWarp.TabIndex = 11;
            this.btnWordWarp.Text = "    换行";
            this.btnWordWarp.UseVisualStyleBackColor = false;
            this.btnWordWarp.Click += new System.EventHandler(this.btnWordWarp_Click);
            // 
            // richboxSources
            // 
            this.richboxSources.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richboxSources.BackColor = System.Drawing.Color.Gainsboro;
            this.richboxSources.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richboxSources.EnableAutoDragDrop = true;
            this.richboxSources.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richboxSources.HideSelection = false;
            this.richboxSources.Location = new System.Drawing.Point(39, 30);
            this.richboxSources.Name = "richboxSources";
            this.richboxSources.Size = new System.Drawing.Size(377, 288);
            this.richboxSources.TabIndex = 6;
            this.richboxSources.Text = "";
            this.richboxSources.WordWrap = false;
            // 
            // pnlSourcesLineNo
            // 
            this.pnlSourcesLineNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSourcesLineNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlSourcesLineNo.Location = new System.Drawing.Point(4, 28);
            this.pnlSourcesLineNo.Name = "pnlSourcesLineNo";
            this.pnlSourcesLineNo.Size = new System.Drawing.Size(35, 290);
            this.pnlSourcesLineNo.TabIndex = 5;
            // 
            // lblSources
            // 
            this.lblSources.AutoSize = true;
            this.lblSources.Image = global::Eproduction.Integrated.Assistant.Start.Properties.Resources.code;
            this.lblSources.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSources.Location = new System.Drawing.Point(34, 10);
            this.lblSources.Name = "lblSources";
            this.lblSources.Size = new System.Drawing.Size(64, 17);
            this.lblSources.TabIndex = 1;
            this.lblSources.Text = "     源代码";
            // 
            // GenerateWorker
            // 
            this.GenerateWorker.WorkerReportsProgress = true;
            this.GenerateWorker.WorkerSupportsCancellation = true;
            // 
            // GenerateTemporaryTableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SplitContainer);
            this.Controls.Add(this.pnlWorkFlow);
            this.Controls.Add(this.tabContainer);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GenerateTemporaryTableControl";
            this.Size = new System.Drawing.Size(844, 465);
            this.Load += new System.EventHandler(this.GenerateTemporaryTableControl_Load);
            this.tabContainer.ResumeLayout(false);
            this.pageBaseParamsSetting.ResumeLayout(false);
            this.pageBaseParamsSetting.PerformLayout();
            this.pnlWorkFlow.ResumeLayout(false);
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel1.PerformLayout();
            this.SplitContainer.Panel2.ResumeLayout(false);
            this.SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.pnlSourcesToolbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabContainer;
        private System.Windows.Forms.TabPage pageBaseParamsSetting;
        private System.Windows.Forms.ImageList ImageList;
        private Common.Control.PanelEx pnlWorkFlow;
        private System.Windows.Forms.CheckBox cboxFirstPropertyGeneratePrimaryKey;
        private System.Windows.Forms.CheckBox cboxGenerateRemark;
        private System.Windows.Forms.CheckBox cboxGenerateFunctionHeader;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private Common.Control.ButtonEx btnGenerate;
        private System.Windows.Forms.Label lblSpecification;
        private System.Windows.Forms.Label lblSources;
        private System.Windows.Forms.RichTextBox richboxSpecification;
        private System.Windows.Forms.Panel pnlSpecificationLineNo;
        private System.Windows.Forms.RichTextBox richboxSources;
        private System.Windows.Forms.Panel pnlSourcesLineNo;
        private System.Windows.Forms.LinkLabel lnkStandardExample;
        private System.Windows.Forms.BindingSource BindingSource;
        private System.ComponentModel.BackgroundWorker GenerateWorker;
        private System.Windows.Forms.Panel pnlSourcesToolbar;
        private Common.Control.ButtonEx btnView;
        private Common.Control.ButtonEx btnClear;
        private Common.Control.ButtonEx btnWordWarp;
        private Common.Control.ButtonEx btnCopy;
    }
}
