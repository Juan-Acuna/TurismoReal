﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TurismoRealEscritorio.Controlador;

namespace TurismoRealEscritorio.Vista
{
    public partial class frmMain : Form
    {
        public bool expand = false;
        public bool suma = true;
        public bool anim = false;
        public bool Conectado = true;

        public frmMain()
        {
            InitializeComponent();
            pReconectando.BackColor = ColorTranslator.FromHtml("#212529");
            pReconectando.Height = 0;
            timerConexion.Start();
            ConfigurarBotones(panel1);
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
                }
            }
        }

        public void AbrirForm(Form form)
        {
            if (pContainer.Controls != null)
            {
                pContainer.Controls.Clear();
            }
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.pContainer.Controls.Add(form);
            this.pContainer.Tag = form;
            form.Show();
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
                Reconectar();
            }
        }
        #endregion
    }
}
