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
    public partial class UploadVideoForm : Form
    {
        // private IList<UCUploadVideoItem> m_lst_uuvi = new List<UCUploadVideoItem>();
        
        public UploadVideoForm()
        {
            InitializeComponent();
        }
        
        private void m_bte_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_bte_add_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_bte_shortaudio_Click(object sender, EventArgs e)
        {
            setupAudio("短视频");
        }

        private void m_bte_audio_Click(object sender, EventArgs e)
        {
            setupAudio("视频");
        }

        private void setupAudio(String audiotype)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "MP4文件(*.mp4)|*.mp4";
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string filename = openFileDialog.FileName;
                    String name = System.IO.Path.GetFileName(filename);                    
                }
            }
        }
    }
}
