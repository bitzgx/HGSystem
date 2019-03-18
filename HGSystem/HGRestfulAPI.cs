using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HGSystem.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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

        public void login(string _mobile, string _password, string _vcode, string _vtoken)
        {
            String captchaUrl = "/platform/school/ymsLogin";
            String postData = "mobile=" + _mobile + "&password=" + _password + "&vcode=" + _vcode + "&vtoken" + _vtoken;
            // HGCaptcha hgc = new HGCaptcha();
            postData = "{\"mobile\":\"13488613602\",\"password\":\"7b490bbb31fb36019a941d64d6077e07\",\"vcode\":\"eq32\",\"vtoken\":\"f3697b30-a5c7-46db-ae7b-140e7a1037f1\"}";
            String res = HttpHelper.HttpPostJsonData(BaseUrl + captchaUrl, postData);
            if (res != null)
            {
                //TODO: HGResponse<HGCaptcha> hgr = JsonNewtonsoft.FromJSON<HGResponse<HGCaptcha>>(res);
            }
        }

        public Bitmap GetBitmapFromBase64(string base64string)
        {
            byte[] b = Convert.FromBase64String(base64string);
            MemoryStream ms = new MemoryStream(b);
            Bitmap bitmap = new Bitmap(ms);
            return bitmap;
        }

        public Image GetImageFromBase64(string base64string)
        {
            byte[] bytes = Convert.FromBase64String(base64string);
            MemoryStream memStream = new MemoryStream(bytes);
            BinaryFormatter binFormatter = new BinaryFormatter();
            Image img = (Image)binFormatter.Deserialize(memStream);
            return img;
            // this.pictureBox.Image = img;
        }
        public string GetBase64FromImage(string imagefile)
        {
            string strbaser64 = "";
            try
            {
                Bitmap bmp = new Bitmap(imagefile);
                MemoryStream ms = new MemoryStream();
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arr = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(arr, 0, (int)ms.Length);
                ms.Close();
                strbaser64 = Convert.ToBase64String(arr);
            }
            catch (Exception)
            {
                throw new Exception("Something wrong during convert!");
            }
            return strbaser64;
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
