using System;

namespace TurismoRealEscritorio.Modelos
{
    public class Servicio
    {
        public int Id_servicio { get; set; } //PRIMARY KEY
        public String Nombre { get; set; }
        public int Valor { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public int Cupos { get; set; }
        public char Semana { get; set; }
        public int Id_localidad { get; set; }
        public int Id_centro { get; set; }
    }
}
