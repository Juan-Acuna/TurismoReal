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

namespace TurismoRealEscritorio.Vistas.Deptos
{
    public partial class frmEditor : Form
    {
        Bitmap Antes;
        Bitmap Despues;
        frmImagenes form;
        public Bitmap ImagenFinal;
        public frmEditor(frmImagenes f = null,Image i = null)
        {
            InitializeComponent();
            form = f;
            Antes = (Bitmap)i;
            Despues = (Bitmap)Tools.ResizeImage(Antes,640);
        }

        private void frmEditor_Load(object sender, EventArgs e)
        {
            imgAntes.Image = Antes;
            if (Tools.GetPeso(Antes) > 1024 * 1024)
            {
                txtPesoA.Text = Math.Round((Tools.GetPeso(Antes) / 1024.0) / 1024.0,2).ToString() + " Mb (" + Math.Round(Tools.GetPeso(Antes) / 1024.0,2).ToString() + "Kb)";
            }
            else
            {
                txtPesoA.Text = Math.Round(Tools.GetPeso(Antes) / 1024.0,2).ToString() + " Kb";
            }
            txtPesoA.Text = txtPesoA.Text.PadLeft(20, ' ');
            txtAltoA.Text = (Antes.Height.ToString() + " pixeles").PadLeft(13, ' ');
            txtAnchoA.Text = (Antes.Width.ToString() + " pixeles").PadLeft(13, ' ');
            ImagenFinal = Despues;
            RecargarImagenFinal();
            pFinal.Text = "Imagen Final (Reescalada)";
            form.Enabled = false;
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            Antes.Dispose();
            Despues.Dispose();
            DialogResult = DialogResult.OK;
            form.RecibirImagen(ImagenFinal);
            form.Enabled = true;
            form.Focus();
            Dispose();
        }

        private void btnRecortar_Click(object sender, EventArgs e)
        {
            frmRecortar r = new frmRecortar(this,Antes);
            r.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ImagenFinal.Dispose();
            Antes.Dispose();
            Despues.Dispose();
            DialogResult = DialogResult.Cancel;
            form.Enabled = true;
            form.Focus();
            Dispose();
        }

        private void btnVistaD_Click(object sender, EventArgs e)
        {
            frmVistaPrevia v = new frmVistaPrevia(this,Despues);
            v.Show();
        }
        public void SetRecorte()
        {
            btnRecortar.Enabled = false;
            btnAplicar.Text = "Aplicar Recorte";
            txtP1.Text = "A continuación se muestra una comparacion de la imagen seleccionada con la imagen final con el recorte compatible con";
            txtP2.Text = "la plataforma web.";
        }
        public void RecibirImagen(Image img)
        {
            ImagenFinal = (Bitmap)img;
            Despues = ImagenFinal;
            RecargarImagenFinal();
            pFinal.Text = "Imagen Final (Recortada)";
        }
        private void RecargarImagenFinal()
        {
            imgDespues.Image = Despues;
            if (Tools.GetPeso(Despues) > 1024 * 1024)
            {
                txtPesoD.Text = Math.Round((Tools.GetPeso(Despues) / 1024.0) / 1024.0, 2).ToString() + " Mb (" + Math.Round(Tools.GetPeso(Despues) / 1024.0, 2).ToString() + "Kb)";
            }
            else
            {
                txtPesoD.Text = Math.Round(Tools.GetPeso(Despues) / 1024.0, 2).ToString() + " Kb";
            }
            txtPesoD.Text = txtPesoD.Text.PadLeft(20, ' ');
            txtAltoD.Text = (Despues.Height.ToString() + " pixeles").PadLeft(13, ' ');
            txtAnchoD.Text = (Despues.Width.ToString() + " pixeles").PadLeft(13, ' ');
        }
    }
}
