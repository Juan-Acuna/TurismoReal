using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoRealEscritorio.Controlador
{
    public static class Tools
    {
        public static double GetPeso(Image img)
        {
            long tamanoImagen = 0;
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Jpeg);
                tamanoImagen = ms.Length;
            }
            //El tamaño está en bytes.
            return tamanoImagen;
        }
        public static Image ResizeImage(Image srcImage, int newWidth)
        {
            int newHeight = 9 * (newWidth / 16);
            using (Bitmap imagenBitmap =
               new Bitmap(newWidth, newHeight, PixelFormat.Format32bppRgb))
            {
                imagenBitmap.SetResolution(
                   Convert.ToInt32(srcImage.HorizontalResolution),
                   Convert.ToInt32(srcImage.HorizontalResolution));

                using (Graphics imagenGraphics =
                        Graphics.FromImage(imagenBitmap))
                {
                    imagenGraphics.SmoothingMode =
                       SmoothingMode.AntiAlias;
                    imagenGraphics.InterpolationMode =
                       InterpolationMode.HighQualityBicubic;
                    imagenGraphics.PixelOffsetMode =
                       PixelOffsetMode.HighQuality;
                    imagenGraphics.DrawImage(srcImage,
                       new Rectangle(0, 0, newWidth, newHeight),
                       new Rectangle(0, 0, srcImage.Width, srcImage.Height),
                       GraphicsUnit.Pixel);
                    MemoryStream imagenMemoryStream = new MemoryStream();
                    imagenBitmap.Save(imagenMemoryStream, ImageFormat.Jpeg);
                    srcImage = Image.FromStream(imagenMemoryStream);
                }
            }
            return srcImage;
        }
        public static Bitmap CortarImagen(Image img, Rectangle area)
        {
            Bitmap bmp = new Bitmap(area.Width, area.Height);
            Graphics g = Graphics.FromImage(bmp);

            g.DrawImage(img, 0, 0, area, GraphicsUnit.Pixel);

            return bmp;
        }
        public static bool ValidarRut(String rut)
        {
            rut = rut.Replace(".", "").Replace("-", "");
            char dvf = rut[rut.Length - 1];
            int dv = 0;
            switch (dvf)
            {
                case 'k':
                    dv = 10;
                    break;
                case '0':
                    dv = 11;
                    break;
                default:
                    dv = Int32.Parse(dvf.ToString());
                    break;
            }
            int[] ns = new int[rut.Length-1];
            int[] val = new int[rut.Length-1];
            for (int i=0;i<rut.Length-1;i++)
            {
                ns[(rut.Length-2) - i] = Int32.Parse(rut[i].ToString());
            }
            for(int i = 0, s = 2; i<ns.Count(); i++,s++)
            {
                val[i] = ns[i] * s;
                if (s >= 7)
                {
                    s = 1;
                }
            }
            int suma = 0;
            foreach(var v in val)
            {
                suma += v;
            }
            int div = (int)Math.Floor((double)suma / 11);
            div = div * 11;
            int res = Math.Abs(suma - div);
            res = 11 - res;
            return res == dv;
        }
        public static String FormatearRut(String rut)
        {
            String final = rut.Replace(".","").Replace("-", "");
            for(int i = 3; i < final.Length; i += 4)
            {
                if(i < final.Length)
                {
                    final = final.Insert(final.Length - i, ".");
                }
            }
            if (final.Length > 2)
            {
                final = final.Insert(final.Length, "-");
            }
            return final.ToUpper();
        }
    }
}
