using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace HGSystem.UI
{
    public partial class NewAlbumForm : Form
    {
        public NewAlbumForm()
        {
            InitializeComponent();
        }

        private void m_bte_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_bte_add_Click(object sender, EventArgs e)
        {
            MessageBox.Show("创建专辑");
            

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
                m_pbx_albumcover.BorderStyle = BorderStyle.FixedSingle;
                m_pbx_albumcover.Load(file);
                // TODO: HGRestfulAPI.getInstance().uploadHGFile(file);
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
