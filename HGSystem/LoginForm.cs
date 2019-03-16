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
    public partial class LoginForm : Form
    {
        private FormWindowState m_fws_previous;
        private FloatWindow m_float_window;

        public LoginForm()
        {
            InitializeComponent();

            m_fws_previous = this.WindowState;                
            m_float_window = new FloatWindow(this);
        }

        private void btn_float_Click(object sender, EventArgs e)
        {
            //FloatWindow fw = new FloatWindow();
            //fw.Show();
        }

        /// <summary>
        /// Restore window state
        /// </summary>
        public void RestoreWindow()
        {
            this.WindowState = m_fws_previous;
            this.ShowInTaskbar = true;
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                // Window minimized
                // Show top most window
                m_float_window.Show();
                this.ShowInTaskbar = false;
            }

            else if (this.WindowState != m_fws_previous)
            {
                // Save current window state
                m_fws_previous = this.WindowState;
            }

        }

        private void m_btn_login_Click(object sender, EventArgs e)
        {
            MainForm mf = new MainForm();
            this.Hide();
            mf.ShowDialog();
            Application.ExitThread(); // mainthread change to MainForm
        }
    }
}
