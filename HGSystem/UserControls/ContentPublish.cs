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
        private AlbumListPanel m_alp_video;
        private AlbumListPanel m_alp_audio;

        public ContentPublish()
        {
            InitializeComponent();
        }

        private void ContentPublish_Load(object sender, EventArgs e)
        {
            m_alp_video = new AlbumListPanel(AlbumListPanel.AlbumType.VideoAlbum);            
            this.Controls.Add(m_alp_video);
            m_alp_audio = new AlbumListPanel(AlbumListPanel.AlbumType.AudioAlbum);
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
