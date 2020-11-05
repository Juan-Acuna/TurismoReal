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
    public partial class frmRecortar : Form
    {
        Bitmap img;
        frmEditor form;
        bool dragging = false;
        int offsetX = 0;
        int offsetY = 0;
        public frmRecortar(frmEditor f = null, Image i = null)
        {
            InitializeComponent();
            img = (Bitmap)i;
            form = f;
            this.Cursor = new Cursor(Cursor.Current.Handle);
            imgMain.Cursor = this.Cursor;
            pBase.Cursor = this.Cursor;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            img.Dispose();
            form.Enabled = true;
            form.Focus();
            Dispose();
        }

        private void frmRecortar_Load(object sender, EventArgs e)
        {
            imgMain.SizeMode = PictureBoxSizeMode.AutoSize;
            imgMain.Parent = pBase;
            if (img != null)
            {
                imgMain.Image = img;
            }
        }
        private void _MouseDown(object sender, MouseEventArgs e)
        {
            //EMPIEZA EL DRAG
            if (!dragging)
            {

                offsetX = Cursor.Position.X - imgMain.Location.X;
                offsetY = Cursor.Position.Y - imgMain.Location.Y;
                dragging = true;
            }

        }
        private void _MouseMove(object sender, MouseEventArgs e)
        {
            //DURANTE DRAG
            int x;
            int y;
            int xf;
            int yf;
            if (dragging)
            {
                x = Cursor.Position.X - offsetX;
                y = Cursor.Position.Y - offsetY;
                xf = imgMain.Location.X;
                yf = imgMain.Location.Y;
                if (x > 0 || x <= -(imgMain.Width - pBase.Width))
                {
                    x = xf;
                }
                if (y > 0 || y <= -(imgMain.Height - pBase.Height))
                {
                    y = yf;
                }
                imgMain.Location = new Point(x, y);
            }
        }
        private void _MouseUp(object sender, MouseEventArgs e)
        {
            //FIN DRAG
            dragging = false;
            offsetX = 0;
            offsetY = 0;
        }

        private void btnRecortar_Click(object sender, EventArgs e)
        {
            form.SetRecorte();
            form.RecibirImagen(Tools.CortarImagen(img, new Rectangle(-imgMain.Location.X, -imgMain.Location.Y, 640, 360)));
            form.Enabled = true;
            form.Focus();
            img.Dispose();
            Dispose();
        }
    }
}
