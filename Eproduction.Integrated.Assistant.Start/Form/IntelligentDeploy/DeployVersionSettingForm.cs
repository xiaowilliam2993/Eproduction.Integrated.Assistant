using Eproduction.Integrated.Assistant.Start.Core;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using Eproduction.Integrated.Assistant.Start.Control;
using System.Drawing;
using Eproduction.Integrated.Assistant.Start.Worker;
using System.IO;
using System.Diagnostics;

namespace Eproduction.Integrated.Assistant.Start {
    public partial class DeployVersionSettingForm : Form {
        private DeployVersionContext _selectedVersion = null;
        private string _oldSelectedVersionName = string.Empty;
        private IList<DeployVersionContext> _deployVersions = null;
        /// <summary>
        /// 当前选中版本
        /// </summary>
        public DeployVersionContext SelectedVersion {
            get => _selectedVersion;
            set => _selectedVersion = value;
        }
        public string OldSelectedVersionName { get => _oldSelectedVersionName; }
        /// <summary>
        /// 部署版本列表信息
        /// </summary>
        public IList<DeployVersionContext> DeployVersions {
            get {
                if (_deployVersions == null) {
                    _deployVersions = new List<DeployVersionContext>();
                }
                return _deployVersions;
            }
            private set => _deployVersions = value;
        }
        public string SelectedPath { get; set; }
        public DeployVersionSettingForm(IList<DeployVersionContext> deployVersions) {
            InitializeComponent();

            _deployVersions = deployVersions;
            _selectedVersion = DeployVersions.FirstOrDefault(_ => _.IsSelected);
            _oldSelectedVersionName = SelectedVersion.Name;

            Func<string, string> ChooseFolderPath = (string _) => {
                string selectedPath = string.Empty;
                using (var browserDialog = new FolderBrowserDialog()) {
                    browserDialog.RootFolder = Environment.SpecialFolder.Desktop;
                    browserDialog.Description = _;
                    if (!string.IsNullOrEmpty(SelectedPath)) {
                        browserDialog.SelectedPath = SelectedPath;
                    }
                    if (browserDialog.ShowDialog() == DialogResult.OK) {
                        selectedPath = browserDialog.SelectedPath;
                        SelectedPath = selectedPath;
                    }
                }
                return selectedPath;
            };

            EventHandler PathLinkClickHandler = (o, v) => {
                var sender = (LinkLabel)o;
                var tag = sender.Tag;
                if (tag != null && tag is TextBox) {
                    var owner = (TextBox)tag;
                    var path = owner.Text;
                    if (Directory.Exists(path)) {
                        Process.Start(path);
                    }
                }
            };

            //
            // lnkSelectEnvrionmentPath
            //
            lnkSelectEnvrionmentPath.Click += (o, v) => {
                string selectedPath = ChooseFolderPath("选择环境路径");
                if (!string.IsNullOrEmpty(selectedPath)) {
                    tboxEnvrionmentPath.Text = selectedPath;
                }
            };
            //
            // lnkSelectExportPath
            //
            lnkSelectExportPath.Click += (o, v) => {
                string selectedPath = ChooseFolderPath("选择Export路径");
                if (!string.IsNullOrEmpty(selectedPath)) {
                    tboxExportPath.Text = selectedPath;
                }
            };
            //
            // lnkEnvrionmentPath
            //
            lnkEnvrionmentPath.Tag = tboxEnvrionmentPath;
            lnkEnvrionmentPath.Click += PathLinkClickHandler;
            //
            // lnkExportPath
            //
            lnkExportPath.Tag = tboxExportPath;
            lnkExportPath.Click += PathLinkClickHandler;

            //
            // lnkEditVersionName
            //
            lnkEditVersionName.Click += (o, v) => {
                using (var editorForm = new DeployVersionNameEditorForm(SelectedVersion)) {
                    if(editorForm.ShowDialog() == DialogResult.OK) {
                        lblVersionName.Text = SelectedVersion.Name;//为什么必须手动修改UI属性值变更才能生效呢？
                    }
                }
            };

            tsbtnDelete.Enabled = DeployVersions.Count > 1;
        }

