namespace Eproduction.Integrated.Assistant.Start {
    partial class SqlServerConnectSettingForm {
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
            Eproduction.Integrated.Assistant.Common.Core.SqlServerDbContext sqlServerDbContext1 = new Eproduction.Integrated.Assistant.Common.Core.SqlServerDbContext();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlServerConnectSettingForm));
            this.SqlServerDbSelector = new Eproduction.Integrated.Assistant.Common.Control.SqlServerDbSelector();
            this.pnlFooter = new Eproduction.Integrated.Assistant.Common.Control.PanelEx();
            this.btnExit = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.btnConfirm = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.pnlFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // SqlServerDbSelector
            // 
            this.SqlServerDbSelector.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SqlServerDbSelector.ConnectionString = "";
            sqlServerDbContext1.Catalog = null;
            sqlServerDbContext1.DbServerSource = 0;
            sqlServerDbContext1.Exists = false;
            sqlServerDbContext1.IdentityVerify = 0;
            sqlServerDbContext1.Passport = null;
            sqlServerDbContext1.Server = null;
            sqlServerDbContext1.Username = null;
            this.SqlServerDbSelector.DataSource = sqlServerDbContext1;
            this.SqlServerDbSelector.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SqlServerDbSelector.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SqlServerDbSelector.Location = new System.Drawing.Point(0, 0);
            this.SqlServerDbSelector.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SqlServerDbSelector.Name = "SqlServerDbSelector";
            this.SqlServerDbSelector.Size = new System.Drawing.Size(424, 342);
            this.SqlServerDbSelector.TabIndex = 0;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFooter.BorderColor = System.Drawing.Color.Silver;
            this.pnlFooter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFooter.BorderWidth = 1;
            this.pnlFooter.Controls.Add(this.btnExit);
            this.pnlFooter.Controls.Add(this.btnConfirm);
            this.pnlFooter.Location = new System.Drawing.Point(-1, 293);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(426, 50);
            this.pnlFooter.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.Location = new System.Drawing.Point(331, 9);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 28);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "退出(E)";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConfirm.Location = new System.Drawing.Point(250, 9);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 28);
            this.btnConfirm.TabIndex = 0;
            this.btnConfirm.Text = "确定(C)";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // SqlServerConnectSettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 342);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.SqlServerDbSelector);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SqlServerConnectSettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "维护SQL Server数据库连接设置";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SqlServerConnectSettingForm_KeyDown);
            this.pnlFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Common.Control.SqlServerDbSelector SqlServerDbSelector;
        private Common.Control.PanelEx pnlFooter;
        private Common.Control.ButtonEx btnExit;
        private Common.Control.ButtonEx btnConfirm;
    }
}