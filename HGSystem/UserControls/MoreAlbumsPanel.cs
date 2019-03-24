using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HGSystem.UserControls;
using HGSystem.Model;
using System.IO;
using HGSystem.Helpers;

namespace HGSystem.UserControls
{
    public partial class MoreAlbumsPanel : UserControl
    {
        private IList<AlbumInfo> m_albums = new List<AlbumInfo>();
        private const int AlbumsPerPage = 10;
        public ContentPublishPanel.SwitchToMoreAlbumsPanel SwitchToMAP { get; set; }
        public ContentPublishPanel.SubControlHeightChagned HeightChanged { get; set; }
        private ContentPublishPanel.AlbumType m_album_type = ContentPublishPanel.AlbumType.VideoAlbum;
        public ContentPublishPanel.AlbumType PanelAlbumType
        {
            get { return m_album_type; }
            set
            {
                m_album_type = value;
                if (m_album_type == ContentPublishPanel.AlbumType.VideoAlbum)
                {
                    m_lbl_albumtypename.Text = "视频专辑";
                }
                else
                {
                    m_lbl_albumtypename.Text = "音频专辑";
                }
            }
        }
        public MoreAlbumsPanel()
        {
            InitializeComponent();
            m_pgc_morealbum.RowsPerPage = AlbumsPerPage;
        }

        private void m_lbl_back_Click(object sender, EventArgs e)
        {
            if (SwitchToMAP != null)
                SwitchToMAP(ContentPublishPanel.AlbumType.AllAlbum);
        }

        private void LoadAlbums(int current_page = 1)
        {
            HGAlbumSearchParams hgasp = new HGAlbumSearchParams(current_page, m_pgc_morealbum.RowsPerPage);
            HGData.getInstance().Album = HGRestfulAPI.getInstance().getHGAlbum(hgasp);
            HGAlbum hga = HGData.getInstance().Album;
            if (hga == null)
                return;
            m_pgc_morealbum.RecordCount = hga.Total;
            // int total_page = (hga.Total - 1) / m_pgc_morealbum.RowsPerPage + 1;
            // m_pgc_morealbum.TotalPage = total_page;
            m_pgc_morealbum.CurrentPage = current_page;

            foreach (AlbumInfo ai in m_albums) 
                this.Controls.Remove(ai);
            m_albums.Clear();
            for (int i = 0; i < hga.Data.Length; i++)
            {

                HGAlbumItem hgai = hga.Data[i];
                /*
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
                }*/
                AlbumInfo ai = new AlbumInfo(m_album_type);
                ai.AlbumName = hgai.AlbumName;
                if (!String.IsNullOrEmpty(hgai.FileUrl))
                {
                    try
                    {
                        MemoryStream ms = new MemoryStream();
                        Util.Download(HGRestfulAPI.FileServerBaseUrl + hgai.FileUrl, ms);
                        ai.AlbumImage = Image.FromStream(ms);
                    }
                    catch (Exception ex)
                    {
                        //TODO; don't do that, just log
                        MessageBox.Show("下载网络图片" + hgai.FileUrl + "失败：" + ex.Message);
                    }
                }
                ai.ClickEventHandler += ShowAlbumDetail;

                m_albums.Add(ai);
            }
            ShowAlbums();
        }
                
        private void ShowAlbums()
        {
            int albums_count = m_albums.Count > m_pgc_morealbum.RowsPerPage ? m_pgc_morealbum.RowsPerPage : m_albums.Count;            
            for (int i = 0; i < albums_count; i++)
            {
                AlbumInfo ai = m_albums[i];

                ai.Location = new Point(50 + 220 * (i % 5), 60 + 220 * (i / 5));

                this.Controls.Add(ai);
            }
            m_pgc_morealbum.Location = new Point(600, 70 + 220 * ((albums_count - 1)/ 5) + 220);
            if (HeightChanged != null)
                HeightChanged(70 + 220 * ((albums_count - 1) / 5) + 220 + m_pgc_morealbum.Height + 20);
        }
        private void ShowAlbumDetail(ContentPublishPanel.AlbumType album_type)
        {
            MessageBox.Show("显示专辑详情");
        }

        private void MoreAlbumsPanel_Load(object sender, EventArgs e)
        {
            LoadAlbums();
        }

        private void m_pgc_morealbum_PageChange()
        {
            // MessageBox.Show("Page change");
            Console.WriteLine("Page change");
            LoadAlbums();            
        }
    }
}
