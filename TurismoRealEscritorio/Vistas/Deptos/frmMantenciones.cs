using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurismoRealEscritorio.Controlador;
using TurismoRealEscritorio.Modelos;
using TurismoRealEscritorio.Modelos.Util;
using TurismoRealEscritorio.Vista;

namespace TurismoRealEscritorio.Vistas.Deptos
{
    public partial class frmMantenciones : Form
    {
        frmMain Main;
        public bool expand = false;
        public bool suma = true;
        public bool anim = false;
        bool primeraCarga = true;
        Departamento Depto;
        String idDepto;
        PersonaUsuario Fun;
        List<Funcionario> funcionarios;

        public frmMantenciones(frmMain f = null, String id = null)
        {
            InitializeComponent();
            Main = f;
            idDepto = id;
            //var dep = await ClienteHttp.Peticion.Get<Departamento>(IdDepto);
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

        private async void frmMantenciones_Load(object sender, EventArgs e)
        {
            Main.Enabled = false;
            do
            {
                Depto = await ClienteHttp.Peticion.Get<Departamento>(idDepto);
            } while (Depto==null);
            pEdicion.Height = 0;
            funcionarios = new List<Funcionario>();
            Fun = await ClienteHttp.Peticion.Get<PersonaUsuario>("localidad/asignado/"+Depto.Id_localidad,SesionManager.Token,urlEspecial:true);
            Thread.Sleep(300);
            cbTipo.DataSource = Main.Repos.TipoMantenciones;
            cbTipo.DisplayMember = "Nombre";
            cbTipo.ValueMember = "Id_tipo";
            dtFecha.MinDate = DateTime.Now;
            CargarDatos();
        }

        private async void CargarDatos(object sender = null, EventArgs e = null)
        {
            
            var lista = await ClienteHttp.Peticion.GetList<Mantencion>(token:SesionManager.Token,url:"depto/"+Depto.Id_depto);
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
            if (Fun == null)
            {
                MessageBox.Show("Esta localidad no cuenta con un funcionario asignado,"
                    +" por favor asigne uno.\nPara asignar un funcionario, seleccione"
                    +" el apartado:\n'GESTIÓN DE RECURSOS > GESTIÓN DE LOCALIDADES > ASIGNAR'.",
                    "Funcionario no asignado", MessageBoxButtons.OK);
                Main.Enabled = true;
                Main.Focus();
                this.Dispose();
                return;
            }
            foreach (var i in lista)
            {
                tablaManten.Rows.Add(i.Id_mantencion, Fun.Persona.Nombres+" "+Fun.Persona.Apellidos, i.Fecha,(i.Hecho=='1'?"Realizada": "En proceso"));
            }
            if (primeraCarga)
            {
                tablaManten.MultiSelect = false;
                primeraCarga = false;
                pEdicion.Visible = true;
                
            }
            if (tablaManten.Rows.Count > 0)
            {
                tablaManten.Rows[0].Selected = true;
            }
            txtFuncionario.Text = Fun.Persona.Nombres.Split(' ')[0] + " " + Fun.Persona.Apellidos.Split(' ')[0];
        }
        private void btnAgendar_Click(object sender, EventArgs e)
        {
            cbTipo.Text = "Seleccione Tipo";
            Desplegar();
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            Mantencion m = new Mantencion();
            m.Fecha = dtFecha.Value;
            m.Id_depto = Depto.Id_depto;
            m.Hecho = '0';
            m.Id_tipo = (int)cbTipo.SelectedValue;
            m.Username = Fun.Usuario.Username;
            ClienteHttp.Peticion.Send<Mantencion>(HttpMethod.Post, m, token: SesionManager.Token);
            CargarDatos();
            expand = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            expand = true;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Main.Enabled = true;
            Main.Focus();
            this.Dispose();
        }

        private void frmMantenciones_FormClosing(object sender, FormClosingEventArgs e)
        {
            Main.Enabled = true;
            Main.Focus();
        }
    }
}
