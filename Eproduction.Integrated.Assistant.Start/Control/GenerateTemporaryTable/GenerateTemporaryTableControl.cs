using System;
using System.ComponentModel;
using System.Configuration;
using System.Windows.Forms;
using System.Collections.Generic;
using Eproduction.Integrated.Assistant.Start.Core;
using Eproduction.Integrated.Assistant.Start.Core.Section;
using Eproduction.Integrated.Assistant.Start.Worker;
using Eproduction.Integrated.Assistant.Common;
using Eproduction.Integrated.Assistant.Start.Core.Model.Metadata;

namespace Eproduction.Integrated.Assistant.Start.Control {
    public partial class GenerateTemporaryTableControl : UserControl {
        private EpIAContext _EpIAContext = null;
        public EpIAContext EpIAContext { get => _EpIAContext; }
        public GenerateTempoarayTableContext Context { get => EpIAContext.GenerateTempoarayTableContext; }
        private IEnumerable<IComponent> _Components = null;
        private EnabledComponentsProxy _enabledComponentsProxy = null;
        private delegate void EnabledComponentsProxy(IEnumerable<IComponent> components, bool enabled);
        private VisibleComponentsProxy _visibleComponentsProxy = null;
        private delegate void VisibleComponentsProxy(IEnumerable<IComponent> components, bool visible);
        private WriteSourcesProxy _writeSourcesProxy = null;
        private delegate void WriteSourcesProxy(RichTextBox richboxSources, string sources);
        public GenerateTemporaryTableControl(EpIAContext context) {
            _enabledComponentsProxy = new EnabledComponentsProxy((IEnumerable<IComponent> components, bool enabled) => {
                IComponentUtils.RefreshStatus(components, enabled);
            });
            _visibleComponentsProxy = new VisibleComponentsProxy((IEnumerable<IComponent> components, bool visible) => {
                IComponentUtils.VisibleComponents(components, visible);
            });
            _writeSourcesProxy = new WriteSourcesProxy((RichTextBox richboxSources, string sources) => {
                richboxSources.Text = sources;
            });
            InitializeComponent();

            Dock = DockStyle.Fill;

            _EpIAContext = context;

            _Components = new System.Windows.Forms.Control[] { cboxGenerateFunctionHeader, cboxGenerateRemark, cboxFirstPropertyGeneratePrimaryKey, btnGenerate, richboxSpecification, richboxSources };
            //
            // pnlSpecificationLineNo
            //
            pnlSpecificationLineNo.Paint += (o, v) => { CommonWorker.PaintLineNo(richboxSpecification, (Panel)o); };
            //
            // richboxSpecification
            //
            richboxSpecification.TextChanged += (o, v) => { pnlSpecificationLineNo.Invalidate(); };
            richboxSpecification.VScroll += (o, v) => { pnlSpecificationLineNo.Invalidate(); };
            //
            // pnlSourcesLineNo
            //
            pnlSourcesLineNo.Paint += (o, v) => { CommonWorker.PaintLineNo(richboxSources, (Panel)o); };
            //
            // richboxSources
            //
            richboxSources.TextChanged += (o, v) => { pnlSourcesLineNo.Invalidate(); };
            richboxSources.VScroll += (o, v) => { pnlSourcesLineNo.Invalidate(); };
            //
            // GenerateWorker
            //
            GenerateWorker.DoWork += (o, v) => {
                Invoke(_enabledComponentsProxy, new object[] { _Components, false });
                Invoke(_visibleComponentsProxy, new object[] { new System.Windows.Forms.Control[] { pnlSourcesToolbar }, false });
                GenerateProxy();
            };
            GenerateWorker.RunWorkerCompleted += (o, v) => {
                Invoke(_enabledComponentsProxy, new object[] { _Components, true });
                if (!string.IsNullOrEmpty(Context.Sources)) {
                    Invoke(_visibleComponentsProxy, new object[] { new System.Windows.Forms.Control[] { pnlSourcesToolbar }, true });
                }
            };
        }

