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

namespace TurismoRealEscritorio.Vistas.Logistica
{
    public partial class frmAsignarF : Form
    {
        int idLoc;
        List<Funcionario> funcionarios;
        frmMain Main;
        bool asignado = true;
        public frmAsignarF(frmMain m= null, int id = 1,String nombre = "Localidad", object f = null, bool asignado = false)
        {
            InitializeComponent();
            idLoc = id;
            lbNombre.Text = nombre;
            Main = m;
            Main.ConfigurarBotones(this);
            funcionarios = (List<Funcionario>)f;
            this.asignado = asignado;
        }

        private void frmAsignarF_Load(object sender, EventArgs e)
        {
            CargarFuncionarios();
        }
        private void CargarFuncionarios()
        {
            cbFuncionario.DataSource = funcionarios;
            cbFuncionario.ValueMember = "Username";
            cbFuncionario.DisplayMember = "Nombre";
            cbFuncionario.Text = "Seleccione funcionario";
        }
        async void Asignar()
        {
            LocalidadUsuario l = new LocalidadUsuario();
            l.Id_localidad = idLoc;
            l.Username = ((Funcionario)cbFuncionario.SelectedItem).Username;
            if(await ClienteHttp.Peticion.Send<LocalidadUsuario>(HttpMethod.Post, l,"localidad/asignar",SesionManager.Token,true))
            {
                if(MessageBox.Show("El funcionario fue asignado a la localidad exitosamente.", "Funcionario asignado", MessageBoxButtons.OK)== DialogResult.OK){
                    Cerrar();
                }
            }
            else
            {
                MessageBox.Show("No ha sido posible asignar al funcionario. Compruebe su conexión a internet.", "Problema al asignar funcionario", MessageBoxButtons.OK);
            }
        }
        private async void Desasignar()
        {
            if (MessageBox.Show("¿Esta seguro que desea desasignar este funcionario?", "Desasignar Funcionario", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            if (await ClienteHttp.Peticion.Delete<LocalidadUsuario>("localidad/desasignar/"+ ((Funcionario)cbFuncionario.SelectedItem).Username, SesionManager.Token, true))
            {
                MessageBox.Show("El funcionario fue desasignado exitosamente.", "Funcionario desasignado", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("No ha sido posible desasignar al funcionario. Compruebe su conexión a internet.", "Problema al desasignar funcionario", MessageBoxButtons.OK);
            }
        }
        private void btnAplicar_Click(object sender, EventArgs e)
        {
            Asignar();
        }
        private void btnDesasignar_Click(object sender, EventArgs e)
        {
            Desasignar();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cerrar();
        }
        void Cerrar()
        {
            Main.Enabled = true;
            Main.Focus();
            Dispose();
        }
    }
}
