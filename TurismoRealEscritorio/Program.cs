using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurismoRealEscritorio.Controlador;
using TurismoRealEscritorio.Vista;

namespace TurismoRealEscritorio
{
    static class Program
    {
        static bool Loop = false;
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            do
            {
                Application.Run(new frmLogin());
                if (SesionManager.Sesion.Autenticado)
                {
                    Application.Run(new frmMain());
                }
            } while (Loop);
        }
    }
}
