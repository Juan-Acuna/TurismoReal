using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoRealEscritorio.Modelos.Util
{
    public class MensajeCorreo
    {
        string asunto = String.Empty;
        string contenido = String.Empty;
        public String Para { get; set; }
        public String Asunto { get { return asunto; } }
        public String Contenido { get { return contenido; } }
        public MensajeCorreo( String asunto, String mensaje)
        {
            this.asunto = asunto;
            this.contenido = mensaje;
        }
    }
}
