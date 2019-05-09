using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Launcher
{
    class Funções
    {
        private static readonly HttpClient client = new HttpClient();

        public static async Task<string> MudarSenha(string senhaatual, string novasenha, string renovasenha)
        {
            await logar();
            var values = new Dictionary<string, string>
                {
                     { "Old_Password", senhaatual},
                     { "Password", novasenha},
                     { "Re_Password", renovasenha}
                };

            var content = new FormUrlEncodedContent(values);
            try
            {
                var response = await client.PostAsync(Globals.webrequest + "?pag=paneluser&str=ACCOUNT&cmd=password", content);
                var responseString = await response.Content.ReadAsStringAsync();
                string test = LimpaString(responseString);
                return test;
               
            }
            catch
            {
                return "Erro de solicitação";
            }
        }

        public static async Task<string> CompraVip(string tipo){
            try
            {
                await Funções.logar();
                var values = new Dictionary<string, string>
                {
                     { "SetValue", "0"},
                     { "Type", tipo},
                     { "Value", "0"}
                };

            var content = new FormUrlEncodedContent(values);
            
                var response = await client.PostAsync(Globals.webrequest + "?pag=paneluser&str=BUY_VIP&cmd=true", content);

                var responseString = await response.Content.ReadAsStringAsync();
                
                string test = Funções.LimpaString(responseString);

                return test;
            }
            catch
            {
                return "Erro de solicitação";
            }
        }

        public static string Online(string server, int port)
        {
            string hostname = server;
            int portno = port;
            IPAddress ipa = (IPAddress)Dns.GetHostAddresses(hostname)[0];
            try
            {
                System.Net.Sockets.Socket sock = new System.Net.Sockets.Socket(System.Net.Sockets.AddressFamily.InterNetwork, System.Net.Sockets.SocketType.Stream, System.Net.Sockets.ProtocolType.Tcp);
                sock.Connect(ipa, portno);
                if (sock.Connected == true) {
                    sock.Close();
                    return "Online";
                }  // Port is in use and connection is successful
                sock.Close();


            }
            catch (System.Net.Sockets.SocketException ex)
            {
                if (ex.ErrorCode == 10061)  // Port is unused and could not establish connection 
                    return "Offline";
                else
                    return "Offline";
            }
            return "Erro";
        }
    

    public static string LimpaString(string txt)
        {

            var resposta = txt.Replace("<div class=", "")
               .Replace("div", "")
               .Replace("</li>", "")
               .Replace("<li>", "")
               .Replace("<span>", "")
               .Replace("</span>", "")
               .Replace("error-box", "")
               .Replace("<br/>", "\n")
               .Replace("<br />", "\n")
               .Replace("</br>", "\n")
               .Replace("<br>", "\n")
               .Replace("<b>", "")
               .Replace("<b/>", "")
               .Replace("</b>", "")
               .Replace(">", "")
               .Replace("&atilde;", "ã")
               .Replace("&aacute;", "á")
               .Replace("&raquo;", "»")
               .Replace("&ecirc;", "ê")
               .Replace("&uacute;", "ú")
               .Replace("&eacute", "é")
               .Replace("&ccedil;", "ç")
               .Replace("\"", "")
               .Replace("<", "")
               .Replace("        ", "")
               .Replace("\t", "")
               .Replace("ul", "")
               .Replace("class", "")
               .Replace("=", "")
               .Replace("list", "")
               .Replace("//", "")
               .Replace("!-- Effect Web v1.8.5 Finish Edition | Powered by Erick-Master - CTM TEAM Softwares --", "")
               .Replace("a hrefjavascript: void(EffectWeb); oncckCTM_Load('?pagpaneluser','conteudo','GET');» Painel de Controlea", "")
               .Replace("    a hrefjavascript: void(EffectWeb); oncckCTM_Load('?pagpaneladmin','conteudo','GET');» Painel Administrativoa", "")
               .Replace("    a href?execlogout» Deslogara", "")
               .Replace("a hrefjavascript: void(EffectWeb); oncckCTM_Load('?pagpaneluser','conteudo','GET');» Painel de Controle/a/","")
               .Replace("    a href?execlogout» Deslogar/a/", "")
               .Replace("\n/", "")
               .Replace("\n\n", "\n")
               .Replace("\n /", "")
               .Replace("o/", "o")
               .Replace("/Seu","Seu")
               .Replace("success-box", "")
               .Replace("warning-box", "");
            return resposta;
        }

        public static async Task<string> Getnotify()
        {
            try
            { 
                var response = await client.GetAsync(Globals.webrequest + "getnotify.txt");

                var responseString = await response.Content.ReadAsStringAsync();

                string test = Funções.LimpaString(responseString);

                return test;
            }
            catch
            {
                return "Erro de solicitação";
            }
        }

        public async static Task <string[]> logar()
        {
            var values = new Dictionary<string, string>
                {
                     { "Log_Account", Globals.login},
                     { "Log_Password", Globals.senha}
                };

            var content = new FormUrlEncodedContent(values);
            try
            {
                var response = await client.PostAsync(Globals.webrequest + "?ajax=panel&cmd=login", content);
                var responseString = await response.Content.ReadAsStringAsync();
                var response2 = await client.GetStringAsync(Globals.webrequest + "?ajax=panel&cmd=login");
                var resposta = LimpaString(response2);
                string[] x = { resposta, responseString };
                return x;
                

            }
            catch
            {
                string[] x = { "Erro de sincronização, tente novamente." };
                return x;
            }
        }
        
    }


}
