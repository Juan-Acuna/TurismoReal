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

        public async Task<T> Get<T>(String url, String token = "none", Label txt = null) where T : class, new()
        {
            HttpRequestMessage m = new HttpRequestMessage(HttpMethod.Get, UrlBase + "/" + typeof(T).Name.Replace("Persona", "").Replace("Proxy", "") + "/" + url);
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
            return default(T);
        }

        public async Task<List<T>> GetList<T>(String token = "none", Label txt = null) where T : class, new()
        {
            HttpRequestMessage m = new HttpRequestMessage(HttpMethod.Get, UrlBase + "/" + typeof(T).Name.Replace("Persona", "").Replace("Proxy", ""));
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

        public async Task<bool> Send<T>(HttpMethod metodo, T body, String url = "", String token = "none", Label txt = null)
        {
            HttpRequestMessage m = new HttpRequestMessage(metodo, UrlBase + "/" + typeof(T).Name.Replace("Persona", "").Replace("Proxy", "").ToLower()+url);
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

        public async Task<bool> Send(String url, HttpMethod metodo, String token = "none", Label txt = null)
        {
            HttpRequestMessage m = new HttpRequestMessage(metodo, UrlBase + "/" + url);
            if (!token.Equals("none"))
            {
                m.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
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
        public async Task<bool> Disponible(TextBox input, Control txt = null)
        {
            if (input.Text.Trim().Length <= 0)
            {
                txt.Text = "";
                input.ForeColor = Color.Black;
                return false;
            }
            HttpResponseMessage r;
            try
            {
                HttpRequestMessage m = new HttpRequestMessage(HttpMethod.Get, UrlBase + "/publico/util/disponible/" + input.Name.Replace("txt","") + "/" + input.Text);
                r = await httpTest.SendAsync(m);
                if (r.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var def = new { Disponible = true };
                    var a = JsonConvert.DeserializeAnonymousType(await r.Content.ReadAsStringAsync(),def);
                    r.Dispose();
                    if (a.Disponible)
                    {
                        txt.Text = "";
                        input.ForeColor = Color.Black;
                        if (input.Name.Equals("txtUsername"))
                        {
                            if (input.Text.Length > 4)
                            {
                                input.ForeColor = Color.Green;
                            }
                            else
                            {
                                input.ForeColor = Color.Red;
                                txt.Text = "El nombre de usuario debe tener al menos 5 caracteres.";
                            }
                        }
                    }
                    else
                    {
                        txt.Text = "El " + input.Name.Replace("txt","").Replace("username","usuario").Replace("email", "correo electrónico") + " ya esta registrado.";
                        input.ForeColor = Color.Red;
                    }
                    return a.Disponible;
                }
            }
            catch (Exception e)
            {
                txt.Text = "Error de servidor.";
                return false;
            }
            txt.Text = "Error de servidor.";
            return false;
        }
        public async Task<bool> RecuperarContraseña(String username, String token)
        {
            return true;
        }
    }
}