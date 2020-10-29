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

namespace TurismoRealEscritorio
{
    public partial class frmLogin : Form
    {
        public bool expand = false;
        public bool suma = true;
        public bool anim = false;
        public bool Conectado = true;
        public bool Changed = false;
        public frmLogin()
        {
            InitializeComponent();
            pReconectando.BackColor = ColorTranslator.FromHtml("#212529");
            pReconectando.Height = 0;
            timerConexion.Start();
            btnIniciar.BackColor = ColorTranslator.FromHtml("#1d809f");
            btnIniciar.ForeColor = ColorTranslator.FromHtml("#ffffff");
            lbError.Text = "";
            lbError.Parent = pbRandom;
            lbError.BackColor = Color.FromArgb(0,Color.White);
            btnRecuperar.Parent = pbRandom;
            btnRecuperar.BackColor = Color.Transparent;
            lbLogin.Parent = pbRandom;
            lbLogin.BackColor = Color.Transparent;
            lbUsuario.BackColor = Color.White;
            lbClave.BackColor = Color.White;
        }

        public async Task<bool> ComprobarConexion()
        {
            //Se comprueba conexion
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
        private void frmLogin_Load(object sender, EventArgs e)
        {
            btnIniciar.FlatAppearance.BorderSize = 0;
            btnIniciar.FlatAppearance.BorderColor = ColorTranslator.FromHtml("#1d809f");
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (expand)
            {
                if (suma)
                {
                    pReconectando.Height = pReconectando.Height + 3;
                    if(pReconectando.Height >= 42)
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
                        timer1.Stop();
                    }
                }
                pReconectando.Refresh();
            }
        }
        private void btnIniciar_Click(object sender, EventArgs e)
        {
            btnIniciar.Enabled = false;
            lbError.Text = "";
            if (Conectado)
            {
                ClienteHttp.Peticion.Autenticar(txtUsername.Text, txtClave.Text, lbError,btnIniciar,this);
            }
            else
            {
                lbError.Text = "";
            }
            
        }

        private async void timerConexion_Tick(object sender, EventArgs e)
        {
            if (await ComprobarConexion())
            {
                btnIniciar.Enabled = true;
                if (pReconectando.Height>=42)
                {
                    suma = false;
                }
                expand = true;
                anim = false;
            }
            else
            {
                btnIniciar.Enabled = false;
                Reconectar();
            }
        }

        private void btnIniciar_MouseEnter(object sender, EventArgs e)
        {
            btnIniciar.BackColor = ColorTranslator.FromHtml("#155d74");

            btnIniciar.ForeColor = ColorTranslator.FromHtml("#ffffff");
        }

        private void btnIniciar_MouseLeave(object sender, EventArgs e)
        {
            btnIniciar.BackColor = ColorTranslator.FromHtml("#1d809f");
            
            btnIniciar.ForeColor = ColorTranslator.FromHtml("#ffffff");
        }

        private void btnRecuperar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lbError.Text = "";
        }

        private void txtUsername_Click(object sender, EventArgs e)
        {
            lbError.Text = "";
            lbUsuario.Visible = false;
        }

        private void lbError_TextChanged(object sender, EventArgs e)
        {
            lbError.Text = lbError.Text.PadLeft(23);
        }

        private void lbUsuario_Click(object sender, EventArgs e)
        {
            lbUsuario.Visible = false;
            txtUsername.Focus();
        }

        private void lbClave_Click(object sender, EventArgs e)
        {
            lbClave.Visible = false;
            txtClave.Focus();
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {
                lbUsuario.Visible = true;
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            if (!txtUsername.Text.Equals(""))
            {
                lbUsuario.Visible = false;
            }
        }

        private void txtClave_Leave(object sender, EventArgs e)
        {
            if (txtClave.Text.Equals(""))
            {
                lbClave.Visible = true;
            }
        }

        private void txtClave_TextChanged(object sender, EventArgs e)
        {
            if (!txtClave.Text.Equals(""))
            {
                lbClave.Visible = false;
            }
        }

        private void txtClave_Click(object sender, EventArgs e)
        {
            lbClave.Visible = false;
        }
    }
}
