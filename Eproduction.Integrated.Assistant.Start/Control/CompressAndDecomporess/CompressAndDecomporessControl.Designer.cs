namespace Eproduction.Integrated.Assistant.Start.Control {
    partial class CompressAndDecomporessControl {
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
            this.SplitContainer = new System.Windows.Forms.SplitContainer();
            this.lblSources = new System.Windows.Forms.Label();
            this.richboxCompressed = new System.Windows.Forms.RichTextBox();
            this.pnlCompressedLineNo = new System.Windows.Forms.Panel();
            this.richboxDecompressed = new System.Windows.Forms.RichTextBox();
            this.pnlDecompressedLineNo = new System.Windows.Forms.Panel();
            this.lblEncrypt = new System.Windows.Forms.Label();
            this.pnlCompressionToolbar = new System.Windows.Forms.Panel();
            this.btnDecompression = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.btnCompression = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.btnClear = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.btnWordWarp = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).BeginInit();
            this.SplitContainer.Panel1.SuspendLayout();
            this.SplitContainer.Panel2.SuspendLayout();
            this.SplitContainer.SuspendLayout();
            this.pnlCompressionToolbar.SuspendLayout();
            this.SuspendLayout();
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
            this.SplitContainer.Panel1.Controls.Add(this.richboxCompressed);
            this.SplitContainer.Panel1.Controls.Add(this.pnlCompressedLineNo);
            // 
            // SplitContainer.Panel2
            // 
            this.SplitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.SplitContainer.Panel2.Controls.Add(this.richboxDecompressed);
            this.SplitContainer.Panel2.Controls.Add(this.pnlDecompressedLineNo);
            this.SplitContainer.Panel2.Controls.Add(this.lblEncrypt);
            this.SplitContainer.Size = new System.Drawing.Size(772, 383);
            this.SplitContainer.SplitterDistance = 441;
            this.SplitContainer.TabIndex = 5;
            // 
            // lblSources
            // 
            this.lblSources.AutoSize = true;
            this.lblSources.Image = global::Eproduction.Integrated.Assistant.Start.Properties.Resources.sources;
            this.lblSources.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSources.Location = new System.Drawing.Point(37, 10);
            this.lblSources.Name = "lblSources";
            this.lblSources.Size = new System.Drawing.Size(172, 17);
            this.lblSources.TabIndex = 6;
            this.lblSources.Text = "     压缩源（来源格式原文本）";
            // 
            // richboxCompressed
            // 
            this.richboxCompressed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richboxCompressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.richboxCompressed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richboxCompressed.EnableAutoDragDrop = true;
            this.richboxCompressed.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richboxCompressed.HideSelection = false;
            this.richboxCompressed.Location = new System.Drawing.Point(40, 38);
            this.richboxCompressed.Name = "richboxCompressed";
            this.richboxCompressed.Size = new System.Drawing.Size(398, 342);
            this.richboxCompressed.TabIndex = 8;
            this.richboxCompressed.Text = "";
            this.richboxCompressed.WordWrap = false;
            // 
            // pnlCompressedLineNo
            // 
            this.pnlCompressedLineNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlCompressedLineNo.BackColor = System.Drawing.Color.Transparent;
            this.pnlCompressedLineNo.Location = new System.Drawing.Point(4, 38);
            this.pnlCompressedLineNo.Name = "pnlCompressedLineNo";
            this.pnlCompressedLineNo.Size = new System.Drawing.Size(35, 342);
            this.pnlCompressedLineNo.TabIndex = 7;
            // 
            // richboxDecompressed
            // 
            this.richboxDecompressed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richboxDecompressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.richboxDecompressed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richboxDecompressed.EnableAutoDragDrop = true;
            this.richboxDecompressed.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richboxDecompressed.HideSelection = false;
            this.richboxDecompressed.Location = new System.Drawing.Point(40, 38);
            this.richboxDecompressed.Name = "richboxDecompressed";
            this.richboxDecompressed.Size = new System.Drawing.Size(284, 342);
            this.richboxDecompressed.TabIndex = 11;
            this.richboxDecompressed.Text = "";
            this.richboxDecompressed.WordWrap = false;
            // 
            // pnlDecompressedLineNo
            // 
            this.pnlDecompressedLineNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlDecompressedLineNo.BackColor = System.Drawing.Color.Transparent;
            this.pnlDecompressedLineNo.Location = new System.Drawing.Point(4, 38);
            this.pnlDecompressedLineNo.Name = "pnlDecompressedLineNo";
            this.pnlDecompressedLineNo.Size = new System.Drawing.Size(35, 342);
            this.pnlDecompressedLineNo.TabIndex = 10;
            // 
            // lblEncrypt
            // 
            this.lblEncrypt.AutoSize = true;
            this.lblEncrypt.Image = global::Eproduction.Integrated.Assistant.Start.Properties.Resources.encrypt;
            this.lblEncrypt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEncrypt.Location = new System.Drawing.Point(37, 10);
            this.lblEncrypt.Name = "lblEncrypt";
            this.lblEncrypt.Size = new System.Drawing.Size(172, 17);
            this.lblEncrypt.TabIndex = 9;
            this.lblEncrypt.Text = "     压缩文本（压缩后的内容）";
            // 
            // pnlCompressionToolbar
            // 
            this.pnlCompressionToolbar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCompressionToolbar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnlCompressionToolbar.Controls.Add(this.btnDecompression);
            this.pnlCompressionToolbar.Controls.Add(this.btnCompression);
            this.pnlCompressionToolbar.Controls.Add(this.btnClear);
            this.pnlCompressionToolbar.Controls.Add(this.btnWordWarp);
            this.pnlCompressionToolbar.Location = new System.Drawing.Point(531, 3);
            this.pnlCompressionToolbar.Name = "pnlCompressionToolbar";
            this.pnlCompressionToolbar.Size = new System.Drawing.Size(238, 27);
            this.pnlCompressionToolbar.TabIndex = 0;
            // 
            // btnDecompression
            // 
            this.btnDecompression.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnDecompression.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnDecompression.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDecompression.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDecompression.Image = global::Eproduction.Integrated.Assistant.Start.Properties.Resources.transfer;
            this.btnDecompression.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDecompression.Location = new System.Drawing.Point(60, 1);
            this.btnDecompression.Name = "btnDecompression";
            this.btnDecompression.Size = new System.Drawing.Size(59, 25);
            this.btnDecompression.TabIndex = 2;
            this.btnDecompression.Text = "    解压";
            this.btnDecompression.UseVisualStyleBackColor = false;
            this.btnDecompression.Click += new System.EventHandler(this.btnDecompression_Click);
            // 
            // btnCompression
            // 
            this.btnCompression.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnCompression.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnCompression.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompression.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCompression.Image = global::Eproduction.Integrated.Assistant.Start.Properties.Resources.compression;
            this.btnCompression.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompression.Location = new System.Drawing.Point(1, 1);
            this.btnCompression.Name = "btnCompression";
            this.btnCompression.Size = new System.Drawing.Size(59, 25);
            this.btnCompression.TabIndex = 1;
            this.btnCompression.Text = "    压缩";
            this.btnCompression.UseVisualStyleBackColor = false;
            this.btnCompression.Click += new System.EventHandler(this.btnCompression_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnClear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.Image = global::Eproduction.Integrated.Assistant.Start.Properties.Resources.clear;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(178, 1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(59, 25);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "    清理";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnWordWarp
            // 
            this.btnWordWarp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnWordWarp.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnWordWarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWordWarp.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnWordWarp.Image = global::Eproduction.Integrated.Assistant.Start.Properties.Resources.word_warp;
            this.btnWordWarp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWordWarp.Location = new System.Drawing.Point(119, 1);
            this.btnWordWarp.Name = "btnWordWarp";
            this.btnWordWarp.Size = new System.Drawing.Size(59, 25);
            this.btnWordWarp.TabIndex = 3;
            this.btnWordWarp.Text = "    换行";
            this.btnWordWarp.UseVisualStyleBackColor = false;
            this.btnWordWarp.Click += new System.EventHandler(this.btnWordWarp_Click);
            // 
            // CompressAndDecomporessControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.pnlCompressionToolbar);
            this.Controls.Add(this.SplitContainer);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "CompressAndDecomporessControl";
            this.Size = new System.Drawing.Size(772, 417);
            this.SplitContainer.Panel1.ResumeLayout(false);
            this.SplitContainer.Panel1.PerformLayout();
            this.SplitContainer.Panel2.ResumeLayout(false);
            this.SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SplitContainer)).EndInit();
            this.SplitContainer.ResumeLayout(false);
            this.pnlCompressionToolbar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.RichTextBox richboxCompressed;
        private System.Windows.Forms.Panel pnlCompressedLineNo;
        private System.Windows.Forms.RichTextBox richboxDecompressed;
        private System.Windows.Forms.Panel pnlDecompressedLineNo;
        private System.Windows.Forms.Panel pnlCompressionToolbar;
        private Common.Control.ButtonEx btnClear;
        private Common.Control.ButtonEx btnWordWarp;
        private Common.Control.ButtonEx btnDecompression;
        private Common.Control.ButtonEx btnCompression;
        private System.Windows.Forms.Label lblSources;
        private System.Windows.Forms.Label lblEncrypt;
    }
}
