using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HGSystem.Model;

namespace HGSystem
{
    public class HGRestfulAPI
    {
        private static HGRestfulAPI m_hg_restfulapi = new HGRestfulAPI();
        private HGRestfulAPI()
        {
        }

        public static HGRestfulAPI getInstance()
        {
            return m_hg_restfulapi;
        }

        public HGCaptcha getHGCaptcha()
        {
            HGCaptcha hgc = new HGCaptcha();
            HttpHelper hh = new HttpHelper();
            ResponseModel rm = hh.HttpVisit("https://edutest.hongkazhijia.com/platform/login/getImage", true, null, 0);
            // ResponseModel rm = hh.HttpVisit("http://www.baidu.com");
            Console.WriteLine("res:" + rm.Html);
            return hgc;
            /*
            byte[] bytes = Convert.FromBase64String(base64);
            MemoryStream memStream = new MemoryStream(bytes);
            BinaryFormatter binFormatter = new BinaryFormatter();
            Image img = (Image)binFormatter.Deserialize(memStream);
            this.pictureBox.Image = img;
             */
        }
    }
}
