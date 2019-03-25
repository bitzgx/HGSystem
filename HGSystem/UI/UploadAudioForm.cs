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
    }
}
