﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;


namespace HGSystem.UserControls
{
    public class ContentPublishPanel: PanelWithoutAutoScroll
    {
        public enum AlbumType { AllAlbum, VideoAlbum, AudioAlbum }

        private SearchBar m_searchbar;
        private AlbumListPanel m_alp_video;
        private AlbumListPanel m_alp_audio;
        private MoreAlbumsPanel m_map;
        private int m_searchbar_y = 20;        
        private int m_subcontrol_width = 1160;
        private int m_alp_height = 500;
        private int m_map_height = 600;

        public delegate void SwitchToMoreAlbumsPanel(ContentPublishPanel.AlbumType at);

        public ContentPublishPanel()
        {
            ContentPublishPanel_Load();
        }

        private void SwitchToMAP(ContentPublishPanel.AlbumType at)
        {
            if (at == ContentPublishPanel.AlbumType.AllAlbum)
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
                    m_map.Size = new Size(m_subcontrol_width, m_map_height);
                    m_map.Location = new Point(0, m_searchbar_y + m_searchbar.Height);
                    m_map.BringToFront();
                }
                m_map.PanelAlbumType = at;
                m_map.Show();
            }
        }

        private void ContentPublishPanel_Load()
        {
            m_searchbar = new SearchBar();

            this.Controls.Add(m_searchbar);
            m_searchbar.Size = new Size(m_subcontrol_width, m_searchbar.Height);
            m_searchbar.Location = new Point(0, m_searchbar_y);

            m_alp_video = new AlbumListPanel(ContentPublishPanel.AlbumType.VideoAlbum);
            m_alp_video.SwitchToMAP = SwitchToMAP;
            this.Controls.Add(m_alp_video);
            m_alp_audio = new AlbumListPanel(ContentPublishPanel.AlbumType.AudioAlbum);
            m_alp_audio.SwitchToMAP = SwitchToMAP;
            this.Controls.Add(m_alp_audio);
            m_alp_video.Size = new Size(m_subcontrol_width, m_alp_height);
            m_alp_video.Location = new Point(0, m_searchbar_y + m_searchbar.Height);
            m_alp_audio.Size = new Size(m_subcontrol_width, m_alp_height);
            m_alp_audio.Location = new Point(0, m_searchbar_y + m_searchbar.Height + m_alp_height);

            // Use AutoScrollMinSize instead of AutoScroll可以帮助优化弹出MessageBox之后直接往上跳的情况，但是不能完全解决。
            this.AutoScrollMinSize = new Size(ClientRectangle.Width, ClientRectangle.Height);
            // this.AutoScroll = true;

            // this.VerticalScroll.Maximum = 1200;
        }
    }
}