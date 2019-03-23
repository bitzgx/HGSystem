using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HGSystem.UserControls;
using HGSystem.UI;

namespace HGSystem.UserControls
{
    public partial class AlbumListPanel : UserControl
    {
        private IList<AlbumInfo> m_albums = new List<AlbumInfo>();
        private ContentPublishPanel.AlbumType m_album_type = ContentPublishPanel.AlbumType.VideoAlbum;

        public ContentPublishPanel.SwitchToMoreAlbumsPanel SwitchToMAP {get; set;}

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
        public AlbumListPanel(ContentPublishPanel.AlbumType album_type)
        {
            InitializeComponent();
            this.PanelAlbumType = album_type;
        }

        private void LoadAlbums()
        {
            for (int i = 0; i < 10; i++)
            {
                AlbumInfo ai = new AlbumInfo(m_album_type);

                if (i == 0)
                {
                    ai.ClickEventHandler += NewAlbum;
                    ai.AlbumName = "新建专辑";
                }
                else
                    ai.ClickEventHandler += ShowAlbumDetail;
                
                m_albums.Add(ai);
            }
        }

        private void NewAlbum(ContentPublishPanel.AlbumType album_type)
        {
            NewAlbumForm naf = new NewAlbumForm(album_type);
            // OpacityWindow naf2 = new OpacityWindow(naf);
            // naf2.ShowDialog();
            naf.ShowDialog();
            // naf2.Close();
        }

        private void ShowAlbumDetail(ContentPublishPanel.AlbumType album_type)
        {
            MessageBox.Show("显示专辑详情");
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

        private void AlbumListPanel_Load(object sender, EventArgs e)
        {
            LoadAlbums();
            ShowAlbums();
        }

        private void m_lbl_morealbum_Click(object sender, EventArgs e)
        {
            if (SwitchToMAP != null)
                SwitchToMAP(m_album_type);
        }
    }
}
