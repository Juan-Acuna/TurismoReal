using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurismoRealEscritorio.Modelos.Util.Strategy
{
    class TipConexiones : Tip
    {
        public override Panel CrearTip(int x, int y, params object[] input)
        {
            Panel p = new Panel();
            p.BorderStyle = BorderStyle.FixedSingle;
            p.Size = new Size(276, 155);
            p.Location = new Point(x, y);

            Label titulo = new Label();
            titulo.Font = new Font("Microsoft YaHei UI Light", 13.8f);
            titulo.Location = new Point(4, 0);
            titulo.Text = "Conexiones";
            p.Controls.Add(titulo);

            Label equis = new Label();
            equis.Font = new Font("Eras Light ITC", 13.8f);
            equis.Location = new Point(248, 0);
            equis.Text = "X";
            equis.ForeColor = Color.Gray;
            p.Controls.Add(SetEquis(equis));

            Label admin = new Label();
            admin.Font = new Font("Microsoft YaHei", 7.8f);
            admin.Location = new Point(6,39);
            admin.Text = "Administradores";
            admin.ForeColor = Color.Gray;
            p.Controls.Add(admin);

            Label reservas = new Label();
            reservas.Font = new Font("Microsoft YaHei", 7.8f);
            reservas.Location = new Point(6, 59);
            reservas.Text = "Gest. Reservas";
            reservas.ForeColor = Color.Gray;
            p.Controls.Add(reservas);

            Label servicios = new Label();
            servicios.Font = new Font("Microsoft YaHei", 7.8f);
            servicios.Location = new Point(6, 79);
            servicios.Text = "Gest. Servicios";
            servicios.ForeColor = Color.Gray;
            p.Controls.Add(servicios);

            Label func = new Label();
            func.Font = new Font("Microsoft YaHei", 7.8f);
            func.Location = new Point(6, 99);
            func.Text = "Funcionarios";
            func.ForeColor = Color.Gray;
            p.Controls.Add(func);

            Label clientes = new Label();
            clientes.Font = new Font("Microsoft YaHei", 7.8f);
            clientes.Location = new Point(6, 119);
            clientes.Text = "Clientes";
            clientes.ForeColor = Color.Gray;
            p.Controls.Add(clientes);

            Label c;
            for (int i = 0; i < ((int[])input[0]).Count(); i++)
            {
                c = new Label();
                c.Font = new Font("Microsoft YaHei", 7.8f);
                c.Location = new Point(230, 39+(20*i));
                if (((int[])input[0])[i] > 9)
                {
                    c.Text = (((int[])input[1])[i].ToString()+"/"+((int[])input[0])[i].ToString()).PadLeft(7);
                }
                else
                {
                    c.Text = (((int[])input[1])[i].ToString() + "/" + ((int[])input[0])[i].ToString()).PadLeft(8);
                }
                c.ForeColor = Color.Black;
                p.Controls.Add(c);
            }
            p.Size = new Size(276, 155);
            return p;
        }
    }
}
