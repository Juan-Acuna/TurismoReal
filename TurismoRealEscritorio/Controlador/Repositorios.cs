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
        List<Localidad> localidades;
        List<ProxyRegion> regiones;
        List<TipoMantencion> mantenciones;
        public List<Rol> Roles { get { return roles; } }
        public List<EstadoDepto> EstadoDeptos { get { return estadoDeptos; } }
        public List<Genero> Generos { get { return generos; } }
        public List<Localidad> Localidades { get { return localidades; } }
        public List<ProxyRegion> Regiones { get { return regiones; } }
        public List<TipoMantencion> TipoMantenciones { get { return mantenciones; } }
        public Repositorios()
        {
            CargarRepos();
        }

        private async void CargarRepos()
        {
            do
            {
                roles = await ClienteHttp.Peticion.GetList<Rol>(SesionManager.Token);
            } while (roles == null);
            do
            {
                estadoDeptos = await ClienteHttp.Peticion.GetList<EstadoDepto>();
            } while (estadoDeptos==null);
            do
            {
                generos = await ClienteHttp.Peticion.GetList<Genero>();
            } while (generos==null);
            do
            {
                localidades = await ClienteHttp.Peticion.GetList<Localidad>();
            } while (localidades == null);
            do
            {
                regiones = await ClienteHttp.Peticion.Util_ProxyRegion<ProxyRegion>();
            } while (regiones==null);
            do
            {
                mantenciones = await ClienteHttp.Peticion.GetList<TipoMantencion>(SesionManager.Token);
            } while (mantenciones == null);
        }

        public static T Buscar<T>(List<T> lista, String campo, object valor) where T : class
        {
            if (valor == null)
            {
                return null;
            }
            var mem = typeof(T).GetProperties();
            if(lista == null)
            {
                return default(T);
            }
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
            return null;
        }
    }
}
