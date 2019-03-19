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
        private static HGRestfulAPI m_hg_restfulapi = new HGRestfulAPI();
        private HGRestfulAPI()
        {
        }

        public static HGRestfulAPI getInstance()
        {
            return m_hg_restfulapi;
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
            if (res != null)
            {
                JObject jo = JObject.Parse(res);
                int status = jo.ContainsKey("status") ? Convert.ToInt32(jo["status"].ToString()) : 0;
                if (status == 200) {
                    HGResponse<HGUser> hgr = JsonNewtonsoft.FromJSON<HGResponse<HGUser>>(res);
                    return hgr.Data;
                }
            }
            return null;
        }

        public HGCaptcha getHGCaptcha()
        {
            String captchaUrl = "/platform/login/getImage";
            // HGCaptcha hgc = new HGCaptcha();
            String res = HttpHelper.HttpPostData(BaseUrl + captchaUrl, null);
            if (res != null)
            {
                HGResponse<HGCaptcha> hgr = JsonNewtonsoft.FromJSON<HGResponse<HGCaptcha>>(res);
                return hgr.Data;
            }
            return null;
        }
    }
    
}
