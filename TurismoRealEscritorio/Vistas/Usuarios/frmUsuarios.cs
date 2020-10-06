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
{//                                                  TERMINAR
    public partial class frmUsuarios : Form
    {
        frmMain Main;
        public bool expand = false;
        public bool suma = true;
        public bool anim = false;

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
            tablaUsuarios.Columns.Add("activo", "Estado");
            tablaUsuarios.Columns.Add("rol", "Rol");
            foreach (var i in lista)
            {
                tablaUsuarios.Rows.Add(i.Usuario.Username, i.Persona.Nombres, i.Persona.Apellidos, i.Persona.Email, (i.Usuario.Activo == '1' ? "Activo" : "Inactivo"), Main.Repo.Roles[i.Usuario.Id_rol - 1].Nombre);
            }
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
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
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (expand)
            {
                if (suma)
                {
                    pEdicion.Height = pEdicion.Height + 3;
                    if (pEdicion.Height >= 42)
                    {
                        suma = !suma;
                        expand = false;
                    }
                }
                else
                {
                    pEdicion.Height = pEdicion.Height - 3;
                    if (pEdicion.Height <= 0)
                    {
                        suma = !suma;
                        expand = false;
                        anim = true;
                        timerEdicion.Stop();
                    }
                }
                pEdicion.Refresh();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            timerEdicion.Start();
        }
    }
}