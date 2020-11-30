using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurismoRealEscritorio.Controlador;
using TurismoRealEscritorio.Modelos;
using TurismoRealEscritorio.Modelos.Util;
using TurismoRealEscritorio.Vista;

namespace TurismoRealEscritorio.Vistas.Usuarios
{
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
        frmCargando ve;
        bool Vusername = false;
        bool VemailDisp = false;
        bool Vemail = false;
        bool VrutDisp = false;
        Regex formatoCorreo = new Regex(@"^[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,4}$");

        public frmUsuarios(frmMain main = null)
        {
            InitializeComponent();
            Main = main;
            Main.Do();
            imgAbierto = imgAbiertoCont.Image;
            imgCerrado = imgCerradoCont.Image;
            imgAbriendo = imgAbriendoCont.Image;
            imgCerrando = imgCerrandoCont.Image;
            btnOjo.Image = imgCerrado;
            FrameDimension dim = new FrameDimension(imgAbriendo.FrameDimensionsList[0]);
            cuadros = imgAbriendo.GetFrameCount(dim);
            dtNacimiento.MaxDate = DateTime.Now.Subtract(DateTime.Now.AddYears(18) - DateTime.Now);
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
            } while (cbRegion.DataSource == null);
            do
            {
                cbGenero.DataSource = Main.Repos.Generos;
            } while (cbGenero.DataSource == null);
            do
            {
                cbRol.DataSource = Main.Repos.Roles;
            } while (cbRol.DataSource == null);
            pEdicion.Visible = true;
        }

        private async void CargarUsuarios(object sender = null, EventArgs e = null)
        {
            Main.Do();
            try
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
                    btnModificar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnRefrescar.Enabled = true;
                    btnAgregar.Enabled = true;
                }
                Main.Undo();
            }
            catch(Exception ex)
            {
                Main.Undo();
                btnRefrescar.Enabled = true;
                btnAgregar.Enabled = true;
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
            dtNacimiento.Value = dtNacimiento.MaxDate;
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            Main.EstadoTrabajo = EstadoTrabajo.Agregando;
        }
        private async void PrepararModificar()
        {
            Main.EstadoTrabajo = EstadoTrabajo.Modificando;
            usuarioActual = null;
            do
            {
                usuarioActual = await ClienteHttp.Peticion.Get<PersonaUsuario>(tablaUsuarios.SelectedRows[0].Cells[0].Value.ToString(), SesionManager.Token);
            } while (usuarioActual == null);
            lbEstado.Visible = true;
            chkActivo.Visible = true;
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
            try
            {
                dtNacimiento.Value = p.Nacimiento;
            }
            catch(Exception e)
            {
                dtNacimiento.Value = dtNacimiento.MaxDate;
            }
            txtEmail.Text = p.Email;
            txtTelefono.Text = p.Telefono.ToString();
            txtDireccion.Text = p.Direccion;
            cbRol.SelectedItem = Repositorios.Buscar((List<Rol>)cbRol.DataSource, "Id_rol", u.Id_rol);
            cbRegion.SelectedItem = Repositorios.Buscar((List<ProxyRegion>) cbRegion.DataSource, "Region", p.Region);
            cbRegion_SelectionChangeCommitted(cbRegion);
            cbComuna.SelectedItem = Repositorios.Buscar((List<Comuna>) cbComuna.DataSource, "Nombre", p.Comuna);
            cbGenero.SelectedItem = Repositorios.Buscar((List<Genero>) cbGenero.DataSource, "Id_genero", p.Id_genero);
            cbRegion.Refresh();
            cbComuna.Refresh();
            cbGenero.Refresh();
            cbRol.Refresh();
        }
        private void LimpiarCampos()
        {
            PrepararComboboxes();
            txtUsername.Text = "";
            txtRut.Text = "";
            txtNombres.Text = "";
            txtApellidos.Text = "";
            dtNacimiento.Value = dtNacimiento.MaxDate;
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
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
            btnAplicar.Enabled = false;
        }
        private void btnCancelar_Click(object sender, EventArgs e = null)
        {
            expand = true;
            LimpiarCampos();
        }
        private void cbRegion_SelectionChangeCommitted(object sender, EventArgs e = null)
        {
            if (sender != null)
            {
                ComboBox temp = (ComboBox)sender;
                if (temp.SelectedItem == null)
                {
                    return;
                }
                cbComuna.DataSource = ((ProxyRegion)temp.SelectedItem).Comunas;
                cbComuna.DisplayMember = "Nombre";
                cbComuna.ValueMember = "Nombre";
                cbComuna.Refresh();
                cbComuna.Enabled = true;
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos() || !btnAplicar.Enabled)
            {
                MessageBox.Show("Por favor, revise el formulario y complete o corrija la informacion.", "Formulario incompleto", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                return;
            }
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
                    ClienteHttp.Peticion.Send(new HttpMethod("PATCH"), Actual,u.Username,SesionManager.Token);
                    break;
            }
            Main.EstadoTrabajo = EstadoTrabajo.Espera;
            expand = true;
            CargarUsuarios();
            LimpiarCampos();
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
            if (MessageBox.Show("¿Esta seguro que desea borrar al usuario del sistema?", "Borrar Usuario", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                await ClienteHttp.Peticion.Delete<Usuario>(tablaUsuarios.SelectedRows[0].Cells[0].Value.ToString(), token: SesionManager.Token);
                CargarUsuarios();
            }
        }
        private async void VerificarDisponibilidad(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            switch (txt.Name)
            {
                case "txtUsername":
                    if (Main.EstadoTrabajo == EstadoTrabajo.Agregando)
                    {
                        bool b = false;
                        if (txt.Text.Length > 4)
                        {
                            b = true;
                            txt.ForeColor = Color.Green;
                            lbErrorU.Text = "";
                            lbErrorU.Visible = false;
                            Vusername = await ClienteHttp.Peticion.Disponible(txt.Text, "username");
                            if (!Vusername)
                            {
                                txt.ForeColor = Color.Red;
                                lbErrorU.Text = "El nombre de usuario no esta disponible.";
                                lbErrorU.Visible = true;
                            }
                        }
                        else if(txt.Text.Length <= 4)
                        {
                            txt.ForeColor = Color.Red;
                            lbErrorU.Text = "El nombre de usuario debe tener al menos 5 caracteres.";
                            lbErrorU.Visible = true;
                        }
                        Vusername = Vusername && b;
                    }
                    break;
                case "txtRut":
                    if (Main.EstadoTrabajo == EstadoTrabajo.Agregando)
                    {
                        VrutDisp = await ClienteHttp.Peticion.Disponible(txt.Text, "rut");
                        if (VrutDisp)
                        {
                            txt.ForeColor = Color.Green;
                            lbErrorR.Text = "";
                            lbErrorR.Visible = false;
                        }
                        else
                        {
                            txt.ForeColor = Color.Red;
                            lbErrorR.Text = "El rut ingresado ya pertenece a un usuario.";
                            lbErrorR.Visible = true;
                        }
                    }
                    break;
                case "txtEmail":
                    if(Main.EstadoTrabajo == EstadoTrabajo.Agregando)
                    {
                        if (txtEmail.Text.Trim().Length >= 5)
                        {
                            Vemail = formatoCorreo.IsMatch(txtEmail.Text.ToUpper());
                            Console.WriteLine(Vemail);
                            if (Vemail)
                            {
                                txt.ForeColor = Color.Green;
                                lbErrorE.Text = "";
                                lbErrorE.Visible = false;
                                VemailDisp = await ClienteHttp.Peticion.Disponible(txt.Text, "email");
                                if (!VemailDisp)
                                {
                                    txt.ForeColor = Color.Red;
                                    lbErrorE.Text = "El correo electrónico ingresado ya pertenece a un usuario/chofer.";
                                    lbErrorE.Visible = true;
                                }
                            }
                            else
                            {
                                txt.ForeColor = Color.Red;
                                lbErrorE.Text = "Formato de correo electrónico inválido.";
                                lbErrorE.Visible = true;
                            }
                        }
                        else
                        {
                            txt.ForeColor = Color.Black;
                            lbErrorE.Text = "";
                            lbErrorE.Visible = false;
                            Vemail = false;
                            VemailDisp = false;
                        }
                        
                    }
                    break;
            }
            ValidarCampos();
        }
        private void ValidarSoloNumeros(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            ValidarCampos();
        }
        private void ValidarSoloLetras(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            ValidarCampos();
        }

        private void FormatearRut(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !(e.KeyChar == 'k' || e.KeyChar == 'K'))
            {
                e.Handled = true;
            }
            else if (!char.IsControl(e.KeyChar))
            {
                txt.Text = Tools.FormatearRut(txt.Text);
            }
            txt.SelectionStart = txt.Text.Length;
            ValidarCampos();
        }
        private bool ValidarCampos()
        {
            bool Vrol = false;
            bool Vrut = false;
            bool Vnombres = false;
            bool Vapellidos = false;
            bool Vgenero = false;
            bool Vtelefono = false;
            bool Vdireccion = false;
            bool Vregion = false;

            Vrol = cbRol.SelectedItem != null;
            Vrut = Tools.ValidarRut(txtRut.Text);
            Vnombres = txtNombres.Text.Trim().Length > 1;
            Vapellidos = txtApellidos.Text.Trim().Length > 3;
            Vregion = cbRegion.SelectedItem != null;
            Vdireccion = txtDireccion.Text.Trim().Length > 5;
            Vtelefono = txtTelefono.Text.Trim().Length == 9;
            Vgenero = cbGenero.SelectedItem != null;

            bool b = VrutDisp && VemailDisp && Vusername && Vrol && Vrut && Vnombres && Vapellidos && Vemail && Vgenero 
                && Vtelefono && Vdireccion && Vregion;
            btnAplicar.Enabled = b;
            return b;
        }

        private void Update(object sender, EventArgs e)
        {
            ValidarCampos();
        }
    }
}