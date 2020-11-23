using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.Kernel.Colors;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace TurismoRealEscritorio.Controlador
{
    public static class PDFTools
    {
        public static Paragraph GenerarTituloPortada(object texto)
        {
            Paragraph p = new Paragraph(texto.ToString());
            p.SetTextAlignment(TextAlignment.RIGHT);
            p.SetFontSize(72);
            return p;
        }
        public static Paragraph GenerarSubtituloPortada(object texto, float size = 22)
        {
            Paragraph p = new Paragraph(texto.ToString());
            p.SetTextAlignment(TextAlignment.RIGHT);
            p.SetFontSize(size);
            return p;
        }
        public static Paragraph GenerarTitulo(object texto)
        {
            Paragraph p = new Paragraph(texto.ToString());
            p.SetTextAlignment(TextAlignment.LEFT);
            p.SetFontSize(24);
            p.SetBold();
            return p;
        }
        public static Paragraph GenerarSubtitulo(object texto)
        {
            Paragraph p = new Paragraph(texto.ToString());
            p.SetTextAlignment(TextAlignment.LEFT);
            p.SetFontSize(16);
            return p;
        }
        public static Paragraph GenerarParrafo(object texto)
        {
            Paragraph p = new Paragraph(texto.ToString());
            p.SetTextAlignment(TextAlignment.JUSTIFIED);
            p.SetFontSize(12);
            return p;
        }
        public static Cell GenerarCelda(object texto, bool cabecera = false)
        {
            Paragraph p = new Paragraph(texto.ToString());
            Cell c = new Cell();
            p.SetTextAlignment(TextAlignment.LEFT);
            p.SetFontSize(12);
            if (cabecera)
            {
                p.SetBold();
                p.SetFontColor(ColorConstants.WHITE);
                c.AddStyle(new iText.Layout.Style().SetBackgroundColor(ColorConstants.DARK_GRAY));
            }
            c.Add(p);
            return c;
        }
    }
}
