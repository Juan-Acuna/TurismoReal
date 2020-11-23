using iText.IO.Font;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using TurismoRealEscritorio.Controlador;
using TurismoRealEscritorio.Modelos.Util;
using TurismoRealEscritorio.Modelos.Util.Strategy;
using TurismoRealEscritorio.Vista;

namespace TurismoRealEscritorio.Vistas.Finanzas
{
    public partial class frmFinanzas : Form
    {
        frmMain Main;
        Informe informe;
        ProxyMetricas Metricas;
        Panel pTip;
        bool tipActivo = false;
        public frmFinanzas(frmMain f = null)
        {
            InitializeComponent();
            if (f != null)
            {
                Main = f;
            }
        }/* CONTROL */
        private void frmFinanzas_Load(object sender, EventArgs e)
        {
            CargarInforme();
            CargarMetricas();
        }
        private void CambiarTab(object sender, EventArgs e)
        {
            switch (contMaestro.SelectedIndex)
            {
                case 0:

                    break;
                case 1:

                    break;
            }
        }
        /* DATA */
        private async void CargarMetricas()
        {
            Main.Do();
            Metricas = await ClienteHttp.Peticion.Get<ProxyMetricas>("interno/gestion/metricas", SesionManager.Token, urlEspecial: true);
            var us = 0;
            var con = 0;
            foreach (var i in Metricas.Usuarios)
            {
                us += i;
            }
            foreach(var i in Metricas.Conectados)
            {
                con += i;
            }
            var a= (con.ToString() + "/" + us.ToString()).PadLeft(5);
            var b = a.PadLeft(5);
            txtNConectados.Text = b;
            txtNTransacciones.Text = Metricas.Transacciones.ToString().PadLeft(3,' ');
            txtMNT.Text = "(Mes de " + DateTime.Now.ToString("MMMM", CultureInfo.CreateSpecificCulture("es")) + ")";
            txtNReservas.Text = Metricas.Reservas.ToString().PadLeft(3,' ');
            txtMNR.Text = "(Periodo " + DateTime.Now.ToString("MMMM", CultureInfo.CreateSpecificCulture("es")) + " - " + DateTime.Now.AddMonths(3).ToString("MMMM", CultureInfo.CreateSpecificCulture("es")) + ")";
            txtNMantenciones.Text = Metricas.Mantenciones.ToString().PadLeft(3,' ');
            txtMNM.Text = txtMNR.Text;
            txtE1.Text = Metricas.Departamentos[0].ToString();
            txtE2.Text = Metricas.Departamentos[1].ToString();
            txtE3.Text = Metricas.Departamentos[2].ToString();
            txtE4.Text = Metricas.Departamentos[3].ToString();
            txtE5.Text = Metricas.Departamentos[4].ToString();
            Main.Undo();
        }
        private async void CargarInforme()
        {
            int mes = DateTime.Now.Month - 1;
            int ano = DateTime.Now.Year;
            if (mes <= 0)
            {
                mes = 12;
                ano--;
            }
            informe = await ClienteHttp.Peticion.Get<Informe>("interno/gestion/informe/" + mes + "$" + ano, SesionManager.Token, urlEspecial: true);
            foreach (var i in informe.Ingresos.IngresosReserva)
            {
                tablaReservas.Rows.Add(i.Depto, i.CostoDia, i.Reservas, i.DiasTotales, i.Ganancias);
            }
            foreach(var i in informe.Ingresos.IngresosServicio)
            {
                TablaServicios.Rows.Add(i.Servicio,i.CostoContratacion,i.Contrataciones,i.Ganancias);
            }
        }
        private void DesactivarTipCon(object sender, EventArgs e)
        {
        }
        /* TIPS */
        private void lbHC_Click(object sender, EventArgs e)
        {
            CreadorTip c = CreadorTip.TipConexiones();
            int x = pConexiones.Location.X + lbHC.Location.X + (int)Math.Floor((double)lbHC.Width / 2);
            int y = pConexiones.Location.Y + lbHC.Location.Y + (int)Math.Floor((double)lbHC.Height / 2);
            pTip = c.CrearTip(x, y, Metricas.Usuarios, Metricas.Conectados);
            pVistaGeneral.Controls.Add(pTip);
            pTip.BringToFront();
        }
        private void DesactivarTips(object sender, EventArgs e)
        {
            pVistaGeneral.Controls.Remove(pTip);
        }
        private void ActivarTipDepto(object sender, EventArgs e)
        {
            Label l = ((Label)sender);
            Control papa = l.Parent;
            CreadorTip c = CreadorTip.TipDeptos();
            int x = pDeptos.Location.X + papa.Location.X + l.Location.X + (int)Math.Floor((double)l.Width / 2);
            int y = pDeptos.Location.Y + papa.Location.Y + l.Location.Y + (int)Math.Floor((double)l.Height / 2);
            EDepto ed = EDepto.No_Disponible;
            short idx = 0;
            switch (l.Name)
            {
                case "lbHD1":
                    ed = EDepto.No_Disponible;
                    break;
                case "lbHD2":
                    idx = 1;
                    ed = EDepto.Disponible;
                    break;
                case "lbHD3":
                    idx = 2;
                    ed = EDepto.Reservado;
                    break;
                case "lbHD4":
                    idx = 3;
                    ed = EDepto.En_Mantencion;
                    break;
                case "lbHD5":
                    idx = 4;
                    ed = EDepto.Inhabitable;
                    break;
            }
            pTip = c.CrearTip(x, y, ed, Metricas.Departamentos[idx]);
            tabPage1.Controls.Add(pTip);
            pTip.BringToFront();
        }
        /* INFORME */
        private void btnPDF_Click(object sender, EventArgs e)
        {
            GenerarInforme(@"C:\Users\Juancho\Desktop\TEST_PDF", informe);
        }

        private void GenerarInforme(String ruta, Informe informe)
        {
            using(PdfWriter pw = new PdfWriter(ruta+"\\informe.pdf"))
            {
                using(PdfDocument pd = new PdfDocument(pw))
                {
                    using(Document documento = new Document(pd,PageSize.LETTER))
                    {
                        Table t;
                        Cell c;
                        documento.SetFont(PdfFontFactory.CreateFont(iText.IO.Font.Constants.StandardFonts.TIMES_ROMAN));
                        documento.SetMargins(65,67,65,67);
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
                        foreach(var i in informe.Ingresos.IngresosReserva)
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
                            +" reservas asociadas a estos durante el periodo."));
                    }
                }
            }
            Process.Start(ruta + "\\informe.pdf");
        }
    }
}
