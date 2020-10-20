using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
namespace Demo
{
    public class HttpPostForm
    {
        /// <summary>
        /// httppost 表单提交
        /// </summary>
        /// <param name="url"></param>
        /// <param name="pixData"></param>
        /// <returns></returns>
        public static string HttpPostForms(string url, string pixData)
        {
            WebClient webClient = new WebClient();
            try
            {
                //ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(CheckValidationResult);
                //string postString = "arg1=a&arg2=b";//这里即为传递的参数，可以用工具抓包分析，也可以自己分析，主要是form里面每一个name都要加进来  
                byte[] postData = Encoding.UTF8.GetBytes(pixData);//编码，尤其是汉字，事先要看下抓取网页的编码方式  


                webClient.Headers.Add("Content-Type", "application/x-www-form-urlencoded");//采取POST方式必须加的header，如果改为GET方式的话就去掉这句话即可  
                byte[] responseData = webClient.UploadData(url, "POST", postData);//得到返回字符流  
                string srcString = Encoding.UTF8.GetString(responseData);//解码  
                return srcString;
            }
            catch (Exception e)
            {
                return e.Message;
                //  webClient.Close();
                //res = (HttpWebResponse)ex.Response;
            }
            return null;
        }

        public bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {   // 总是接受  
            return true;
        }
    }
}
