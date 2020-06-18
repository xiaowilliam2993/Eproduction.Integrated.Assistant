namespace Eproduction.Integrated.Assistant.Start.Control {
    partial class ExtractInsertPropertyControl {
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
            this.pnlExtractToolbar = new System.Windows.Forms.Panel();
            this.btnExtract = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.lblSources = new System.Windows.Forms.Label();
            this.richboxSpecificationSource = new System.Windows.Forms.RichTextBox();
            this.pnlSpecificationSourceLineNo = new System.Windows.Forms.Panel();
            this.richboxExtract = new System.Windows.Forms.RichTextBox();
            this.pnlExtractLineNo = new System.Windows.Forms.Panel();
            this.lblExtract = new System.Windows.Forms.Label();
            this.lblLeftDelimiterChar = new System.Windows.Forms.Label();
            this.tboxLeftDelimiterChar = new System.Windows.Forms.TextBox();
            this.tboxRightDelimiterChar = new System.Windows.Forms.TextBox();
            this.lblRightDelimiterChar = new System.Windows.Forms.Label();
            this.pnlExtractToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlExtractToolbar
            // 
            this.pnlExtractToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnlExtractToolbar.Controls.Add(this.btnExtract);
            this.pnlExtractToolbar.Location = new System.Drawing.Point(481, 3);
            this.pnlExtractToolbar.Name = "pnlExtractToolbar";
            this.pnlExtractToolbar.Size = new System.Drawing.Size(61, 27);
            this.pnlExtractToolbar.TabIndex = 1;
            // 
            // btnExtract
            // 
            this.btnExtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnExtract.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnExtract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExtract.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExtract.Image = global::Eproduction.Integrated.Assistant.Start.Properties.Resources.extract;
            this.btnExtract.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExtract.Location = new System.Drawing.Point(1, 1);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(59, 25);
            this.btnExtract.TabIndex = 4;
            this.btnExtract.Text = "    提取";
            this.btnExtract.UseVisualStyleBackColor = false;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // SplitContainer
            // 
            this.SplitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SplitContainer.BackColor = System.Drawing.Color.Transparent;
            this.SplitContainer.Location = new System.Drawing.Point(0, 34);
            this.SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            this.SplitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.SplitContainer.Panel1.Controls.Add(this.lblSources);
            this.SplitContainer.Panel1.Controls.Add(this.richboxSpecificationSource);
            this.SplitContainer.Panel1.Controls.Add(this.pnlSpecificationSourceLineNo);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.SplitContainer.Panel2.Controls.Add(this.richboxExtract);
            this.SplitContainer.Panel2.Controls.Add(this.pnlExtractLineNo);
            this.SplitContainer.Panel2.Controls.Add(this.lblExtract);
            this.SplitContainer.Size = new System.Drawing.Size(772, 383);
            this.SplitContainer.SplitterDistance = 441;
            this.SplitContainer.TabIndex = 6;
            // 
            // lblSources
            // 
            this.lblSources.AutoSize = true;
            this.lblSources.Image = global::Eproduction.Integrated.Assistant.Start.Properties.Resources.sources;
            this.lblSources.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSources.Location = new System.Drawing.Point(37, 10);
            this.lblSources.Name = "lblSources";
            this.lblSources.Size = new System.Drawing.Size(136, 17);
            this.lblSources.TabIndex = 6;
            this.lblSources.Text = "     规格源（来源文本）";
            // 
            // richboxSpecificationSource
            // 
            this.richboxSpecificationSource.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richboxSpecificationSource.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.richboxSpecificationSource.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richboxSpecificationSource.EnableAutoDragDrop = true;
            this.richboxSpecificationSource.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richboxSpecificationSource.HideSelection = false;
            this.richboxSpecificationSource.Location = new System.Drawing.Point(40, 38);
            this.richboxSpecificationSource.Name = "richboxSpecificationSource";
            this.richboxSpecificationSource.Size = new System.Drawing.Size(398, 342);
            this.richboxSpecificationSource.TabIndex = 8;
            this.richboxSpecificationSource.Text = "";
            this.richboxSpecificationSource.WordWrap = false;
            // 
            // pnlSpecificationSourceLineNo
            // 
            this.pnlSpecificationSourceLineNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlSpecificationSourceLineNo.BackColor = System.Drawing.Color.Transparent;
            this.pnlSpecificationSourceLineNo.Location = new System.Drawing.Point(4, 38);
            this.pnlSpecificationSourceLineNo.Name = "pnlSpecificationSourceLineNo";
            this.pnlSpecificationSourceLineNo.Size = new System.Drawing.Size(35, 342);
            this.pnlSpecificationSourceLineNo.TabIndex = 7;
            // 
            // richboxExtract
            // 
            this.richboxExtract.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richboxExtract.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.richboxExtract.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richboxExtract.EnableAutoDragDrop = true;
            this.richboxExtract.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richboxExtract.HideSelection = false;
            this.richboxExtract.Location = new System.Drawing.Point(40, 38);
            this.richboxExtract.Name = "richboxExtract";
            this.richboxExtract.Size = new System.Drawing.Size(284, 342);
            this.richboxExtract.TabIndex = 11;
            this.richboxExtract.Text = "";
            this.richboxExtract.WordWrap = false;
            // 
            // pnlExtractLineNo
            // 
            this.pnlExtractLineNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlExtractLineNo.BackColor = System.Drawing.Color.Transparent;
            this.pnlExtractLineNo.Location = new System.Drawing.Point(4, 38);
            this.pnlExtractLineNo.Name = "pnlExtractLineNo";
            this.pnlExtractLineNo.Size = new System.Drawing.Size(35, 342);
            this.pnlExtractLineNo.TabIndex = 10;
            // 
            // lblExtract
            // 
            this.lblExtract.AutoSize = true;
            this.lblExtract.Image = global::Eproduction.Integrated.Assistant.Start.Properties.Resources.code;
            this.lblExtract.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblExtract.Location = new System.Drawing.Point(37, 10);
            this.lblExtract.Name = "lblExtract";
            this.lblExtract.Size = new System.Drawing.Size(160, 17);
            this.lblExtract.TabIndex = 9;
            this.lblExtract.Text = "     源代码（转换后的内容）";
            // 
            // lblLeftDelimiterChar
            // 
            this.lblLeftDelimiterChar.AutoSize = true;
            this.lblLeftDelimiterChar.Location = new System.Drawing.Point(37, 8);
            this.lblLeftDelimiterChar.Name = "lblLeftDelimiterChar";
            this.lblLeftDelimiterChar.Size = new System.Drawing.Size(56, 17);
            this.lblLeftDelimiterChar.TabIndex = 7;
            this.lblLeftDelimiterChar.Text = "起始字符";
            // 
            // tboxLeftDelimiterChar
            // 
            this.tboxLeftDelimiterChar.Location = new System.Drawing.Point(99, 5);
            this.tboxLeftDelimiterChar.Name = "tboxLeftDelimiterChar";
            this.tboxLeftDelimiterChar.Size = new System.Drawing.Size(149, 23);
            this.tboxLeftDelimiterChar.TabIndex = 8;
            // 
            // tboxRightDelimiterChar
            // 
            this.tboxRightDelimiterChar.Location = new System.Drawing.Point(326, 5);
            this.tboxRightDelimiterChar.Name = "tboxRightDelimiterChar";
            this.tboxRightDelimiterChar.Size = new System.Drawing.Size(149, 23);
            this.tboxRightDelimiterChar.TabIndex = 10;
            // 
            // lblRightDelimiterChar
            // 
            this.lblRightDelimiterChar.AutoSize = true;
            this.lblRightDelimiterChar.Location = new System.Drawing.Point(264, 8);
            this.lblRightDelimiterChar.Name = "lblRightDelimiterChar";
            this.lblRightDelimiterChar.Size = new System.Drawing.Size(56, 17);
            this.lblRightDelimiterChar.TabIndex = 9;
            this.lblRightDelimiterChar.Text = "截止字符";
            // 
            // ExtractInsertPropertyControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tboxRightDelimiterChar);
            this.Controls.Add(this.lblRightDelimiterChar);
            this.Controls.Add(this.tboxLeftDelimiterChar);
            this.Controls.Add(this.lblLeftDelimiterChar);
            this.Controls.Add(this.SplitContainer);
            this.Controls.Add(this.pnlExtractToolbar);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ExtractInsertPropertyControl";
            this.Size = new System.Drawing.Size(772, 417);
            this.pnlExtractToolbar.ResumeLayout(false);
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel1.PerformLayout();
            this.SplitContainer.Panel2.ResumeLayout(false);
            this.SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlExtractToolbar;
        private Common.Control.ButtonEx btnExtract;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.Label lblSources;
        private System.Windows.Forms.RichTextBox richboxSpecificationSource;
        private System.Windows.Forms.Panel pnlSpecificationSourceLineNo;
        private System.Windows.Forms.RichTextBox richboxExtract;
        private System.Windows.Forms.Panel pnlExtractLineNo;
        private System.Windows.Forms.Label lblExtract;
        private System.Windows.Forms.Label lblLeftDelimiterChar;
        private System.Windows.Forms.TextBox tboxLeftDelimiterChar;
        private System.Windows.Forms.TextBox tboxRightDelimiterChar;
        private System.Windows.Forms.Label lblRightDelimiterChar;
    }
}
