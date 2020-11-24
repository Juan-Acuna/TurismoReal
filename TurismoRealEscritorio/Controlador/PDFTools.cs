using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
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
        public static void GenerarInformePDF(String ruta, Informe informe)
        {
            using (PdfWriter pw = new PdfWriter(ruta + ("\\informe_periodo_"+informe.mes+"_"+informe.ano.ToString()).ToUpper()+".pdf"))
            {
                using (PdfDocument pd = new PdfDocument(pw))
                {
                    using (Document documento = new Document(pd, PageSize.LETTER))
                    {
                        Table t;
                        Cell c;
                        documento.SetFont(PdfFontFactory.CreateFont(iText.IO.Font.Constants.StandardFonts.TIMES_ROMAN));
                        documento.SetMargins(65, 67, 65, 67);
                        //TITULO
                        documento.Add(PDFTools.GenerarTituloPortada("\nINFORME DE INGRESOS Y EGRESOS"));
                        //SUBTITULO
                        documento.Add(PDFTools.GenerarSubtituloPortada("Turismo Real Ltda."));
                        //PERIODO
                        documento.Add(PDFTools.GenerarSubtituloPortada("Periodo " + informe.mes + " " + informe.ano, 14));
                        //INTRODUCCION
                        documento.Add(new AreaBreak());
                        documento.Add(PDFTools.GenerarTitulo("Introducción"));
                        documento.Add(PDFTools.GenerarParrafo("El presente informe detalla todos los ingresos y egresos que la empresa"
                            + " Turismo Real obtiene a través del negocio de arriendo de departamentos turísticos, considerando"
                            + " costos de mantención, dividendo y contribuciones de los departamentos, mas no se considerarán"
                            + " gastos tales como sueldos de funcionarios, sueldos de administradores, sueldos de transportistas,"
                            + " costeo de combustible, costos de mantención de la plataforma de administración de Turismo Real ni"
                            + " de la plataforma de arriendo de departamentos. En cuanto a ingresos, se considerarán los provenientes"
                            + " de transacciones por motivo de arriendo de departamentos y servicios extra proporcionados."
                            + "\n\nNo entran en calculo todos aquellos ingresos o egresos provenientes de orígenes diferentes a los ya"
                            + " mencionados."));
                        //OTROS
                        documento.Add(PDFTools.GenerarTitulo("\nIngresos"));
                        documento.Add(PDFTools.GenerarSubtitulo("Ingresos por reservas."));
                        //AQUI VA UNA TABLA
                        t = new Table(5);
                        t.UseAllAvailableWidth();
                        t.AddHeaderCell(PDFTools.GenerarCelda("Departamento", true))
                            .AddHeaderCell(PDFTools.GenerarCelda("Costo día", true))
                            .AddHeaderCell(PDFTools.GenerarCelda("Reservas", true))
                            .AddHeaderCell(PDFTools.GenerarCelda("Días totales", true))
                            .AddHeaderCell(PDFTools.GenerarCelda("Ganancias", true));
                        foreach (var i in informe.Ingresos.IngresosReserva)
                        {
                            t.AddCell(PDFTools.GenerarCelda(i.Depto))
                                .AddCell(PDFTools.GenerarCelda(i.CostoDia))
                                .AddCell(PDFTools.GenerarCelda(i.Reservas))
                                .AddCell(PDFTools.GenerarCelda(i.DiasTotales))
                                .AddCell(PDFTools.GenerarCelda(i.Ganancias));
                        }
                        documento.Add(t);
                        documento.Add(PDFTools.GenerarSubtitulo("\nIngresos por Servicios."));
                        //AQUI VA UNA TABLA
                        t = new Table(4);
                        t.UseAllAvailableWidth();
                        t.AddHeaderCell(PDFTools.GenerarCelda("Servicio", true))
                            .AddHeaderCell(PDFTools.GenerarCelda("Costo contratación", true))
                            .AddHeaderCell(PDFTools.GenerarCelda("Contrataciones", true))
                            .AddHeaderCell(PDFTools.GenerarCelda("Ganancias", true));
                        foreach (var i in informe.Ingresos.IngresosServicio)
                        {
                            t.AddCell(PDFTools.GenerarCelda(i.Servicio))
                                .AddCell(PDFTools.GenerarCelda(i.CostoContratacion))
                                .AddCell(PDFTools.GenerarCelda(i.Contrataciones))
                                .AddCell(PDFTools.GenerarCelda(i.Ganancias));
                        }
                        documento.Add(t);
                        documento.Add(new AreaBreak());
                        documento.Add(PDFTools.GenerarTitulo("Egresos"));
                        documento.Add(PDFTools.GenerarSubtitulo("Costos de departamentos."));
                        //AQUI VA UNA TABLA
                        t = new Table(5);
                        t.UseAllAvailableWidth();
                        t.AddHeaderCell(PDFTools.GenerarCelda("Departamento", true))
                            .AddHeaderCell(PDFTools.GenerarCelda("Dividendo", true))
                            .AddHeaderCell(PDFTools.GenerarCelda("Contribuciones", true))
                            .AddHeaderCell(PDFTools.GenerarCelda("Mantenciones", true))
                            .AddHeaderCell(PDFTools.GenerarCelda("Gasto total", true));
                        foreach (var i in informe.Egresos.EgresosDepto)
                        {
                            t.AddCell(PDFTools.GenerarCelda(i.Depto))
                                .AddCell(PDFTools.GenerarCelda(i.Dividendo))
                                .AddCell(PDFTools.GenerarCelda(i.Contribuciones))
                                .AddCell(PDFTools.GenerarCelda(i.Mantenciones))
                                .AddCell(PDFTools.GenerarCelda(i.GastoTotal));
                        }
                        documento.Add(t);
                        documento.Add(PDFTools.GenerarTitulo("\nUtilidades"));
                        documento.Add(PDFTools.GenerarSubtitulo("Utilidades por departamento*."));
                        //AQUI VA UNA TABLA
                        t = new Table(4);
                        t.UseAllAvailableWidth();
                        t.AddHeaderCell(PDFTools.GenerarCelda("Departamento", true))
                            .AddHeaderCell(PDFTools.GenerarCelda("Costo mantención", true))
                            .AddHeaderCell(PDFTools.GenerarCelda("Ganancias por reservas", true))
                            .AddHeaderCell(PDFTools.GenerarCelda("Total utilidades", true));
                        foreach (var i in informe.Utilidades.Utilidades)
                        {
                            t.AddCell(PDFTools.GenerarCelda(i.Depto))
                                .AddCell(PDFTools.GenerarCelda(i.CostoMantencion))
                                .AddCell(PDFTools.GenerarCelda(i.GananciasReservas))
                                .AddCell(PDFTools.GenerarCelda(i.TotalUtilidades));
                        }
                        documento.Add(t);
                        documento.Add(PDFTools.GenerarParrafo("* Utilidades por departamento considerando ganancias provenientes de"
                            + " reservas asociadas a estos durante el periodo."));
                    }
                }
            }
            Process.Start(ruta + ("\\informe_periodo_" + informe.mes + "_" + informe.ano.ToString()).ToUpper() + ".pdf");
        }
    }
}
