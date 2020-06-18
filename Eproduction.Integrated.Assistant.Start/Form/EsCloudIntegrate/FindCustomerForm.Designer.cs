namespace Eproduction.Integrated.Assistant.Start {
    partial class FindCustomerForm {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindCustomerForm));
            this.lblPrompt = new System.Windows.Forms.Label();
            this.tboxCustomerInfo = new System.Windows.Forms.TextBox();
            this.btnFind = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.dgvCustomerQuery = new System.Windows.Forms.DataGridView();
            this.colCustomerType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerServiceCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCustomerFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            this.btnConfirm = new Eproduction.Integrated.Assistant.Common.Control.ButtonEx();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerQuery)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPrompt
            // 
            this.lblPrompt.AutoSize = true;
            this.lblPrompt.Location = new System.Drawing.Point(12, 9);
            this.lblPrompt.Name = "lblPrompt";
            this.lblPrompt.Size = new System.Drawing.Size(296, 17);
            this.lblPrompt.TabIndex = 0;
            this.lblPrompt.Text = "输入客户信息（客户名称、客户编号、客服代号等等）";
            // 
            // tboxCustomerInfo
            // 
            this.tboxCustomerInfo.Location = new System.Drawing.Point(15, 29);
            this.tboxCustomerInfo.Name = "tboxCustomerInfo";
            this.tboxCustomerInfo.Size = new System.Drawing.Size(475, 23);
            this.tboxCustomerInfo.TabIndex = 1;
            // 
            // btnFind
            // 
            this.btnFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnFind.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFind.Location = new System.Drawing.Point(486, 29);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(82, 23);
            this.btnFind.TabIndex = 2;
            this.btnFind.Text = "查找";
            this.btnFind.UseVisualStyleBackColor = false;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // dgvCustomerQuery
            // 
            this.dgvCustomerQuery.AllowUserToAddRows = false;
            this.dgvCustomerQuery.AllowUserToDeleteRows = false;
            this.dgvCustomerQuery.AllowUserToResizeRows = false;
            this.dgvCustomerQuery.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCustomerQuery.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCustomerQuery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerQuery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCustomerType,
            this.colCustomerCode,
            this.colCustomerServiceCode,
            this.colCustomerName,
            this.colCustomerFullName});
            this.dgvCustomerQuery.Location = new System.Drawing.Point(15, 58);
            this.dgvCustomerQuery.MultiSelect = false;
            this.dgvCustomerQuery.Name = "dgvCustomerQuery";
            this.dgvCustomerQuery.ReadOnly = true;
            this.dgvCustomerQuery.RowHeadersVisible = false;
            this.dgvCustomerQuery.RowTemplate.Height = 23;
            this.dgvCustomerQuery.Size = new System.Drawing.Size(553, 185);
            this.dgvCustomerQuery.TabIndex = 3;
            this.dgvCustomerQuery.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerQuery_CellClick);
            // 
            // colCustomerType
            // 
            this.colCustomerType.DataPropertyName = "CustomerType";
            this.colCustomerType.HeaderText = "客户类型";
            this.colCustomerType.Name = "colCustomerType";
            this.colCustomerType.ReadOnly = true;
            // 
            // colCustomerCode
            // 
            this.colCustomerCode.DataPropertyName = "CustomerCode";
            this.colCustomerCode.HeaderText = "客户编号";
            this.colCustomerCode.Name = "colCustomerCode";
            this.colCustomerCode.ReadOnly = true;
            // 
            // colCustomerServiceCode
            // 
            this.colCustomerServiceCode.DataPropertyName = "CustomerServiceCode";
            this.colCustomerServiceCode.HeaderText = "客服代号";
            this.colCustomerServiceCode.Name = "colCustomerServiceCode";
            this.colCustomerServiceCode.ReadOnly = true;
            // 
            // colCustomerName
            // 
            this.colCustomerName.DataPropertyName = "CustomerName";
            this.colCustomerName.HeaderText = "客户简称";
            this.colCustomerName.Name = "colCustomerName";
            this.colCustomerName.ReadOnly = true;
            // 
            // colCustomerFullName
            // 
            this.colCustomerFullName.DataPropertyName = "CustomerFullName";
            this.colCustomerFullName.HeaderText = "客户全称";
            this.colCustomerFullName.Name = "colCustomerFullName";
            this.colCustomerFullName.ReadOnly = true;
            this.colCustomerFullName.Width = 150;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCancel.Location = new System.Drawing.Point(486, 249);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfirm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnConfirm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("微软雅黑", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConfirm.Location = new System.Drawing.Point(398, 249);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(82, 23);
            this.btnConfirm.TabIndex = 5;
            this.btnConfirm.Text = "确定";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // FindCustomerForm
            // 
            this.AcceptButton = this.btnFind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 278);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvCustomerQuery);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.tboxCustomerInfo);
            this.Controls.Add(this.lblPrompt);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FindCustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查找客户资料";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerQuery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPrompt;
        private System.Windows.Forms.TextBox tboxCustomerInfo;
        private Common.Control.ButtonEx btnFind;
        private System.Windows.Forms.DataGridView dgvCustomerQuery;
        private Common.Control.ButtonEx btnCancel;
        private Common.Control.ButtonEx btnConfirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerType;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerServiceCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCustomerFullName;
    }
}