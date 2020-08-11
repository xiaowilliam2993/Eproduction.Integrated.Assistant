namespace Eproduction.Integrated.Assistant.Start {
    partial class DeployVersionNameEditorForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeployVersionNameEditorForm));
            this.lblVersionName = new System.Windows.Forms.Label();
            this.tboxVersionName = new Eproduction.Integrated.Assistant.Common.Control.TextBoxEx();
            this.btnDone = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVersionName
            // 
            this.lblVersionName.AutoSize = true;
            this.lblVersionName.Location = new System.Drawing.Point(17, 13);
            this.lblVersionName.Name = "lblVersionName";
            this.lblVersionName.Size = new System.Drawing.Size(56, 17);
            this.lblVersionName.TabIndex = 0;
            this.lblVersionName.Text = "版本名称";
            // 
            // tboxVersionName
            // 
            this.tboxVersionName.BorderColor = System.Drawing.Color.Silver;
            this.tboxVersionName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxVersionName.HotColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tboxVersionName.Location = new System.Drawing.Point(20, 37);
            this.tboxVersionName.Name = "tboxVersionName";
            this.tboxVersionName.Size = new System.Drawing.Size(351, 23);
            this.tboxVersionName.TabIndex = 1;
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.SystemColors.Control;
            this.btnDone.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDone.Image = global::Eproduction.Integrated.Assistant.Start.Properties.Resources.done;
            this.btnDone.Location = new System.Drawing.Point(342, 10);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(29, 23);
            this.btnDone.TabIndex = 2;
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProvider.ContainerControl = this;
            // 
            // DeployVersionNameEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 78);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.tboxVersionName);
            this.Controls.Add(this.lblVersionName);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeployVersionNameEditorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置部署版本名称";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DeployVersionNameEditorForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVersionName;
        private Common.Control.TextBoxEx tboxVersionName;
        private Common.Control.ButtonEx btnDone;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}