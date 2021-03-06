﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;
using System.Windows.Forms;
using HGSystem.UserControls;
using HGSystem.Model;

namespace HGSystem
{
    public partial class AlbumInfo : UserControl
    {        
        private HGAlbumItem m_hgai;
        private ContentPublishPanel.AlbumType m_album_type;

        public AlbumInfo(ContentPublishPanel.AlbumType album_type, HGAlbumItem hgai)
        {
            InitializeComponent();
            m_album_type = album_type;
            m_hgai = hgai;            
        }

        public Image AlbumImage { set { if (value != null) m_pbx_album.Image = value; } }
        public String AlbumName { set { if (value != null) m_lbl_album.Text = value; } }

        public delegate void ClickEventHandlerDelegate(ContentPublishPanel.AlbumType at, HGAlbumItem hgai);
        public ClickEventHandlerDelegate ClickEventHandler { get; set; }

        private void m_pbx_album_Click(object sender, EventArgs e)
        {
            if (ClickEventHandler != null)
                ClickEventHandler(m_album_type, m_hgai);
        }
    }
}
