using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoRealEscritorio.Controlador
{
    static class SesionManager
    {
        private static Sesion sesion = Sesion.SesionVacia;
        private static String tkn = String.Empty;
        private static String username = String.Empty;
        public static Sesion Sesion { get { return sesion; } }
        public static String Usuario { get { return username; } }
        public static String Token { get { return tkn; } }
        public static void IniciarSesion(Token token, String usuario)
        {
            sesion = new Sesion(token);
            tkn = sesion.Token.token;
            username = usuario;
        }

        public static void CerrarSesion()
        {
            sesion = Sesion.SesionVacia;
            tkn = String.Empty;
            username = String.Empty;
        }
    }
    class Sesion
    {
        bool aut = false;
        Token tkn;
        public bool Autenticado { get { return aut; } }
        public Token Token { get { return tkn; } }
        public static Sesion SesionVacia { get { return new Sesion(); } }
        private Sesion() { }

        public Sesion(Token token)
        {
            aut = true;
            tkn = token;
        }
    }
    public class Token
    {
        public String token { get; set; }
        public DateTime expiration { get; set; }

        public Token(String token, DateTime expiration)
        {
            this.token = token;
            this.expiration = expiration;
        }
    }
    public class MensajeError
    {
        public String Error { get; set; }
    }
}
