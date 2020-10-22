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
    public partial class frmMantenciones : Form
    {
        Form frm;
        public frmMantenciones(Form f = null)
        {
            InitializeComponent();
            frm = f;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frm.Focus();
            this.Dispose();
        }
    }
}
