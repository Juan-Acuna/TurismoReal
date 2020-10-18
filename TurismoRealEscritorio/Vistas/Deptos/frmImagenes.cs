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
    public partial class frmImagenes : Form
    {
        List<Foto> fotos;
        String IdDepto;
        List<PictureBox> imgs = new List<PictureBox>();
        List<bool> Cargadas = new List<bool>();
        public frmImagenes(String id = null)
        {
            InitializeComponent();
            IdDepto = id;
            imgs.Add(imgMain);
            imgs.Add(img1);
            imgs.Add(img2);
            imgs.Add(img3);
            imgs.Add(img4);
            Cargadas.Add(false);
            Cargadas.Add(false);
            Cargadas.Add(false);
            Cargadas.Add(false);
        }

        private async void CargarFotos()
        {
            do
            {
                fotos = await ClienteHttp.Peticion.GetList<Foto>(url:IdDepto);
            } while (fotos.Count<=0);
            for(int i=0;i<fotos.Count && i <=3;i++)
            {
                imgs[i + 1].Image = img_cargando.Image;
                imgs[i+1].LoadAsync(fotos[i].Ruta);
                Cargadas[i] = true;
            }
        }

        private void frmImagenes_Load(object sender, EventArgs e)
        {
            CargarFotos();
        }

        private void img1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (fotos.Count > 0)
            {
                imgMain.Image = imgs[1].Image;
            }
        }
        private void ImagenesClick(object sender = null, EventArgs e = null)
        {
            if (Cargadas[imgs.IndexOf((PictureBox)sender) - 1])
            {
                imgMain.Image=((PictureBox)sender).Image;
            }
        }
    }
}
