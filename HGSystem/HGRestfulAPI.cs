using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;
using HGSystem.Model;
using HGSystem.Helpers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
using System.IO;

namespace HGSystem
{
    [Serializable()]
    public class HGResponse<T>
    {
        /*
        private int status;
        private String msg;
        private long time;
        private T data;
         */

        public int Status { get; set; }
        public String Msg { get; set; }
        public long Time { get; set; }
        public T Data { get; set; }
    }

    public class HGRestfulAPI
    {
        public static String BaseUrl = "https://edutest.hongkazhijia.com"; // for test
        // private static String BaseUrl = "https://edut.hongkazhijia.com"; // for production
        public static String FileServerBaseUrl = "https://filetest.hongkazhijia.com"; // for fileserver test
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
                if (status == 200)
                {
                    HGResponse<T> hgr = JsonNewtonsoft.FromJSON<HGResponse<T>>(json_data);
                    return hgr.Data;
                }
                else
                {
                    throw new Exception(jo.ContainsKey("msg") ? jo["msg"].ToString() : "未知错误:" + json_data);
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
            if (DebugHelper.getInstance().FastUserLogin)
                postData = "{\"mobile\":\"" + _mobile + "\",\"password\":\"" + new_pwd_md5 + "\",\"vcode\":\"eq32\",\"vtoken\":\"f3697b30-a5c7-46db-ae7b-140e7a1037f1\"}";
            String res = HttpHelper.HttpPostJsonData(BaseUrl + captchaUrl, postData);
            // TODO: need to handle "{\"status\":1404,\"msg\":\"账号或密码错误\",\"data\":{},\"time\":1553098311748}"
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
            return null;
        }

        public HGComCategory[] getHGComCategory()
        {
            String resturl = "/platform/album/getComCategory";
            // TODO: no need to add customized headers
            String res = HttpHelper.HttpPostJsonData(BaseUrl + resturl, null);
            // String res = "{ \"msg\": \"执行成功！\", \"data\": [{ \"children\": [{ \"children\": [{ \"label\": \"认识自我\", \"value\": 10001001 }], \"label\": \"品德素质\", \"value\": 10001000 }], \"label\": \"学生\", \"value\": 10000000 }, { \"children\": [{ \"children\": [{ \"label\": \"身体健康\", \"value\": 11001001 }], \"label\": \"自我提升\", \"value\": 11003000 }], \"label\": \"家长\", \"value\": 11000000 } ], \"time\": 1553329855958, \"status\": 200 }";
            HGComCategory[] hgcc = parseHGData<HGComCategory[]>(res);
            return hgcc;
            /*
            if (res != null)
            {
                HGResponse<HGComCategory[]> hgr = JsonNewtonsoft.FromJSON<HGResponse<HGComCategory[]>>(res);
                return hgr.Data;
            }
            return null;
            */
        }

        private IList<KeyValuePair<String, String>> buildHeaderParams(HGUser hgu)
        {
            IList<KeyValuePair<String, String>> headers = new List<KeyValuePair<String, String>>();
            headers.Add(new KeyValuePair<string,string>("Content-Type", "application/json"));
            if (DebugHelper.getInstance().FastUserLogin)
            {
                // headers.Add(new KeyValuePair<string,string>("Content-Type", "application/json"));
                headers.Add(new KeyValuePair<string, string>("id", "180919101033025850632"));
                headers.Add(new KeyValuePair<string, string>("userType", "2"));
                headers.Add(new KeyValuePair<string, string>("orgid", "18091910104183120964"));
                headers.Add(new KeyValuePair<string, string>("orgType", "2"));
                headers.Add(new KeyValuePair<string, string>("token", "9a893d4d-a80f-4d68-ab30-10f4a5b6193c"));
                return headers;
            }
            else if (hgu != null)
            {
                // headers.Add(new KeyValuePair<string, string>("Content-Type", "application/json"));
                headers.Add(new KeyValuePair<string, string>("id", hgu.Id));
                headers.Add(new KeyValuePair<string, string>("userType", hgu.UserType));
                headers.Add(new KeyValuePair<string, string>("orgid", hgu.Orgid));
                headers.Add(new KeyValuePair<string, string>("orgType", hgu.OrgType));
                headers.Add(new KeyValuePair<string, string>("token", hgu.Token));
                return headers;
            }
            return null;
        }

        public HGAlbum getHGAlbum(HGAlbumSearchParams hgasp)
        {
            String resturl = "/platform/album/query";
            if (hgasp == null)
                throw new Exception("查询专辑传递的参数为空");
            string json_params = JsonConvert.SerializeObject(hgasp);
            Console.WriteLine(json_params);
            String res = HttpHelper.HttpPostJsonData(BaseUrl + resturl, json_params, buildHeaderParams(null));
            HGAlbum hgalbum = parseHGData<HGAlbum>(res);
            return hgalbum;
        }

        // deprecated
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
            if (DebugHelper.getInstance().SampleAlbums)
            {
                json_params = "{\"orgName\": \"\",\"albumCategory\": [],\"albumId\": null,\"albumName\": null,\"albumStatus\": null,\"createTimeBeginTime\": null,\"createTimeEndTime\": null,\"sliceParams\": {\"pageNum\": 1,\"pageSize\": 30},\"direction\": null,\"orderBy\": null}";
            }
             
