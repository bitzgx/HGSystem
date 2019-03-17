using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HGSystem.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace HGSystem
{
    public class HGRestfulAPI
    {
        private static String BaseUrl = "https://edutest.hongkazhijia.com";
        private static HGRestfulAPI m_hg_restfulapi = new HGRestfulAPI();
        private HGRestfulAPI()
        {
        }

        public static HGRestfulAPI getInstance()
        {
            return m_hg_restfulapi;
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
            HGCaptcha hgc = new HGCaptcha();
            String res = HttpHelper.HttpPostData(BaseUrl + captchaUrl, null);
            if (res != null)
            {
                JavaScriptObject jso = JavaScriptConvert.DeserializeObject<JavaScriptObject>(res);
                if (jso.ContainsKey("status") && jso["status"] != null)
                {
                    Console.WriteLine("status is " + jso["status"]);
                }
                if (jso.ContainsKey("msg") && jso["msg"] != null)
                {
                    Console.WriteLine("msg is " + jso["msg"]);
                }
                if (jso.ContainsKey("time") && jso["time"] != null)
                {
                    Console.WriteLine("time is " + jso["time"]);
                }
                if (jso.ContainsKey("data") && jso["data"] != null)
                {
                    // Console.WriteLine("data is " + jso["data"]);
                    JavaScriptObject jso2 = (JavaScriptObject)jso["data"];// JavaScriptConvert.DeserializeObject<JavaScriptObject>(jso["data"].ToString());

                    if (jso2.ContainsKey("vtoken") && jso2["vtoken"] != null)
                    {
                        Console.WriteLine("vtoken is " + jso2["vtoken"]);
                        hgc.Vtoken = (string)jso2["vtoken"];
                    }
                    if (jso2.ContainsKey("img") && jso2["img"] != null)
                    {
                        Console.WriteLine("img is " + jso2["img"]);
                        hgc.Img = (string)jso2["img"];
                    }
                }
            }
            return hgc;
        }
    }
}
