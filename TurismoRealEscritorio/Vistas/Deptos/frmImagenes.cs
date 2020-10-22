using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
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
            btnCambiar.Location = new Point(183, 284);
            btnBorrar.Location = new Point(258, 284);
            btnCambiar.Load("../../img/btn_agregar_trans.png");
            btnBorrar.Load("../../img/btn_borrar_trans_rojo.png");
            img1.Load("../../img/imgbtn_agregar_img.png");
            img2.Load("../../img/imgbtn_agregar_img.png");
            img3.Load("../../img/imgbtn_agregar_img.png");
            img4.Load("../../img/imgbtn_agregar_img.png");
            imgMain.Load("../../img/imgbtn_agregar_img.png");
            img1.SizeMode = PictureBoxSizeMode.Zoom;
            img2.SizeMode = PictureBoxSizeMode.Zoom;
            img3.SizeMode = PictureBoxSizeMode.Zoom;
            img4.SizeMode = PictureBoxSizeMode.Zoom;
            img1.ErrorImage = Image.FromFile("../../img/btn_error_img.png");
            img2.ErrorImage = Image.FromFile("../../img/btn_error_img.png");
            img3.ErrorImage = Image.FromFile("../../img/btn_error_img.png");
            img4.ErrorImage = Image.FromFile("../../img/btn_error_img.png");
        }

        private async void CargarFotos()
        {
            do
            {
                fotos = await ClienteHttp.Peticion.GetList<Foto>(url:IdDepto);
            } while (fotos.Count<=0);
            for(int i=0;i<fotos.Count && i <=3;i++)
            {
                imgs[i + 1].Load("../../img/imgbtn_cargando_img.gif");
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
        }

        private void ImagenesClick(object sender = null, EventArgs e = null)
        {
            imgMain.Image = ((PictureBox)sender).Image;
            Actual = imgs.IndexOf((PictureBox)sender);
            if (Cargadas[imgs.IndexOf((PictureBox)sender) - 1])
            {
                Estado = "Cambiar";
                btnBorrar.Enabled = true;
            }
            else
            {
                Estado = "Agregar";
                btnBorrar.Enabled = false;
            }
            if (Estado.Equals("Cambiar"))
            {
                btnCambiar.Load("../../img/btn_cambiar_trans.png");
            }
            else
            {
                btnCambiar.Load("../../img/btn_agregar_trans.png");
            }
        }
        private void ImagenesLoad(object sender, AsyncCompletedEventArgs e = null)
        {
            if(imgs.IndexOf((PictureBox)sender) == Actual)
            {
                imgMain.Image = ((PictureBox)sender).Image;
            }
            img1.SizeMode = PictureBoxSizeMode.Zoom;
            img2.SizeMode = PictureBoxSizeMode.Zoom;
            img3.SizeMode = PictureBoxSizeMode.Zoom;
            img4.SizeMode = PictureBoxSizeMode.Zoom;
            imgMain.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            ClienteHttp.Peticion.BorrarFoto(GetId(fotos[Actual - 1]), SesionManager.Token);
            Thread.Sleep(50);
            CargarFotos();
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            String archivo = "";
            if (ofdEntrada.ShowDialog() == DialogResult.OK)
            {
                archivo = ofdEntrada.FileName;
            }
            else
            {
                return;
            }
            if (Estado.Equals("Cambiar"))
            {
                ClienteHttp.Peticion.ActualizarFoto(GetId(fotos[Actual - 1]), archivo, SesionManager.Token);
            }
            else
            {
                ClienteHttp.Peticion.SubirFoto(IdDepto, archivo, SesionManager.Token);
            }
            Thread.Sleep(50);
            CargarFotos();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Deptosfrm.Focus();
            this.Dispose();
        }

        private void btnCambiar_MouseEnter(object sender, EventArgs e)
        {
            if (Estado.Equals("Cambiar"))
            {
                btnCambiar.Load("../../img/btn_cambiar_img.png");
            }
            else
            {
                btnCambiar.Load("../../img/btn_agregar_img.png");
            }
        }

        private void btnCambiar_MouseLeave(object sender, EventArgs e)
        {
            if (Estado.Equals("Cambiar"))
            {
                btnCambiar.Load("../../img/btn_cambiar_trans.png");
            }
            else
            {
                btnCambiar.Load("../../img/btn_agregar_trans.png");
            }
            
        }

        private void btnBorrar_MouseEnter(object sender, EventArgs e)
        {
            btnBorrar.Load("../../img/btn_borrar_img_rojo.png");
        }

        private void btnBorrar_MouseLeave(object sender, EventArgs e)
        {
            btnBorrar.Load("../../img/btn_borrar_trans_rojo.png");
        }

        private String GetId(Foto f)
        {
            String s = f.Ruta.Split('/').Last().Split('_').Last().Split('.')[0];
            return s;
        }
    }
}
