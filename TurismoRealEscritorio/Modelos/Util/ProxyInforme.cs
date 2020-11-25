using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TurismoRealEscritorio.Modelos;

namespace TurismoRealEscritorio.Controlador
{
    public class Informe
    {
        public String mes = String.Empty;
        public int numMes;
        public int ano;
        public ProxyIngresos Ingresos { get; set; }
        public ProxyEgresos Egresos { get; set; }
        public ProxyUtilidades Utilidades { get; set; }

        public Informe()
        {
            Ingresos = new ProxyIngresos();
            Egresos = new ProxyEgresos();
            Utilidades = new ProxyUtilidades();
        }
    }
    public class ProxyIngresos
    {
        public List<IngresoReserva> IngresosReserva { get; set; }
        public List<IngresoServicio> IngresosServicio { get; set; }

        public ProxyIngresos()
        {
            IngresosReserva = new List<IngresoReserva>();
            IngresosServicio = new List<IngresoServicio>();
        }
    }
    public class ProxyEgresos
    {
        public List<EgresoDepto> EgresosDepto { get; set; }

        public ProxyEgresos()
        {
            EgresosDepto = new List<EgresoDepto>();
        }
    }
    public class ProxyUtilidades
    {
        public List<Utilidad> Utilidades { get; set; }

        public ProxyUtilidades()
        {
            Utilidades = new List<Utilidad>();
        }
    }
    public class IngresoReserva
    {
        public String Depto { get; set; }
        public int CostoDia { get; set; }
        public int Reservas { get; set; }
        public int DiasTotales { get; set; }
        public long Ganancias { get; set; }
        public IngresoReserva() { }
    }
    public class IngresoServicio
    {
        public String Servicio { get; set; }
        public int CostoContratacion { get; set; }
        public int Contrataciones { get; set; }
        public long Ganancias { get; set; }
        public IngresoServicio() { }

    }
    public class EgresoDepto
    {
        public String Depto { get; set; }
        public int Dividendo { get; set; }
        public int Contribuciones { get; set; }
        public long Mantenciones { get; set; }
        public long GastoTotal { get; set; }
        public EgresoDepto() { }
    }
    public class Utilidad
    {
        public String Depto { get; set; }
        public long CostoMantencion { get; set; }
        public long GananciasReservas { get; set; }
        public long TotalUtilidades { get; set; }
        public Utilidad() { }
    }
}