            // TODO: no need to add customized headers
            String res = HttpHelper.HttpPostJsonData(BaseUrl + resturl, json_params, buildHeaderParams(null));
            return parseHGData<HGAlbum>(res);
        }
        public bool newHGAlbum(HGAlbumParams hgap)
        {
            String resturl = "/platform/album/add";
            if (hgap == null)
                throw new Exception("新建专辑传递的参数为空");
            string json_params = JsonConvert.SerializeObject(hgap);
            Console.WriteLine(json_params);
            String res = HttpHelper.HttpPostJsonData(BaseUrl + resturl, json_params, buildHeaderParams(null));
            Object newOK = parseHGData<Object>(res);
            return true;
        }
        // deprecated
        public bool newHGAlbum(String albumName, int albumType, String albumIntro, String fileUrl, String albumFileId, String albumLabel, String albumCategoryId)
        {
            String resturl = "/platform/album/add";
        
            //String albumName = "";
            //int albumType = 0;
            //String albumIntro = "";
            //String fileUrl = "";
            //String albumFileId = "";
            //String albumLabel = "";
            //String albumCategoryId = "";
            String json_params = "{\"albumName\": \"" + albumName 
                + "\",\"albumType\":" + albumType
                + ",\"intro\": \"" + albumIntro
                + "\",\"fileUrl\": \"" + fileUrl
                + "\",\"albumFileId\": \"" + albumFileId
                + "\",\"albumLabel\": \"" + albumLabel
                + "\",\"albumCategoryId\":" + albumCategoryId
                + "}";
            Console.WriteLine(json_params);
            if (DebugHelper.getInstance().FakeNewAlbum)
            {
                json_params = "{\"albumName\": \"70周年大阅兵7\",\"albumType\": 1,\"intro\": \"70周年大阅兵，简介\",\"fileUrl\": \"https://filetest.hongkazhijia.com/cb/cb7a88314621ad93ce4f9c5fe0495c942953197489e01f925162314153baa0a2.jpg\",	\"albumFileId\": \"cb7a88314621ad93ce4f9c5fe0495c942953197489e01f925162314153baa0a2\",\"albumLabel\": \"70周年\",\"albumCategoryId\": [10000000, 10001000, 10001001]}";
            }
            String res = HttpHelper.HttpPostJsonData(BaseUrl + resturl, json_params, buildHeaderParams(null));
            Object newOK = parseHGData<Object>(res);
            return true;
        }

        public bool newHGProgram()
        {
            String resturl = "/platform/material/eims/add";
            String json_params = "";
            if (DebugHelper.getInstance().FastUserLogin)
            {
                json_params = "{\"materials\": [{\"fileId\": \"00790707ef3ff682fd0d4688ff1350fb1c516bae1f1f2c3df6e76200266af9e0\", \"realUrl\": \"https://filetest.hongkazhijia.com/00/00790707ef3ff682fd0d4688ff1350fb1c516bae1f1f2c3df6e76200266af9e0.mp3\", \"fileName\": \"00790707ef3ff682fd0d\", \"duration\": 197, \"wh\": [], \"thumbnail\": \"\", \"albumId\": \"190321013159480064266\", \"coverId\": \"\", \"imageUrl\": \"\", \"name\": \"00790707ef3ff682fd0d\", \"sort\": \"\", \"publisher\": \"1\", \"type\": 1 }] }";
                Console.WriteLine("json_params : " + json_params);
            }
            else
            {

            }
            String res = HttpHelper.HttpPostJsonData(BaseUrl + resturl, json_params, buildHeaderParams(null));
            Object newOK = parseHGData<Object>(res);
            return true;
        }

        public HGImageUploadRes uploadHGFile(String filename)
        {
            // TODO: seems fail
            //String sha256_str = Helpers.EncryptHelper.SHA256(filename, true);
            //Console.WriteLine("SHA256 for " + filename + " is " + sha256_str);
            //System.IO.FileInfo fileInfo = new System.IO.FileInfo(filename);
            //long filelen = fileInfo.Length;
            //long startpos = 0;
            //String filemeta = sha256_str + "." + filelen + "." + startpos;

            //String resturl = "/file/ihongka_files/upload";
            //String res = HttpHelper.UploadFileByOffset(FileServerBaseUrl + resturl, filename, 0);
            //Console.WriteLine(res);
            
            // TODO: this seems OK for image but not OK for mp3/mp4
            String resturl = "/file/ihongka_files/upload";
            // TODO: how to get SHA256 for file
            String sha256 = EncryptHelper.SHA256(filename, true);
            // filename = @"E:\work\testmp3.mp3";
            FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read);
            String res = Util.HttpRequestPost(FileServerBaseUrl + resturl, "media", filename, fs);
            HGImageUploadRes hgiur = parseHGImageUploadResponse(res);
            return hgiur;

            //String resturl = "/file/ihongka_files/upload";
            ////MyWebClient wc = new MyWebClient();
            ////String res = wc.UploadFile(FileServerBaseUrl + resturl, "file=" + filename);
            //String res = CurlHelper.PostFile(FileServerBaseUrl + resturl, filename);
            //HGImageUploadRes hgiur = parseHGImageUploadResponse(res);
            //return hgiur;

        }

        private HGImageUploadRes parseHGImageUploadResponse(String json_data)
        {
            if (json_data != null)
            {
                JObject jo = JObject.Parse(json_data);
                int status = jo.ContainsKey("status") ? Convert.ToInt32(jo["status"].ToString()) : 0;
                if (status == 200)
                {
                    HGImageUploadRes hgiur = JsonNewtonsoft.FromJSON<HGImageUploadRes>(json_data);
                    return hgiur;
                }
                else
                {
                    throw new Exception(jo.ContainsKey("msg") ? jo["msg"].ToString() : "未知错误:" + json_data);
                }
            }
            return null;
        }
    }
    
}
