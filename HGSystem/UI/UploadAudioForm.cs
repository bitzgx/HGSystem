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
    public partial class UploadAudioForm : Form
    {
        private IList<UCUploadAudioItem> m_lst_uuai = new List<UCUploadAudioItem>();

        public delegate void DeleteUploadAudioItem(UCUploadAudioItem uuai);

        public UploadAudioForm()
        {
            InitializeComponent();
        }

        private void DeleteAudioItem(UCUploadAudioItem uuai)
        {
            m_pl_uploadaudios.Controls.Remove(uuai);
            m_lst_uuai.Remove(uuai);            
            for (int i = 0; i < m_lst_uuai.Count; i++)
            {
                m_lst_uuai[i].Location = new Point(0, 37 * i);
            }
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
                openFileDialog.Filter = "MP3文件(*.mp3)|*.mp3";
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string filename = openFileDialog.FileName;
                    String name = System.IO.Path.GetFileName(filename);
                    int timelen = 280; // TODO: get timelen dynamically
                    UploadAudioItem uai = new UploadAudioItem(audiotype, name, timelen, filename);
                    UCUploadAudioItem uuai = new UCUploadAudioItem(uai);
                    uuai.DeleteAudioItem = DeleteAudioItem;
                    m_pl_uploadaudios.Controls.Add(uuai);
                    uuai.Location = new Point(0, 37 * m_lst_uuai.Count);
                    m_lst_uuai.Add(uuai);                    
                }
            }
        }
    }
}
