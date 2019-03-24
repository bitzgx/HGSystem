using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HGSystem.UserControls
{
    public partial class NavigationBar : UserControl
    {
        public NavigationBar()
        {
            InitializeComponent();
        }
        public ContentPublishPanel.SwitchToMoreAlbumsPanel SwitchToMAP { get; set; }

        public ContentPublishPanel.AlbumType PanelAlbumType { get; set; }

        private void m_lbl_back_Click(object sender, EventArgs e)
        {
            if (SwitchToMAP != null)
                SwitchToMAP(PanelAlbumType);
        }
    }
}
