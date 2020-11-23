using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurismoRealEscritorio.Modelos.Util.Strategy
{
    public abstract class Tip
    {
        public abstract Panel CrearTip(int x, int y, params object[] input);
        protected virtual void EquisClick(object sender, EventArgs e)
        {
            ((Label)sender).Parent.Dispose();
        }
        protected virtual void EquisMouseIn(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.Black;
        }
        protected virtual void EquisMouseOut(object sender, EventArgs e)
        {
            ((Label)sender).ForeColor = Color.Gray;
        }
        protected virtual Label SetEquis(Label l)
        {
            l.MouseEnter += new EventHandler(EquisMouseIn);
            l.MouseLeave += new EventHandler(EquisMouseOut);
            l.Click += new EventHandler(EquisClick);
            return l;
        }
    }
    enum EDepto
    {
        No_Disponible,
        Disponible,
        Reservado,
        En_Mantencion,
        Inhabitable
    }
}
