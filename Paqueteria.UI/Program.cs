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

            ApplicationConfiguration.Initialize();//esta linea carga la configuracion de la aplicacion
            Application.EnableVisualStyles(); //esto habilita los estilos visuales de la aplicacion
            Application.SetCompatibleTextRenderingDefault(false);//esto establece el renderizado de texto compatible con versiones anteriores
            frmInicioSesion inicioSesion = new frmInicioSesion(); //esto crea una nueva instancia del formulario de inicio de sesion
            inicioSesion.FormClosed += MainForm_Closed; //esto agrega un controlador de eventos para el evento FormClosed del formulario de inicio de sesion
            inicioSesion.Size = inicioSesion.ClientSize; //esto establece el tamaño del formulario de inicio de sesion al tamaño de su cliente
            inicioSesion.Show(); //esto muestra el formulario de inicio de sesion
            Application.Run(); //esto inicia el bucle de mensajes de la aplicacion
        }


        // esto es un controlador de eventos que se ejecuta cuando el formulario principal se cierra
        // se encarga de cerrar la aplicacion si no hay otros formularios abiertos
        // si hay otros formularios abiertos, se agrega un controlador de eventos para el evento FormClosed del primer formulario abierto
        // para que se ejecute el mismo comportamiento al cerrar ese formulario
        // esto es necesario para evitar que la aplicacion se cierre si hay otros
        // abiertos
        // el evento FormClosed se ejecuta cuando el formulario se cierra
        // y se encarga de verificar si hay otros formularios abiertos
        // si no hay otros formularios abiertos, se cierra la aplicacion
        // si hay otros formularios abiertos, se agrega un controlador de eventos
        // para el evento FormClosed del primer formulario abierto
        // para que se ejecute el mismo comportamiento al cerrar ese formulario
        // esto es necesario para evitar que la aplicacion se cierre si hay otros
        // abiertos

        // para mas informacion sobre esta parte del codigo:
        // https://es.stackoverflow.com/questions/38427/c%C3%B3mo-cerrar-un-form-en-c-y-que-se-habra-otro

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