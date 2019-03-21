using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
// using System.Threading.Tasks;
using System.Windows.Forms;
using HGSystem.Model;
using System.Drawing.Drawing2D;

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

            DebugHelper.IsServerFail = false;
            DebugHelper.FastUserLogin = true;

            m_tbx_mobile.GotFocus += new EventHandler(m_tbx_mobile_GotFocus);
            m_tbx_password.GotFocus += new EventHandler(m_tbx_password_GotFocus);
            m_tbx_captcha.GotFocus += new EventHandler(m_tbx_captcha_GotFocus);

            // TODO: use captcha and remove login
            if (Model.DebugHelper.IsServerFail)
            {
                m_bte_login_Click(this, null);
                return;
            }

            m_pbx_captcha_Click(this, null);

            // 13488613602
            // hongka1018
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
            /* This should belong to MainForm
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
             */

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

        private void m_pbx_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void m_pbx_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;            
        }

        private void m_pnl_bg_Paint(object sender, PaintEventArgs e)
        {
            /*
            int pen_width = 3;
            int x_padding = 10;
            int y_axis = 240;
            e.Graphics.DrawLine(new Pen(Color.Gray, pen_width), new PointF(x_padding, y_axis), new Point(this.Width - x_padding, y_axis));
            y_axis += 40;
            e.Graphics.DrawLine(new Pen(Color.Gray, pen_width), new PointF(x_padding, y_axis), new Point(this.Width - x_padding, y_axis));
            y_axis += 40;
            e.Graphics.DrawLine(new Pen(Color.Gray, pen_width), new PointF(x_padding, y_axis), new Point(this.Width - x_padding, y_axis));
            // TODO: it is not displayed in the bottom part of this window
            e.Graphics.DrawLine(new Pen(Color.Gray, 3), new PointF(10, 130), new Point(this.Width - 10, 280));
             */
            
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            
            int cornerRadius = 7;
            Rectangle rect = this.ClientRectangle;
            GraphicsPath gp = new GraphicsPath();
            // 添加圆弧
            gp.AddArc(0, 0, cornerRadius * 2, cornerRadius * 2, 180, 90);
            gp.AddArc(rect.Width - cornerRadius * 2 , 0, cornerRadius * 2, cornerRadius * 2, 270, 90);
            gp.AddArc(rect.Width - cornerRadius * 2 , rect.Height - cornerRadius * 2, cornerRadius * 2, cornerRadius * 2, 0, 90);
            gp.AddArc(0, rect.Height - cornerRadius * 2 , cornerRadius * 2, cornerRadius * 2, 90, 90);
            gp.CloseFigure();
            
            this.Region = new Region(gp);
        }

        /*
        private void handleTextChanged(TextBox tbx, String prompt)
        {
            tbx.ForeColor = SystemColors.WindowText;
            if (tbx.Text.StartsWith(prompt))
            {
                tbx.Text = tbx.Text.Replace(prompt, "");
                tbx.Select(tbx.TextLength, 0);
            }
        }
         * */
        private void m_tbx_mobile_TextChanged(object sender, EventArgs e)
        {
            // handleTextChanged(m_tbx_mobile, "请输入手机号");
            m_tbx_mobile.ForeColor = SystemColors.WindowText;
            var reg = new System.Text.RegularExpressions.Regex("^[0-9]*$");
            var str = m_tbx_mobile.Text.Trim();
            var sb = new StringBuilder();
            if (!reg.IsMatch(str))
            {
                for (int i = 0; i < str.Length; i++)
                {
                    if (reg.IsMatch(str[i].ToString()))
                    {
                        sb.Append(str[i].ToString());
                    }
                }
                m_tbx_mobile.Text = sb.ToString();
                m_tbx_mobile.SelectionStart = m_tbx_mobile.Text.Length;    //定义输入焦点在最后一个字符
            }
        }

        private void m_tbx_password_TextChanged(object sender, EventArgs e)
        {
            m_tbx_password.ForeColor = SystemColors.WindowText;
            // handleTextChanged(m_tbx_password, "请输入密码");

            if (m_tbx_password.Text.StartsWith("请输入密码"))
            {
                m_tbx_password.Text = m_tbx_password.Text.Replace("请输入密码", "");
                m_tbx_password.Select(m_tbx_password.TextLength, 0);
            }
            // m_tbx_password.PasswordChar = '*';
            m_tbx_password.UseSystemPasswordChar = true;
        }

        private void m_tbx_captcha_TextChanged(object sender, EventArgs e)
        {
            m_tbx_captcha.ForeColor = SystemColors.WindowText;
            // handleTextChanged(m_tbx_captcha, "请输入验证码");
        }

        private bool isValidMobileNo(String mobile)
        {
            string path = @"((^13[0-9]{1}[0-9]{8}|^15[0-9]{1}[0-9]{8}|^14[0-9]{1}[0-9]{8}|^16[0-9]{1}[0-9]{8}|^17[0-9]{1}[0-9]{8}|^18[0-9]{1}[0-9]{8}|^19[0-9]{1}[0-9]{8})|^((\d{7,8})|(\d{4}|\d{3})-(\d{7,8})|(\d{4}|\d{3})-(\d{7,8})-(\d{4}|\d{3}|\d{2}|\d{1})|(\d{7,8})-(\d{4}|\d{3}|\d{2}|\d{1}))$)";
            return (mobile.Length == 11) && System.Text.RegularExpressions.Regex.IsMatch(mobile, path);
        }

        private void m_bte_login_Click(object sender, EventArgs e)
        {
            String mobile = m_tbx_mobile.Text; // "13488613602";// "15811208494";
            String password = m_tbx_password.Text; // "hongka1018";
            String vcode = m_tbx_captcha.Text;

            if (DebugHelper.FastUserLogin)
            {
                mobile = "13488613602";
                password = "hongka1018";
                vcode = "eq32";
            }

            if (mobile.Equals("请输入手机号"))
            {
                MessageBox.Show("手机号不能为空");
            }
            if (password.Equals("请输入密码"))
            {
                MessageBox.Show("密码不能为空");
            }
            if (vcode.Equals("请输入验证码"))
            {
                MessageBox.Show("验证码不能为空");
            }
            // TODO: don't do the following, just for debug
            if (Model.DebugHelper.IsServerFail && mobile != null)
            {
                MainForm mf = new MainForm();
                this.Hide();
                mf.ShowDialog();
                Application.ExitThread(); // mainthread change to MainForm
                return;
            }

            if (!isValidMobileNo(mobile))
            {
                MessageBox.Show("请输入正确的手机号");
                m_tbx_mobile.Focus();
                return;
            }

            if (m_hg_captcha == null)
            {
                MessageBox.Show("验证码未更新，请点击验证码图片，重新更新验证码");
                return;
            }

            String vtoken = m_hg_captcha.Vtoken;
            try
            {
                HGUser hgu = HGRestfulAPI.getInstance().login(mobile, password, vcode, vtoken);

                if (hgu != null)
                {
                    MainForm mf = new MainForm();
                    this.Hide();
                    mf.ShowDialog();
                    Application.ExitThread(); // mainthread change to MainForm
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void m_btn_resetpwd_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("forget pwd");
            System.Diagnostics.Process.Start("https://edutest.hongkazhijia.com/#/homePage");  
        }

        private void m_tbx_mobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            Console.WriteLine("text is " + m_tbx_mobile.Text);
            if ((int)e.KeyChar == 13)  
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);  //需设置textBox的TabIndex顺序属性
                return;
            }

            //判断按键是不是要输入的类型。
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8 && (int)e.KeyChar != 127 && (int)e.KeyChar != 22)
            {
                MessageBox.Show("手机号只支持数字");
                e.Handled = true;
                return;
            }
            if (m_tbx_mobile.Text.Equals("请输入手机号"))
                m_tbx_mobile.Text = "";            
        }

        private void m_tbx_mobile_GotFocus(object sender, EventArgs e)
        {
            m_tbx_mobile.Select(m_tbx_mobile.Text.Length, 0);
        }

        // TODO: 密码如果要拷贝进来，需要拷贝两次
        private void m_tbx_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == 13)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);  //需设置textBox的TabIndex顺序属性
                return;
            }
            if ((int)e.KeyChar == 22)
            {
                return;
            }
            if (m_tbx_password.Text.Equals("请输入密码"))
            {                
                m_tbx_password.Text = e.KeyChar.ToString();
            }
            Console.WriteLine(m_tbx_password.Text);
            m_tbx_password.SelectionStart = m_tbx_password.Text.Length;
        }
        private void m_tbx_password_GotFocus(object sender, EventArgs e)
        {
            m_tbx_password.Select(m_tbx_password.Text.Length, 0);
        }

        private void m_tbx_captcha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.SelectNextControl(this.ActiveControl, true, true, true, true);  //需设置textBox的TabIndex顺序属性
                return;
            }
            if ((e.KeyChar != '\b') && (!Char.IsLetter(e.KeyChar)) && (!char.IsDigit(e.KeyChar)) && (int)e.KeyChar != 22)
            {
                e.Handled = true;
                return;
            }
            if (m_tbx_captcha.Text.Equals("请输入验证码"))
                m_tbx_captcha.Text = "";   
        }
        private void m_tbx_captcha_GotFocus(object sender, EventArgs e)
        {
            m_tbx_captcha.Select(m_tbx_captcha.Text.Length, 0);
        }
    }
}
