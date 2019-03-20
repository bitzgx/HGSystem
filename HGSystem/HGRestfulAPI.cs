using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HGSystem.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;

namespace HGSystem
{
    [Serializable()]
    public class HGResponse<T>
    {
        private int status;
        private String msg;
        private long time;
        private T data;

        public int Status { get; set; }
        public String Msg { get; set; }
        public long Time { get; set; }
        public T Data { get; set; }
    }

    public class HGRestfulAPI
    {
        private static String BaseUrl = "https://edutest.hongkazhijia.com"; // for test
        // private static String BaseUrl = "https://edut.hongkazhijia.com"; // for production
        private static String FileServerBaseUrl = "https://filetest.hongkazhijia.com"; // for fileserver test
        private static HGRestfulAPI m_hg_restfulapi = new HGRestfulAPI();
        private HGRestfulAPI()
        {
        }

        public static HGRestfulAPI getInstance()
        {
            return m_hg_restfulapi;
        }

        private T parseHGData<T>(String json_data)
        {
            if (json_data != null)
            {
                JObject jo = JObject.Parse(json_data);
                int status = jo.ContainsKey("status") ? Convert.ToInt32(jo["status"].ToString()) : 0;
                if (status == 200) {
                    HGResponse<T> hgr = JsonNewtonsoft.FromJSON<HGResponse<T>>(json_data);
                    return hgr.Data;
                }
            }
            return default(T);
        }

        public HGUser login(string _mobile, string _password, string _vcode, string _vtoken)
        {
            String captchaUrl = "/platform/school/ymsLogin";
            String pwd_md5 = Helpers.EncryptHelper.CreateMD5Hash(_password);
            String new_pwd = pwd_md5 + "hongka";
            String new_pwd_md5 = Helpers.EncryptHelper.CreateMD5Hash(new_pwd);
            String postData = "mobile=" + _mobile + "&password=" + new_pwd_md5 + "&vcode=" + _vcode + "&vtoken" + _vtoken;
            // HGCaptcha hgc = new HGCaptcha();
            // postData = "{\"mobile\":\"13488613602\",\"password\":\"7b490bbb31fb36019a941d64d6077e07\",\"vcode\":\"eq32\",\"vtoken\":\"f3697b30-a5c7-46db-ae7b-140e7a1037f1\"}";
            postData = "{\"mobile\":\"" + _mobile + "\",\"password\":\"" + new_pwd_md5 + "\",\"vcode\":\"" + _vcode + "\",\"vtoken\":\"" + _vtoken + "\"}";
            postData = "{\"mobile\":\"" + _mobile + "\",\"password\":\"" + new_pwd_md5 + "\",\"vcode\":\"eq32\",\"vtoken\":\"f3697b30-a5c7-46db-ae7b-140e7a1037f1\"}";
            String res = HttpHelper.HttpPostJsonData(BaseUrl + captchaUrl, postData);
            return parseHGData<HGUser>(res);
            /*
            if (res != null)
            {
                JObject jo = JObject.Parse(res);
                int status = jo.ContainsKey("status") ? Convert.ToInt32(jo["status"].ToString()) : 0;
                if (status == 200) {
                    HGResponse<HGUser> hgr = JsonNewtonsoft.FromJSON<HGResponse<HGUser>>(res);
                    return hgr.Data;
                }
            }
            return null;*/
        }

        public HGCaptcha getHGCaptcha()
        {
            String captchaUrl = "/platform/login/getImage";
            // String res = HttpHelper.HttpPostJsonData(BaseUrl + captchaUrl, null);
            // return parseHGData<HGCaptcha>(res);
            return null;
            /*
            try
            {
                String res = HttpHelper.HttpPostData(BaseUrl + captchaUrl, null);
                if (res != null)
                {
                    HGResponse<HGCaptcha> hgr = JsonNewtonsoft.FromJSON<HGResponse<HGCaptcha>>(res);
                    return hgr.Data;
                }
            }
            catch (System.Net.WebException we)
            {
                System.Windows.Forms.MessageBox.Show(we.Message);
            }
            return null;*/
        }

        public HGComCategory[] getHGComCategory()
        {
            String resturl = "/platform/album/getComCategory";
            // TODO: no need to add customized headers
            String res = HttpHelper.HttpPostJsonData(BaseUrl + resturl, null);
            return parseHGData<HGComCategory[]>(res);
            /*
            if (res != null)
            {
                HGResponse<HGComCategory[]> hgr = JsonNewtonsoft.FromJSON<HGResponse<HGComCategory[]>>(res);
                return hgr.Data;
            }
            return null;
            */
        }

        public HGAlbum getHGAlbum(int id, string key, int albumType, long startTime, long endTime, int pageNum, int pageSize)
        {
            String resturl = "/platform/album/query";
            // String json_params = @"{""id"":1,""key"":"""",""albumType"":2,""startTime"":1521738981174,""endTime"":1541738981174,""sliceParams"": {""pageNum"": 1, ""pageSize"": 10}}";
            
            String json_params = "{\"id\":" + id
                + ",\"key\":\"" + key
                + "\",\"albumType\":" + albumType
                + ",\"startTime\":" + startTime
                + ",\"endTime\":" + endTime
                + ",\"sliceParams\":{\"pageNum\":" + pageNum
                + ",\"pageSize\":" + pageSize
                + "}}";
             
            // TODO: no need to add customized headers
            String res = HttpHelper.HttpPostJsonData(BaseUrl + resturl, json_params);
            return parseHGData<HGAlbum>(res);
        }

        public void uploadHGFile(String filename)
        {
            String sha256_str = Helpers.EncryptHelper.SHA256(filename, true);
            Console.WriteLine("SHA256 for " + filename + " is " + sha256_str);
            System.IO.FileInfo fileInfo = new System.IO.FileInfo(filename);
            long filelen = fileInfo.Length;
            long startpos = 0;
            String filemeta = sha256_str + "." + filelen + "." + startpos;

            String resturl = "/fileServer/ihongka_files/eims/upload";
            HttpHelper.UploadFileByOffset(FileServerBaseUrl + resturl, filename, 0);
        }
    }
    
}
