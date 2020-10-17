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
    public partial class frmImagenes : Form
    {
        public frmImagenes()
        {
            InitializeComponent();
        }

        private void frmImagenes_Load(object sender, EventArgs e)
        {
            imgMain.LoadAsync();
        }
    }
}
