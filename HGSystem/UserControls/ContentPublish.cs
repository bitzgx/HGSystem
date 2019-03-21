using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;
using System.Windows.Forms;

namespace HGSystem
{
    public partial class ContentPublish : UserControl
    {
        private IList<AlbumInfo> m_video_albums = new List<AlbumInfo>();
        private IList<AlbumInfo> m_audio_albums = new List<AlbumInfo>();

        public ContentPublish()
        {
            InitializeComponent();
        }

        private void ContentPublish_Load(object sender, EventArgs e)
        {
            // this.AutoScroll = true;
            // this.VerticalScroll.Maximum = 1200;
            loadVideoAlbums();
            loadAudioAlbums();
            displayVideoAlbums();
            displayAudioAlbums();
        }

        private void loadVideoAlbums()
        {
            for (int i = 0; i < 10; i++)
            {
                AlbumInfo ai = new AlbumInfo();
                if (i == 0)
                    ai.ClickEventHandler += NewAlbum;
                else
                    ai.ClickEventHandler += ShowAlbumDetail;
                m_video_albums.Add(ai);
            }
        }
        private void loadAudioAlbums()
        {
            for (int i = 0; i < 10; i++)
            {
                AlbumInfo ai = new AlbumInfo();                
                if (i == 0)
                    ai.ClickEventHandler += NewAlbum;
                else
                    ai.ClickEventHandler += ShowAlbumDetail;
                m_audio_albums.Add(ai);
            }
        }

        private void displayVideoAlbums()
        {
            for (int i = 0; i < m_video_albums.Count; i++)
            {
                AlbumInfo ai = m_video_albums[i];
                
                ai.Location = new Point(50 + 220 * (i % 5), 60 + 220 * (i / 5));                

                this.Controls.Add(ai);
            }
        }

        private void displayAudioAlbums()
        {
            for (int i = 0; i < m_audio_albums.Count; i++)
            {
                AlbumInfo ai = m_audio_albums[i];

                ai.Location = new Point(50 + 220 * (i % 5), 560 + 220 * (i / 5));

                this.Controls.Add(ai);
            }
        }

        private void m_lbl_morevideo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("更多视频");
        }

        private void m_lbl_moreaudio_Click(object sender, EventArgs e)
        {
            MessageBox.Show("更多音频");
        }

        private void NewAlbum(String id)
        {
            MessageBox.Show("新增专辑");
            this.Focus();
        }

        private void ShowAlbumDetail(String id)
        {
            MessageBox.Show("显示专辑");
        }
    }
}
