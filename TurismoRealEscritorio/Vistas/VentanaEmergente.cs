using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurismoRealEscritorio.Vistas
{
    public partial class VentanaEmergente : Form
    {
        String Titulo = "";
        String Mensaje = "";
        public VentanaEmergente(String titulo = null, String mensaje = null)
        {
            InitializeComponent();
        }

        private void VentanaEmergente_Load(object sender, EventArgs e)
        {

        }
    }
}
