namespace Eproduction.Integrated.Assistant.Start.Control {
    partial class ModuleControl {
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
            this.cbox = new System.Windows.Forms.CheckBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCaption = new System.Windows.Forms.Label();
            this.pbox = new Eproduction.Integrated.Assistant.Common.Control.PictureBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // cbox
            // 
            this.cbox.AutoSize = true;
            this.cbox.Location = new System.Drawing.Point(78, 19);
            this.cbox.Name = "cbox";
            this.cbox.Size = new System.Drawing.Size(15, 14);
            this.cbox.TabIndex = 0;
            this.cbox.UseVisualStyleBackColor = true;
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDescription.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblDescription.Location = new System.Drawing.Point(110, 28);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(307, 32);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Module Description";
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCaption.Location = new System.Drawing.Point(110, 7);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(107, 17);
            this.lblCaption.TabIndex = 3;
            this.lblCaption.Text = "Module Caption";
            // 
            // pbox
            // 
            this.pbox.Location = new System.Drawing.Point(16, 9);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(32, 32);
            this.pbox.TabIndex = 1;
            this.pbox.TabStop = false;
            // 
            // ModuleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.Controls.Add(this.lblCaption);
            this.Controls.Add(this.pbox);
            this.Controls.Add(this.cbox);
            this.Controls.Add(this.lblDescription);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ModuleControl";
            this.Size = new System.Drawing.Size(434, 67);
            this.Load += new System.EventHandler(this.ModuleControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbox;
        private Eproduction.Integrated.Assistant.Common.Control.PictureBoxEx pbox;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.BindingSource BindingSource;
        private System.Windows.Forms.Label lblCaption;
    }
}
