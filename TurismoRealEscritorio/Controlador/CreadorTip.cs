using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurismoRealEscritorio.Modelos.Util.Strategy;

namespace TurismoRealEscritorio.Controlador
{
    class CreadorTip
    {
        Tip Tip;
        private CreadorTip(Tip tip)
        {
            this.Tip = tip;
        }
        
        public static CreadorTip TipConexiones()
        {
            return new CreadorTip(new TipConexiones());
        }
        public static CreadorTip TipDeptos()
        {
            return new CreadorTip(new TipDepto());
        }
        public static CreadorTip TipComun()
        {
            return new CreadorTip(new TipComun());
        }
        public Panel CrearTip(int x, int y, params object[] input)
        {
            return Tip.CrearTip(x, y, input);
        }
        
    }
}
