namespace Eproduction.Integrated.Assistant.Start.Control {
    partial class EscloudIntegrateControl {
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
            this.gboxCustomerInfo = new System.Windows.Forms.GroupBox();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerCodeCaption = new System.Windows.Forms.Label();
            this.lblCustomerCode = new System.Windows.Forms.Label();
            this.lblSplit1 = new System.Windows.Forms.Label();
            this.lblCustomerServiceCode = new System.Windows.Forms.Label();
            this.lblCustomerServiceCodeCaption = new System.Windows.Forms.Label();
            this.lblSplit2 = new System.Windows.Forms.Label();
            this.lblCustomerTypeCaption = new System.Windows.Forms.Label();
            this.lblCustomerType = new System.Windows.Forms.Label();
            this.tabEsClient = new System.Windows.Forms.TabControl();
            this.sContainerBase = new System.Windows.Forms.SplitContainer();
            this.sContainerSub1 = new System.Windows.Forms.SplitContainer();
            this.tabEsCloud = new System.Windows.Forms.TabControl();
            this.pageReportSettingQuery = new System.Windows.Forms.TabPage();
            this.pageMQRecordQuery = new System.Windows.Forms.TabPage();
            this.pageReportDataQuery = new System.Windows.Forms.TabPage();
            this.tabDiagram = new System.Windows.Forms.TabControl();
            this.pagePublishInfoQuery = new System.Windows.Forms.TabPage();
            this.pageBrowseHistoryQuery = new System.Windows.Forms.TabPage();
            this.pageScreensQuery = new System.Windows.Forms.TabPage();
            this.pageEsClientQuery = new System.Windows.Forms.TabPage();
            this.btnFindCustomer = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.btnDbConnectionSetting = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.gboxCustomerInfo.SuspendLayout();
            this.tabEsClient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sContainerBase)).BeginInit();
            this.sContainerBase.Panel1.SuspendLayout();
            this.sContainerBase.Panel2.SuspendLayout();
            this.sContainerBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sContainerSub1)).BeginInit();
            this.sContainerSub1.Panel1.SuspendLayout();
            this.sContainerSub1.Panel2.SuspendLayout();
            this.sContainerSub1.SuspendLayout();
            this.tabEsCloud.SuspendLayout();
            this.tabDiagram.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxCustomerInfo
            // 
            this.gboxCustomerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxCustomerInfo.Controls.Add(this.lblCustomerType);
            this.gboxCustomerInfo.Controls.Add(this.lblCustomerTypeCaption);
            this.gboxCustomerInfo.Controls.Add(this.lblSplit2);
            this.gboxCustomerInfo.Controls.Add(this.lblCustomerServiceCode);
            this.gboxCustomerInfo.Controls.Add(this.lblCustomerServiceCodeCaption);
            this.gboxCustomerInfo.Controls.Add(this.lblSplit1);
            this.gboxCustomerInfo.Controls.Add(this.lblCustomerCode);
            this.gboxCustomerInfo.Controls.Add(this.lblCustomerCodeCaption);
            this.gboxCustomerInfo.Controls.Add(this.lblCustomerName);
            this.gboxCustomerInfo.Location = new System.Drawing.Point(13, 8);
            this.gboxCustomerInfo.Name = "gboxCustomerInfo";
            this.gboxCustomerInfo.Size = new System.Drawing.Size(735, 72);
            this.gboxCustomerInfo.TabIndex = 0;
            this.gboxCustomerInfo.TabStop = false;
            this.gboxCustomerInfo.Text = "客户和驻派员基本信息";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCustomerName.Location = new System.Drawing.Point(18, 23);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(45, 19);
            this.lblCustomerName.TabIndex = 0;
            this.lblCustomerName.Text = "------";
            // 
            // lblCustomerCodeCaption
            // 
            this.lblCustomerCodeCaption.AutoSize = true;
            this.lblCustomerCodeCaption.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCustomerCodeCaption.Location = new System.Drawing.Point(19, 46);
            this.lblCustomerCodeCaption.Name = "lblCustomerCodeCaption";
            this.lblCustomerCodeCaption.Size = new System.Drawing.Size(52, 16);
            this.lblCustomerCodeCaption.TabIndex = 1;
            this.lblCustomerCodeCaption.Text = "客户编号";
            // 
            // lblCustomerCode
            // 
            this.lblCustomerCode.AutoSize = true;
            this.lblCustomerCode.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCustomerCode.Location = new System.Drawing.Point(77, 46);
            this.lblCustomerCode.Name = "lblCustomerCode";
            this.lblCustomerCode.Size = new System.Drawing.Size(38, 16);
            this.lblCustomerCode.TabIndex = 2;
            this.lblCustomerCode.Text = "------";
            // 
            // lblSplit1
            // 
            this.lblSplit1.AutoSize = true;
            this.lblSplit1.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSplit1.Location = new System.Drawing.Point(152, 46);
            this.lblSplit1.Name = "lblSplit1";
            this.lblSplit1.Size = new System.Drawing.Size(11, 16);
            this.lblSplit1.TabIndex = 3;
            this.lblSplit1.Text = "|";
            // 
            // lblCustomerServiceCode
            // 
            this.lblCustomerServiceCode.AutoSize = true;
            this.lblCustomerServiceCode.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCustomerServiceCode.Location = new System.Drawing.Point(227, 46);
            this.lblCustomerServiceCode.Name = "lblCustomerServiceCode";
            this.lblCustomerServiceCode.Size = new System.Drawing.Size(38, 16);
            this.lblCustomerServiceCode.TabIndex = 5;
            this.lblCustomerServiceCode.Text = "------";
            // 
            // lblCustomerServiceCodeCaption
            // 
            this.lblCustomerServiceCodeCaption.AutoSize = true;
            this.lblCustomerServiceCodeCaption.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCustomerServiceCodeCaption.Location = new System.Drawing.Point(169, 46);
            this.lblCustomerServiceCodeCaption.Name = "lblCustomerServiceCodeCaption";
            this.lblCustomerServiceCodeCaption.Size = new System.Drawing.Size(52, 16);
            this.lblCustomerServiceCodeCaption.TabIndex = 4;
            this.lblCustomerServiceCodeCaption.Text = "客服代号";
            // 
            // lblSplit2
            // 
            this.lblSplit2.AutoSize = true;
            this.lblSplit2.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSplit2.Location = new System.Drawing.Point(289, 46);
            this.lblSplit2.Name = "lblSplit2";
            this.lblSplit2.Size = new System.Drawing.Size(11, 16);
            this.lblSplit2.TabIndex = 6;
            this.lblSplit2.Text = "|";
            // 
            // lblCustomerTypeCaption
            // 
            this.lblCustomerTypeCaption.AutoSize = true;
            this.lblCustomerTypeCaption.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCustomerTypeCaption.Location = new System.Drawing.Point(306, 46);
            this.lblCustomerTypeCaption.Name = "lblCustomerTypeCaption";
            this.lblCustomerTypeCaption.Size = new System.Drawing.Size(52, 16);
            this.lblCustomerTypeCaption.TabIndex = 7;
            this.lblCustomerTypeCaption.Text = "客户类型";
            // 
            // lblCustomerType
            // 
            this.lblCustomerType.AutoSize = true;
            this.lblCustomerType.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCustomerType.Location = new System.Drawing.Point(364, 46);
            this.lblCustomerType.Name = "lblCustomerType";
            this.lblCustomerType.Size = new System.Drawing.Size(23, 16);
            this.lblCustomerType.TabIndex = 8;
            this.lblCustomerType.Text = "---";
            // 
            // tabEsClient
            // 
            this.tabEsClient.Controls.Add(this.pageEsClientQuery);
            this.tabEsClient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEsClient.Location = new System.Drawing.Point(0, 0);
            this.tabEsClient.Name = "tabEsClient";
            this.tabEsClient.SelectedIndex = 0;
            this.tabEsClient.Size = new System.Drawing.Size(230, 433);
            this.tabEsClient.TabIndex = 4;
            // 
            // sContainerBase
            // 
            this.sContainerBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sContainerBase.Location = new System.Drawing.Point(13, 86);
            this.sContainerBase.Name = "sContainerBase";
            // 
            // sContainerBase.Panel1
            // 
            this.sContainerBase.Panel1.Controls.Add(this.tabEsClient);
            // 
            // sContainerBase.Panel2
            // 
            this.sContainerBase.Panel2.Controls.Add(this.sContainerSub1);
            this.sContainerBase.Size = new System.Drawing.Size(850, 433);
            this.sContainerBase.SplitterDistance = 230;
            this.sContainerBase.TabIndex = 3;
            // 
            // sContainerSub1
            // 
            this.sContainerSub1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sContainerSub1.Location = new System.Drawing.Point(0, 0);
            this.sContainerSub1.Name = "sContainerSub1";
            this.sContainerSub1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sContainerSub1.Panel1
            // 
            this.sContainerSub1.Panel1.Controls.Add(this.tabEsCloud);
            // 
            // sContainerSub1.Panel2
            // 
            this.sContainerSub1.Panel2.Controls.Add(this.tabDiagram);
            this.sContainerSub1.Size = new System.Drawing.Size(616, 433);
            this.sContainerSub1.SplitterDistance = 194;
            this.sContainerSub1.TabIndex = 4;
            // 
            // tabEsCloud
            // 
            this.tabEsCloud.Controls.Add(this.pageReportSettingQuery);
            this.tabEsCloud.Controls.Add(this.pageMQRecordQuery);
            this.tabEsCloud.Controls.Add(this.pageReportDataQuery);
            this.tabEsCloud.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEsCloud.Location = new System.Drawing.Point(0, 0);
            this.tabEsCloud.Name = "tabEsCloud";
            this.tabEsCloud.SelectedIndex = 0;
            this.tabEsCloud.Size = new System.Drawing.Size(616, 194);
            this.tabEsCloud.TabIndex = 5;
            // 
            // pageReportSettingQuery
            // 
            this.pageReportSettingQuery.BackColor = System.Drawing.SystemColors.Control;
            this.pageReportSettingQuery.Location = new System.Drawing.Point(4, 26);
            this.pageReportSettingQuery.Name = "pageReportSettingQuery";
            this.pageReportSettingQuery.Padding = new System.Windows.Forms.Padding(3);
            this.pageReportSettingQuery.Size = new System.Drawing.Size(608, 164);
            this.pageReportSettingQuery.TabIndex = 1;
            this.pageReportSettingQuery.Text = "报告设定项";
            // 
            // pageMQRecordQuery
            // 
            this.pageMQRecordQuery.BackColor = System.Drawing.SystemColors.Control;
            this.pageMQRecordQuery.Location = new System.Drawing.Point(4, 26);
            this.pageMQRecordQuery.Name = "pageMQRecordQuery";
            this.pageMQRecordQuery.Padding = new System.Windows.Forms.Padding(3);
            this.pageMQRecordQuery.Size = new System.Drawing.Size(608, 164);
            this.pageMQRecordQuery.TabIndex = 2;
            this.pageMQRecordQuery.Text = "MQ消息发送记录";
            // 
            // pageReportDataQuery
            // 
            this.pageReportDataQuery.BackColor = System.Drawing.SystemColors.Control;
            this.pageReportDataQuery.Location = new System.Drawing.Point(4, 26);
            this.pageReportDataQuery.Name = "pageReportDataQuery";
            this.pageReportDataQuery.Padding = new System.Windows.Forms.Padding(3);
            this.pageReportDataQuery.Size = new System.Drawing.Size(608, 164);
            this.pageReportDataQuery.TabIndex = 3;
            this.pageReportDataQuery.Text = "报告数据";
            // 
            // tabDiagram
            // 
            this.tabDiagram.Controls.Add(this.pagePublishInfoQuery);
            this.tabDiagram.Controls.Add(this.pageBrowseHistoryQuery);
            this.tabDiagram.Controls.Add(this.pageScreensQuery);
            this.tabDiagram.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDiagram.Location = new System.Drawing.Point(0, 0);
            this.tabDiagram.Name = "tabDiagram";
            this.tabDiagram.SelectedIndex = 0;
            this.tabDiagram.Size = new System.Drawing.Size(616, 235);
            this.tabDiagram.TabIndex = 6;
            // 
            // pagePublishInfoQuery
            // 
            this.pagePublishInfoQuery.BackColor = System.Drawing.SystemColors.Control;
            this.pagePublishInfoQuery.Location = new System.Drawing.Point(4, 26);
            this.pagePublishInfoQuery.Name = "pagePublishInfoQuery";
            this.pagePublishInfoQuery.Padding = new System.Windows.Forms.Padding(3);
            this.pagePublishInfoQuery.Size = new System.Drawing.Size(608, 205);
            this.pagePublishInfoQuery.TabIndex = 4;
            this.pagePublishInfoQuery.Text = "报告发布信息";
            // 
            // pageBrowseHistoryQuery
            // 
            this.pageBrowseHistoryQuery.BackColor = System.Drawing.SystemColors.Control;
            this.pageBrowseHistoryQuery.Location = new System.Drawing.Point(4, 26);
            this.pageBrowseHistoryQuery.Name = "pageBrowseHistoryQuery";
            this.pageBrowseHistoryQuery.Padding = new System.Windows.Forms.Padding(3);
            this.pageBrowseHistoryQuery.Size = new System.Drawing.Size(608, 205);
            this.pageBrowseHistoryQuery.TabIndex = 5;
            this.pageBrowseHistoryQuery.Text = "报告浏览记录";
            // 
            // pageScreensQuery
            // 
            this.pageScreensQuery.BackColor = System.Drawing.SystemColors.Control;
            this.pageScreensQuery.Location = new System.Drawing.Point(4, 26);
            this.pageScreensQuery.Name = "pageScreensQuery";
            this.pageScreensQuery.Padding = new System.Windows.Forms.Padding(3);
            this.pageScreensQuery.Size = new System.Drawing.Size(608, 205);
            this.pageScreensQuery.TabIndex = 6;
            this.pageScreensQuery.Text = "报告设计";
            // 
            // pageEsClientQuery
            // 
            this.pageEsClientQuery.BackColor = System.Drawing.SystemColors.Control;
            this.pageEsClientQuery.Location = new System.Drawing.Point(4, 26);
            this.pageEsClientQuery.Name = "pageEsClientQuery";
            this.pageEsClientQuery.Size = new System.Drawing.Size(222, 403);
            this.pageEsClientQuery.TabIndex = 0;
            this.pageEsClientQuery.Text = "驻派员信息";
            // 
            // btnFindCustomer
            // 
            this.btnFindCustomer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnFindCustomer.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnFindCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindCustomer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFindCustomer.Location = new System.Drawing.Point(754, 17);
            this.btnFindCustomer.Name = "btnFindCustomer";
            this.btnFindCustomer.Size = new System.Drawing.Size(109, 28);
            this.btnFindCustomer.TabIndex = 1;
            this.btnFindCustomer.Text = "查找客户信息";
            this.btnFindCustomer.UseVisualStyleBackColor = false;
            this.btnFindCustomer.Click += new System.EventHandler(this.btnFindCustomer_Click);
            // 
            // btnDbConnectionSetting
            // 
            this.btnDbConnectionSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDbConnectionSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnDbConnectionSetting.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnDbConnectionSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDbConnectionSetting.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDbConnectionSetting.Location = new System.Drawing.Point(754, 51);
            this.btnDbConnectionSetting.Name = "btnDbConnectionSetting";
            this.btnDbConnectionSetting.Size = new System.Drawing.Size(109, 28);
            this.btnDbConnectionSetting.TabIndex = 2;
            this.btnDbConnectionSetting.Text = "数据库相关设置";
            this.btnDbConnectionSetting.UseVisualStyleBackColor = false;
            this.btnDbConnectionSetting.Click += new System.EventHandler(this.btnDbConnectionSetting_Click);
            // 
            // EscloudIntegrateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFindCustomer);
            this.Controls.Add(this.btnDbConnectionSetting);
            this.Controls.Add(this.sContainerBase);
            this.Controls.Add(this.gboxCustomerInfo);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EscloudIntegrateControl";
            this.Size = new System.Drawing.Size(879, 533);
            this.gboxCustomerInfo.ResumeLayout(false);
            this.gboxCustomerInfo.PerformLayout();
            this.tabEsClient.ResumeLayout(false);
            this.sContainerBase.Panel1.ResumeLayout(false);
            this.sContainerBase.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sContainerBase)).EndInit();
            this.sContainerBase.ResumeLayout(false);
            this.sContainerSub1.Panel1.ResumeLayout(false);
            this.sContainerSub1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sContainerSub1)).EndInit();
            this.sContainerSub1.ResumeLayout(false);
            this.tabEsCloud.ResumeLayout(false);
            this.tabDiagram.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxCustomerInfo;
        private System.Windows.Forms.Label lblCustomerServiceCode;
        private System.Windows.Forms.Label lblCustomerServiceCodeCaption;
        private System.Windows.Forms.Label lblSplit1;
        private System.Windows.Forms.Label lblCustomerCode;
        private System.Windows.Forms.Label lblCustomerCodeCaption;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerType;
        private System.Windows.Forms.Label lblCustomerTypeCaption;
        private System.Windows.Forms.Label lblSplit2;
        private System.Windows.Forms.TabControl tabEsClient;
        private System.Windows.Forms.TabPage pageEsClientQuery;
        private System.Windows.Forms.SplitContainer sContainerBase;
        private System.Windows.Forms.SplitContainer sContainerSub1;
        private System.Windows.Forms.TabControl tabEsCloud;
        private System.Windows.Forms.TabPage pageReportSettingQuery;
        private System.Windows.Forms.TabPage pageMQRecordQuery;
        private System.Windows.Forms.TabPage pageReportDataQuery;
        private System.Windows.Forms.TabControl tabDiagram;
        private System.Windows.Forms.TabPage pagePublishInfoQuery;
        private System.Windows.Forms.TabPage pageBrowseHistoryQuery;
        private System.Windows.Forms.TabPage pageScreensQuery;
        private Common.Control.ButtonEx btnDbConnectionSetting;
        private Common.Control.ButtonEx btnFindCustomer;
    }
}