        private void DeployVersionSettingForm_Load(object sender, EventArgs e) {
            for (int i = 0; i < DeployVersions.Count; i++) {
                CreateVersionItem(DeployVersions[i], i);
            }
            SelectedVersion.VersionItemControl.IsSelected = true;

            BindingSource.DataSource = SelectedVersion;
            lblVersionName.DataBindings.Add(new Binding("Text", BindingSource, "Name", false, DataSourceUpdateMode.OnPropertyChanged));
            tboxEnvrionmentPath.DataBindings.Add(new Binding("Text", BindingSource, "EnvrionmentPath", false, DataSourceUpdateMode.OnPropertyChanged));
            tboxExportPath.DataBindings.Add(new Binding("Text", BindingSource, "ExportPath", false, DataSourceUpdateMode.OnPropertyChanged));
            tboxTypeKey.DataBindings.Add(new Binding("Text", BindingSource, "TypeKey", false, DataSourceUpdateMode.OnPropertyChanged));
            tboxE10Version.DataBindings.Add(new Binding("Text", BindingSource, "E10Version", false, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void DeployVersionSettingForm_FormClosed(object sender, FormClosedEventArgs e) {
            foreach (var item in DeployVersions) {
                item.VersionItemControl = null;
            }
            if (DialogResult != DialogResult.OK) {
                var oldVersion = DeployVersions.FirstOrDefault(_ => _.Name == OldSelectedVersionName);
                if (oldVersion != null && !oldVersion.IsSelected) {
                    SelectedVersion = oldVersion;
                    foreach (var item in DeployVersions) {
                        item.IsSelected = item.Name == OldSelectedVersionName;
                    }
                }
            }
        }

        private void DeployVersionSettingForm_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Escape) {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

        private void tsbtnCreate_Click(object sender, EventArgs e) {
            CreateVersion();
        }

        private void btnExit_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void tsbtnDelete_Click(object sender, EventArgs e) {
            if (MessageBox.Show("确定要删除部署版本 " + SelectedVersion.Name + " 吗？", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
                IntelligentDeployWorker.DeleteDeployVersion(SelectedVersion);

                pnlVersionList.Controls.Remove(SelectedVersion.VersionItemControl);
                DeployVersions.Remove(SelectedVersion);

                for (int i = 0; i < DeployVersions.Count; i++) {
                    var versionItem = DeployVersions[i];
                    versionItem.VersionItemControl.Location = new Point(5, 28 * i + 5);
                }

                var firstVersion = DeployVersions.FirstOrDefault();
                if (firstVersion != null) {
                    SelectedVersion = firstVersion;
                    firstVersion.IsSelected = true;
                    firstVersion.VersionItemControl.IsSelected = true;
                    BindingSource.DataSource = firstVersion;
                }
                if (DeployVersions.Count <= 1) tsbtnDelete.Enabled = false;
            }
        }

        private void CreateVersion() {
            var context = new DeployVersionContext() { IsSelected = true };
            IntelligentDeployWorker.CreateDeployVersion(context);

            foreach (var item in DeployVersions.Where(_ => _.IsSelected)) {
                item.IsSelected = false;
                item.VersionItemControl.IsSelected = false;
            }

            CreateVersionItem(context, DeployVersions.Count);
            DeployVersions.Add(context);

            SelectedVersion = context;
            BindingSource.DataSource = SelectedVersion;

            if (DeployVersions.Count > 1) tsbtnDelete.Enabled = true;
        }

        private void CreateVersionItem(DeployVersionContext context, int index) {
            var VersionControlClickHandler = new Action<DeployVerionItemControl>(delegate (DeployVerionItemControl versionControl) {
                if (versionControl.IsSelected) return;

                versionControl.IsSelected = true;
                var version = (DeployVersionContext)versionControl.Tag;
                version.IsSelected = true;
                foreach (var item in DeployVersions.Where(_ => _.IsSelected && _.Name != version.Name)) {
                    item.IsSelected = false;
                    item.VersionItemControl.IsSelected = false;
                }
                BindingSource.DataSource = version;
                SelectedVersion = version;
            });
            EventHandler ChildComponentClickHandler = (o, v) => {
                var sender = (System.Windows.Forms.Control)o;
                var versionControl = (DeployVerionItemControl)sender.Parent;
                VersionControlClickHandler(versionControl);
            };
            SuspendLayout();
            int yPoint = 28 * index + 5;
            var versionItem = new DeployVerionItemControl(context) { IsSelected = context.IsSelected };
            versionItem.Size = new Size(pnlVersionList.Width - 10, versionItem.Height);
            versionItem.Location = new Point(5, yPoint);
            versionItem.Tag = context;
            versionItem.Click += (o, v) => { VersionControlClickHandler((DeployVerionItemControl)o); };
            versionItem.pboxVersion.Click += ChildComponentClickHandler;
            versionItem.lblVersion.Click += ChildComponentClickHandler;
            pnlVersionList.Controls.Add(versionItem);
            versionItem.Validate();
            context.VersionItemControl = versionItem;
            ResumeLayout();
        }
    }
}
