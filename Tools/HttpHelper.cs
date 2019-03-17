using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ourtm.Common.Utilitys
{
    public class HttpHelper
    {
        /// <summary>
        /// 回调方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="certificate"></param>
        /// <param name="chain"></param>
        /// <param name="errors"></param>
        /// <returns></returns>
        private static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            //为了通过证书验证，总是返回true
            return true;
        }

        /// <summary>
        /// http请求读取数据
        /// </summary>
        /// <param name="strGetUrl"></param>
        /// <returns></returns>
        public static string HttpGetData(string strGetUrl)
        {
            if (strGetUrl.StartsWith("https", StringComparison.OrdinalIgnoreCase))///https请求
            {
                //SSL3协议替换成TLS协议
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
            }

            HttpWebRequest request = WebRequest.Create(strGetUrl) as HttpWebRequest;   

            request.Method = "GET";
            request.KeepAlive = true;
            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        using (StreamReader read = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                        {
                            return read.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("在HttpHelper类HttpGetData方法出错", ex);
            }
            return "";
        }

        /// <summary>
        /// http请求提交数据
        /// </summary>
        /// <param name="strPostUrl"></param>
        /// <param name="strPostData"></param>
        /// <returns></returns>
        public static string HttpPostData(string strPostUrl, string strPostData)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            byte[] b = encoding.GetBytes(strPostData);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strPostUrl);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = b.Length;
            try
            {
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(b, 0, b.Length);
                }
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        using (StreamReader read = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                        {
                            return read.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                LogHelper.Error("在HttpHelper类HttpPostData方法出错", ex);
            }
            return "";
        }

    }
}
