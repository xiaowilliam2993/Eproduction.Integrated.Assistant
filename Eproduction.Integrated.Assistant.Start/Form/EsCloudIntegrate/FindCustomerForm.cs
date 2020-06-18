using Eproduction.Integrated.Assistant.Common.Worker;
using Eproduction.Integrated.Assistant.Start.Core;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Eproduction.Integrated.Assistant.Start {
    public partial class FindCustomerForm : Form {
        private EscloudIntegrateContext _context;
        public EscloudIntegrateContext Context { get => _context; }
        public CustomerInfo CustomerInfo { get; private set; }
        public FindCustomerForm(EscloudIntegrateContext context) {
            InitializeComponent();

            _context = context;
        }

        private void btnCancel_Click(object sender, EventArgs e) {
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e) {
            if(CustomerInfo != null) {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnFind_Click(object sender, EventArgs e) {
            string customerInfo = tboxCustomerInfo.Text;
            string connectionString = "Server=rm-bp1k25v6j475s4ai7jo.mysql.rds.aliyuncs.com;Port=3306;Database=escloud-db;Uid=dbread;Pwd=Escloud238173";
            string commandText = $@"select distinct s1.CustomerType, s1.CustomerCode, s1.CustomerServiceCode, s1.CustomerName, s1.CustomerFullName
from (
	select 'E10' as CustomerType, t2.CustomerCode, t2.CustomerServiceCode, t2.CustomerName, t3.OrgName as CustomerFullName
	from `escloud-db`.mars_server t1
	inner join `escloud-db`.mars_customer t2 on t1.CustomerCode = t2.CustomerCode and t1.DeviceId is not null and t1.DeviceId <> ''
    inner join `escloud-db`.wx_org t3 on t2.CustomerCode = t3.OrgCode
	where t2.CustomerCode like '%{customerInfo}%' or t2.CustomerServiceCode like '%{customerInfo}%' or t2.CustomerName like '%{customerInfo}%'
	union all
	select 'YF' as CustomerType, t2.CustomerCode, t2.CustomerServiceCode, t2.CustomerName, t3.OrgName as CustomerFullName
	from `escloud-yifei`.mars_server t1
	inner join `escloud-db`.mars_customer t2 on t1.CustomerCode = t2.CustomerServiceCode and t1.DeviceId is not null and t1.DeviceId <> ''
    inner join `escloud-db`.wx_org t3 on t2.CustomerCode = t3.OrgCode
	where t2.CustomerCode like '%{customerInfo}%' or t2.CustomerServiceCode like '%{customerInfo}%' or t2.CustomerName like '%{customerInfo}%'
) s1";
            var customerQuery = MySqlWorker.Execute(connectionString, commandText);
            dgvCustomerQuery.DataSource = customerQuery;
        }

        private void dgvCustomerQuery_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex > -1 && e.RowIndex > -1) {
                var dataRow = dgvCustomerQuery.Rows.Cast<DataGridViewRow>().ToArray()[e.RowIndex];
                if (dataRow != null) {
                    CustomerInfo = new CustomerInfo() {
                        CustomerType = dataRow.Cells["colCustomerType"].Value.ToString() == "E10" ? CustomerType.E10 : CustomerType.YF,
                        CustomerCode = dataRow.Cells["colCustomerCode"].Value.ToString(),
                        CustomerServiceCode = dataRow.Cells["colCustomerServiceCode"].Value.ToString(),
                        CustomerName = dataRow.Cells["colCustomerName"].Value.ToString(),
                        CustomerFullName = dataRow.Cells["colCustomerFullName"].Value.ToString(),
                    };
                }
            }
        }
    }
}
