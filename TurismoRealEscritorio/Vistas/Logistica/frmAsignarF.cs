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
        List<Funcionario> funcionarios;
        ProxyLocalidad Localidad;
        frmMain Main;
        frmLogistica Padre;
        public frmAsignarF(frmLogistica l = null, frmMain m = null, ProxyLocalidad pl = null, object f = null)
        {
            InitializeComponent();
            Padre = l;
            Localidad = pl;
            lbNombre.Text = Localidad.Localidad.Nombre;
            Main = m;
            Main.ConfigurarBotones(this);
            funcionarios = (List<Funcionario>)f;
        }

        private void frmAsignarF_Load(object sender, EventArgs e)
        {
            CargarFuncionarios();
            if (Localidad.Asignado)
            {
                cbFuncionario.SelectedItem = Tools.BuscarEnLista((List<Funcionario>)cbFuncionario.DataSource, "Username", Localidad.Username);
                cbFuncionario.Enabled = false;
                btnDesasignar.Enabled = true;
            }
        }
        private void CargarFuncionarios()
        {
            cbFuncionario.DataSource = funcionarios;
            cbFuncionario.ValueMember = "Username";
            cbFuncionario.DisplayMember = "Nombre";
            cbFuncionario.SelectedItem = null;
            cbFuncionario.Text = "Seleccione funcionario";
        }
        async void Asignar()
        {
            LocalidadUsuario l = new LocalidadUsuario();
            l.Id_localidad = Localidad.Localidad.Id_localidad;
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
                cbFuncionario.Enabled = true;
                cbFuncionario.SelectedItem = null;
                cbFuncionario.Text = "Seleccione funcionario";
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
            Padre.CargarLocalidades();
            Dispose();
        }
    }
}
