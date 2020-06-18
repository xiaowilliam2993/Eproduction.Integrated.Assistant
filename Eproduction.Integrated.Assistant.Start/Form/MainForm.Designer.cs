namespace Eproduction.Integrated.Assistant.Start {
    partial class MainForm {
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sysMenuStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiTools = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModuleSelector = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.sysStatusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tspbarProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.tsslblProgressMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.sysToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.LoadingWorker = new System.ComponentModel.BackgroundWorker();
            this.pnlContainer = new Eproduction.Integrated.Assistant.Common.Control.PanelEx();
            this.pnlWorkFlow = new Eproduction.Integrated.Assistant.Common.Control.PanelEx();
            this.sysMenuStrip.SuspendLayout();
            this.sysStatusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // sysMenuStrip
            // 
            this.sysMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFile,
            this.tsmiTools,
            this.tsmiHelp});
            this.sysMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.sysMenuStrip.Name = "sysMenuStrip";
            this.sysMenuStrip.Size = new System.Drawing.Size(1037, 25);
            this.sysMenuStrip.TabIndex = 0;
            this.sysMenuStrip.Text = "menuStrip";
            // 
            // tsmiFile
            // 
            this.tsmiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiExit});
            this.tsmiFile.Name = "tsmiFile";
            this.tsmiFile.Size = new System.Drawing.Size(58, 21);
            this.tsmiFile.Text = "文件(F)";
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.tsmiExit.Size = new System.Drawing.Size(161, 22);
            this.tsmiExit.Text = "退出(X)";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tsmiTools
            // 
            this.tsmiTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiModuleSelector});
            this.tsmiTools.Name = "tsmiTools";
            this.tsmiTools.Size = new System.Drawing.Size(59, 21);
            this.tsmiTools.Text = "工具(T)";
            // 
            // tsmiModuleSelector
            // 
            this.tsmiModuleSelector.Name = "tsmiModuleSelector";
            this.tsmiModuleSelector.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F12)));
            this.tsmiModuleSelector.Size = new System.Drawing.Size(214, 22);
            this.tsmiModuleSelector.Text = "模组选择器(D)...";
            this.tsmiModuleSelector.Click += new System.EventHandler(this.tsmiModuleSelector_Click);
            // 
            // tsmiHelp
            // 
            this.tsmiHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAbout});
            this.tsmiHelp.Name = "tsmiHelp";
            this.tsmiHelp.Size = new System.Drawing.Size(61, 21);
            this.tsmiHelp.Text = "帮助(H)";
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(199, 22);
            this.tsmiAbout.Text = "关于 E开发集成助手(A)";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // sysStatusStrip
            // 
            this.sysStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslblStatus,
            this.tspbarProgress,
            this.tsslblProgressMessage});
            this.sysStatusStrip.Location = new System.Drawing.Point(0, 533);
            this.sysStatusStrip.Name = "sysStatusStrip";
            this.sysStatusStrip.Size = new System.Drawing.Size(1037, 22);
            this.sysStatusStrip.TabIndex = 6;
            this.sysStatusStrip.Text = "statusStrip1";
            // 
            // tsslblStatus
            // 
            this.tsslblStatus.Name = "tsslblStatus";
            this.tsslblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // tspbarProgress
            // 
            this.tspbarProgress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(180)))), ((int)(((byte)(148)))));
            this.tspbarProgress.Name = "tspbarProgress";
            this.tspbarProgress.Size = new System.Drawing.Size(200, 16);
            this.tspbarProgress.Visible = false;
            // 
            // tsslblProgressMessage
            // 
            this.tsslblProgressMessage.Name = "tsslblProgressMessage";
            this.tsslblProgressMessage.Size = new System.Drawing.Size(117, 17);
            this.tsslblProgressMessage.Text = "Progress Message";
            this.tsslblProgressMessage.Visible = false;
            // 
            // LoadingWorker
            // 
            this.LoadingWorker.WorkerReportsProgress = true;
            this.LoadingWorker.WorkerSupportsCancellation = true;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(231)))), ((int)(((byte)(231)))));
            this.pnlContainer.BorderColor = System.Drawing.Color.Black;
            this.pnlContainer.BorderWidth = 1;
            this.pnlContainer.Location = new System.Drawing.Point(12, 103);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1013, 421);
            this.pnlContainer.TabIndex = 5;
            // 
            // pnlWorkFlow
            // 
            this.pnlWorkFlow.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWorkFlow.BackColor = System.Drawing.Color.Gainsboro;
            this.pnlWorkFlow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(180)))), ((int)(((byte)(212)))));
            this.pnlWorkFlow.BorderWidth = 1;
            this.pnlWorkFlow.Location = new System.Drawing.Point(12, 36);
            this.pnlWorkFlow.Name = "pnlWorkFlow";
            this.pnlWorkFlow.Size = new System.Drawing.Size(1013, 61);
            this.pnlWorkFlow.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 555);
            this.Controls.Add(this.sysStatusStrip);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlWorkFlow);
            this.Controls.Add(this.sysMenuStrip);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.sysMenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(1053, 594);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E开发集成助手";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.sysMenuStrip.ResumeLayout(false);
            this.sysMenuStrip.PerformLayout();
            this.sysStatusStrip.ResumeLayout(false);
            this.sysStatusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip sysMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiFile;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripMenuItem tsmiTools;
        private System.Windows.Forms.ToolStripMenuItem tsmiHelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private Eproduction.Integrated.Assistant.Common.Control.PanelEx pnlWorkFlow;
        private Eproduction.Integrated.Assistant.Common.Control.PanelEx pnlContainer;
        private System.Windows.Forms.StatusStrip sysStatusStrip;
        private System.Windows.Forms.ToolTip sysToolTip;
        private System.Windows.Forms.ToolStripMenuItem tsmiModuleSelector;
        private System.ComponentModel.BackgroundWorker LoadingWorker;
        private System.Windows.Forms.ToolStripStatusLabel tsslblStatus;
        private System.Windows.Forms.ToolStripProgressBar tspbarProgress;
        private System.Windows.Forms.ToolStripStatusLabel tsslblProgressMessage;
    }
}

