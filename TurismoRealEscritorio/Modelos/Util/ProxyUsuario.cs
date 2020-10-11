using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoRealEscritorio.Modelos.Util
{
    class ProxyUsuario
    {
        public String Username { get; set; } //PRIMARY KEY
        public String Clave { get; set; }
        public int Id_rol { get; set; }
        public char Activo { get; set; }
        public String Rut { get; set; }
    }
}
