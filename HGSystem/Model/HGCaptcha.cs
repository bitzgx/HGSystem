using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;

namespace HGSystem.Model
{
    public class HGCaptcha
    {
        private String vtoken;
        private String img;

        public String Vtoken { get; set; }
        public String Img { get; set; }

        public HGCaptcha(String _vtoken, String _img) { vtoken = _vtoken; img = _img; }
        public HGCaptcha() { }
    }
}
