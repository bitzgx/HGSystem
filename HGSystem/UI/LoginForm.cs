using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HGSystem.Model;

namespace HGSystem
{
    public partial class LoginForm : Form
    {
        private FormWindowState m_fws_previous;
        private FloatWindow m_float_window;
        private HGCaptcha m_hg_captcha;

        public LoginForm()
        {
            InitializeComponent();

            m_fws_previous = this.WindowState;                
            m_float_window = new FloatWindow(this);

            // TODO: use captcha and remove login
            // m_pbx_captcha_Click(this, null);
            // m_pbx_captcha.Image = HGRestfulAPI.getInstance().GetImageFromBase64(HGRestfulAPI.getInstance().getHGCaptcha().Img);
            m_btn_login_Click(this, null);
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
            String mobile = m_tbx_mobile.Text; // "13488613602";// "15811208494";
            String password = m_tbx_password.Text; // "hongka1018";
            String vcode = m_tbx_captcha.Text;

            // TODO: don't do the following, just for debug
            if (mobile != null)
            {
                MainForm mf = new MainForm();
                this.Hide();
                mf.ShowDialog();
                Application.ExitThread(); // mainthread change to MainForm
                return;
            }

            if (m_hg_captcha == null)
            {
                System.Windows.Forms.MessageBox.Show("验证码未更新，请点击验证码图片，重新更新验证码");
                return;
            }
            String vtoken = m_hg_captcha.Vtoken;
            HGUser hgu = HGRestfulAPI.getInstance().login(mobile, password, vcode, vtoken);

            if (hgu != null)
            {
                MainForm mf = new MainForm();
                this.Hide();
                mf.ShowDialog();
                Application.ExitThread(); // mainthread change to MainForm
            }
        }

        private void m_pbx_captcha_Click(object sender, EventArgs e)
        {
            m_hg_captcha = HGRestfulAPI.getInstance().getHGCaptcha();
            if (m_hg_captcha != null)
            {
                Console.WriteLine("vtoken " + m_hg_captcha.Vtoken);
                m_pbx_captcha.Image = Helpers.Base64Helper.GetBitmapFromBase64(m_hg_captcha.Img);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("验证码更新失败，请联系网站管理员");
            }
        }
    }
}
