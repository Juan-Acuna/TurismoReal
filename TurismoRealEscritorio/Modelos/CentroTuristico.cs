using System;

namespace TurismoRealEscritorio.Modelos
{
    public class CentroTuristico
    {
        public int Id_centro { get; set; } //PRIMARY KEY
        public String Nombre { get; set; }
        public String Logo { get; set; }
        public String Descripcion { get; set; }
    }
}
