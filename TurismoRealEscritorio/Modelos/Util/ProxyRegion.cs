using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoRealEscritorio.Modelos.Util
{
    public class ProxyRegion
    {
        public String Region { get; set; }
        public String Numero { get; set; }
        public List<Comuna> Comunas { get; set; }
    }
}
