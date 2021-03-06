﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurismoRealEscritorio.Controlador;
using TurismoRealEscritorio.Modelos;
using TurismoRealEscritorio.Vista;

namespace TurismoRealEscritorio.Vistas.Deptos
{
    public partial class frmDeptos : Form
    {
        int intent = 0;
        public frmMain Main;
        public bool expand = false;
        public bool suma = true;
        public bool anim = false;
        bool primeraCarga = true;


        public frmDeptos(frmMain main = null)
        {
            InitializeComponent();
            Main = main;
            Main.ConfigurarBotones(pEdicion.Controls[0]);
            foreach (Control item in pEdicion.Controls[0].Controls)
            {
                Main.ConfigurarBotones(item);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (expand)
            {
                if (suma)
                {
                    if (pEdicion.Height >= 343)
                    {
                        suma = !suma;
                        expand = false;
                    }
                    else
                    {
                        pEdicion.Height = pEdicion.Height + 49;
                    }
                }
                else
                {
                    if (pEdicion.Height <= 0)
                    {
                        suma = !suma;
                        expand = false;
                        anim = true;
                        timerEdicion.Stop();
                        btnAgregar.Enabled = true;
                        btnEliminar.Enabled = true;
                        btnRefrescar.Enabled = true;
                        btnModificar.Enabled = true;
                        btnMantenciones.Enabled = true;
                    }
                    else
                    {
                        pEdicion.Height = pEdicion.Height - 49;
                    }
                }
                pEdicion.Refresh();
            }
        }
        private void Desplegar()
        {
            timerEdicion.Start();
            expand = true;
            suma = true;
            btnAgregar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = false;
            btnModificar.Enabled = false;
            btnMantenciones.Enabled = false;
        }

        private void PrepararComboboxes()
        {
            cbLocalidad.DataSource = null;
            cbLocalidad.ValueMember = "Id_localidad";
            cbLocalidad.DisplayMember = "Nombre";
            do
            {
                cbLocalidad.DataSource = Main.Repos.Localidades;
            } while (cbLocalidad.DataSource==null);
            cbLocalidad.SelectedItem = null;
            cbLocalidad.Text = "Seleccione Localidad";
        }

        private void btnCancelar_Click(object sender, EventArgs e = null)
        {
            expand = true;
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            lbId.Visible = true;
            txtId.Visible = true;
            lbEstado.Visible = true;
            txtEstado.Visible = true;
            btnAplicar.Text = "Aplicar";
            PrepararComboboxes();
            Departamento depto;
            do
            {
                depto = await ClienteHttp.Peticion.Get<Departamento>(tablaDeptos.SelectedRows[0].Cells[0].Value.ToString());
            } while (depto == null);
            txtId.Text = depto.Id_depto.ToString();
            txtNombre.Text = depto.Nombre;
            txtDireccion.Text = depto.Direccion;
            cbLocalidad.SelectedItem = Tools.BuscarEnLista((List<Localidad>)cbLocalidad.DataSource, "Id_localidad", depto.Id_localidad);
            txtMCuadrados.Text = depto.Mts_cuadrados.ToString();
            txtHabitaciones.Text = depto.Habitaciones.ToString();
            txtBanos.Text = depto.Banos.ToString();
            txtArriendo.Text = depto.Arriendo.ToString();
            txtDividendo.Text = depto.Dividendo.ToString();
            txtContribuciones.Text = depto.Contribuciones.ToString();
            txtEstado.Text = Repositorios.Buscar(Main.Repos.EstadoDeptos, "Id_estado", depto.Id_estado).Nombre;
            Desplegar();
            Main.EstadoTrabajo = EstadoTrabajo.Modificando;
        }

        private void frmDeptos_Load(object sender, EventArgs e)
        {
            pEdicion.Height = 0;
            CargarDatos();
            pEdicion.Visible = true;
        }
        private async void CargarDatos(object sender = null, EventArgs e = null)
        {
            try{
                Main.Do();
                var lista = await ClienteHttp.Peticion.GetList<Departamento>();
                if (primeraCarga)
                {
                    tablaDeptos.Columns.Add("id_depto", "Identificador");
                    tablaDeptos.Columns.Add("nombre", "Nombre");
                    tablaDeptos.Columns.Add("direccion", "Dirección");
                    tablaDeptos.Columns.Add("arriendo", "Arriendo");
                    tablaDeptos.Columns.Add("mts", "Metros cuadrados");
                    tablaDeptos.Columns.Add("habitaciones", "Habitaciones");
                    tablaDeptos.Columns.Add("banos", "Baños");
                    tablaDeptos.Columns.Add("localidad", "Localidad");
                    tablaDeptos.Columns.Add("estado", "Estado");

                    tablaDeptos.Columns["id_depto"].Width = 75;
                    tablaDeptos.Columns["nombre"].Width = 150;
                    tablaDeptos.Columns["direccion"].Width = 160;
                    tablaDeptos.Columns["arriendo"].Width = 55;
                    tablaDeptos.Columns["mts"].Width = 100;
                    tablaDeptos.Columns["habitaciones"].Width = 75;
                    tablaDeptos.Columns["banos"].Width = 45;
                    tablaDeptos.Columns["localidad"].Width = 100;
                    tablaDeptos.Columns["estado"].Width = 110;
                }
                else
                {
                    tablaDeptos.Rows.Clear();
                }
                foreach (var i in lista)
                {
                    tablaDeptos.Rows.Add(i.Id_depto, i.Nombre, i.Direccion, "$" + i.Arriendo, i.Mts_cuadrados, i.Habitaciones, i.Banos, Repositorios.Buscar(Main.Repos.Localidades, "Id_localidad", i.Id_localidad).Nombre, Repositorios.Buscar(Main.Repos.EstadoDeptos, "Id_estado", i.Id_estado).Nombre);
                }
                if (primeraCarga)
                {
                    tablaDeptos.MultiSelect = false;
                    tablaDeptos.Rows[0].Selected = true;
                    primeraCarga = false;
                }
                Main.Undo();
            }
            catch (Exception ex)
            {
                if (intent > 1)
                {
                    Main.Undo();
                    intent = 0;
                    return;
                }
                intent++;
                CargarDatos();
            }
        }

        private void btnImagenes_Click(object sender, EventArgs e)
        {
            frmImagenes frm = new frmImagenes(this,txtId.Text);
            Main.ConfigurarBotones(frm);
            frm.Show();
            frm.Focus();
        }

        private async void btnAplicar_Click(object sender, EventArgs e)
        {
            Departamento dep = new Departamento();
            dep.Nombre = txtNombre.Text;
            dep.Direccion = txtDireccion.Text;
            dep.Arriendo = Convert.ToInt32(txtArriendo.Text);
            dep.Habitaciones = Convert.ToInt32(txtHabitaciones.Text);
            dep.Banos = Convert.ToInt32(txtBanos.Text);
            dep.Mts_cuadrados = (float)Convert.ToDouble(txtMCuadrados.Text);
            dep.Contribuciones = Convert.ToInt32(txtContribuciones.Text);
            dep.Dividendo = Convert.ToInt32(txtDividendo.Text);
            dep.Id_localidad = (int)cbLocalidad.SelectedValue;
            switch (Main.EstadoTrabajo)
            {
                case EstadoTrabajo.Modificando:
                    dep.Id_estado = 1;
                    await ClienteHttp.Peticion.Send(new HttpMethod("PATCH"),dep,txtId.Text,SesionManager.Token);
                    break;
                case EstadoTrabajo.Agregando:
                    await ClienteHttp.Peticion.Send(HttpMethod.Post, dep, token: SesionManager.Token,txt:new Control());
                    break;
            }
            expand = true;
            Main.EstadoTrabajo = EstadoTrabajo.Espera;
            CargarDatos();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea borrar el departamento del sistema?", "Borrar Departamento", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                ClienteHttp.Peticion.Delete<Departamento>(tablaDeptos.SelectedRows[0].Cells[0].Value.ToString(), SesionManager.Token);
                CargarDatos();
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnMantenciones_Click(object sender, EventArgs e)
        {
            frmMantenciones frm = new frmMantenciones(Main, tablaDeptos.SelectedRows[0].Cells[0].Value.ToString());
            frm.Show();
            frm.Focus();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            lbId.Visible = false;
            txtId.Visible = false;
            lbEstado.Visible = false;
            txtEstado.Visible = false;
            btnAplicar.Text = "Crear";
            PrepararComboboxes();
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtMCuadrados.Text = "";
            txtHabitaciones.Text = "";
            txtBanos.Text = "";
            txtArriendo.Text = "";
            txtDividendo.Text = "";
            txtContribuciones.Text = "";
            Desplegar();
            Main.EstadoTrabajo = EstadoTrabajo.Agregando;
        }

        private void ValidarSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
