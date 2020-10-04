using System;

namespace TurismoRealEscritorio.Modelos
{
    public class Persona
    {
        public String Rut { get; set; } //PRIMARY KEY
        public String Nombres { get; set; }
        public String Apellidos { get; set; }
        public DateTime Nacimiento { get; set; }
        public String Email { get; set; }
        public Int64 Telefono { get; set; }
        public String Direccion { get; set; }
        public String Comuna { get; set; }
        public String Region { get; set; }
        public int Id_genero { get; set; }
    }
}
