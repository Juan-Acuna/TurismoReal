using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoRealEscritorio.Modelos.Util
{
    public class ProxyArticulo
    {
        public Articulo Articulo { get; set; }
        public int Depto { get; set; }
        public bool Asignado { get; set; }
    }
}
