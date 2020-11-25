using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurismoRealEscritorio.Modelos.Util.Strategy
{
    class TipComun : Tip
    {
        public override Panel CrearTip(int x, int y, params object[] input)
        {
            Panel p = new Panel();
            p.BorderStyle = BorderStyle.FixedSingle;
            p.Size = new Size(267, 107);
            p.Location = new Point(x, y);

            Label titulo = new Label();
            titulo.Font = new Font("Microsoft YaHei UI Light", 13.8f);
            titulo.Location = new Point(7, 4);
            titulo.Size = new Size(140, 25);
            titulo.Text = input[0].ToString();
            p.Controls.Add(titulo);

            TextBox lparr = new TextBox();
            lparr.Font = new Font("Microsoft YaHei", 7.8f);
            lparr.Location = new Point(7, 42);
            lparr.Size = new Size(255, 54);
            lparr.BorderStyle = BorderStyle.None;
            lparr.Multiline = true;
            lparr.BackColor = Color.White;
            lparr.ReadOnly = true;
            lparr.Text = input[1].ToString();
            p.Controls.Add(lparr);

            Label equis = new Label();
            equis.Font = new Font("Eras Light ITC", 13.8f);
            equis.Location = new Point(242, 0);
            equis.Text = "X";
            equis.ForeColor = Color.Gray;
            p.Controls.Add(SetEquis(equis));

            return p;
        }
    }
}
