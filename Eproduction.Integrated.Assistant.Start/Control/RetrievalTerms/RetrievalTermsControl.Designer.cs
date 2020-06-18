namespace Eproduction.Integrated.Assistant.Start.Control {
    partial class RetrievalTermsControl {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RetrievalTermsControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabContainer = new System.Windows.Forms.TabControl();
            this.pageBaseParamsSetting = new System.Windows.Forms.TabPage();
            this.cboxEnabledFuzzyQuery = new System.Windows.Forms.CheckBox();
            this.lblChsEntryTitle = new System.Windows.Forms.Label();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.dgvEntries = new System.Windows.Forms.DataGridView();
            this.pageAdvancesSetting = new System.Windows.Forms.TabPage();
            this.lblDbConnectionStringTitle = new System.Windows.Forms.Label();
            this.lblDbConnectionString = new System.Windows.Forms.Label();
            this.lnkModifiedConnectionSetting = new System.Windows.Forms.LinkLabel();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboxDisplayPassword = new System.Windows.Forms.CheckBox();
            this.pnlWorkFlow = new Eproduction.Integrated.Assistant.Common.Control.PanelEx();
            this.btnQuery = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.tboxChsEntry = new Eproduction.Integrated.Assistant.Common.Control.TextBoxEx();
            this.queryWorker = new System.ComponentModel.BackgroundWorker();
            this.tabContainer.SuspendLayout();
            this.pageBaseParamsSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntries)).BeginInit();
            this.pageAdvancesSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.pnlWorkFlow.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabContainer
            // 
            this.tabContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabContainer.Controls.Add(this.pageBaseParamsSetting);
            this.tabContainer.Controls.Add(this.pageAdvancesSetting);
            this.tabContainer.ImageList = this.ImageList;
            this.tabContainer.Location = new System.Drawing.Point(13, 12);
            this.tabContainer.Name = "tabContainer";
            this.tabContainer.SelectedIndex = 0;
            this.tabContainer.Size = new System.Drawing.Size(641, 117);
            this.tabContainer.TabIndex = 0;
            // 
            // pageBaseParamsSetting
            // 
            this.pageBaseParamsSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pageBaseParamsSetting.Controls.Add(this.cboxEnabledFuzzyQuery);
            this.pageBaseParamsSetting.Controls.Add(this.tboxChsEntry);
            this.pageBaseParamsSetting.Controls.Add(this.lblChsEntryTitle);
            this.pageBaseParamsSetting.ImageKey = "params.png";
            this.pageBaseParamsSetting.Location = new System.Drawing.Point(4, 26);
            this.pageBaseParamsSetting.Name = "pageBaseParamsSetting";
            this.pageBaseParamsSetting.Padding = new System.Windows.Forms.Padding(3);
            this.pageBaseParamsSetting.Size = new System.Drawing.Size(633, 87);
            this.pageBaseParamsSetting.TabIndex = 0;
            this.pageBaseParamsSetting.Text = "基本选项";
            // 
            // cboxEnabledFuzzyQuery
            // 
            this.cboxEnabledFuzzyQuery.AutoSize = true;
            this.cboxEnabledFuzzyQuery.Location = new System.Drawing.Point(84, 46);
            this.cboxEnabledFuzzyQuery.Name = "cboxEnabledFuzzyQuery";
            this.cboxEnabledFuzzyQuery.Size = new System.Drawing.Size(99, 21);
            this.cboxEnabledFuzzyQuery.TabIndex = 3;
            this.cboxEnabledFuzzyQuery.Text = "启用模糊查询";
            this.cboxEnabledFuzzyQuery.UseVisualStyleBackColor = true;
            // 
            // lblChsEntryTitle
            // 
            this.lblChsEntryTitle.AutoSize = true;
            this.lblChsEntryTitle.Location = new System.Drawing.Point(22, 19);
            this.lblChsEntryTitle.Name = "lblChsEntryTitle";
            this.lblChsEntryTitle.Size = new System.Drawing.Size(56, 17);
            this.lblChsEntryTitle.TabIndex = 1;
            this.lblChsEntryTitle.Text = "中文词条";
            // 
            // ImageList
            // 
            this.ImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ImageList.ImageStream")));
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.ImageList.Images.SetKeyName(0, "params.png");
            this.ImageList.Images.SetKeyName(1, "advanced.png");
            // 
            // dgvEntries
            // 
            this.dgvEntries.AllowUserToAddRows = false;
            this.dgvEntries.AllowUserToDeleteRows = false;
            this.dgvEntries.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvEntries.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEntries.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEntries.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.dgvEntries.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEntries.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEntries.ColumnHeadersHeight = 22;
            this.dgvEntries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvEntries.EnableHeadersVisualStyles = false;
            this.dgvEntries.Location = new System.Drawing.Point(13, 135);
            this.dgvEntries.Name = "dgvEntries";
            this.dgvEntries.ReadOnly = true;
            this.dgvEntries.RowTemplate.Height = 21;
            this.dgvEntries.RowTemplate.ReadOnly = true;
            this.dgvEntries.Size = new System.Drawing.Size(818, 280);
            this.dgvEntries.TabIndex = 7;
            // 
            // pageAdvancesSetting
            // 
            this.pageAdvancesSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pageAdvancesSetting.Controls.Add(this.cboxDisplayPassword);
            this.pageAdvancesSetting.Controls.Add(this.lnkModifiedConnectionSetting);
            this.pageAdvancesSetting.Controls.Add(this.lblDbConnectionString);
            this.pageAdvancesSetting.Controls.Add(this.lblDbConnectionStringTitle);
            this.pageAdvancesSetting.ImageKey = "advanced.png";
            this.pageAdvancesSetting.Location = new System.Drawing.Point(4, 26);
            this.pageAdvancesSetting.Name = "pageAdvancesSetting";
            this.pageAdvancesSetting.Padding = new System.Windows.Forms.Padding(3);
            this.pageAdvancesSetting.Size = new System.Drawing.Size(633, 87);
            this.pageAdvancesSetting.TabIndex = 1;
            this.pageAdvancesSetting.Text = "高级选项";
            // 
            // lblDbConnectionStringTitle
            // 
            this.lblDbConnectionStringTitle.AutoSize = true;
            this.lblDbConnectionStringTitle.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDbConnectionStringTitle.Location = new System.Drawing.Point(15, 9);
            this.lblDbConnectionStringTitle.Name = "lblDbConnectionStringTitle";
            this.lblDbConnectionStringTitle.Size = new System.Drawing.Size(110, 17);
            this.lblDbConnectionStringTitle.TabIndex = 0;
            this.lblDbConnectionStringTitle.Text = ">>数据库连接设置";
            // 
            // lblDbConnectionString
            // 
            this.lblDbConnectionString.AutoSize = true;
            this.lblDbConnectionString.BackColor = System.Drawing.Color.Gainsboro;
            this.lblDbConnectionString.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDbConnectionString.Location = new System.Drawing.Point(15, 36);
            this.lblDbConnectionString.Name = "lblDbConnectionString";
            this.lblDbConnectionString.Size = new System.Drawing.Size(466, 17);
            this.lblDbConnectionString.TabIndex = 1;
            this.lblDbConnectionString.Text = "data source={ip};initial catalog={E10_DB};user id=sa;password={password}";
            // 
            // lnkModifiedConnectionSetting
            // 
            this.lnkModifiedConnectionSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkModifiedConnectionSetting.AutoSize = true;
            this.lnkModifiedConnectionSetting.Image = global::Eproduction.Integrated.Assistant.Start.Properties.Resources.edit;
            this.lnkModifiedConnectionSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkModifiedConnectionSetting.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lnkModifiedConnectionSetting.Location = new System.Drawing.Point(547, 9);
            this.lnkModifiedConnectionSetting.Name = "lnkModifiedConnectionSetting";
            this.lnkModifiedConnectionSetting.Size = new System.Drawing.Size(48, 17);
            this.lnkModifiedConnectionSetting.TabIndex = 2;
            this.lnkModifiedConnectionSetting.TabStop = true;
            this.lnkModifiedConnectionSetting.Text = "    修改";
            this.lnkModifiedConnectionSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lnkModifiedConnectionSetting.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkModifiedConnectionSetting_LinkClicked);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            this.ErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("ErrorProvider.Icon")));
            // 
            // cboxDisplayPassword
            // 
            this.cboxDisplayPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboxDisplayPassword.AutoSize = true;
            this.cboxDisplayPassword.Location = new System.Drawing.Point(550, 35);
            this.cboxDisplayPassword.Name = "cboxDisplayPassword";
            this.cboxDisplayPassword.Size = new System.Drawing.Size(75, 21);
            this.cboxDisplayPassword.TabIndex = 3;
            this.cboxDisplayPassword.Text = "显示密码";
            this.cboxDisplayPassword.UseVisualStyleBackColor = true;
            // 
            // pnlWorkFlow
            // 
            this.pnlWorkFlow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWorkFlow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlWorkFlow.BorderColor = System.Drawing.Color.Black;
            this.pnlWorkFlow.BorderWidth = 1;
            this.pnlWorkFlow.Controls.Add(this.btnQuery);
            this.pnlWorkFlow.Location = new System.Drawing.Point(660, 38);
            this.pnlWorkFlow.Name = "pnlWorkFlow";
            this.pnlWorkFlow.Size = new System.Drawing.Size(171, 90);
            this.pnlWorkFlow.TabIndex = 4;
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnQuery.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnQuery.Location = new System.Drawing.Point(10, 9);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(151, 28);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "查询(Q)";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // tboxChsEntry
            // 
            this.tboxChsEntry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxChsEntry.BorderColor = System.Drawing.Color.Silver;
            this.tboxChsEntry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxChsEntry.HotColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tboxChsEntry.Location = new System.Drawing.Point(84, 17);
            this.tboxChsEntry.Name = "tboxChsEntry";
            this.tboxChsEntry.Size = new System.Drawing.Size(521, 23);
            this.tboxChsEntry.TabIndex = 2;
            // 
            // queryWorker
            // 
            this.queryWorker.WorkerReportsProgress = true;
            this.queryWorker.WorkerSupportsCancellation = true;
            // 
            // RetrievalTermsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvEntries);
            this.Controls.Add(this.pnlWorkFlow);
            this.Controls.Add(this.tabContainer);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RetrievalTermsControl";
            this.Size = new System.Drawing.Size(846, 429);
            this.Load += new System.EventHandler(this.RetrievalTermsControl_Load);
            this.tabContainer.ResumeLayout(false);
            this.pageBaseParamsSetting.ResumeLayout(false);
            this.pageBaseParamsSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntries)).EndInit();
            this.pageAdvancesSetting.ResumeLayout(false);
            this.pageAdvancesSetting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.pnlWorkFlow.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabContainer;
        private System.Windows.Forms.TabPage pageBaseParamsSetting;
        private System.Windows.Forms.ImageList ImageList;
        private Common.Control.PanelEx pnlWorkFlow;
        private Common.Control.ButtonEx btnQuery;
        private System.Windows.Forms.CheckBox cboxEnabledFuzzyQuery;
        private Common.Control.TextBoxEx tboxChsEntry;
        private System.Windows.Forms.Label lblChsEntryTitle;
        private System.Windows.Forms.DataGridView dgvEntries;
        private System.Windows.Forms.BindingSource BindingSource;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.TabPage pageAdvancesSetting;
        private System.Windows.Forms.LinkLabel lnkModifiedConnectionSetting;
        private System.Windows.Forms.Label lblDbConnectionString;
        private System.Windows.Forms.Label lblDbConnectionStringTitle;
        private System.Windows.Forms.CheckBox cboxDisplayPassword;
        private System.ComponentModel.BackgroundWorker queryWorker;
    }
}
