﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurismoRealEscritorio.Controlador;
using TurismoRealEscritorio.Modelos;
using TurismoRealEscritorio.Modelos.Util;
using TurismoRealEscritorio.Vista;

namespace TurismoRealEscritorio.Vistas.Usuarios
{//                                                  TERMINAR
    public partial class frmUsuarios : Form
    {
        frmMain Main;
        public bool expand = false;
        public bool suma = true;
        public bool anim = false;
        bool primeraCarga = true;
        bool claveVisible = false;
        Image imgAbierto;
        Image imgCerrado;
        Image imgAbriendo;
        Image imgCerrando;
        int cuadros = 0;
        int cuadroActual = 0;
        public PersonaUsuario usuarioActual;

        public frmUsuarios(frmMain main = null)
        {
            InitializeComponent();
            Main = main;
            imgAbierto = imgAbiertoCont.Image;
            imgCerrado = imgCerradoCont.Image;
            imgAbriendo = imgAbriendoCont.Image;
            imgCerrando = imgCerrandoCont.Image;
            btnOjo.Image = imgCerrado;
            FrameDimension dim = new FrameDimension(imgAbriendo.FrameDimensionsList[0]);
            cuadros = imgAbriendo.GetFrameCount(dim);
        }

        private async void CargarUsuarios(object sender = null, EventArgs e = null)
        {
            var lista = await ClienteHttp.Peticion.GetList<PersonaUsuario>(SesionManager.Token);
            if (primeraCarga)
            {
                tablaUsuarios.Columns.Add("username", "Usuario");
                tablaUsuarios.Columns.Add("nombres", "Nombres");
                tablaUsuarios.Columns.Add("apellidos", "Apellidos");
                tablaUsuarios.Columns.Add("email", "Correo electronico");
                tablaUsuarios.Columns.Add("activo", "Estado");
                tablaUsuarios.Columns.Add("rol", "Rol");
            }
            else
            {
                tablaUsuarios.Rows.Clear();
            }
            foreach (var i in lista)
            {
                tablaUsuarios.Rows.Add(i.Usuario.Username, i.Persona.Nombres, i.Persona.Apellidos, i.Persona.Email, (i.Usuario.Activo == '1' ? "Activo" : "Inactivo"), Main.Repos.Roles[i.Usuario.Id_rol - 1].Nombre);
            }
            if (primeraCarga)
            {
                foreach (DataGridViewRow r in tablaUsuarios.Rows)
                {
                    foreach (DataGridViewCell c in r.Cells)
                    {
                        if (c.OwningColumn.Width < (c.Value.ToString().Length + 124))
                        {
                            c.OwningColumn.Width = c.Value.ToString().Length + 124;
                        }
                    }
                }
                tablaUsuarios.MultiSelect = false;
                tablaUsuarios.Rows[0].Selected = true;
                primeraCarga = false;
                pEdicion.Visible = true;
            }
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            pEdicion.Height = 0;
            Main.ConfigurarBotones(pEdicion);
            CargarUsuarios();
            Main.EstadoTrabajo = EstadoTrabajo.Espera;
            cbRegion.DisplayMember = "Region";
            cbRegion.ValueMember = "Region";
            cbGenero.DisplayMember = "Nombre";
            cbGenero.ValueMember = "Id_genero";
            cbRol.DisplayMember = "Nombre";
            cbRol.ValueMember = "Id_rol";
            do
            {
                cbRegion.DataSource = Main.Repos.Regiones;
            } while (cbRegion.DataSource==null);
            do
            {
                cbGenero.DataSource = Main.Repos.Generos;
            } while (cbGenero.DataSource == null);
            do
            {
                cbRol.DataSource = Main.Repos.Roles;
            } while (cbRol.DataSource == null);
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
                    }
                    else
                    {
                        pEdicion.Height = pEdicion.Height - 49;
                    }
                }
                pEdicion.Refresh();
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            PrepararModificar();
            Desplegar();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PrepararAgregar();
            Desplegar();
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
        }
        private void PrepararAgregar()
        {
            lbEstado.Visible = false;
            chkActivo.Visible = false;
            lbFrecuente.Visible = false;
            txtFrecuente.Visible = false;
            pClave.Visible = false;
            chkClave.Visible = false;
            PrepararComboboxes();
            btnAplicar.Text = "Crear";
            txtUsername.Text = "";
            txtUsername.Enabled = true;
            chkActivo.Checked = true;
            //ESPACIO PARA CONTRASEÑA
            txtRut.Text = "";
            txtRut.Enabled = true;
            txtNombres.Text = "";
            txtApellidos.Text = "";
            dtNacimiento.Value = DateTime.Now;
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            Main.EstadoTrabajo = EstadoTrabajo.Agregando;
        }
        private async void PrepararModificar()
        {
            lbEstado.Visible = true;
            chkActivo.Visible = true;
            usuarioActual = null;
            usuarioActual = await ClienteHttp.Peticion.Get<PersonaUsuario>(tablaUsuarios.SelectedRows[0].Cells[0].Value.ToString(), SesionManager.Token);
            btnAplicar.Text = "Aplicar";
            chkClave.Checked = false;
            claveVisible = false;
            btnOjo.Image = imgCerrado;
            pClave.Visible = true;
            chkClave.Visible = true;
            pClave.Enabled = false;
            PrepararComboboxes();
            //Se preparan los campos
            var u = usuarioActual.Usuario;
            var p = usuarioActual.Persona;
            txtClave.Text = "";
            txtUsername.Text = u.Username;
            txtUsername.Enabled = false;
            chkActivo.Checked = u.Activo == '1';
            txtFrecuente.Text = (u.Frecuente == '1') ? "Si" : "No";
            if (u.Id_rol == 5)
            {
                txtFrecuente.Visible = true;
                lbFrecuente.Visible = true;
            }
            else
            {
                txtFrecuente.Visible = false;
                lbFrecuente.Visible = false;
            }
            txtRut.Text = p.Rut;
            txtRut.Enabled = false;
            txtNombres.Text = p.Nombres;
            txtApellidos.Text = p.Apellidos;
            dtNacimiento.Value = p.Nacimiento;
            txtEmail.Text = p.Email;
            txtTelefono.Text = p.Telefono.ToString();
            txtDireccion.Text = p.Direccion;
            /*do
            {
                if (cbRol.DataSource != null)
                {
                    cbRol.SelectedItem = Main.Repos.Buscar((List<Rol>)cbRol.DataSource, "Id_rol", u.Id_rol);
                }
            } while (cbRol.DataSource == null);
            do
            {
                if (cbRegion.DataSource != null)
                {
                    cbRegion.SelectedItem = Main.Repos.Buscar((List<ProxyRegion>)cbRegion.DataSource, "Region", p.Region);
                }
            } while (cbRegion.DataSource == null);
            cbRegion_SelectionChangeCommitted(cbRegion);
            do
            {
                if (cbComuna.DataSource != null)
                {
                    cbComuna.SelectedItem = Main.Repos.Buscar((List<Comuna>)cbComuna.DataSource, "Nombre", p.Comuna);
                }
            } while (cbComuna.DataSource == null);
            do
            {
                if (cbGenero.DataSource != null)
                {
                    cbGenero.SelectedItem = Main.Repos.Buscar((List<Genero>)cbGenero.DataSource, "Id_genero", p.Id_genero);
                }
            } while (cbGenero.DataSource == null);
            /**/
            cbRol.SelectedItem = Main.Repos.Buscar((List<Rol>)cbRol.DataSource, "Id_rol", u.Id_rol);
            cbRegion.SelectedItem = Main.Repos.Buscar((List<ProxyRegion>) cbRegion.DataSource, "Region", p.Region);
            cbRegion_SelectionChangeCommitted(cbRegion);
            cbComuna.SelectedItem = Main.Repos.Buscar((List<Comuna>) cbComuna.DataSource, "Nombre", p.Comuna);
            cbGenero.SelectedItem = Main.Repos.Buscar((List<Genero>) cbGenero.DataSource, "Id_genero", p.Id_genero);
            /**/
            cbRegion.Refresh();
            cbComuna.Refresh();
            cbGenero.Refresh();
            cbRol.Refresh();
            Main.EstadoTrabajo = EstadoTrabajo.Modificando;
        }
        private void PrepararComboboxes()
        {
            cbRegion.SelectedItem = null;
            cbRol.SelectedItem = null;
            cbComuna.SelectedItem = null;
            cbGenero.SelectedItem = null;
            cbComuna.Enabled = false;
            cbRegion.Text = "Seleccione Region";
            cbComuna.Text = "Seleccione Comuna";
            cbGenero.Text = "Seleccione Genero";
            cbRol.Text    = "Seleccione Rol";
            cbRegion.Refresh();
            cbComuna.Refresh();
            cbGenero.Refresh();
            cbRol.Refresh();
        }
        private void btnCancelar_Click(object sender, EventArgs e = null)
        {
            expand = true;
        }
        private void cbRegion_SelectionChangeCommitted(object sender, EventArgs e = null)
        {
            if (sender != null)
            {
                ComboBox temp = (ComboBox)sender;
                cbComuna.DataSource = ((ProxyRegion)temp.SelectedItem).Comunas;
                cbComuna.DisplayMember = "Nombre";
                cbComuna.ValueMember = "Nombre";
                cbComuna.Refresh();
                cbComuna.Enabled = true;
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            ProxyPersonaUsuario Actual = new ProxyPersonaUsuario();
            Actual.Persona = new Persona();
            Actual.Usuario = new ProxyUsuario();
            var p = Actual.Persona;
            var u = Actual.Usuario;
            switch (Main.EstadoTrabajo)
            {
                case EstadoTrabajo.Agregando:
                    
                    u.Username = txtUsername.Text;
                    u.Id_rol = (int)cbRol.SelectedValue;
                    u.Activo = chkActivo.Checked ? '1' : '0';
                    p.Rut = txtRut.Text;
                    p.Nombres = txtNombres.Text;
                    p.Apellidos = txtApellidos.Text;
                    p.Nacimiento = dtNacimiento.Value;
                    p.Email = txtEmail.Text;
                    p.Id_genero = (int)cbGenero.SelectedValue;
                    p.Telefono = Convert.ToInt32(txtTelefono.Text);
                    p.Direccion = txtDireccion.Text;
                    p.Region = cbRegion.SelectedValue.ToString();
                    p.Comuna = cbComuna.SelectedValue.ToString();
                    ClienteHttp.Peticion.Send(HttpMethod.Post,Actual);
                    break;
                case EstadoTrabajo.Modificando:
                    u.Username = txtUsername.Text;
                    u.Id_rol = (int)cbRol.SelectedValue;
                    u.Activo = chkActivo.Checked ? '1' : '0';
                    p.Rut = u.Rut = txtRut.Text;
                    p.Nombres = txtNombres.Text;
                    p.Apellidos = txtApellidos.Text;
                    p.Nacimiento = dtNacimiento.Value;
                    p.Email = txtEmail.Text;
                    p.Id_genero = (int)cbGenero.SelectedValue;
                    p.Telefono = Convert.ToInt32(txtTelefono.Text);
                    p.Direccion = txtDireccion.Text;
                    p.Region = cbRegion.SelectedValue.ToString();
                    p.Comuna = cbComuna.SelectedValue.ToString();
                    u.Clave = txtClave.Text;
                    ClienteHttp.Peticion.Send(new HttpMethod("PATCH"), Actual,"/"+u.Username,SesionManager.Token);
                    break;
            }
            Main.EstadoTrabajo = EstadoTrabajo.Espera;
            expand = true;
            CargarUsuarios();
        }

        private void chkClave_CheckedChanged(object sender, EventArgs e)
        {
            pClave.Enabled = chkClave.Checked;
            if (!chkClave.Checked)
            {
                txtClave.Text = "";
            }
        }

        private void btnOjo_Click(object sender = null, EventArgs e = null)
        {
            claveVisible = !claveVisible;
            if (claveVisible)
            {
                btnOjo.Image = imgAbriendo;
                txtClave.PasswordChar = '\0';
            }
            else
            {
                btnOjo.Image = imgCerrando;
                txtClave.PasswordChar = '*';
            }
            btnOjo.Refresh();
        }

        private void btnOjo_Paint(object sender, PaintEventArgs e)
        {
            if (cuadroActual == cuadros && cuadroActual > 1)
            {
                if (claveVisible)
                {
                    btnOjo.Image = imgAbierto;
                }
                else
                {
                    btnOjo.Image = imgCerrado;
                }
                cuadroActual = 0;
            }
            cuadroActual++;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            usuarioActual = null;
            usuarioActual = await ClienteHttp.Peticion.Get<PersonaUsuario>(tablaUsuarios.SelectedRows[0].Cells[0].Value.ToString(), SesionManager.Token);
            await ClienteHttp.Peticion.Send(HttpMethod.Delete, usuarioActual.Usuario, token: SesionManager.Token);
            CargarUsuarios();
        }
        private async void VerificarDisponibilidad(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            switch (txt.Name)
            {
                case "txtUsername":
                    if (Main.EstadoTrabajo == EstadoTrabajo.Agregando)
                    {
                        await ClienteHttp.Peticion.Disponible(txt, lbErrorU);
                    }
                    break;
                case "txtRut":
                    if (Main.EstadoTrabajo == EstadoTrabajo.Agregando)
                    {
                        await ClienteHttp.Peticion.Disponible(txt, lbErrorR);
                    }
                    break;
                case "txtEmail":
                    if(Main.EstadoTrabajo == EstadoTrabajo.Agregando)
                    {
                        await ClienteHttp.Peticion.Disponible(txt, lbErrorE);
                    }
                    break;
            }
        }
    }
}