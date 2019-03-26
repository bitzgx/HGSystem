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
    public partial class ProgramItemRow : UserControl
    {
        private HGProgramItem m_hgi;
        private int m_index = 0;
        public ProgramItemRow(int index, HGProgramItem hgi)
        {
            InitializeComponent();
            m_index = index;
            m_hgi = hgi;
            m_lbl_no.Text = m_index.ToString();
            // m_lbl_name.Text = hgi.Name;
            m_lbl_name.Text = hgi.MaterialName;
            // m_lbl_timelen.Text = getTimeLen(hgi.TimeLen);
            m_lbl_timelen.Text = getTimeLen(hgi.MaterialDuration);
            // m_lbl_cat.Text = hgi.Category;
            m_lbl_cat.Text = hgi.MaterialAlbumCategoryName;
            // m_lbl_createat.Text = hgi.CreatedAt.ToShortDateString();
            m_lbl_createat.Text = Helpers.Util.ConvertLongToDateTime(hgi.MaterialCtime).ToShortDateString();
            // m_lbl_play_times.Text = getAmount(hgi.PlayAmount);
            m_lbl_play_times.Text = hgi.LikeCount;
            // m_lbl_share_times.Text = getAmount(hgi.ShareAmount);
            m_lbl_share_times.Text = hgi.LikeCount;
        }

        private String getAmount(int amount)
        {
            if (amount >= 10000)
            {
                String amountStr = "" + (amount / 10000) + "万";
                return amountStr;
            }
            return amount.ToString();
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
        private void m_lbl_name_Click(object sender, EventArgs e)
        {

        }

        private void m_pbx_delete_Click(object sender, EventArgs e)
        {

        }

        private void m_pbx_share_Click(object sender, EventArgs e)
        {

        }
    }
}
