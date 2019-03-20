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

        public void Init(Image img, String text)
        {
            m_pbx_album.Image = img;
            m_lbl_album.Text = text;
        }
    }
}
