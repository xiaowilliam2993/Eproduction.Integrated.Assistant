using System;
using System.Windows.Forms;
using Eproduction.Integrated.Assistant.Start.Core;

namespace Eproduction.Integrated.Assistant.Start.Control {
    public partial class ModuleControl : UserControl {
        public Module Module { get; private set; } = null;
        public ModuleControl(Module module) {
            InitializeComponent();

            Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;

            Module = module;
        }

        private void ModuleControl_Load(object sender, EventArgs e) {
            BindingSource.DataSource = Module;

            pbox.DataBindings.Add(new Binding("Image", BindingSource, "ImageLarger", false, DataSourceUpdateMode.OnPropertyChanged));
            cbox.DataBindings.Add(new Binding("Checked", BindingSource, "Visible", false, DataSourceUpdateMode.OnPropertyChanged));
            cbox.DataBindings.Add(new Binding("Enabled", BindingSource, "RemoveReadonly", false, DataSourceUpdateMode.OnPropertyChanged));
            lblCaption.DataBindings.Add(new Binding("Text", BindingSource, "Text", false, DataSourceUpdateMode.OnPropertyChanged));
            lblDescription.DataBindings.Add(new Binding("Text", BindingSource, "Description", false, DataSourceUpdateMode.OnPropertyChanged));
        }
    }
}
