using System;

namespace TurismoRealEscritorio.Modelos
{
    public class Foto
    {
        public int Id_foto { get; set; } //PRIMARY KEY
        public String Ruta { get; set; }
        public int Id_depto { get; set; }
    }
}
