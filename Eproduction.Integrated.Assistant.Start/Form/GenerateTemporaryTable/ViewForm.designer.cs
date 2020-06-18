namespace Eproduction.Integrated.Assistant.Start {
    partial class ViewForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewForm));
            this.richboxSources = new System.Windows.Forms.RichTextBox();
            this.pnlLineNo = new System.Windows.Forms.Panel();
            this.pnlSourcesToolbar = new System.Windows.Forms.Panel();
            this.btnExit = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.btnWordWarp = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.pnlSourcesToolbar.SuspendLayout();
            this.SuspendLayout();
            // 
            // richboxSources
            // 
            this.richboxSources.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richboxSources.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.richboxSources.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richboxSources.EnableAutoDragDrop = true;
            this.richboxSources.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richboxSources.ForeColor = System.Drawing.SystemColors.ControlText;
            this.richboxSources.Location = new System.Drawing.Point(42, 0);
            this.richboxSources.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richboxSources.Name = "richboxSources";
            this.richboxSources.Size = new System.Drawing.Size(738, 410);
            this.richboxSources.TabIndex = 4;
            this.richboxSources.Text = "";
            this.richboxSources.WordWrap = false;
            // 
            // pnlLineNo
            // 
            this.pnlLineNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlLineNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.pnlLineNo.Location = new System.Drawing.Point(0, 0);
            this.pnlLineNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlLineNo.Name = "pnlLineNo";
            this.pnlLineNo.Size = new System.Drawing.Size(41, 410);
            this.pnlLineNo.TabIndex = 5;
            // 
            // pnlSourcesToolbar
            // 
            this.pnlSourcesToolbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlSourcesToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnlSourcesToolbar.Controls.Add(this.btnExit);
            this.pnlSourcesToolbar.Controls.Add(this.btnWordWarp);
            this.pnlSourcesToolbar.Location = new System.Drawing.Point(627, 12);
            this.pnlSourcesToolbar.Name = "pnlSourcesToolbar";
            this.pnlSourcesToolbar.Size = new System.Drawing.Size(121, 27);
            this.pnlSourcesToolbar.TabIndex = 19;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Image = global::Eproduction.Integrated.Assistant.Start.Properties.Resources.exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(60, 1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(59, 25);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "    退出";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnWordWarp
            // 
            this.btnWordWarp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnWordWarp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnWordWarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWordWarp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWordWarp.Image = global::Eproduction.Integrated.Assistant.Start.Properties.Resources.word_warp;
            this.btnWordWarp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWordWarp.Location = new System.Drawing.Point(1, 1);
            this.btnWordWarp.Name = "btnWordWarp";
            this.btnWordWarp.Size = new System.Drawing.Size(59, 25);
            this.btnWordWarp.TabIndex = 11;
            this.btnWordWarp.Text = "    换行";
            this.btnWordWarp.UseVisualStyleBackColor = false;
            this.btnWordWarp.Click += new System.EventHandler(this.btnWordWarp_Click);
            // 
            // ViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 410);
            this.Controls.Add(this.pnlSourcesToolbar);
            this.Controls.Add(this.pnlLineNo);
            this.Controls.Add(this.richboxSources);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CodeViewForm";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CodeViewForm_KeyDown);
            this.pnlSourcesToolbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richboxSources;
        private System.Windows.Forms.Panel pnlLineNo;
        private System.Windows.Forms.Panel pnlSourcesToolbar;
        private Common.Control.ButtonEx btnExit;
        private Common.Control.ButtonEx btnWordWarp;
    }
}