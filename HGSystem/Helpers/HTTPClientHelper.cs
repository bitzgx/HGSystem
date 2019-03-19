using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HGSystem
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
                Console.WriteLine("在HttpHelper类HttpGetData方法出错", ex);
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
            if (strPostData == null)
                strPostData = "";
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
            catch (System.Net.WebException we)
            {
                Console.WriteLine("在HttpHelper类HttpPostData方法出错", we);
            }
            catch (Exception ex)
            {
                Console.WriteLine("在HttpHelper类HttpPostData方法出错", ex);
            }
            return "";
        }
        /// <summary>
        /// http请求提交数据
        /// </summary>
        /// <param name="strPostUrl"></param>
        /// <param name="strPostData"></param>
        /// <returns></returns>
        public static string HttpPostJsonData(string strPostUrl, string strPostData)
        {
            UTF8Encoding encoding = new UTF8Encoding();
            if (strPostData == null)
                strPostData = "";
            byte[] b = encoding.GetBytes(strPostData);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(strPostUrl);
            request.Method = "POST";
            request.ContentType = "application/json";
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
            catch (System.Net.WebException we)
            {
                Console.WriteLine("在HttpHelper类HttpPostData方法出错", we);
                System.Windows.Forms.MessageBox.Show("we:" + we);
            }
            catch (Exception ex)
            {
                Console.WriteLine("在HttpHelper类HttpPostData方法出错", ex);
                System.Windows.Forms.MessageBox.Show("ex:" + ex);
            }
            return "";
        }

    }
    public class HTTPClientHelper
    {
        ///
        /// Get请求
        /// 
        /// 
        /// 字符串
        public static string GetHttpResponse(string url, int Timeout)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "text/html;charset=UTF-8";
            request.UserAgent = null;
            request.Timeout = Timeout;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream myResponseStream = response.GetResponseStream();
            StreamReader myStreamReader = new StreamReader(myResponseStream, Encoding.GetEncoding("utf-8"));
            string retString = myStreamReader.ReadToEnd();
            myStreamReader.Close();
            myResponseStream.Close();

            return retString;
        }

        /// 创建POST方式的HTTP请求  
        public static HttpWebResponse CreatePostHttpResponse(string url, IDictionary<string, string> parameters, int timeout, string userAgent, CookieCollection cookies)
        {
            HttpWebRequest request = null;
            //如果是发送HTTPS请求  
            if (url.StartsWith("https", StringComparison.OrdinalIgnoreCase))
            {
                request = WebRequest.Create(url) as HttpWebRequest;
            }
            else
            {
                request = WebRequest.Create(url) as HttpWebRequest;
            }
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            //设置代理UserAgent和超时
            //request.UserAgent = userAgent;
            //request.Timeout = timeout; 

            if (cookies != null)
            {
                request.CookieContainer = new CookieContainer();
                request.CookieContainer.Add(cookies);
            }
            //发送POST数据  
            if (!(parameters == null || parameters.Count == 0))
            {
                StringBuilder buffer = new StringBuilder();
                int i = 0;
                foreach (string key in parameters.Keys)
                {
                    if (i > 0)
                    {
                        buffer.AppendFormat("&{0}={1}", key, parameters[key]);
                    }
                    else
                    {
                        buffer.AppendFormat("{0}={1}", key, parameters[key]);
                        i++;
                    }
                }
                byte[] data = Encoding.ASCII.GetBytes(buffer.ToString());
                using (Stream stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
            }
            string[] values = request.Headers.GetValues("Content-Type");
            return request.GetResponse() as HttpWebResponse;
        }


        /// <summary>
        /// 获取请求的数据
        /// </summary>
        public static string GetResponseString(HttpWebResponse webresponse)
        {
            using (Stream s = webresponse.GetResponseStream())
            {
                StreamReader reader = new StreamReader(s, Encoding.UTF8);
                return reader.ReadToEnd();

            }
        }
    }
}
