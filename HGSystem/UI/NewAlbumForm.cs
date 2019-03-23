using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using HGSystem.Model;
using HGSystem.UserControls;

namespace HGSystem.UI
{
    public partial class NewAlbumForm : Form
    {
        private HGImageUploadRes m_hg_iur;
        private ContentPublishPanel.AlbumType m_album_type;
        public NewAlbumForm(ContentPublishPanel.AlbumType album_type)
        {
            InitializeComponent();
            m_album_type = album_type;
        }

        private void m_bte_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_bte_add_Click(object sender, EventArgs e)
        {
            String albumName = m_tbx_albumname.Text;
            String albumLabel = m_tbx_albumtags.Text;
            String albumIntro = m_tbx_albumintro.Text;
            if (String.IsNullOrEmpty(albumName))
            {
                MessageBox.Show("专辑名称不能为空");
                m_tbx_albumname.Focus();
                return;
            }
            // TODO: 判断是否选择了category
            String albumCategoryId = "[10000000, 10001000, 10001001]";
            // TODO: 是否一定要封面？
            if (m_hg_iur == null)
            {
                MessageBox.Show("请上传专辑封面");
                return;
            }
            String albumCoverUrl = HGRestfulAPI.FileServerBaseUrl + m_hg_iur.Url;
            String albumFileId = m_hg_iur.Data.FileId;
            Model.HGAlbumParams hgap = new HGAlbumParams(albumName, (int)m_album_type, albumIntro, albumCoverUrl, albumFileId, albumLabel, 10000000, 10001000, 10000001);
            if (Helpers.DebugHelper.getInstance().FakeNewAlbum)
            {
                hgap = new HGAlbumParams("70周年大阅兵7", (int)m_album_type, "70周年大阅兵，简介", "https://filetest.hongkazhijia.com/cb/cb7a88314621ad93ce4f9c5fe0495c942953197489e01f925162314153baa0a2.jpg", "cb7a88314621ad93ce4f9c5fe0495c942953197489e01f925162314153baa0a2", "70周年", 10000000, 10001000, 10000001);
            }
            try
            {
                // bool newAlbumOK = HGRestfulAPI.getInstance().newHGAlbum(albumName, 1, albumIntro, albumCoverUrl, albumFileId, albumLabel, albumCategoryId);
                bool newAlbumOK = HGRestfulAPI.getInstance().newHGAlbum(hgap);
                if (newAlbumOK)
                    MessageBox.Show("专辑《" + albumName + "》创建成功");
                else
                    MessageBox.Show("专辑《" + albumName + "》创建失败");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            this.Close();
        }

        private void m_pbx_albumcover_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            // dialog.Multiselect = true;//该值确定是否可以选择多个文件
            // dialog.Title = "请选择文件夹";
            dialog.Filter = "图片文件(*.jpg,*.jpeg,*.png,*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = dialog.FileName;
                Console.WriteLine("file is " + file);
                if (getImageSize(file) > 0.1)
                {
                    MessageBox.Show("图片文件不要超过1M");
                    return;
                }
                Image pic = Image.FromFile(file);//strFilePath是该图片的绝对路径
                int intWidth = pic.Width;//长度像素值
                int intHeight = pic.Height;//高度像素值
                Console.WriteLine("file size is " + intWidth + "*" + intHeight);
                if (intWidth <300 || intHeight <300)
                {
                    MessageBox.Show("图片分辨率不得低于300x300");
                    return;
                }
                m_hg_iur = HGRestfulAPI.getInstance().uploadHGFile(file);
                if (m_hg_iur == null || m_hg_iur.Status != 200)
                {
                    MessageBox.Show("图片上传失败");
                    m_hg_iur = null;
                }
                else
                {
                    m_pbx_albumcover.BorderStyle = BorderStyle.FixedSingle;
                    m_pbx_albumcover.Load(file);
                }
            }
        }
        
        /// <summary>
        /// 得到路径下文件的大小 MB
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        private double getImageSize(string path)
        {
            FileInfo fileInfo = new FileInfo(path);
            double length = Convert.ToDouble(fileInfo.Length);
            double Size = length / 1024 / 1024;
            return Size;
        }
    }
}
