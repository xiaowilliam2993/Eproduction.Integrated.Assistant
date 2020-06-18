using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Windows.Forms;

namespace Eproduction.Integrated.Assistant.Start {
    static class Program {
        [DllImport("USER32.DLL")]
        static extern bool SetForegroundWindow(IntPtr hWnd);
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string processName = "Eproduction.Integrated.Assistant";
            Process process = Process.GetProcesses().FirstOrDefault(_ => _.ProcessName == processName);
            if (process != null) {
                if (process.Id != Process.GetCurrentProcess().Id) {
                    SetForegroundWindow(process.MainWindowHandle);
                    return;
                }
            }

            WindowsIdentity identity = WindowsIdentity.GetCurrent();
            WindowsPrincipal principal = new WindowsPrincipal(identity);
            if (principal.IsInRole(WindowsBuiltInRole.Administrator)) {
                Application.Run(new MainForm());
            } else {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.UseShellExecute = true;
                startInfo.WorkingDirectory = Environment.CurrentDirectory;
                startInfo.FileName = Application.ExecutablePath;
                startInfo.Verb = "runas";
                try {
                    Process.Start(startInfo);
                } catch {
                    return;
                }
                Application.Exit();
            }
        }
    }
}
