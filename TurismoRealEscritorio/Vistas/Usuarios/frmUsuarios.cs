using System;
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
        public PersonaUsuario usuarioActual;

        public frmUsuarios(frmMain main = null)
        {
            InitializeComponent();
            Main = main;
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
            /*cbRegion.DataSource = Main.Repos.Regiones;
            cbGenero.DataSource = Main.Repos.Generos;
            cbRol.DataSource = Main.Repos.Roles;*/
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
            usuarioActual = null;
            usuarioActual = await ClienteHttp.Peticion.Get<PersonaUsuario>(tablaUsuarios.SelectedRows[0].Cells[0].Value.ToString(), SesionManager.Token);
            btnAplicar.Text = "Aplicar";
            PrepararComboboxes();
            //Se preparan los campos
            var u = usuarioActual.Usuario;
            var p = usuarioActual.Persona;
            txtUsername.Text = u.Username;
            txtUsername.Enabled = false;
            chkActivo.Checked = u.Activo == '1';
            lbFrecuente.Text = (u.Frecuente == '1') ? "Si" : "No";
            txtRut.Text = p.Rut;
            txtRut.Enabled = false;
            txtNombres.Text = p.Nombres;
            txtApellidos.Text = p.Apellidos;
            dtNacimiento.Value = p.Nacimiento;
            txtEmail.Text = p.Email;
            txtTelefono.Text = p.Telefono.ToString();
            txtDireccion.Text = p.Direccion;
            do
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
            usuarioActual = new PersonaUsuario();
            usuarioActual.Persona = new Persona();
            usuarioActual.Usuario = new Usuario();
            var p = usuarioActual.Persona;
            var u = usuarioActual.Usuario;
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
                    ClienteHttp.Peticion.Send(HttpMethod.Post,usuarioActual);
                    break;
                case EstadoTrabajo.Modificando:
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
                    ClienteHttp.Peticion.Send(new HttpMethod("PATCH"), usuarioActual,"/"+u.Username,SesionManager.Token);
                    break;
            }
            expand = true;
            CargarUsuarios();
        }
    }
}