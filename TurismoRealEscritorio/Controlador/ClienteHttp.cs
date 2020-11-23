using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Net.Mail;
using System.Net;
using TurismoRealEscritorio.Modelos.Util;
using System.Drawing;
using System.IO;

namespace TurismoRealEscritorio.Controlador
{
    class ClienteHttp
    {
        static HttpClient http = new HttpClient();
        static HttpClient httpTest = new HttpClient();
        static ClienteHttp instancia = new ClienteHttp();
        public static ClienteHttp Peticion { get { return instancia; } }
        //static String UrlBase = "http://localhost:51936/api";  //OFFLINE
        static String UrlBase = "http://turismoreal.xyz/api";  //ONLINE
        private ClienteHttp()
        {
            http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));
            http.DefaultRequestHeaders.UserAgent.ParseAdd("TurismoRealDesktop");
            http.Timeout = TimeSpan.FromSeconds(25);
            httpTest.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));
            httpTest.DefaultRequestHeaders.UserAgent.ParseAdd("TurismoRealDesktop");
            httpTest.Timeout = TimeSpan.FromSeconds(16);
        }

        public async Task<T> Get<T>(String url, String token = "none", Label txt = null, bool urlEspecial = false) where T : class, new()
        {
            HttpRequestMessage m = new HttpRequestMessage(HttpMethod.Get, UrlBase + (urlEspecial?"":"/" + typeof(T).Name.Replace("Persona", "").Replace("Proxy", "")) + "/" + url);
            if (!token.Equals("none"))
            {
                m.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            var r = await http.SendAsync(m);
            switch ((int)r.StatusCode)
            {
                case 200:
                    var a = JsonConvert.DeserializeObject<T>(await r.Content.ReadAsStringAsync());
                    r.Dispose();
                    return a;
                case 401:
                    if (txt != null)
                    {
                        txt.Text = "Acceso Denegado.";
                    }
                    break;
                case 500:
                    if (txt != null)
                    {
                        txt.Text = "Error de servidor.";
                    }
                    break;
                default:
                    if (txt != null)
                    {
                        txt.Text = JsonConvert.DeserializeObject<MensajeError>(await r.Content.ReadAsStringAsync()).Error;
                    }
                    break;
            }
            r.Dispose();
            return null;
        }

        public async Task<List<T>> GetList<T>(String token = "none", Label txt = null, String url = "") where T : class, new()
        {
            var s = "";
            if (!url.Equals(""))
            {
                s = "/" + url;
            }
            HttpRequestMessage m = new HttpRequestMessage(HttpMethod.Get, UrlBase + "/" + typeof(T).Name.Replace("Persona", "").Replace("Proxy", "") + s);
            if (!token.Equals("none"))
            {
                m.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            var r = await http.SendAsync(m);
            switch ((int)r.StatusCode)
            {
                case 200:
                    var a = JsonConvert.DeserializeObject<List<T>>(await r.Content.ReadAsStringAsync());
                    r.Dispose();
                    return a;
                case 401:
                    if (txt != null)
                    {
                        txt.Text = "Acceso Denegado.";
                    }
                    break;
                case 500:
                    if (txt != null)
                    {
                        txt.Text = "Error de servidor.";
                    }
                    break;
                default:
                    if (txt != null)
                    {
                        txt.Text = JsonConvert.DeserializeObject<MensajeError>(await r.Content.ReadAsStringAsync()).Error;
                    }
                    break;
            }
            r.Dispose();
            return new List<T>();
        }

        public async Task<bool> Send<T>(HttpMethod metodo, T body, String url = "", String token = "none", Control txt = null)
        {
            var s = "";
            if (!url.Equals(""))
            {
                s = "/" + url;
            }
            HttpRequestMessage m = new HttpRequestMessage(metodo, UrlBase + "/" + typeof(T).Name.Replace("Persona", "").Replace("Proxy", "").ToLower()+s);
            if (!token.Equals("none"))
            {
                m.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            var jsonbody = JsonConvert.SerializeObject(body);
            var carga = new StringContent(jsonbody, Encoding.UTF8, "Application/json");
            m.Content = carga;
            var r = await http.SendAsync(m);
            switch ((int)r.StatusCode)
            {
                case 200:
                    r.Dispose();
                    return true;
                case 401:
                    if (txt != null)
                    {
                        txt.Text = "Acceso Denegado.";
                    }
                    break;
                /*case 500:
                    if (txt != null)
                    {
                        txt.Text = "Error de servidor.";
                    }
                    break;*/
                default:
                    if (txt != null)
                    {
                        var a = await r.Content.ReadAsStringAsync();
                        txt.Text = JsonConvert.DeserializeObject<MensajeError>(a).Error;
                    }
                    break;
            }
            r.Dispose();
            return false;
        }

        public async Task<bool> Delete<T>(String url, String token, Label txt = null)
        {
            HttpRequestMessage m = new HttpRequestMessage(HttpMethod.Delete, UrlBase + "/" + typeof(T).Name.Replace("Persona", "").Replace("Proxy", "").ToLower() + "/" + url);
            m.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var r = await http.SendAsync(m);
            switch ((int)r.StatusCode)
            {
                case 200:
                    r.Dispose();
                    return true;
                case 401:
                    if (txt != null)
                    {
                        txt.Text = "Acceso Denegado.";
                    }
                    break;
                case 500:
                    if (txt != null)
                    {
                        txt.Text = "Error de servidor.";
                    }
                    break;
                default:
                    if (txt != null)
                    {
                        txt.Text = JsonConvert.DeserializeObject<MensajeError>(await r.Content.ReadAsStringAsync()).Error;
                    }
                    break;
            }
            r.Dispose();
            return false;
        }

        public async Task<bool> SubirFoto(String url, String rutaArchivo, String token, Control txt = null)
        {
            FileStream archivo = new FileStream(rutaArchivo, FileMode.Open);
            HttpResponseMessage r;
            HttpRequestMessage m = new HttpRequestMessage(HttpMethod.Post, UrlBase + "/" + "foto/" + url);
            m.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var archivoCarga = new StreamContent(archivo);
            var form = new MultipartFormDataContent();
            form.Add(archivoCarga,"imagenes",rutaArchivo);
            m.Content = form;
            try
            {
                r = await http.SendAsync(m);
                switch ((int)r.StatusCode)
                {
                    case 200:
                        archivo.Dispose();
                        r.Dispose();
                        return true;
                    case 401:
                        if (txt != null)
                        {
                            txt.Text = "Acceso Denegado.";
                        }
                        break;
                    default:
                        if (txt != null)
                        {
                            var a = await r.Content.ReadAsStringAsync();
                            txt.Text = JsonConvert.DeserializeObject<MensajeError>(a).Error;
                        }
                        break;
                }
                r.Dispose();
                archivo.Dispose();
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<bool> ActualizarFoto(String url, String rutaArchivo, String token, Control txt = null)
        {
            FileStream archivo = new FileStream(rutaArchivo, FileMode.Open);
            HttpResponseMessage r;
            HttpRequestMessage m = new HttpRequestMessage(new HttpMethod("PATCH"), UrlBase + "/" + "foto/" + url);
            m.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var archivoCarga = new StreamContent(archivo);
            var form = new MultipartFormDataContent();
            form.Add(archivoCarga, "imagen", rutaArchivo);
            m.Content = form;
            try
            {
                r = await http.SendAsync(m);
                switch ((int)r.StatusCode)
                {
                    case 200:
                        archivo.Dispose();
                        r.Dispose();
                        return true;
                    case 401:
                        if (txt != null)
                        {
                            txt.Text = "Acceso Denegado.";
                        }
                        break;
                    default:
                        if (txt != null)
                        {
                            var a = await r.Content.ReadAsStringAsync();
                            txt.Text = JsonConvert.DeserializeObject<MensajeError>(a).Error;
                        }
                        break;
                }
                r.Dispose();
                archivo.Dispose();
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async Task<bool> BorrarFoto(String url, String token, Control txt = null)
        {
            HttpResponseMessage r;
            HttpRequestMessage m = new HttpRequestMessage(HttpMethod.Delete, UrlBase + "/" + "foto/" + url);
            m.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            try
            {
                r = await http.SendAsync(m);
                switch ((int)r.StatusCode)
                {
                    case 200:
                        r.Dispose();
                        return true;
                    case 401:
                        if (txt != null)
                        {
                            txt.Text = "Acceso Denegado.";
                        }
                        break;
                    default:
                        if (txt != null)
                        {
                            var a = await r.Content.ReadAsStringAsync();
                            txt.Text = JsonConvert.DeserializeObject<MensajeError>(a).Error;
                        }
                        break;
                }
                r.Dispose();
                return false;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public async void Autenticar(String username, String clave, Label txt = null, Button btn = null, Form form = null)
        {
            HttpResponseMessage r;
            HttpRequestMessage m = new HttpRequestMessage(HttpMethod.Post, UrlBase + "/usuario/autenticar");
            var credenciales = JsonConvert.SerializeObject(new { Username = username, Clave = clave });
            var carga = new StringContent(credenciales, Encoding.UTF8, "Application/json");
            m.Content = carga;
            try
            {
                r = await http.SendAsync(m);
            }
            catch (TaskCanceledException e)
            {
                txt.Text = "Error en la conexion.";
                ((frmLogin)form).Conectado = false;
                return;
            }
            switch ((int)r.StatusCode)
            {
                case 200:
                    SesionManager.IniciarSesion(JsonConvert.DeserializeObject<Token>(await r.Content.ReadAsStringAsync()));
                    form.Dispose();
                    break;
                case 401:
                    if (txt != null)
                    {
                        txt.Text = "Acceso Denegado.";
                        btn.Enabled = true;
                    }
                    break;
                case 500:
                    if (txt != null)
                    {
                        txt.Text = "Error de servidor.";
                        btn.Enabled = true;
                    }
                    break;
                default:
                    if (txt != null)
                    {
                        btn.Enabled = true;
                        var a = await r.Content.ReadAsStringAsync();
                        txt.Text = JsonConvert.DeserializeObject<MensajeError>(a).Error;
                    }
                    break;
            }
            r.Dispose();
        }
        public async Task<List<T>> Util_ProxyRegion<T>(Control txt = null) where T : class, new()
        {
            HttpRequestMessage m = new HttpRequestMessage(HttpMethod.Get, UrlBase + "/publico/util/regiones.json");
            var r = await http.SendAsync(m);
            switch ((int)r.StatusCode)
            {
                case 200:
                    var a = JsonConvert.DeserializeObject<List<T>>(await r.Content.ReadAsStringAsync());
                    r.Dispose();
                    return a;
                case 401:
                    if (txt != null)
                    {
                        txt.Text = "Acceso Denegado.";
                    }
                    break;
                case 500:
                    if (txt != null)
                    {
                        txt.Text = "Error de servidor.";
                    }
                    break;
                default:
                    if (txt != null)
                    {
                        txt.Text = JsonConvert.DeserializeObject<MensajeError>(await r.Content.ReadAsStringAsync()).Error;
                    }
                    break;
            }
            r.Dispose();
            return new List<T>();
        }
        public async Task<bool> Disponible(String input, String url)
        {
            if (input.Trim().Length <= 0)
            {
                return true;
            }
            HttpResponseMessage r;
            try
            {
                HttpRequestMessage m = new HttpRequestMessage(HttpMethod.Get, UrlBase + "/publico/util/disponible/" + url + "/" + input);
                r = await httpTest.SendAsync(m);
                if (r.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var def = new { Disponible = true };
                    var a = JsonConvert.DeserializeAnonymousType(await r.Content.ReadAsStringAsync(),def);
                    r.Dispose();
                    Console.WriteLine(a.Disponible);
                    return a.Disponible;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return false;
        }
        public async Task<bool> RecuperarContraseña(String username, String token)
        {
            return true;
        }
        public async Task<bool> Test()
        {
            HttpResponseMessage r;
            try
            {
                HttpRequestMessage m = new HttpRequestMessage(HttpMethod.Get, UrlBase + "/publico/util/test");
                r = await httpTest.SendAsync(m);
                if (r.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    r.Dispose();
                    return true;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            return false;
        }
    }
}