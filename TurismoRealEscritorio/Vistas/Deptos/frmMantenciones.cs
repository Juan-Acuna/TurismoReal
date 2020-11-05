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

namespace TurismoRealEscritorio.Vistas.Deptos
{
    public partial class frmMantenciones : Form
    {
        frmDeptos frm;
        public bool expand = false;
        public bool suma = true;
        public bool anim = false;
        bool primeraCarga = true;
        String IdDepto;

        List<Funcionario> funcionarios;

        public frmMantenciones(frmDeptos f = null, String depto = null)
        {
            InitializeComponent();
            frm = f;
            IdDepto = depto;
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
            pEdicion.Height = 0;
            funcionarios = new List<Funcionario>();
            var fun = await ClienteHttp.Peticion.GetList<PersonaUsuario>(SesionManager.Token);
            foreach (var i in fun)
            {
                if (i.Usuario.Id_rol == 4)
                {
                    funcionarios.Add(new Funcionario{ Username = i.Usuario.Username, Nombre = i.Persona.Nombres.Split(' ')[0] + i.Persona.Apellidos.Split(' ')[0] + " [" + i.Usuario.Username + "]" });
                }
            }
            cbTipo.DataSource = frm.Main.Repos.TipoMantenciones;
            cbTipo.DisplayMember = "Nombre";
            cbTipo.ValueMember = "Id_tipo";
            cbFuncionario.DataSource = funcionarios;
            cbFuncionario.ValueMember = "Username";
            cbFuncionario.DisplayMember = "Nombre";
            CargarDatos();
        }

        private async void CargarDatos(object sender = null, EventArgs e = null)
        {
            
            var lista = await ClienteHttp.Peticion.GetList<Mantencion>(token:SesionManager.Token,url:"depto/"+IdDepto);
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
                tablaManten.Rows.Add(i.Id_mantencion, Repositorios.Buscar(funcionarios,"Username",i.Username).Nombre, i.Fecha,(i.Hecho=='1'?"Realizada": "En proceso"));
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
            m.Id_depto = Int32.Parse(IdDepto);
            m.Hecho = '0';
            m.Id_tipo = (int)cbTipo.SelectedValue;
            m.Username = (String)cbFuncionario.SelectedValue;
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
            frm.Focus();
            this.Dispose();
        }
    }
}
