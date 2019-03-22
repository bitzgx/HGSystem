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
    public partial class AlbumInfo : UserControl
    {
        public AlbumInfo()
        {
            InitializeComponent();
        }

        public Image AlbumImage { set { if (value != null) m_pbx_album.Image = value; } }
        public String AlbumName { set { if (value != null) m_lbl_album.Text = value; } }
        
        public delegate void ClickEventHandlerDelegate(String id);
        public ClickEventHandlerDelegate ClickEventHandler { get; set; }

        private void m_pbx_album_Click(object sender, EventArgs e)
        {
            if (ClickEventHandler != null)
                ClickEventHandler("hello");
        }
    }
}
