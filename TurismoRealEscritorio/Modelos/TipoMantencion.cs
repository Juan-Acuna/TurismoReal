using System;

namespace TurismoRealEscritorio.Modelos
{
    public class TipoMantencion
    {
        public int Id_tipo { get; set; } //PRIMARY KEY
        public String Nombre { get; set; }
        public int Valor { get; set; }
    }
}
