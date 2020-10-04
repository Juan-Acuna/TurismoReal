using System;

namespace TurismoRealEscritorio.Modelos
{
    public class Articulo
    {
        public int Id_articulo { get; set; } //PRIMARY KEY
        public String Nombre { get; set; }
        public int Valor { get; set; }
    }
}
