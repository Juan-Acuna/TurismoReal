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
using TurismoRealEscritorio.Modelos;
using TurismoRealEscritorio.Vista;

namespace TurismoRealEscritorio.Vistas.Usuarios
{
    public partial class frmUsuarios : Form
    {
        frmMain Main;
        public frmUsuarios(frmMain main = null)
        {
            InitializeComponent();
            Main = main;
        }

        private async void CargarUsuarios(object sender = null, EventArgs e = null)
        {
            var lista = await ClienteHttp.Peticion.GetList<PersonaUsuario>(SesionManager.Token);
            tablaUsuarios.Columns.Add("username", "Usuario");
            tablaUsuarios.Columns.Add("nombres", "Nombres");
            tablaUsuarios.Columns.Add("apellidos", "Apellidos");
            tablaUsuarios.Columns.Add("email", "Correo electronico");
            tablaUsuarios.Columns.Add("activo", "Activo");
            tablaUsuarios.Columns.Add("rol", "Rol");
            foreach (var i in lista)
            {
                tablaUsuarios.Rows.Add(i.Usuario.Username, i.Persona.Nombres, i.Persona.Apellidos, i.Persona.Email, (i.Usuario.Activo == '1' ? "Si" : "No"),Main.Repo.Roles[i.Usuario.Id_rol-1].Nombre);
            }
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }
    }
}
