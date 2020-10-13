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

namespace TurismoRealEscritorio.Vistas.Deptos
{
    public partial class frmDeptos : Form
    {
        frmMain Main;

        public frmDeptos(frmMain main = null)
        {
            InitializeComponent();
            Main = main;
        }
    }
}
