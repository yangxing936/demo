using SqlSugar;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class DefaultController : ApiController
    {
        [Route("api/Default/Get")]
        [HttpGet]
        public object Get()
        {
            return null;
        }
        [HttpGet]
        public string GetCode(string appid, string redirect_uri, string response_type, string scope, string wechat_redirect, string state = "a-zA-Z0-9")
        {
            try
            {
                if (string.IsNullOrEmpty(appid)) { return "The Params is not null"; };
                string url = "https://open.weixin.qq.com/connect/oauth2/authorize?";
                url += $"appid={appid}&redirect_uri={redirect_uri}&response_type={response_type}&scope={scope}&wechat_redirect={wechat_redirect}&state={state}";
                var res = HttpGet(url, null);
                if (!string.IsNullOrEmpty(res))
                {
                    if (res.IndexOf("10003") >= 0)
                    {
                        return "redirect_uri域名与后台配置不一致";
                    }
                    return res;
                }
                return "This request is null";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

        }
        public static string HttpGet(string url, Hashtable headht = null)
        {
            System.Net.HttpWebRequest request;

            //如果是发送HTTPS请求  
            if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version10;
            }
            else
            {
                request = WebRequest.Create(url) as HttpWebRequest;
            }
            request.Method = "GET";
            //request.ContentType = "application/x-www-form-urlencoded";
            request.Accept = "*/*";
            request.Timeout = 15000;
            request.AllowAutoRedirect = false;
            WebResponse response = null;
            string responseStr = null;
            if (headht != null)
            {
                foreach (DictionaryEntry item in headht)
                {
                    request.Headers.Add(item.Key.ToString(), item.Value.ToString());
                }
            }

            try
            {
                response = request.GetResponse();

                if (response != null)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                    responseStr = reader.ReadToEnd();
                    reader.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            return responseStr;
        }
        /// <summary>
        /// HTTP POST方式请求数据
        /// </summary>
        /// <param name="url">URL.</param>
        /// <param name="param">POST的数据</param>
        /// <returns></returns>
        public static string HttpPostJson(string url, string param = null)
        {
            HttpWebRequest request;

            //如果是发送HTTPS请求  
            if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
                request = WebRequest.Create(url) as HttpWebRequest;
                request.ProtocolVersion = HttpVersion.Version10;
            }
            else
            {
                request = WebRequest.Create(url) as HttpWebRequest;
            }

            request.Method = "POST";
            request.ContentType = "application/json";
            request.Accept = "*/*";
            request.Timeout = 15000;
            request.AllowAutoRedirect = false;



            StreamWriter requestStream = null;
            WebResponse response = null;
            string responseStr = null;

            try
            {
                requestStream = new StreamWriter(request.GetRequestStream());
                requestStream.Write(param);
                requestStream.Close();

                response = request.GetResponse();
                if (response != null)
                {
                    StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8);
                    responseStr = reader.ReadToEnd();
                    reader.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                request = null;
                requestStream = null;
                response = null;
            }

            return responseStr;
        }

    }
}
