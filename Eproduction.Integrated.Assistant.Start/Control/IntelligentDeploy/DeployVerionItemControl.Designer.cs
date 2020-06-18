namespace Eproduction.Integrated.Assistant.Start.Control {
    partial class DeployVerionItemControl {
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
            this.lblVersion = new System.Windows.Forms.Label();
            this.pboxVersion = new Eproduction.Integrated.Assistant.Common.Control.PictureBoxEx();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblSelectedPrompt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboxVersion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(42, 6);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(91, 17);
            this.lblVersion.TabIndex = 1;
            this.lblVersion.Text = "Version Name";
            // 
            // pboxVersion
            // 
            this.pboxVersion.Image = global::Eproduction.Integrated.Assistant.Start.Properties.Resources.version;
            this.pboxVersion.Location = new System.Drawing.Point(17, 6);
            this.pboxVersion.Name = "pboxVersion";
            this.pboxVersion.Size = new System.Drawing.Size(16, 16);
            this.pboxVersion.TabIndex = 0;
            this.pboxVersion.TabStop = false;
            // 
            // lblSelectedPrompt
            // 
            this.lblSelectedPrompt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblSelectedPrompt.Location = new System.Drawing.Point(0, 3);
            this.lblSelectedPrompt.Name = "lblSelectedPrompt";
            this.lblSelectedPrompt.Size = new System.Drawing.Size(4, 22);
            this.lblSelectedPrompt.TabIndex = 3;
            this.lblSelectedPrompt.Visible = false;
            // 
            // DeployVerionItemControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.lblSelectedPrompt);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.pboxVersion);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DeployVerionItemControl";
            this.Size = new System.Drawing.Size(279, 28);
            this.Load += new System.EventHandler(this.DeployVerionItemControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pboxVersion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.BindingSource BindingSource;
        public Common.Control.PictureBoxEx pboxVersion;
        public System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblSelectedPrompt;
    }
}
