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
    public partial class frmCargando : Form
    {
        public Control Padre;
        public frmCargando(Control c = null)
        {
            InitializeComponent();
            if (c != null)
            {
                this.Padre = c;
            }
        }

        /*public static frmCargando Do(Control control)
        {
            var v = new frmCargando(control);
            v.DesktopLocation = new Point((int)Math.Floor((double)control.Width/2)- (int)Math.Floor((double)v.Width / 2), (int)Math.Floor((double)control.Height / 2)- (int)Math.Floor((double)v.Height / 2));
            v.Show();
            v.Padre.Enabled = false;
            return v;
        }
        public static frmCargando Do(Form control)
        {
            var v = new frmCargando(control);
            //v.DesktopLocation = new Point(v.DesktopLocation.X + (int)Math.Floor((double)v.Width / 2), v.DesktopLocation.Y + (int)Math.Floor((double)v.Height / 2));
            v.DesktopLocation = new Point(1000,1000);
            v.Show();
            v.Padre.Enabled = false;
            return v;
        }
        public static void Undo(frmCargando v)
        {
            v.Padre.Enabled = true;
            v.Padre.Focus();
            v.Dispose();
        }*/
    }
}
