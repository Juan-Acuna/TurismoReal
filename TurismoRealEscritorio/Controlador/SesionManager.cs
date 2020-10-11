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
        private static String pila = String.Empty;
        public static Sesion Sesion { get { return sesion; } }
        public static String Usuario { get { return username; } }
        public static String NombrePila { get { return pila; } }
        public static String Token { get { return tkn; } }
        public static void IniciarSesion(Token token)
        {
            sesion = new Sesion(token);
            tkn = sesion.Token.token;
            username = sesion.Token.username;
            pila = sesion.Token.nombres.Split(' ')[0] +" "+ sesion.Token.apellidos.Split(' ')[0];

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
        public String username { get; set; }
        public String nombres { get; set; }
        public String apellidos { get; set; }

        public Token(String token, DateTime expiration,String username, String nombres, String apellidos)
        {
            this.token = token;
            this.expiration = expiration;
            this.username = username;
            this.apellidos = apellidos;
            this.nombres = nombres;
        }
    }
    public class MensajeError
    {
        public String Error { get; set; }
    }
}
