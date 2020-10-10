using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurismoRealEscritorio.Modelos;
using TurismoRealEscritorio.Modelos.Util;

namespace TurismoRealEscritorio.Controlador
{

    public class Repositorios
    {
        List<Rol> roles;
        List<EstadoDepto> estadoDeptos;
        List<Genero> generos;
        List<ProxyRegion> regiones;
        public List<Rol> Roles { get { return roles; } }
        public List<EstadoDepto> EstadoDeptos { get { return estadoDeptos; } }
        public List<Genero> Generos { get { return generos; } }
        public List<ProxyRegion> Regiones { get { return regiones; } }
        public Repositorios()
        {
            CargarRepos();
        }

        private async void CargarRepos()
        {
            roles = await ClienteHttp.Peticion.GetList<Rol>(SesionManager.Token);
            estadoDeptos = await ClienteHttp.Peticion.GetList<EstadoDepto>();
            generos = await ClienteHttp.Peticion.GetList<Genero>();
            regiones = await ClienteHttp.Peticion.Util_ProxyRegion<ProxyRegion>();
        }

        public T Buscar<T>(List<T> lista, String campo, object valor)
        {
            var mem = typeof(T).GetProperties();
            foreach(var item in lista)
            {
                foreach(var m in mem)
                {
                    if (m.Name.Equals(campo))
                    {
                        if (valor.Equals(m.GetValue(item)))
                        {
                            return item;
                        }
                    }
                }
            }
            return default(T);
        }
    }
}
