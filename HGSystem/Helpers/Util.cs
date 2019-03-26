using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Web;
using System.Net;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Net.Security;

namespace HGSystem.Helpers
{
    public class Util
    {
        // DateTime --> long
        public static long ConvertDateTimeToLong(DateTime dt)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            TimeSpan toNow = dt.Subtract(dtStart);
            long timeStamp = toNow.Ticks;
            timeStamp = long.Parse(timeStamp.ToString().Substring(0, timeStamp.ToString().Length - 4));
            return timeStamp;
        }


        // long --> DateTime
        public static DateTime ConvertLongToDateTime(long d)
        {
            DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1));
            long lTime = long.Parse(d + "0000");
            TimeSpan toNow = new TimeSpan(lTime);
            DateTime dtResult = dtStart.Add(toNow);
            return dtResult;
        }
        /// <summary>
        /// Sha1
        /// </summary>
        /// <param name="orgStr"></param>
        /// <param name="encode"></param>
        /// <returns></returns>
        public static string Sha1(string orgStr, string encode = "UTF-8")
        {
            var sha1 = new SHA1Managed();
            var sha1bytes = System.Text.Encoding.GetEncoding(encode).GetBytes(orgStr);
            byte[] resultHash = sha1.ComputeHash(sha1bytes);
            string sha1String = BitConverter.ToString(resultHash).ToLower();
            sha1String = sha1String.Replace("-", "");
            return sha1String;
        }
        public static string MD5(string encypStr, string charset = "UTF-8")
        {
            string retStr;
            MD5CryptoServiceProvider m5 = new MD5CryptoServiceProvider();

            //创建md5对象
            byte[] inputBye;
            byte[] outputBye;

            //使用GB2312编码方式把字符串转化为字节数组．
            try
            {
                inputBye = Encoding.GetEncoding(charset).GetBytes(encypStr);
            }
            catch
            {
                inputBye = Encoding.GetEncoding("GB2312").GetBytes(encypStr);
            }
            outputBye = m5.ComputeHash(inputBye);

            retStr = System.BitConverter.ToString(outputBye);
            retStr = retStr.Replace("-", "").ToUpper();
            return retStr;
        }

        private static string[] strs = new string[]
                                 {
                                  "a","b","c","d","e","f","g","h","i","j","k","l","m","n","o","p","q","r","s","t","u","v","w","x","y","z",
                                  "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"
                                 };
        /// <summary>
        /// 创建随机字符串
        /// </summary>
        /// <returns></returns>
        public static string CreateNonce_str()
        {
            Random r = new Random();
            var sb = new StringBuilder();
            var length = strs.Length;
            for (int i = 0; i < 15; i++)
            {
                sb.Append(strs[r.Next(length - 1)]);
            }
            return sb.ToString();
        }

        /// <summary>
        /// 创建时间戳
        /// </summary>
        /// <returns></returns>
        public static long CreateTimestamp()
        {
            return (DateTime.Now.ToUniversalTime().Ticks - 621355968000000000) / 10000000;
        }

        /// <summary>
        /// html转义
        /// </summary>
        /// <param name="instr"></param>
        /// <returns></returns>
        public static string Transfer(string instr)
        {
            if (instr == null) return "";
            return instr.Replace("&", "&amp;").Replace("<", "&lt;")
                        .Replace(">", "&gt;").Replace("\"", "&quot;");
        }
        /// <summary>
        /// html转义字符串还原
        /// </summary>
        /// <param name="instr"></param>
        /// <returns></returns>
        public static string DeTransfer(string instr)
        {
            if (instr == null) return "";
            return instr.Replace("&amp;", "&").Replace("&lt;", "<")
                        .Replace("&gt;", ">").Replace("&quot;", "\"");
        }

        /// <summary>
        /// FORM表单POST方式上传一个多媒体文件
        /// </summary>
        /// <param name="url">API URL</param>
        /// <param name="typeName"></param>
        /// <param name="fileName"></param>
        /// <param name="fs"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public static string HttpRequestPost(string url, string typeName, string fileName, Stream fs, string encoding = "UTF-8")
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.Timeout = 1000000;
            var postStream = new MemoryStream();
            #region 处理Form表单文件上传
            //通过表单上传文件
            string boundary = "----" + DateTime.Now.Ticks.ToString("x");
            string formdataTemplate = "\r\n--" + boundary + "\r\nContent-Disposition: form-data; name=\"{0}\"; filename=\"{1}\"\r\nContent-Type: application/octet-stream\r\n\r\n";
            try
            {
                var formdata = string.Format(formdataTemplate, typeName, fileName);
                var formdataBytes = Encoding.ASCII.GetBytes(postStream.Length == 0 ? formdata.Substring(2, formdata.Length - 2) : formdata);//第一行不需要换行
                Console.WriteLine("formdata:" + formdata);
                postStream.Write(formdataBytes, 0, formdataBytes.Length);

                //写入文件
                byte[] buffer = new byte[1024];
                int bytesRead = 0;
                while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) != 0)
                {
                    postStream.Write(buffer, 0, bytesRead);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            //结尾
            var footer = Encoding.ASCII.GetBytes("\r\n--" + boundary + "--\r\n");
            postStream.Write(footer, 0, footer.Length);
            request.ContentType = string.Format("multipart/form-data; boundary={0}", boundary);
            #endregion

            request.ContentLength = postStream != null ? postStream.Length : 0;
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            request.KeepAlive = true;
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/31.0.1650.57 Safari/537.36";

            #region 输入二进制流
            if (postStream != null)
            {
                postStream.Position = 0;

                //直接写入流
                Stream requestStream = request.GetRequestStream();

                byte[] buffer = new byte[1024];
                int bytesRead = 0;
                while ((bytesRead = postStream.Read(buffer, 0, buffer.Length)) != 0)
                {
                    requestStream.Write(buffer, 0, bytesRead);
                }

                postStream.Close();//关闭文件访问
            }
            #endregion

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (Stream responseStream = response.GetResponseStream())
            {
                using (StreamReader myStreamReader = new StreamReader(responseStream, Encoding.GetEncoding(encoding)))
                {
                    string retString = myStreamReader.ReadToEnd();
                    return retString;
                }
            }
        }

        /// <summary>
        /// 下载
        /// </summary>
        /// <param name="url"></param>
        /// <param name="stream"></param>
        public static void Download(string url, Stream stream)
        {
            WebClient wc = new WebClient();
            var data = wc.DownloadData(url);
            foreach (var b in data)
            {
                stream.WriteByte(b);
            }
        }
    }

        /// <summary>
    /// 该类主要是处理网络请求 :https
    /// </summary>
    public class ApplicationUtil
    {
 
        /// <summary>
        /// 该方法主要是处理POST请求,返回处理返回的结果字符串
        /// </summary>
        /// <param name="posturl">请求的接口链接</param>
        /// <param name="postdata">请求的数据</param>
        /// <returns>返回的结果</returns>
        /// 
        #region 该方法主要是处理POST请求,返回处理的结果字符串
        public string DealPost(string posturl, string postdata)
        {
            string responseString = "";//post返回的结果
            ServicePointManager.ServerCertificateValidationCallback
                        += RemoteCertificateValidate;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
            HttpWebRequest req = (HttpWebRequest)HttpWebRequest.Create(posturl);
            req.Method = "POST";
            req.Headers["Cookie"] = "usersession=67d2da2c9f17e5e189fb1bf334fc6e36";
            byte[] postBytes = Encoding.UTF8.GetBytes(postdata);
            req.ContentType = "application/json; charset=utf-8";
            req.ContentLength = Encoding.UTF8.GetByteCount(postdata);//strJson为json字符串
            Stream stream = req.GetRequestStream();
            stream.Write(postBytes, 0, postBytes.Length);
            req.Timeout = 90000;
            stream.Close();
            var response = req.GetResponse();
            Stream streamResponse = response.GetResponseStream();
            StreamReader streamRead = new StreamReader(streamResponse);
            responseString = streamRead.ReadToEnd();
            response.Close();
            streamRead.Close();
            return responseString;
        }
        #endregion
 
        #region 信任https请求证书
        private static bool RemoteCertificateValidate(
            object sender, X509Certificate cert,
             X509Chain chain, SslPolicyErrors error)
        {
            System.Console.WriteLine("Warning, trust any certificate");
            return true;
        }
        #endregion
 
        #region 该方法主要是处理Get请求,返回处理的结果字符串
        public string DealGet(string url)
        {
            //设置安全的类型
            ServicePointManager.ServerCertificateValidationCallback
                       += RemoteCertificateValidate;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
            HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(url);
            myRequest.Method = "GET";
            HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
            StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
            string content = reader.ReadToEnd();
            reader.Close();
            return content;
        }
        #endregion
 
        #region 自定义一个方法实现Http上传
        public string UploadByHttp(string posturl, string path)
        {
            ServicePointManager.ServerCertificateValidationCallback
                    += RemoteCertificateValidate;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls;
            HttpWebRequest request = WebRequest.Create(posturl) as HttpWebRequest;
            CookieContainer cookieContainer = new CookieContainer();
            request.CookieContainer = cookieContainer;
            request.AllowAutoRedirect = true;
            request.Method = "POST";
            string boundary = DateTime.Now.Ticks.ToString("X"); // 随机分隔线
            request.ContentType = "multipart/form-data;charset=utf-8;boundary=" + boundary;
            byte[] itemBoundaryBytes = Encoding.UTF8.GetBytes("\r\n--" + boundary + "\r\n");
            byte[] endBoundaryBytes = Encoding.UTF8.GetBytes("\r\n--" + boundary + "--\r\n");
            int pos = path.LastIndexOf("\\");
            string fileName = path.Substring(pos + 1);
            //请求头部信息 
            StringBuilder sbHeader = new StringBuilder(string.Format("Content-Disposition:form-data;name=\"file\";filename=\"{0}\"\r\nContent-Type:application/octet-stream\r\n\r\n", fileName));
            byte[] postHeaderBytes = Encoding.UTF8.GetBytes(sbHeader.ToString());
            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] bArr = new byte[fs.Length];
            fs.Read(bArr, 0, bArr.Length);
            fs.Close();
            Stream postStream = request.GetRequestStream();
            //写入照片信息
            postStream.Write(itemBoundaryBytes, 0, itemBoundaryBytes.Length);
            postStream.Write(postHeaderBytes, 0, postHeaderBytes.Length);
            postStream.Write(bArr, 0, bArr.Length);
            postStream.Write(endBoundaryBytes, 0, endBoundaryBytes.Length);
            postStream.Close();
            //发送请求并获取相应回应数据
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            //直到request.GetResponse()程序才开始向目标网页发送Post请求
            Stream instream = response.GetResponseStream();
            StreamReader sr = new StreamReader(instream, Encoding.UTF8);
            //返回结果网页（html）代码
            string content = sr.ReadToEnd();
            return content;
        }
        #endregion
    }

    public static class WebRequestExtensions
    {
        public static Stream GetRequestStreamWithTimeout(
            this WebRequest request,
            int? millisecondsTimeout = null)
        {
            return AsyncToSyncWithTimeout(
                request.BeginGetRequestStream,
                request.EndGetRequestStream,
                millisecondsTimeout ?? request.Timeout);
        }

        public static WebResponse GetResponseWithTimeout(
            this HttpWebRequest request,
            int? millisecondsTimeout = null)
        {
            return AsyncToSyncWithTimeout(
                request.BeginGetResponse,
                request.EndGetResponse,
                millisecondsTimeout ?? request.Timeout);
        }

        private static T AsyncToSyncWithTimeout<T>(
            Func<AsyncCallback, object, IAsyncResult> begin,
            Func<IAsyncResult, T> end,
            int millisecondsTimeout)
        {
            var iar = begin(null, null);
            if (!iar.AsyncWaitHandle.WaitOne(millisecondsTimeout))
            {
                var ex = new TimeoutException();
                throw new WebException(ex.Message, ex, WebExceptionStatus.Timeout, null);
            }
            return end(iar);
        }

        public static String UploadFile(string path, string url, string contentType)
        {
            // Build request
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = WebRequestMethods.Http.Post;
            request.AllowWriteStreamBuffering = false;
            request.ContentType = contentType;
            string fileName = Path.GetFileName(path);
            request.Headers["Content-Disposition"] = string.Format("attachment; filename=\"{0}\"", fileName);

            try
            {
                // Open source file
                using (var fileStream = File.OpenRead(path))
                {
                    // Set content length based on source file length
                    request.ContentLength = fileStream.Length;

                    // Get the request stream with the default timeout
                    using (var requestStream = WebRequestExtensions.GetRequestStreamWithTimeout(request, 300000))
                    {
                        // Upload the file with no timeout
                        // fileStream.CopyTo(requestStream);

                        byte[] bArr = new byte[fileStream.Length];
                        fileStream.Read(bArr, 0, bArr.Length);
                        fileStream.Close();
                        Stream postStream = request.GetRequestStream();
                        requestStream.Write(bArr, 0, bArr.Length);
                    }
                }

                // Get response with the default timeout, and parse the response body
                using (var response = WebRequestExtensions.GetResponseWithTimeout(request, 300000))
                using (var responseStream = response.GetResponseStream())
                using (var reader = new StreamReader(responseStream))
                {
                    string json = reader.ReadToEnd();
                    return json;
                    //var j = JObject.Parse(json);
                    //return j.Value<long>("Id");
                }
            }
            catch (WebException ex)
            {
                if (ex.Status == WebExceptionStatus.Timeout)
                {
                    Console.WriteLine("Timeout while uploading '{0}':'{1}'", fileName, ex.Message);
                }
                else
                {
                    Console.WriteLine("Error while uploading '{0}':'{1}'", fileName, ex.Message);
                }
                throw;
            }
        }
    }
}