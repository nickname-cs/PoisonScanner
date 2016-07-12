using System;
using System.Reflection;
using System.Threading;
using System.Windows.Forms;

namespace PoisonScanner
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (Mutex mutex = new Mutex(false, "Global\\" + Assembly.GetExecutingAssembly().GetType().GUID.ToString()))
            {
                if (!mutex.WaitOne(0, false))
                {
                    MessageBox.Show("There is an instance already running!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MainForm());
            }
        }
    }
}
