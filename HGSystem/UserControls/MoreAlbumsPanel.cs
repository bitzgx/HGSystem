using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HGSystem.UserControls;

namespace HGSystem.UserControls
{
    public partial class MoreAlbumsPanel : UserControl
    {
        public ContentPublish.SwitchToMoreAlbumsPanel SwitchToMAP { get; set; }
        private ContentPublish.AlbumType m_album_type = ContentPublish.AlbumType.VideoAlbum;
        public ContentPublish.AlbumType PanelAlbumType
        {
            get { return m_album_type; }
            set
            {
                m_album_type = value;
                if (m_album_type == ContentPublish.AlbumType.VideoAlbum)
                {
                    m_lbl_albumtypename.Text = "视频专辑";
                }
                else
                {
                    m_lbl_albumtypename.Text = "音频专辑";
                }
            }
        }
        public MoreAlbumsPanel()
        {
            InitializeComponent();
        }

        private void m_lbl_back_Click(object sender, EventArgs e)
        {
            if (SwitchToMAP != null)
                SwitchToMAP(ContentPublish.AlbumType.AllAlbum);
        }
    }
}
