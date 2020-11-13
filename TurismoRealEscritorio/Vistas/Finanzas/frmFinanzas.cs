using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurismoRealEscritorio.Vista;

namespace TurismoRealEscritorio.Vistas.Finanzas
{
    public partial class frmFinanzas : Form
    {
        frmMain Main;
        public frmFinanzas(frmMain f = null)
        {
            InitializeComponent();
            if (f != null)
            {
                Main = f;
            }
        }
        private void frmFinanzas_Load(object sender, EventArgs e)
        {

        }
    }
}
