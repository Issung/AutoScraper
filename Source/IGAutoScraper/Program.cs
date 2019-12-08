using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace IGAutoScraper
{
    static class Program
    {
        public static string INSTALL_DIRECTORY { get; } = AppDomain.CurrentDomain.BaseDirectory;

        public static string LOG_FILE { get; } = Application.CommonAppDataPath + "\\crash.logs";

        [STAThread]
        static void Main()
        {
            // Unhandled exceptions for our Application Domain
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(AppDomain_UnhandledException);

            // Unhandled exceptions for the executing UI thread
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Main());
        }

        public static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            try
            {
                string[] log = new string[] { $"[{DateTime.Now.ToString()}] - Application_ThreadException - {e.Exception.Message}", e.Exception.StackTrace };


                if (File.Exists(LOG_FILE))
                    File.AppendAllLines(LOG_FILE, log);
                else
                    File.WriteAllLines(LOG_FILE, log);

            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.Message);
            }
        }

        public static void AppDomain_UnhandledException(object sender, System.UnhandledExceptionEventArgs e)
        {
            try
            {
                Exception ex = (Exception)e.ExceptionObject;
                string[] log = new string[] { $"[{DateTime.Now.ToString()}] - AppDomain_UnhandledException - {ex.Message}", ex.StackTrace };


                if (File.Exists(LOG_FILE))
                    File.AppendAllLines(LOG_FILE, log);
                else
                    File.WriteAllLines(LOG_FILE, log);
            }
            catch (Exception eX)
            {
                MessageBox.Show(eX.Message);
            }
        }
    }
}
