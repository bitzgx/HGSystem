using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HGSystem
{
    public partial class MainForm : Form
    {
        ContentPublish m_ctl_contentpublish;
        HGPlan m_ctl_hgplan;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (m_ctl_contentpublish == null) {
                m_ctl_contentpublish = new ContentPublish();
                m_ctl_contentpublish.Location = new Point(0, 150);
                this.Controls.Add(m_ctl_contentpublish);
            }
            if (m_ctl_contentpublish != null) m_ctl_hgplan.BringToFront();            
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            PointF p1 = new PointF(10, 75);
            PointF p2 = new PointF(this.Width - 10, 75);            
            g.DrawLine(new Pen(Color.Gray, 2), p1, p2);
        }

        private void m_btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_btn_hgplan_Click(object sender, EventArgs e)
        {
            if (m_ctl_hgplan == null) {
                m_ctl_hgplan = new HGPlan();
                m_ctl_hgplan.Location = new Point(0, 150);
                this.Controls.Add(m_ctl_hgplan);
            }
            if (m_ctl_hgplan != null) m_ctl_hgplan.BringToFront();
        }
    }
}
