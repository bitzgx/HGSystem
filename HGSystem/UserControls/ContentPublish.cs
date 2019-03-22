using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;
using System.Windows.Forms;
using HGSystem.UserControls;

namespace HGSystem
{
    public partial class ContentPublish : UserControl
    {
        public enum AlbumType { AllAlbum, VideoAlbum, AudioAlbum }

        private AlbumListPanel m_alp_video;
        private AlbumListPanel m_alp_audio;
        private MoreAlbumsPanel m_map;

        public delegate void SwitchToMoreAlbumsPanel(ContentPublish.AlbumType at);

        public ContentPublish()
        {
            InitializeComponent();
        }

        private void SwitchToMAP(ContentPublish.AlbumType at)
        {
            if (at == ContentPublish.AlbumType.AllAlbum)
            {
                if (m_map != null) m_map.Hide();
                if (m_alp_video != null) m_alp_video.Show();
                if (m_alp_audio != null) m_alp_audio.Show();
                return;
            }
            else
            {
                m_alp_video.Hide();
                m_alp_audio.Hide();
                if (m_map == null)
                {
                    m_map = new MoreAlbumsPanel();
                    m_map.SwitchToMAP = SwitchToMAP;
                    this.Controls.Add(m_map);
                    m_map.Size = new Size(1200, 600);
                    m_map.Location = new Point(0, 50);
                    m_map.BringToFront();
                }
                m_map.PanelAlbumType = at;
                m_map.Show();
            }
        }

        private void ContentPublish_Load(object sender, EventArgs e)
        {
            m_alp_video = new AlbumListPanel(ContentPublish.AlbumType.VideoAlbum);            
            m_alp_video.SwitchToMAP = SwitchToMAP;
            this.Controls.Add(m_alp_video);
            m_alp_audio = new AlbumListPanel(ContentPublish.AlbumType.AudioAlbum);
            m_alp_audio.SwitchToMAP = SwitchToMAP;
            this.Controls.Add(m_alp_audio);
            m_alp_video.Size = new Size(1200, 500);
            m_alp_video.Location = new Point(0, 50);
            m_alp_audio.Size = new Size(1200, 500);
            m_alp_audio.Location = new Point(0, 550);

            // this.AutoScroll = true;
            // this.VerticalScroll.Maximum = 1200;
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
        }

        private void ShowAlbumDetail(String id)
        {
            MessageBox.Show("显示专辑");
        }
    }
}
