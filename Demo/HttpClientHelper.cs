using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace Demo
{
   public class HttpClientHelper
    {
        /// <summary>
        /// post
        /// </summary> 
        /// http://127.0.0.1:8080/wl-integration-web/extService/wechat/cancelOrder
        /// 基地址 http://127.0.0.1:8080/
        /// 地址  wl-integration-web/extService/wechat/cancelOrder
        /// <param name="Baseurl">基地址</param>
        /// <param name="url">地址</param>
        /// <param name="data">数据json</param>
        /// <returns></returns>
        public string Post(string Baseurl,string url,string data)
        {

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(Baseurl);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            try
            {
                var json = JsonConvert.DeserializeObject<Dictionary<string,object>>(data);
                HttpContent content = new StringContent(data);
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var task = client.PostAsync(url, content);
                if (task.Result.IsSuccessStatusCode)
                {
                    var res = task.Result.Content.ReadAsStringAsync().Result;
                    return res;
                }
                else
                {
                    return "请求失败";
                }
            }
            catch (Exception)
            {
                HttpContent content = new StringContent(JsonConvert.SerializeObject(data));
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
                var task = client.PostAsync(url, content);
                if (task.Result.IsSuccessStatusCode)
                {
                    var res = task.Result.Content.ReadAsStringAsync().Result;
                    return res;
                }
                else 
                {
                    return "请求失败";
                }
            }
           
        }
    }
}
