using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurismoRealEscritorio.Modelos;

namespace TurismoRealEscritorio.Controlador
{
    public class Repositorios
    {
        public List<Rol> Roles { get; set; }
        public List<EstadoDepto> EstadoDeptos { get; set; }
        public Repositorios()
        {
            CargarRepos();
        }

        private async void CargarRepos()
        {
            Roles = await ClienteHttp.Peticion.GetList<Rol>(SesionManager.Token);
            EstadoDeptos = await ClienteHttp.Peticion.GetList<EstadoDepto>();
        }
    }
}
