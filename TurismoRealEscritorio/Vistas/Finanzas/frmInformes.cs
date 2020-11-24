using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurismoRealEscritorio.Controlador;
using TurismoRealEscritorio.Vista;

namespace TurismoRealEscritorio.Vistas.Finanzas
{
    public partial class frmInformes : Form
    {
        List<Informe> lista = new List<Informe>();
        Informe actual;
        frmMain Main;
        public frmInformes(frmMain m = null)
        {
            InitializeComponent();
            tablaInformes.MultiSelect = false;
            if (m != null)
            {
                Main = m;
            }
        }

        private void frmInformes_Load(object sender, EventArgs e)
        {
            Main.Enabled = false;
            Main.ConfigurarBotones(pBotones);
            CargarInformes();
        }
        private async void CargarInformes()
        {
            do
            {
                lista = await ClienteHttp.Peticion.GetList<Informe>(SesionManager.Token, url: "interno/gestion/informe", urlEspecial: true);
            } while (lista.Count <= 0);
            tablaInformes.Rows.Clear();
            for(int i=0;i<lista.Count;i++)
            {
                tablaInformes.Rows.Add(i, "Informe periodo " + lista[i].mes + ", " + lista[i].ano);
            }
            if (tablaInformes.Rows.Count >= 1)
            {
                tablaInformes.Rows[0].Selected = true;
                CargarActual();
            }
        }
        void CargarActual()
        {
            int idx = (int)tablaInformes.SelectedRows[0].Cells[0].Value;
            actual = lista[idx];
            tablaReservas.Rows.Clear();
            tablaServicios.Rows.Clear();
            tablaEgresos.Rows.Clear();
            tablaUtilidades.Rows.Clear();
            foreach (var i in actual.Ingresos.IngresosReserva)
            {
                tablaReservas.Rows.Add(i.Depto, i.CostoDia, i.Reservas, i.DiasTotales, i.Ganancias);
            }
            foreach (var i in actual.Ingresos.IngresosServicio)
            {
                tablaServicios.Rows.Add(i.Servicio,i.CostoContratacion,i.Contrataciones,i.Ganancias);
            }
            foreach (var i in actual.Egresos.EgresosDepto)
            {
                tablaEgresos.Rows.Add(i.Depto, i.Dividendo, i.Contribuciones, i.Mantenciones, i.GastoTotal);
            }
            foreach(var i in actual.Utilidades.Utilidades)
            {
                tablaUtilidades.Rows.Add(i.Depto,i.CostoMantencion,i.GananciasReservas,i.TotalUtilidades);
            }
            lbInformes.Text = "Informe periodo "+actual.mes+", año "+actual.ano.ToString();
        }

        private void CambiarElegido(object sender, DataGridViewCellEventArgs e)
        {
            CargarActual();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PDFTools.GenerarInformePDF(@"C:\Users\Juancho\Desktop\TEST_PDF", actual);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Main.Enabled = true;
            Main.Focus();
            Dispose();
        }
    }
}
