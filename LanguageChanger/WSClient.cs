using System.Diagnostics;
using System.Net.WebSockets;
using System.Net;
using Newtonsoft.Json;

namespace LanguageChanger
{
    internal class WSClient
    {
        readonly ClientWebSocket ws = new ClientWebSocket();
        public string json;

        public async Task<bool> GetAllLang()
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            try
            {
                ws.Options.RemoteCertificateValidationCallback += (o, c, ch, er) => true;

                var handler = new HttpClientHandler();
                handler.ClientCertificateOptions = ClientCertificateOption.Manual;
                handler.ServerCertificateCustomValidationCallback =
                    (httpRequestMessage, cert, cetChain, policyErrors) =>
                    {
                        return true;
                    };

                var client = new HttpClient(handler);
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("wss://riot:" + Properties.App.Default.lockfile_password + "@127.0.0.1:" + Properties.App.Default.lockfile_port + "/rnet-product-registry/v4/available-product-locales/products/valorant/patchlines/live"),
                    Headers = { { "Authorization", "Basic " + Properties.App.Default.lockfile_token }, },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();

                    Properties.App.Default.all_lang = body;

                    if (Properties.App.Default.debug)
                    {
                        Debug.WriteLine("=======================================================================================================================================");
                        Debug.WriteLine("[DEBUG] - WSClient.cs:GetAllLang:body : " + body);
                        Debug.WriteLine("[DEBUG] - WSClient.cs:GetAllLang:all_lang : " + Properties.App.Default.all_lang);
                        Debug.WriteLine("=======================================================================================================================================");
                    }

                    return true;
                }
            }
            catch (Exception ex) { Debug.Write(ex); }
            return false;
        }

        public async Task<bool> GetLocalLang()
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            try
            {
                ws.Options.RemoteCertificateValidationCallback += (o, c, ch, er) => true;

                var handler = new HttpClientHandler();
                handler.ClientCertificateOptions = ClientCertificateOption.Manual;
                handler.ServerCertificateCustomValidationCallback =
                    (httpRequestMessage, cert, cetChain, policyErrors) =>
                    {
                        return true;
                    };

                var client = new HttpClient(handler);
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("wss://riot:" + Properties.App.Default.lockfile_password + "@127.0.0.1:" + Properties.App.Default.lockfile_port + "/riotclient/product-locales/products/valorant/patchlines/live"),
                    Headers = { { "Authorization", "Basic " + Properties.App.Default.lockfile_token }, },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();

                    Properties.App.Default.local_lang = body.Replace("\"", "");

                    if (Properties.App.Default.debug)
                    {
                        Debug.WriteLine("=======================================================================================================================================");
                        Debug.WriteLine("[DEBUG] - WSClient.cs:GetLocaluser:body : " + body);
                        Debug.WriteLine("[DEBUG] - WSClient.cs:GetLocaluser:lang : " + Properties.App.Default.local_lang);
                        Debug.WriteLine("=======================================================================================================================================");
                    }

                    return true;
                }
            }
            catch (Exception ex) { Debug.Write(ex); }
            return false;
        }

        public async Task<bool> GetLocaluser()
        {
            ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            try
            {
                ws.Options.RemoteCertificateValidationCallback += (o, c, ch, er) => true;

                var handler = new HttpClientHandler();
                handler.ClientCertificateOptions = ClientCertificateOption.Manual;
                handler.ServerCertificateCustomValidationCallback =
                    (httpRequestMessage, cert, cetChain, policyErrors) =>
                    {
                        return true;
                    };

                var client = new HttpClient(handler);
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("wss://riot:" + Properties.App.Default.lockfile_password + "@127.0.0.1:" +     Properties.App.Default.lockfile_port + "/player-account/aliases/v1/active"),
                    Headers = { { "Authorization", "Basic " + Properties.App.Default.lockfile_token }, },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();

                    Json_LocalUser data = JsonConvert.DeserializeObject<Json_LocalUser>(body);
                    Properties.App.Default.local_user = data.game_name;
                    Properties.App.Default.local_tag = data.tag_line;

                    if(Properties.App.Default.debug)
                    {
                        Debug.WriteLine("=======================================================================================================================================");
                        Debug.WriteLine("[DEBUG] - WSClient.cs:GetLocaluser:body : " + body);
                        Debug.WriteLine("[DEBUG] - WSClient.cs:GetLocaluser:data.game_name : " + data.game_name);
                        Debug.WriteLine("[DEBUG] - WSClient.cs:GetLocaluser:data.tag_line : " + data.tag_line);
                        Debug.WriteLine("[DEBUG] - WSClient.cs:GetLocaluser:data.summoner : " + data.summoner);
                        Debug.WriteLine("[DEBUG] - WSClient.cs:GetLocaluser:data.active : " + data.active);
                        Debug.WriteLine("[DEBUG] - WSClient.cs:GetLocaluser:data.created_datetime : " + data.created_datetime);
                        Debug.WriteLine("=======================================================================================================================================");
                    }

                    return true;
                }
            }
            catch (Exception ex) { Debug.Write(ex); }
            return false;
        }
    }
}
