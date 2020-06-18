namespace Eproduction.Integrated.Assistant.Start {
    partial class StandardExampleForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StandardExampleForm));
            this.richStandardExample = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richStandardExample
            // 
            this.richStandardExample.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richStandardExample.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.richStandardExample.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richStandardExample.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richStandardExample.ForeColor = System.Drawing.SystemColors.ControlText;
            this.richStandardExample.HideSelection = false;
            this.richStandardExample.Location = new System.Drawing.Point(0, 0);
            this.richStandardExample.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richStandardExample.Name = "richStandardExample";
            this.richStandardExample.ReadOnly = true;
            this.richStandardExample.Size = new System.Drawing.Size(1044, 599);
            this.richStandardExample.TabIndex = 4;
            this.richStandardExample.Text = "";
            this.richStandardExample.WordWrap = false;
            // 
            // StandardExampleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 599);
            this.Controls.Add(this.richStandardExample);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "StandardExampleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "规格源标准范例";
            this.Load += new System.EventHandler(this.StandardExampleForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StandardExampleForm_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richStandardExample;
    }
}