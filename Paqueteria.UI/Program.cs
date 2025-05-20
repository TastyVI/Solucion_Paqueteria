namespace Paqueteria.UI
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new frmInicioSesion());
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmInicioSesion inicioSesion = new frmInicioSesion();
            inicioSesion.FormClosed += MainForm_Closed;
            inicioSesion.Size = inicioSesion.ClientSize;
            inicioSesion.Show();
            Application.Run();
        }

        private static void MainForm_Closed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= MainForm_Closed;

            if (Application.OpenForms.Count == 0)
            {
                Application.ExitThread();
            }
            else
            {
                Application.OpenForms[0].FormClosed += MainForm_Closed;
            }
        }
    }
}