        private void GenerateTemporaryTableControl_Load(object sender, EventArgs e) {
            GenerateTemporaryTableContextSection section = Context.GetGenerateTemporaryTableSection(out Configuration configuration);

            BindingSource.DataSource = Context;
            Context.GenerateFunctionHeader = section.Settings.GenerateFunctionHeader;
            Context.GenerateRemark = section.Settings.GenerateRemark;
            Context.FirstPropertyGeneratePrimaryKey = section.Settings.FirstPropertyGeneratePrimaryKey;
            Context.Specification = section.Settings.Specification;

            cboxGenerateFunctionHeader.DataBindings.Add(new Binding("Checked", BindingSource, "GenerateFunctionHeader", false, DataSourceUpdateMode.OnPropertyChanged));
            cboxGenerateRemark.DataBindings.Add(new Binding("Checked", BindingSource, "GenerateRemark", false, DataSourceUpdateMode.OnPropertyChanged));
            cboxFirstPropertyGeneratePrimaryKey.DataBindings.Add(new Binding("Checked", BindingSource, "FirstPropertyGeneratePrimaryKey", false, DataSourceUpdateMode.OnPropertyChanged));
            richboxSpecification.DataBindings.Add(new Binding("Text", BindingSource, "Specification", false, DataSourceUpdateMode.OnPropertyChanged));
            richboxSources.DataBindings.Add(new Binding("Text", BindingSource, "Sources", false, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void lnkStandardExample_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
            using (var standardExampleForm = new StandardExampleForm()) {
                standardExampleForm.ShowDialog();
            }
        }

        private void btnView_Click(object sender, EventArgs e) {
            using (var viewForm = new ViewForm(richboxSources.Rtf)) {
                viewForm.ShowDialog();
            }
        }

        private void btnCopy_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(Context.Sources)) {
                Clipboard.SetText(Context.Sources);
                using (AlterForm alterForm = new AlterForm()) {
                    alterForm.Show();
                    System.Threading.Thread.Sleep(600);
                    alterForm.Close();
                }
            }
        }

        private void btnWordWarp_Click(object sender, EventArgs e) {
            richboxSources.WordWrap = !richboxSources.WordWrap;
        }

        private void btnClear_Click(object sender, EventArgs e) {
            richboxSources.Clear();
        }

        private void btnGenerate_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(richboxSpecification.Text)) {
                Context.SpecificationLines = richboxSpecification.Lines;
                GenerateWorker.RunWorkerAsync();
            }
        }

        private void GenerateProxy() {
            using (TemporaryTableMetadata temporaryTableMetadata = new TemporaryTableMetadata(Context)) {
                TransformMetadata transformMetadata = temporaryTableMetadata.TransformSchemaObject;
                transformMetadata.TransformFlag = true;
                transformMetadata.Lines = Context.SpecificationLines;

                int lineNumber = 0;
                for (int i = 0; i < Context.SpecificationLines.Length; i++) {
                    lineNumber++;
                    transformMetadata.OrgLineText = Context.SpecificationLines[i].Trim();
                    if (string.IsNullOrEmpty(transformMetadata.OrgLineText)) {
                        continue;
                    }

                    if (!transformMetadata.TemporaryNameFlag) {
                        transformMetadata.AssemblyTemporaryTableNameAndPrimaryKey();
                        continue;
                    }
                    transformMetadata.LineNo = lineNumber;
                    if (!transformMetadata.PrimaryKeyFlag) {
                        transformMetadata.RecodePrimaryKeyContent(true);
                        continue;
                    }

                    if (!transformMetadata.SimplePropertyCompletedFlag) {
                        transformMetadata.GenerateSimpleProperty();
                    } else {
                        transformMetadata.GenerateIndex();
                    }
                }
                transformMetadata.AppendManager();

                Invoke(_writeSourcesProxy, new object[] { richboxSources, transformMetadata.TemporaryTableBuilder.ToString() });
                transformMetadata.TransformFlag = false;
                temporaryTableMetadata.Dispose();
            }
        }
    }
}
