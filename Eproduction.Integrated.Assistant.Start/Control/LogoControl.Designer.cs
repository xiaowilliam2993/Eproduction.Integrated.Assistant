namespace Eproduction.Integrated.Assistant.Start.Control {
    partial class LogoControl {
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
            this.pboxWord = new Eproduction.Integrated.Assistant.Common.Control.PictureBoxEx();
            this.pboxPicture = new Eproduction.Integrated.Assistant.Common.Control.PictureBoxEx();
            ((System.ComponentModel.ISupportInitialize)(this.pboxWord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // pboxWord
            // 
            this.pboxWord.Image = global::Eproduction.Integrated.Assistant.Start.Properties.Resources.EPIA_word_Larger;
            this.pboxWord.Location = new System.Drawing.Point(49, 0);
            this.pboxWord.Name = "pboxWord";
            this.pboxWord.Size = new System.Drawing.Size(129, 49);
            this.pboxWord.TabIndex = 1;
            this.pboxWord.TabStop = false;
            // 
            // pboxPicture
            // 
            this.pboxPicture.Image = global::Eproduction.Integrated.Assistant.Start.Properties.Resources.EPIA_picture_Larger;
            this.pboxPicture.Location = new System.Drawing.Point(0, 0);
            this.pboxPicture.Name = "pboxPicture";
            this.pboxPicture.Size = new System.Drawing.Size(49, 49);
            this.pboxPicture.TabIndex = 0;
            this.pboxPicture.TabStop = false;
            // 
            // LogoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pboxWord);
            this.Controls.Add(this.pboxPicture);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LogoControl";
            this.Size = new System.Drawing.Size(177, 49);
            ((System.ComponentModel.ISupportInitialize)(this.pboxWord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboxPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Common.Control.PictureBoxEx pboxPicture;
        private Common.Control.PictureBoxEx pboxWord;
    }
}
