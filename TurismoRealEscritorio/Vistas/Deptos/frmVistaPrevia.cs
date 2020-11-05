using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurismoRealEscritorio.Vistas.Deptos
{
    public partial class frmVistaPrevia : Form
    {
        frmEditor frm;
        Bitmap b;
        public frmVistaPrevia(frmEditor f = null, Image i = null)
        {
            InitializeComponent();
            frm = f;
            b = (Bitmap)i;
        }

        private void frmVistaPrevia_Load(object sender, EventArgs e)
        {
            frm.Enabled = false;
            Imagen.Image = b;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            b.Dispose();
            frm.Enabled = true;
            frm.Focus();
            Dispose();
        }
    }
}
