using System;

namespace TurismoRealEscritorio.Modelos
{
    public class Usuario
    {
        public String Username { get; set; } //PRIMARY KEY
        public String Clave { get; set; }
        public int Id_rol { get; set; }
        public char Activo { get; set; }
        public char Frecuente { get; set; }
        public String Rut { get; set; }
    }
}
