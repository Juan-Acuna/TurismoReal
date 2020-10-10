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

        public frmMain()
        {
            InitializeComponent();
            pReconectando.BackColor = ColorTranslator.FromHtml("#212529");
            pReconectando.Height = 0;
            timerConexion.Start();
            ConfigurarBotones(panel1);
            AsignarNombre();
        }

        public void ConfigurarBotones(Control cont)
        {
            foreach(var c in cont.Controls)
            {
                if(c is Button)
                {
                    ((Button)c).BackColor = ColorTranslator.FromHtml("#212529");
                    ((Button)c).ForeColor = ColorTranslator.FromHtml("#ffffff");
                    ((Button)c).MouseEnter += new EventHandler(_MouseEnter);
                    ((Button)c).MouseLeave += new EventHandler(_MouseLeave);
                    ((Button)c).FlatStyle = FlatStyle.Flat;
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
        private async void AsignarNombre()
        {
            var pu = await ClienteHttp.Peticion.Get<PersonaUsuario>(SesionManager.Usuario,SesionManager.Token);
            String nom = pu.Persona.Nombres.Split(' ')[0];
            String ape = pu.Persona.Apellidos.Split(' ')[0];
            lbNombre.Text = nom + " " + ape;
        }
        public void _MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = ColorTranslator.FromHtml("#fed136");
            ((Button)sender).ForeColor = ColorTranslator.FromHtml("#212529");
        }

        public void _MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = ColorTranslator.FromHtml("#212529");
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
                BloquearBotones(pContainer.Controls[0]);
                Reconectar();
            }
        }
        #endregion

        #region Botones
        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmUsuarios(this));
        }
        #endregion
    }
    public enum EstadoTrabajo
    {
        Espera,
        Agregando,
        Modificando
    }
}
