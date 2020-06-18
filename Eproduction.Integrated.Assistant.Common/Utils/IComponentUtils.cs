using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace Eproduction.Integrated.Assistant.Common {
    public static class IComponentUtils {

        public static void VisibleComponents(IEnumerable<IComponent> components, bool visible) {
            if (components != null && components.Count() > 0) {
                foreach (var c in components) {
                    if (c is ComboBox) {
                        ((ComboBox)c).Visible = visible;
                    } else if (c is Button) {
                        ((Button)c).Visible = visible;
                    } else if (c is RadioButton) {
                        ((RadioButton)c).Visible = visible;
                    } else if (c is CheckBox) {
                        ((CheckBox)c).Visible = visible;
                    } else if (c is GroupBox) {
                        ((GroupBox)c).Visible = visible;
                    } else if (c is Label) {
                        ((Label)c).Visible = visible;
                    } else if (c is TextBox) {
                        ((TextBox)c).Visible = visible;
                    } else if (c is Panel) {
                        ((Panel)c).Visible = visible;
                    } else if (c is ToolStripItem) {
                        ((ToolStripItem)c).Visible = visible;
                    } else if (c is ProgressBar) {
                        ((ProgressBar)c).Visible = visible;
                    }
                }
            }
        }

        public static void RefreshStatus(IEnumerable<IComponent> components, bool enabled) {
            if (components != null && components.Count() > 0) {
                foreach (var c in components) {
                    if (c is ComboBox) {
                        ((ComboBox)c).Enabled = enabled;
                    } else if (c is Button) {
                        ((Button)c).Enabled = enabled;
                    } else if (c is RadioButton) {
                        ((RadioButton)c).Enabled = enabled;
                    } else if (c is CheckBox) {
                        ((CheckBox)c).Enabled = enabled;
                    } else if (c is GroupBox) {
                        ((GroupBox)c).Enabled = enabled;
                    } else if (c is Label) {
                        ((Label)c).Enabled = enabled;
                    } else if (c is TextBox) {
                        ((TextBox)c).ReadOnly = !enabled;
                    } else if (c is LinkLabel) {
                        ((LinkLabel)c).Enabled = enabled;
                    }
                }
            }
        }

    }
}
