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
using TurismoRealEscritorio.Vistas;
using TurismoRealEscritorio.Vistas.Deptos;
using TurismoRealEscritorio.Vistas.Finanzas;
using TurismoRealEscritorio.Vistas.Logistica;
using TurismoRealEscritorio.Vistas.Usuarios;

namespace TurismoRealEscritorio.Vista
{
    public partial class frmMain : Form
    {
        public bool expand = false;
        public bool suma = true;
        public bool anim = false;
        public bool Conectado = true;
        public Repositorios Repos = new Repositorios();
        public EstadoTrabajo EstadoTrabajo = EstadoTrabajo.Espera;
        frmCargando ve;

        public frmMain()
        {
            InitializeComponent();
            pReconectando.BackColor = ColorTranslator.FromHtml("#212529");
            pReconectando.Height = 0;
            timerConexion.Start();
            ConfigurarBotones(pMenu);
            lbNombre.Text = SesionManager.NombrePila;
            pMenu.BackColor = ColorTranslator.FromHtml("#212529");
            lbTurismo.Parent = pMenu;
            lbTurismo.BackColor = Color.Transparent;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            btnFinanzas_Click();
        }
        public void ConfigurarBotones(Control cont)
        {
            foreach(var c in cont.Controls)
            {
                if(c is Button)
                {
                    ((Button)c).BackColor = ColorTranslator.FromHtml("#1d809f");
                    ((Button)c).ForeColor = ColorTranslator.FromHtml("#ffffff");
                    ((Button)c).MouseEnter += new EventHandler(_MouseEnter);
                    ((Button)c).MouseLeave += new EventHandler(_MouseLeave);
                    ((Button)c).FlatStyle = FlatStyle.Flat;
                    ((Button)c).FlatAppearance.BorderSize = 0;
                }
            }
        }
        
        public void AbrirForm(Form form)
        {
            if (pContainer.Controls != null)
            {
                if (pContainer.Controls.Count>0)
                {
                    pContainer.Controls[0].Dispose();
                }
                pContainer.Controls.Clear();
            }
            ConfigurarBotones(form);
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            pContainer.Controls.Add(form);
            pContainer.Tag = form;
            form.Show();
        }
        public void _MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = ColorTranslator.FromHtml("#155d74");
            ((Button)sender).ForeColor = ColorTranslator.FromHtml("#ffffff");
        }

        public void _MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = ColorTranslator.FromHtml("#1d809f");
            ((Button)sender).ForeColor = ColorTranslator.FromHtml("#ffffff");
        }
        #region Conexion
        public void BloquearBotones(Control cont)
        {
            foreach (var c in cont.Controls)
            {
                if (c is Button)
                {
                    ((Button)c).Enabled = false;
                }
            }
        }
        public void DesbloquearBotones(Control cont)
        {
            foreach (var c in cont.Controls)
            {
                if (c is Button)
                {
                    ((Button)c).Enabled = true;
                }
            }
        }
        public async Task<bool> ComprobarConexion()
        {
            Conectado = await ClienteHttp.Peticion.Test();
            return Conectado;
        }

        public void Reconectar()
        {
            if (!anim)
            {
                timer1.Start();
                expand = anim = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (expand)
            {
                if (suma)
                {
                    pReconectando.Height = pReconectando.Height + 3;
                    if (pReconectando.Height >= 42)
                    {
                        suma = !suma;
                        expand = false;
                    }
                }
                else
                {
                    pReconectando.Height = pReconectando.Height - 3;
                    if (pReconectando.Height <= 0)
                    {
                        suma = !suma;
                        expand = false;
                        anim = true;
                        DesbloquearBotones(pContainer.Controls[0]);
                        timer1.Stop();
                    }
                }
                pReconectando.Refresh();
            }
        }
        private async void timerConexion_Tick(object sender, EventArgs e)
        {
            if (await ComprobarConexion())
            {
                if (pReconectando.Height >= 42)
                {
                    suma = false;
                }
                expand = true;
                anim = false;
            }
            else
            {
                if (pContainer != null)
                {
                    BloquearBotones(pContainer.Controls[0]);
                }
                Reconectar();
            }
        }
        #endregion
        #region Botones
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            timerConexion.Stop();
        }
        private void btnFinanzas_Click(object sender = null, EventArgs e = null)
        {
            SeleccionarBoton(0);
            AbrirForm(new frmFinanzas(this));
        }
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(1);
            AbrirForm(new frmUsuarios(this));
        }
        private void btnDeptos_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(2);
            AbrirForm(new frmDeptos(this));
        }

        private void btnLogistica_Click(object sender, EventArgs e)
        {
            SeleccionarBoton(3);
            AbrirForm(new frmLogistica(this));
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Esta a punto de cerrar el programa.\n\n¿Desea cerrar sesión y salir del programa?","Salir del programa", MessageBoxButtons.OKCancel) == DialogResult.OK){
                this.Dispose();
            }
        }
        #endregion
        #region Metodos Publicos
        public void Do()
        {
            if (ve != null)
            {
                return;
            }
            ve = new frmCargando(this);
            ve.SetDesktopLocation(DesktopLocation.X + (int)Math.Floor((double)Width/2) -20 ,DesktopLocation.Y + ((int)Math.Floor((double)Height / 2) - (int)Math.Floor((double)ve.Height / 2)));
            ve.Show();
            ve.Padre.Enabled = false;
        }
        public void Undo()
        {
            ve.Padre.Enabled = true;
            ve.Padre.Focus();
            ve.Dispose();
            ve = null;
        }
        public void SeleccionarBoton(int index)
        {
            btnFinanzas.Enabled = btnUsuarios.Enabled = btnDeptos.Enabled = btnLogistica.Enabled = true;
            switch (index)
            {
                case 0:
                    btnFinanzas.Enabled = false;
                    break;
                case 1:
                    btnUsuarios.Enabled = false;
                    break;
                case 2:
                    btnDeptos.Enabled = false;
                    break;
                case 3:
                    btnLogistica.Enabled = false;
                    break;
            }
        }
        #endregion
    }
    public enum EstadoTrabajo
    {
        Espera,
        Agregando,
        Modificando,
        Asignando
    }
}
