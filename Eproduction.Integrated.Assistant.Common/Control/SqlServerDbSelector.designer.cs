namespace Eproduction.Integrated.Assistant.Common.Control {
    partial class SqlServerDbSelector {
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
            this.cbboxServer = new Eproduction.Integrated.Assistant.Common.Control.ComboBoxEx();
            this.cbboxChooseDatabase = new Eproduction.Integrated.Assistant.Common.Control.ComboBoxEx();
            this.lblChooseDatabase = new System.Windows.Forms.Label();
            this.btnTestConnect = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.gboxLogon = new System.Windows.Forms.GroupBox();
            this.tboxPassport = new Eproduction.Integrated.Assistant.Common.Control.TextBoxEx();
            this.tboxUsername = new Eproduction.Integrated.Assistant.Common.Control.TextBoxEx();
            this.lblPassport = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.cbboxIdentityVerifyType = new Eproduction.Integrated.Assistant.Common.Control.ComboBoxEx();
            this.lblIdentityVerify = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LoadingWorker = new System.ComponentModel.BackgroundWorker();
            this.gboxLogon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cbboxServer
            // 
            this.cbboxServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbboxServer.BorderColor = System.Drawing.Color.Silver;
            this.cbboxServer.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cbboxServer.FormattingEnabled = true;
            this.cbboxServer.HotColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbboxServer.Location = new System.Drawing.Point(18, 35);
            this.cbboxServer.Name = "cbboxServer";
            this.cbboxServer.Size = new System.Drawing.Size(346, 25);
            this.cbboxServer.TabIndex = 68;
            // 
            // cbboxChooseDatabase
            // 
            this.cbboxChooseDatabase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbboxChooseDatabase.BorderColor = System.Drawing.Color.Silver;
            this.cbboxChooseDatabase.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cbboxChooseDatabase.FormattingEnabled = true;
            this.cbboxChooseDatabase.HotColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbboxChooseDatabase.Location = new System.Drawing.Point(18, 220);
            this.cbboxChooseDatabase.Name = "cbboxChooseDatabase";
            this.cbboxChooseDatabase.Size = new System.Drawing.Size(346, 25);
            this.cbboxChooseDatabase.TabIndex = 69;
            this.cbboxChooseDatabase.DropDown += new System.EventHandler(this.cbboxChooseDatabase_DropDown);
            // 
            // lblChooseDatabase
            // 
            this.lblChooseDatabase.AutoSize = true;
            this.lblChooseDatabase.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblChooseDatabase.Location = new System.Drawing.Point(25, 200);
            this.lblChooseDatabase.Name = "lblChooseDatabase";
            this.lblChooseDatabase.Size = new System.Drawing.Size(221, 17);
            this.lblChooseDatabase.TabIndex = 67;
            this.lblChooseDatabase.Text = "选择或输入营运指标对应E10数据库名称";
            // 
            // btnTestConnect
            // 
            this.btnTestConnect.BackColor = System.Drawing.Color.Gainsboro;
            this.btnTestConnect.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnTestConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTestConnect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTestConnect.Location = new System.Drawing.Point(17, 251);
            this.btnTestConnect.Name = "btnTestConnect";
            this.btnTestConnect.Size = new System.Drawing.Size(75, 27);
            this.btnTestConnect.TabIndex = 64;
            this.btnTestConnect.Text = "测试连接";
            this.btnTestConnect.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTestConnect.UseVisualStyleBackColor = false;
            this.btnTestConnect.Click += new System.EventHandler(this.btnTestConnect_Click);
            // 
            // gboxLogon
            // 
            this.gboxLogon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxLogon.BackColor = System.Drawing.Color.Transparent;
            this.gboxLogon.Controls.Add(this.tboxPassport);
            this.gboxLogon.Controls.Add(this.tboxUsername);
            this.gboxLogon.Controls.Add(this.lblPassport);
            this.gboxLogon.Controls.Add(this.lblUsername);
            this.gboxLogon.Controls.Add(this.cbboxIdentityVerifyType);
            this.gboxLogon.Controls.Add(this.lblIdentityVerify);
            this.gboxLogon.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.gboxLogon.Location = new System.Drawing.Point(18, 72);
            this.gboxLogon.Name = "gboxLogon";
            this.gboxLogon.Size = new System.Drawing.Size(346, 116);
            this.gboxLogon.TabIndex = 66;
            this.gboxLogon.TabStop = false;
            this.gboxLogon.Text = "登录到服务器";
            // 
            // tboxPassport
            // 
            this.tboxPassport.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxPassport.BorderColor = System.Drawing.Color.Silver;
            this.tboxPassport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxPassport.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tboxPassport.HotColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tboxPassport.Location = new System.Drawing.Point(81, 83);
            this.tboxPassport.Name = "tboxPassport";
            this.tboxPassport.PasswordChar = '●';
            this.tboxPassport.ReadOnly = true;
            this.tboxPassport.Size = new System.Drawing.Size(248, 23);
            this.tboxPassport.TabIndex = 62;
            this.tboxPassport.UseSystemPasswordChar = true;
            // 
            // tboxUsername
            // 
            this.tboxUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxUsername.BorderColor = System.Drawing.Color.Silver;
            this.tboxUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxUsername.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.tboxUsername.HotColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tboxUsername.Location = new System.Drawing.Point(81, 54);
            this.tboxUsername.Name = "tboxUsername";
            this.tboxUsername.ReadOnly = true;
            this.tboxUsername.Size = new System.Drawing.Size(248, 23);
            this.tboxUsername.TabIndex = 61;
            // 
            // lblPassport
            // 
            this.lblPassport.AutoSize = true;
            this.lblPassport.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPassport.Location = new System.Drawing.Point(19, 87);
            this.lblPassport.Name = "lblPassport";
            this.lblPassport.Size = new System.Drawing.Size(32, 17);
            this.lblPassport.TabIndex = 60;
            this.lblPassport.Text = "密码";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblUsername.Location = new System.Drawing.Point(19, 57);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(44, 17);
            this.lblUsername.TabIndex = 59;
            this.lblUsername.Text = "用户名";
            // 
            // cbboxIdentityVerifyType
            // 
            this.cbboxIdentityVerifyType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbboxIdentityVerifyType.BorderColor = System.Drawing.Color.Silver;
            this.cbboxIdentityVerifyType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxIdentityVerifyType.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.cbboxIdentityVerifyType.FormattingEnabled = true;
            this.cbboxIdentityVerifyType.HotColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cbboxIdentityVerifyType.Items.AddRange(new object[] {
            "Windows 身份验证",
            "SQL Server 身份验证"});
            this.cbboxIdentityVerifyType.Location = new System.Drawing.Point(81, 20);
            this.cbboxIdentityVerifyType.Name = "cbboxIdentityVerifyType";
            this.cbboxIdentityVerifyType.Size = new System.Drawing.Size(248, 25);
            this.cbboxIdentityVerifyType.TabIndex = 58;
            this.cbboxIdentityVerifyType.SelectedIndexChanged += new System.EventHandler(this.cbboxIdentityVerifyType_SelectedIndexChanged);
            // 
            // lblIdentityVerify
            // 
            this.lblIdentityVerify.AutoSize = true;
            this.lblIdentityVerify.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIdentityVerify.Location = new System.Drawing.Point(19, 25);
            this.lblIdentityVerify.Name = "lblIdentityVerify";
            this.lblIdentityVerify.Size = new System.Drawing.Size(56, 17);
            this.lblIdentityVerify.TabIndex = 57;
            this.lblIdentityVerify.Text = "身份验证";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblServer.Location = new System.Drawing.Point(25, 15);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(172, 17);
            this.lblServer.TabIndex = 65;
            this.lblServer.Text = "输入营运指标对应E10服务器IP";
            // 
            // LoadingWorker
            // 
            this.LoadingWorker.WorkerReportsProgress = true;
            this.LoadingWorker.WorkerSupportsCancellation = true;
            // 
            // SqlServerDbSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Controls.Add(this.cbboxServer);
            this.Controls.Add(this.cbboxChooseDatabase);
            this.Controls.Add(this.lblChooseDatabase);
            this.Controls.Add(this.btnTestConnect);
            this.Controls.Add(this.gboxLogon);
            this.Controls.Add(this.lblServer);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SqlServerDbSelector";
            this.Size = new System.Drawing.Size(382, 291);
            this.Load += new System.EventHandler(this.SqlServerDbSelector_Load);
            this.gboxLogon.ResumeLayout(false);
            this.gboxLogon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Eproduction.Integrated.Assistant.Common.Control.ComboBoxEx cbboxServer;
        public Eproduction.Integrated.Assistant.Common.Control.ComboBoxEx cbboxChooseDatabase;
        public System.Windows.Forms.Label lblChooseDatabase;
        public Eproduction.Integrated.Assistant.Common.Control.ButtonEx btnTestConnect;
        private System.Windows.Forms.GroupBox gboxLogon;
        public Eproduction.Integrated.Assistant.Common.Control.TextBoxEx tboxPassport;
        public Eproduction.Integrated.Assistant.Common.Control.TextBoxEx tboxUsername;
        private System.Windows.Forms.Label lblPassport;
        private System.Windows.Forms.Label lblUsername;
        public Eproduction.Integrated.Assistant.Common.Control.ComboBoxEx cbboxIdentityVerifyType;
        private System.Windows.Forms.Label lblIdentityVerify;
        public System.Windows.Forms.Label lblServer;
        public System.Windows.Forms.BindingSource BindingSource;
        private System.ComponentModel.BackgroundWorker LoadingWorker;
    }
}
