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
        private IList<AlbumInfo> m_albums = new List<AlbumInfo>();

        public ContentPublishPanel.SwitchToMoreAlbumsPanel SwitchToMAP { get; set; }
        private ContentPublishPanel.AlbumType m_album_type = ContentPublishPanel.AlbumType.VideoAlbum;
        public ContentPublishPanel.AlbumType PanelAlbumType
        {
            get { return m_album_type; }
            set
            {
                m_album_type = value;
                if (m_album_type == ContentPublishPanel.AlbumType.VideoAlbum)
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
                SwitchToMAP(ContentPublishPanel.AlbumType.AllAlbum);
        }

        private void LoadAlbums()
        {
            for (int i = 0; i < 10; i++)
            {
                AlbumInfo ai = new AlbumInfo(m_album_type);
                ai.ClickEventHandler += ShowAlbumDetail;

                m_albums.Add(ai);
            }
        }
        private void ShowAlbums()
        {
            int albums_count = m_albums.Count > 10 ? 10 : m_albums.Count;
            for (int i = 0; i < albums_count; i++)
            {
                AlbumInfo ai = m_albums[i];

                ai.Location = new Point(50 + 220 * (i % 5), 60 + 220 * (i / 5));

                this.Controls.Add(ai);
            }
        }
        private void ShowAlbumDetail(ContentPublishPanel.AlbumType album_type)
        {
            MessageBox.Show("显示专辑详情");
        }


        private void MoreAlbumsPanel_Load(object sender, EventArgs e)
        {
            LoadAlbums();
            ShowAlbums();
        }
    }
}
