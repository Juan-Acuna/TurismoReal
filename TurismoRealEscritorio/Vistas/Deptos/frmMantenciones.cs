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

namespace TurismoRealEscritorio.Vistas.Deptos
{
    public partial class frmMantenciones : Form
    {
        Form frm;
        public bool expand = false;
        public bool suma = true;
        public bool anim = false;
        bool primeraCarga = true;
        String IdDepto;
        List<object> funcionarios;

        public frmMantenciones(Form f = null, String depto = null)
        {
            InitializeComponent();
            frm = f;
            IdDepto = depto;
            //var dep = await ClienteHttp.Peticion.Get<Departamento>(IdDepto);
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frm.Focus();
            this.Dispose();
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
                        btnVolver.Enabled = true;
                        btnAgendar.Enabled = true;
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
            btnVolver.Enabled = false;
            btnAgendar.Enabled = false;
        }

        private void frmMantenciones_Load(object sender, EventArgs e)
        {
            pEdicion.Height = 0;
            CargarDatos();
        }

        private async void CargarDatos(object sender = null, EventArgs e = null)
        {
            funcionarios = new List<object>();
            var fun = await ClienteHttp.Peticion.GetList<PersonaUsuario>();
            foreach (var i in fun)
            {
                if (i.Usuario.Id_rol == 4)
                {
                    funcionarios.Add(new { username = i.Usuario.Username, nombre = i.Persona.Nombres.Split(' ')[0] + i.Persona.Apellidos.Split(' ')[0] + " [" + i.Usuario.Username + "]" });
                }
            }
            var lista = await ClienteHttp.Peticion.GetList<Mantencion>(url:"depto/");
            if (primeraCarga)
            {
                tablaManten.Columns.Add("id","Identificador");
                tablaManten.Columns.Add("username","Funcionario");
                tablaManten.Columns.Add("fecha","Fecha");
                tablaManten.Columns.Add("estado", "Estado");

                tablaManten.Columns["id"].Width = 75;
                tablaManten.Columns["username"].Width = 240;
                tablaManten.Columns["fecha"].Width = 114;
                tablaManten.Columns["estado"].Width = 100;
            }
            else
            {
                tablaManten.Rows.Clear();
            }
            foreach (var i in lista)
            {
                tablaManten.Rows.Add(i.Id_mantencion, Repositorios.Buscar(funcionarios,"username",i.Username), i.Fecha,(i.Hecho=='0'?"En proceso":"Realizada"));
            }
            if (primeraCarga)
            {
                tablaManten.MultiSelect = false;
                primeraCarga = false;
                pEdicion.Visible = true;
                
            }
            if (tablaManten.Rows.Count <= 0)
            {
                btnAgendar.Enabled = false;
            }
            else
            {
                tablaManten.Rows[0].Selected = true;
            }
        }

        private void btnAgendar_Click(object sender, EventArgs e)
        {
            Desplegar();
        }
    }
}
