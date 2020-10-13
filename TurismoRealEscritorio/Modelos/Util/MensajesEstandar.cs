using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurismoRealEscritorio.Modelos.Util
{
    public static class MensajesEstandar
    {
        static String ARecuperarClave = "Contraseña Reiniciada.";
        static String MRecuperarClave = "";
        static String AAsignacion = "Asignación de Viaje.";
        static String MAsignacion = "";
        static String ACheckIn = "Notificación de Check-In.";
        static String MCheckIn = "";
        static String ACheckOut = "Notificación de Check-Out.";
        static String MCheckOut = "";
        static String AViaje = "Notificacion de transporte.";
        static String MViaje = "";
        static String ATransaccion = "Notificacion de {accion}.";
        static String MTransaccion = "";
        static String AServicio = "Recordatorio de servicio.";
        static String MServicio = "";
        static String ABaja = "Su cuenta ha sido desactivada.";
        static String MBaja = "";
        static String AMulta = "Usted ha sido multado.";
        static String MMulta = "";

        public static MensajeCorreo RecuperarClave = new MensajeCorreo(ARecuperarClave, MRecuperarClave);
        public static MensajeCorreo AsignacionChofer = new MensajeCorreo(AAsignacion, MAsignacion);
        public static MensajeCorreo NotificacionCheckIn = new MensajeCorreo(ACheckIn, MCheckIn);
        public static MensajeCorreo NotificacionCheckOut = new MensajeCorreo(ACheckOut, MCheckOut);
        public static MensajeCorreo NotificacionViaje = new MensajeCorreo(AViaje, MViaje);
        public static MensajeCorreo NotificarTransaccion = new MensajeCorreo(ATransaccion, MTransaccion);
        public static MensajeCorreo NotificarServicio = new MensajeCorreo(AServicio, MServicio);
        public static MensajeCorreo NotificarBaja = new MensajeCorreo(ABaja,MBaja);
        public static MensajeCorreo NotificarMulta = new MensajeCorreo(AMulta,MMulta);
    }
}
