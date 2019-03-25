using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using HGSystem.Model;

namespace HGSystem.UserControls
{
    public class ContentPublishPanel: PanelWithoutAutoScroll
    {
        public enum AlbumType { AllAlbum = 0, AudioAlbum = 1, VideoAlbum = 2 }
        private AlbumType m_current_album_type;

        private SearchBar m_searchbar;
        private AlbumListPanel m_alp_video;
        private AlbumListPanel m_alp_audio;
        private MoreAlbumsPanel m_map;

        private NavigationBar m_ctl_navbar;
        private ProgramPanel m_ctl_program;

        private int m_searchbar_y = 20;        
        private int m_subcontrol_width = 1160;        
        private int m_alp_height = 500;
        private int m_map_height = 600;

        public delegate void SwitchToMoreAlbumsPanel(ContentPublishPanel.AlbumType at);
        public delegate void SubControlHeightChagned(int height);
        public delegate void SwitchToProgramPanel();

        public ContentPublishPanel()
        {
            ContentPublishPanel_Load();
        }

        private void HeightChanged(int height)
        {
            m_map.Size = new Size(m_subcontrol_width, height);
        }

        private void SwitchToMAP(ContentPublishPanel.AlbumType at)
        {
            m_current_album_type = at;
            if (m_ctl_navbar != null) m_ctl_navbar.Hide();
            if (m_ctl_program != null) m_ctl_program.Hide();
            if (m_searchbar != null) m_searchbar.Show();
            if (at == ContentPublishPanel.AlbumType.AllAlbum)
            {
                if (m_map != null) m_map.Hide();
                if (m_alp_video != null) m_alp_video.Show();
                if (m_alp_audio != null) m_alp_audio.Show();
                // Use AutoScrollMinSize instead of AutoScroll可以帮助优化弹出MessageBox之后直接往上跳的情况，但是不能完全解决。
                // this.AutoScrollMinSize = new Size(ClientRectangle.Width, ClientRectangle.Height);
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
                    m_map.SwitchToPP = SwitchToPP;
                    m_map.HeightChanged = HeightChanged;
                    m_map.Size = new Size(m_subcontrol_width, m_map_height);
                    m_map.Location = new Point(0, m_searchbar_y + m_searchbar.Height);
                    this.Controls.Add(m_map);
                    m_map.BringToFront();

                }
                m_map.PanelAlbumType = at;
                m_map.Show();
                // Use AutoScrollMinSize instead of AutoScroll可以帮助优化弹出MessageBox之后直接往上跳的情况，但是不能完全解决。
                // this.AutoScrollMinSize = new Size(ClientRectangle.Width, ClientRectangle.Height);
                // this.AutoScroll = true;
            }
        }

        private void SwitchToPP()
        {
            // System.Windows.Forms.MessageBox.Show("显示专辑详情");
            if (m_ctl_navbar == null)
            {
                m_ctl_navbar = new NavigationBar();
                m_ctl_navbar.SwitchToMAP = SwitchToMAP;
                this.Controls.Add(m_ctl_navbar);
                m_ctl_navbar.Size = new Size(this.Width, m_ctl_navbar.Height); // TODO:
                m_ctl_navbar.Location = new Point(0, m_searchbar_y);                
            }
            if (m_ctl_program == null)
            {
                m_ctl_program = new ProgramPanel();
                this.Controls.Add(m_ctl_program);
                if (m_ctl_program.SuggestedHeight >= 600)
                {
                    m_ctl_program.Size = new Size(m_subcontrol_width, m_ctl_program.SuggestedHeight);
                    m_ctl_navbar.Size = new Size(m_subcontrol_width, m_ctl_navbar.Height); // TODO:
                }
                else
                    m_ctl_program.Size = new Size(this.Width, m_ctl_program.SuggestedHeight);
                m_ctl_program.Location = new Point(0, m_searchbar_y + m_ctl_navbar.Height);
            }

            if (m_searchbar != null) m_searchbar.Hide();
            if (m_map != null) m_map.Hide();
            if (m_alp_video != null) m_alp_video.Hide();
            if (m_alp_audio != null) m_alp_audio.Hide();
            m_ctl_navbar.PanelAlbumType = m_current_album_type;
            m_ctl_navbar.Show();
            m_ctl_program.Show();
            m_ctl_navbar.BringToFront();
            m_ctl_program.BringToFront();
        }

        private void ContentPublishPanel_Load()
        {
            m_searchbar = new SearchBar();

            this.Controls.Add(m_searchbar);
            m_searchbar.Size = new Size(m_subcontrol_width, m_searchbar.Height);
            m_searchbar.Location = new Point(0, m_searchbar_y);

            m_alp_video = new AlbumListPanel(ContentPublishPanel.AlbumType.VideoAlbum);
            m_alp_video.SwitchToMAP = SwitchToMAP;
            m_alp_video.SwitchToPP = SwitchToPP;
            this.Controls.Add(m_alp_video);
            m_alp_audio = new AlbumListPanel(ContentPublishPanel.AlbumType.AudioAlbum);
            m_alp_audio.SwitchToMAP = SwitchToMAP;
            m_alp_audio.SwitchToPP = SwitchToPP;
            this.Controls.Add(m_alp_audio);
            m_alp_video.Size = new Size(m_subcontrol_width, m_alp_height);
            m_alp_video.Location = new Point(0, m_searchbar_y + m_searchbar.Height);
            m_alp_audio.Size = new Size(m_subcontrol_width, m_alp_height);
            m_alp_audio.Location = new Point(0, m_searchbar_y + m_searchbar.Height + m_alp_height);

            // Use AutoScrollMinSize instead of AutoScroll可以帮助优化弹出MessageBox之后直接往上跳的情况，但是不能完全解决。
            // this.AutoScrollMinSize = new Size(ClientRectangle.Width, ClientRectangle.Height);
            //this.AutoScroll = true;

            // this.VerticalScroll.Maximum = 1200;
            displayAlbums();
        }

        public void displayAlbums()
        {
            HGAlbum hga = HGData.getInstance().Album;
            if (hga == null)
                return;
            for (int i = 0; i < hga.Data.Length; i++)
            {
                HGAlbumItem hgai = hga.Data[i];
                AlbumType at = (AlbumType)hgai.AlbumType;
                if (at == AlbumType.AudioAlbum) 
                { 
                    Console.WriteLine("Audio : " + hga.Data[i].AlbumName + " Url: " + hga.Data[i].FileUrl);
                    m_alp_audio.addAlbum(hga.Data[i]);
                }
                else if (at == AlbumType.VideoAlbum)
                {
                    Console.WriteLine("Video : " + hga.Data[i].AlbumName + " Url: " + hga.Data[i].FileUrl);
                    m_alp_video.addAlbum(hga.Data[i]);
                }
                
            }
        }
    }
}
