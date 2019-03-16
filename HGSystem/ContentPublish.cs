using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HGSystem
{
    public partial class ContentPublish : UserControl
    {
        public ContentPublish()
        {
            InitializeComponent();
        }

        private void ContentPublish_Load(object sender, EventArgs e)
        {
            AlbumInfo ai = new AlbumInfo();
            ai.Location = new Point(10, 150);
            this.Controls.Add(ai);
        }
    }
}
