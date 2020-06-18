using System.Windows.Forms;
using Eproduction.Integrated.Assistant.Start.Core;

namespace Eproduction.Integrated.Assistant.Start.Control {
    public partial class EscloudIntegrateControl : UserControl {
        private EpIAContext _EpIAContext = null;
        public EpIAContext EpIAContext { get => _EpIAContext; }
        private EscloudIntegrateContext Context { get => EpIAContext.EscloudIntegrateContext; }
        public CustomerInfo CustomerInfo { get; set; }
        public EscloudIntegrateControl(EpIAContext context) {
            InitializeComponent();

            Dock = DockStyle.Fill;

            _EpIAContext = context;
        }

        private void btnFindCustomer_Click(object sender, System.EventArgs e) {
            using (var findForm = new FindCustomerForm(Context)) {
                if (findForm.ShowDialog() == DialogResult.OK) {
                    CustomerInfo = findForm.CustomerInfo;
                    lblCustomerName.Text = CustomerInfo.CustomerFullName;
                    lblCustomerCode.Text = CustomerInfo.CustomerCode;
                    lblCustomerServiceCode.Text = CustomerInfo.CustomerServiceCode;
                    lblCustomerType.Text = CustomerInfo.CustomerType == CustomerType.E10 ? "E10" : "易飞";
                }
            }
        }

        private void btnDbConnectionSetting_Click(object sender, System.EventArgs e) {
            using (var settingForm = new EsCloudDbConnectionSettingForm()) {
                settingForm.ShowDialog();
            }
        }
    }
}
