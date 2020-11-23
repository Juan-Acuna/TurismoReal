using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurismoRealEscritorio.Modelos.Util.Strategy
{
    class TipDepto : Tip
    {
        public override Panel CrearTip(int x, int y, params object[] input)
        {
            EDepto e = (EDepto)input[0];
            String parrafo = "";
            String pie = "En este momento, "+input[1].ToString()+" deptos se encuentran en este estado.";


            switch (e)
            {
                case EDepto.No_Disponible:
                    parrafo = "El depto ha sido ingresado al sistema, pero aún debe ser habilitado.";
                    break;
                case EDepto.Disponible:
                    parrafo = "El depto esta disponible para ser arrendado y no tiene reservas actualmente.";
                    break;
                case EDepto.Reservado:
                    parrafo = "El depto tiene reservas actualmente pero esta visible para arriendos segun disponibilidad.";
                    break;
                case EDepto.En_Mantencion:
                    parrafo = "El depto se encuentra en mantención actualmente.";
                    break;
                case EDepto.Inhabitable:
                    parrafo = "El depto se encuentra inhabitable por motivos de fuerza mayor.";
                    break;
            }
            Panel p = new Panel();
            p.BorderStyle = BorderStyle.FixedSingle;
            p.Size = new Size(200, 155);
            if (e== EDepto.Reservado || e== EDepto.En_Mantencion || e== EDepto.Inhabitable)
            {
                y = y - p.Size.Height;
            }
            p.Location = new Point(x - p.Width, y);

            Label titulo = new Label();
            titulo.Font = new Font("Microsoft YaHei UI Light", 13.8f);
            titulo.Location = new Point(0, 4);
            titulo.Text = "Departamento "+e.ToString().Replace('_',' ');
            p.Controls.Add(titulo);

            Label lparr = new Label();
            lparr.Font = new Font("Microsoft YaHei", 7.8f);
            lparr.Location = new Point(0, 35);
            lparr.ForeColor = Color.Gray;
            lparr.Text = parrafo;
            p.Controls.Add(lparr);

            Label lp = new Label();
            lp.Font = new Font("Microsoft YaHei", 7.8f);
            lp.Location = new Point(0, 60);
            lp.ForeColor = Color.Gray;
            lp.Text = pie;
            p.Controls.Add(lp);

            Label equis = new Label();
            equis.Font = new Font("Microsoft YaHei UI Light", 13.8f);
            equis.Location = new Point(150, 0);
            equis.Text = "X";
            equis.ForeColor = Color.Gray;
            p.Controls.Add(SetEquis(equis));

            return p;
        }
    }
}
