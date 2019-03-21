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
            loadVideoAlbums();
            displayVideoAlbums();
        }

        private void loadVideoAlbums()
        {
            for (int i = 0; i < 10; i++)
            {
                AlbumInfo ai = new AlbumInfo();
                m_video_albums.Add(ai);
            }
        }
        private void loadAudioAlbums()
        {
            for (int i = 0; i < 10; i++)
            {
                AlbumInfo ai = new AlbumInfo();
                m_audio_albums.Add(ai);
            }
        }

        private void displayVideoAlbums()
        {
            for (int i = 0; i < m_video_albums.Count; i++)
            {
                AlbumInfo ai = m_video_albums[i];
                
                ai.Location = new Point(50 + 220 * (i % 5), 110 + 220 * (i / 5));                

                this.Controls.Add(ai);
            }
        }

        private void displayAudioAlbums()
        {
            for (int i = 0; i < m_audio_albums.Count; i++)
            {
                AlbumInfo ai = m_audio_albums[i];

                ai.Location = new Point(50 + 220 * (i % 5), 410 + 220 * (i / 5));

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
    }
}
