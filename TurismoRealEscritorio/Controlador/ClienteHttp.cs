using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;

namespace TurismoRealEscritorio.Controlador
{
    class ClienteHttp
    {
        static HttpClient http = new HttpClient();
        static ClienteHttp instancia = new ClienteHttp();
        public static ClienteHttp Peticion { get { return instancia; } }
        //static String UrlBase = "http://localhost:51936/api"; //OFFLINE
        static String UrlBase = "http://turismoreal.xyz/api";   //ONLINE
        private ClienteHttp()
        {
            http.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("Application/json"));
            http.DefaultRequestHeaders.UserAgent.ParseAdd("TurismoRealDesktop");
            http.Timeout = TimeSpan.FromSeconds(25);
        }

        public async Task<T> Get<T>(String url, T body, String token = "none", Label txt = null) where T : class, new()
        {
            HttpRequestMessage m = new HttpRequestMessage(HttpMethod.Get, UrlBase + "/"+typeof(T).Name+"/"+url);
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

        public async Task<List<T>> GetList<T>(String token = "none", Label txt = null) where T: class, new()
        {
            HttpRequestMessage m = new HttpRequestMessage(HttpMethod.Get, UrlBase + "/" + typeof(T).Name);
            if (!token.Equals("none"))
            {
                m.Headers.Authorization = new AuthenticationHeaderValue("Bearer",token);
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

        public async Task<bool> Send<T>(String url, HttpMethod metodo, T body, String token = "none", Label txt = null)
        {
            HttpRequestMessage m = new HttpRequestMessage(HttpMethod.Get, UrlBase + "/" + typeof(T).Name);
            if (!token.Equals("none"))
            {
                m.Headers.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
            var jsonbody = JsonConvert.SerializeObject(body);
            var carga = new ByteArrayContent(Encoding.UTF8.GetBytes(jsonbody));
            m.Content = carga;
            m.Headers.Add("Content-type","Applicacion/json");
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

        public async void Autenticar(String username, String clave, Label txt = null)
        {
            HttpRequestMessage m = new HttpRequestMessage(HttpMethod.Post,UrlBase+"/usuario/autenticar");
            var credenciales = JsonConvert.SerializeObject(new { Username=username, Clave=clave });
            var carga = new StringContent(credenciales,Encoding.UTF8,"Application/json");
            m.Content = carga;
            var r = await http.SendAsync(m);
            switch((int)r.StatusCode){
                case 200:
                    SesionManager.IniciarSesion(JsonConvert.DeserializeObject<Token>(await r.Content.ReadAsStringAsync()));
                    break;
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
                        Console.WriteLine(r.StatusCode);
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
                HttpRequestMessage m = new HttpRequestMessage(HttpMethod.Get, UrlBase + "/usuario/test");
                r = await http.SendAsync(m);
                if (r.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    r.Dispose();
                    return true;
                }
            }
            catch(Exception e)
            {
                return false;
            }
            return false;
        }
    }
}
