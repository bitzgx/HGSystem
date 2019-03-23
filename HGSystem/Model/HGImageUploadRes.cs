using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HGSystem.Model
{
    public class HGImageUploadData
    {
        public String FileId {get; set;}
        public String RealUrl {get; set;}
        public String FileName {get; set;}
        public int Duration {get; set;}
        public int[] Wh { get; set;}
        public String Thumbnail { get; set; }
    }
    public class HGImageUploadRes
    {
        public int Status { get; set; }
        public String Url {get; set;}
        public String ComputedHash {get; set;}
        public String LocalPath {get; set;}
        public int Size {get; set;}
        public HGImageUploadData Data { get; set; }
    }
}
