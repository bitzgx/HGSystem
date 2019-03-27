using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HGSystem.UserControls
{
    public partial class UCSettings : UserControl
    {
        public UCSettings()
        {
            InitializeComponent();

            m_lbl_transferlist_Click(this, null);
        }

        private void SelectMenu(Label lbl)
        {
            m_lbl_transferlist.ForeColor = Color.Black;
            m_lbl_faq.ForeColor = Color.Black;
            m_lbl_resetpwd.ForeColor = Color.Black;
            m_lbl_logout.ForeColor = Color.Black;

            lbl.ForeColor = Color.FromArgb(255, 100, 92);
        }

        private void m_lbl_transferlist_Click(object sender, EventArgs e)
        {
            SelectMenu(m_lbl_transferlist);
        }

        private void m_lbl_faq_Click(object sender, EventArgs e)
        {
            SelectMenu(m_lbl_faq);
        }

        private void m_lbl_resetpwd_Click(object sender, EventArgs e)
        {
            SelectMenu(m_lbl_resetpwd);
        }

        private void m_lbl_logout_Click(object sender, EventArgs e)
        {
            SelectMenu(m_lbl_logout);
        }
    }
}
