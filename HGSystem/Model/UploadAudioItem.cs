using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HGSystem.Model
{
    public class UploadAudioItem
    {
        public String AudioType { get; set; }
        public String AudioName { get; set; }
        public int AudioTimeLen { get; set; }
        public String FileName { get; set; }
        public UploadAudioItem(String audiotype, String audioname, int audio_timelen, String filename) 
        {
            AudioType = audiotype;
            AudioName = audioname;
            AudioTimeLen = audio_timelen;
            FileName = filename;
        }
    }
}
