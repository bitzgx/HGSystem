using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HGSystem.Model;

namespace HGSystem.UserControls
{
    public partial class UCUploadAudioItem : UserControl
    {
        public UploadAudioItem UploadAudioItem{ get; set; }
        public UCUploadAudioItem(UploadAudioItem uai)
        {
            InitializeComponent();

            UploadAudioItem = uai;
            m_lbl_name.Text = UploadAudioItem.AudioName;
            m_lbl_timelen.Text = getTimeLen(UploadAudioItem.AudioTimeLen);
        }

        private String getTimeLen(int timelen)
        {
            String timeStr = "";
            if (timelen >= 3600)
            {
                timeStr += "" + (timelen / 3600) + "时";
            }
            timelen %= 3600;
            if (timelen >= 60)
            {
                timeStr += "" + (timelen / 60) + "分";
            }
            timelen %= 60;
            timeStr += "" + timelen + "秒";
            return timeStr;
        }
    }
}
