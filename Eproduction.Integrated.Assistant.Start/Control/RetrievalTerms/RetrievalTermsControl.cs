using System;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using Eproduction.Integrated.Assistant.Common;
using Eproduction.Integrated.Assistant.Common.Core.Implement;
using Eproduction.Integrated.Assistant.Common.Core.Implement.Interface;
using Eproduction.Integrated.Assistant.Start.Core;
using Eproduction.Integrated.Assistant.Start.Core.Section;
using System.Collections.Generic;

namespace Eproduction.Integrated.Assistant.Start.Control {
    public partial class RetrievalTermsControl : UserControl {
        private EpIAContext _EpIAContext = null;
        public EpIAContext EpIAContext { get => _EpIAContext; }
        public RetrievalTermsContext Context { get => EpIAContext.RetrievalTermsContext; }

        private IEnumerable<IComponent> _Components = null;

        private EnabledComponentsProxy _enabledComponentsProxy = null;
        private delegate void EnabledComponentsProxy(IEnumerable<IComponent> components, bool enabled);
        private SetGridDataSourceProxy _setGridDataSourceProxy = null;
        private delegate void SetGridDataSourceProxy(DataGridView dgvEntries, DataTable dataSource);
        private SetGridSetyleProxy _setGridStyleProxy = null;
        private delegate void SetGridSetyleProxy(DataGridView dgvEntries);
        public RetrievalTermsControl(EpIAContext context) {
            _enabledComponentsProxy = new EnabledComponentsProxy((IEnumerable<IComponent> components, bool enabled) => {
                IComponentUtils.RefreshStatus(components, enabled);
            });
            _setGridDataSourceProxy = new SetGridDataSourceProxy((DataGridView dgvEntries, DataTable dataSource) => {
                dgvEntries.DataSource = dataSource;
            });
            _setGridStyleProxy = new SetGridSetyleProxy((DataGridView dgvEntries) => {
                foreach (DataGridViewColumn column in dgvEntries.Columns) {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                    Type valueType = column.ValueType;
                    if (valueType == typeof(int) ||
                        valueType == typeof(double) ||
                        valueType == typeof(decimal) ||
                        valueType == typeof(float)) {
                        column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                    }
                }
            });
            InitializeComponent();

            Dock = DockStyle.Fill;

            _EpIAContext = context;

            _Components = new IComponent[] { tboxChsEntry, cboxEnabledFuzzyQuery, lnkModifiedConnectionSetting, cboxDisplayPassword, btnQuery };
            //
            // cboxDisplayPassword
            //
            cboxDisplayPassword.CheckedChanged += (o, v) => {
                var sender = (CheckBox)o;
                SetConnectionDisplayText(sender.Checked);
            };
            //
            // queryWorker
            //
            queryWorker.DoWork += (o, v) => {
                Invoke(_enabledComponentsProxy, new object[] { _Components, false });
                QueryProxy();
            };
            queryWorker.RunWorkerCompleted += (o, v) => {
                Invoke(_enabledComponentsProxy, new object[] { _Components, true });
            };
        }

        private void RetrievalTermsControl_Load(object sender, EventArgs e) {
            RetrievalTermsContextSection section = Context.GetRetrievalTermsContextSection(out Configuration configuration);

            BindingSource.DataSource = Context;
            Context.ChsEntry = section.Settings.ChsEntry;
            Context.Fuzzy = section.Settings.Fuzzy;
            Context.EpIAConnectionString = section.Settings.EpIAConnectionString;

            Context.SqlServerDbContext.Analyze(Context.EpIAConnectionString);

            tboxChsEntry.DataBindings.Add(new Binding("Text", BindingSource, "ChsEntry", false, DataSourceUpdateMode.OnPropertyChanged));
            cboxEnabledFuzzyQuery.DataBindings.Add(new Binding("Checked", BindingSource, "Fuzzy", false, DataSourceUpdateMode.OnPropertyChanged));
            cboxDisplayPassword.DataBindings.Add(new Binding("Checked", BindingSource, "DisplayPassword", false, DataSourceUpdateMode.OnPropertyChanged));

            lblDbConnectionString.Text = Context.SqlServerDbContext.SecurityConnectionString;
        }

        private void lnkModifiedConnectionSetting_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (var settingForm = new SqlServerConnectSettingForm(Context.EpIAConnectionString)) {
                if (settingForm.ShowDialog() == DialogResult.OK) {
                    Context.SqlServerDbContext = settingForm.SqlServerDbContext;
                    SetConnectionDisplayText(Context.DisplayPassword);
                }
            }
        }

        private void btnQuery_Click(object sender, EventArgs e) {
            //校验逻辑
            Func<bool> Validator = () => {
                bool successfully = true;
                string message = string.Empty;

                if (string.IsNullOrEmpty(Context.ChsEntry)) {
                    message = "[中文词条不可空白]";
                    successfully = false;
                } else {
                    message = string.Empty;
                }
                ErrorProvider.SetError(tboxChsEntry, message);

                return successfully;
            };

            if (Validator()) {
                queryWorker.RunWorkerAsync();
            }
        }

        private void SetConnectionDisplayText(bool displayPassword) {
            lblDbConnectionString.Text = displayPassword ? Context.SqlServerDbContext.ConnectionString : Context.SqlServerDbContext.SecurityConnectionString;
        }

        private void QueryProxy() {
            try {
                string sql = "SELECT [CHS_NAME], [CHT_NAME], [CHS2CHT_CODE], [WORD_COUNT], [ENG_NAME] FROM [CHS2CHT] (NOLOCK)";
                if (Context.Fuzzy) {
                    sql += "WHERE CHS_NAME LIKE '%" + Context.ChsEntry + "%'";
                } else {
                    sql += "WHERE CHS_NAME = '" + Context.ChsEntry + "'";
                }
                IQueryService queSrv = new QueryService();
                DataTable dataSource = queSrv.ExecuteWithPublicConnect(Context.EpIAConnectionString, sql);

                Invoke(_setGridDataSourceProxy, new object[] { dgvEntries, dataSource });
                Invoke(_setGridStyleProxy, new object[] { dgvEntries });
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
