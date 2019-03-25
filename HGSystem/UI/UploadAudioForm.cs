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
        private IList<UploadAudioItem> m_lst_uai = new List<UploadAudioItem>();
        public UploadAudioForm()
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
                openFileDialog.Filter = "MP3文件(*.mp3)|*.mp3";
                if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string filename = openFileDialog.FileName;
                    String name = System.IO.Path.GetFileName(filename);
                    int timelen = 280; // TODO: get timelen dynamically
                    UploadAudioItem uai = new UploadAudioItem(audiotype, name, timelen);
                    m_lst_uai.Add(uai);
                }
            }
        }
    }
}
