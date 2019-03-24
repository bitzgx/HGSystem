using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HGSystem.Model;

namespace HGSystem.UserControls
{
    public partial class SearchBar : UserControl
    {
        public SearchBar()
        {
            InitializeComponent();
        }

        private void m_btn_search_Click(object sender, EventArgs e)
        {
            // HGRestfulAPI.getInstance().getHGAlbum(1, "", 2, 1521738981174, 1541738981174, 1, 10);
        }

        private void SearchBar_Load(object sender, EventArgs e)
        {
            // TODO: 根据界面参数来生成搜索参数
            HGAlbumSearchParams hgasp = new HGAlbumSearchParams(1, 10);
            HGData.getInstance().Album = HGRestfulAPI.getInstance().getHGAlbum(hgasp);
            // HGAlbum hga = HGRestfulAPI.getInstance().getHGAlbum(1, "", 2, 1521738981174, 1541738981174, 1, 10);
        }
    }
}
