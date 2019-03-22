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
    public partial class MoreAlbums : UserControl
    {
        public MoreAlbums()
        {
            InitializeComponent();
        }
        public void SetAlbumTypeName(String album_type_name)
        {
            m_lbl_albumtypename.Text = album_type_name;
        }
    }
}
