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
        int Actual = 0;
        String Estado = "Agregar";
        frmDeptos Deptosfrm;
        
        public frmImagenes(frmDeptos frm, String id = null)
        {
            InitializeComponent();
            Deptosfrm = frm;
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
            ImagenesClick(sender:imgs[1]);
        }

        private void frmImagenes_Load(object sender, EventArgs e)
        {
            btnCambiar.Parent = btnBorrar.Parent = imgMain;
            btnCambiar.BackColor = btnBorrar.BackColor = Color.Transparent;
            CargarFotos();
            btnCambiar.Location = new Point(183,284);
            btnBorrar.Location = new Point(258, 284);
        }

        private void ImagenesClick(object sender = null, EventArgs e = null)
        {
            imgMain.Image = ((PictureBox)sender).Image;
            Actual = imgs.IndexOf((PictureBox)sender) - 1;
            if (Cargadas[imgs.IndexOf((PictureBox)sender) - 1])
            {
                Estado = "Cambiar";
            }
            else
            {
                Estado = "Agregar";
            }
        }
        private void ImagenesLoad(object sender, AsyncCompletedEventArgs e)
        {
            if((imgs.IndexOf((PictureBox)sender) - 1) == Actual)
            {
                imgMain.Image = ((PictureBox)sender).Image;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Deptosfrm.Focus();
            this.Dispose();
        }
    }
}
