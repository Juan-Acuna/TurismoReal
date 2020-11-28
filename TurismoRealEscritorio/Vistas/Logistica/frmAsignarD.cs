using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;
using TurismoRealEscritorio.Controlador;
using TurismoRealEscritorio.Modelos;
using TurismoRealEscritorio.Modelos.Util;
using TurismoRealEscritorio.Vista;

namespace TurismoRealEscritorio.Vistas.Logistica
{
    public partial class frmAsignarD : Form
    {
        List<Departamento> Deptos;
        ProxyArticulo Articulo;
        frmMain Main;
        frmLogistica Padre;
        public frmAsignarD(frmLogistica l = null, frmMain m = null, ProxyArticulo pa = null, object deptos = null)
        {
            InitializeComponent();
            Padre = l;
            Main = m;
            Articulo = pa;
            Deptos = (List<Departamento>)deptos;
            Main.ConfigurarBotones(this);
            lbNombre.Text = Articulo.Articulo.Nombre;
        }

        private void frmAsignarD_Load(object sender, EventArgs e)
        {
            CargarDeptos();
            if (Articulo.Asignado)
            {
                cbDeptos.SelectedItem = Tools.BuscarEnLista((List<Departamento>)cbDeptos.DataSource, "Id_depto", Articulo.Depto);
                cbDeptos.Enabled = false;
                btnDesasignar.Enabled = true;
            }
        }
        private void CargarDeptos()
        {
            cbDeptos.DataSource = Deptos;
            cbDeptos.ValueMember = "Id_depto";
            cbDeptos.DisplayMember = "Nombre";
            cbDeptos.SelectedItem = null;
            cbDeptos.Text = "Seleccione departamento";
        }
        async void Asignar()
        {
            DeptoArticulo da = new DeptoArticulo();
            da.Id_articulo = Articulo.Articulo.Id_articulo;
            da.Id_depto = ((Departamento)cbDeptos.SelectedItem).Id_depto;
            if (await ClienteHttp.Peticion.Send<DeptoArticulo>(HttpMethod.Post, da, "articulo/asignar", SesionManager.Token, true))
            {
                if (MessageBox.Show("El articulo fue asignado al departamento exitosamente.", "Articulo asignado", MessageBoxButtons.OK) == DialogResult.OK)
                {
                    Cerrar();
                }
            }
            else
            {
                MessageBox.Show("No ha sido posible asignar el articulo. Compruebe su conexión a internet.", "Problema al asignar articulo", MessageBoxButtons.OK);
            }
        }
        private async void Desasignar()
        {
            if (MessageBox.Show("¿Esta seguro que desea desasignar este funcionario?", "Desasignar Funcionario", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            if (await ClienteHttp.Peticion.Delete<DeptoArticulo>("articulo/desasignar/" + Articulo.Articulo.Id_articulo, SesionManager.Token, true))
            {
                MessageBox.Show("El articulo fue desasignado exitosamente.", "Articulo desasignado", MessageBoxButtons.OK);
                cbDeptos.Enabled = true;
                cbDeptos.SelectedItem = null;
                cbDeptos.Text = "Seleccione departamento";
            }
            else
            {
                MessageBox.Show("No ha sido posible desasignar el articulo. Compruebe su conexión a internet.", "Problema al desasignar articulo", MessageBoxButtons.OK);
            }
            void Cerrar()
            {
                Main.Enabled = true;
                Main.Focus();
                Dispose();
            }
        }
        void Cerrar()
        {
            Main.Enabled = true;
            Main.Focus();
            Padre.CargarArticulos();
            Dispose();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            Asignar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }

        private void btnDesasignar_Click(object sender, EventArgs e)
        {
            Desasignar();
        }
    }
}
