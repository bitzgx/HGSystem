namespace HGSystem
{
    partial class LoginForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.m_btn_resetpwd = new System.Windows.Forms.Button();
            this.m_btn_login = new System.Windows.Forms.Button();
            this.m_pbx_captcha = new System.Windows.Forms.PictureBox();
            this.m_tbx_captcha = new System.Windows.Forms.TextBox();
            this.m_tbx_password = new System.Windows.Forms.TextBox();
            this.m_tbx_mobile = new System.Windows.Forms.TextBox();
            this.m_pnl_bg = new System.Windows.Forms.Panel();
            this.m_pbx_close = new System.Windows.Forms.PictureBox();
            this.m_pbx_minimize = new System.Windows.Forms.PictureBox();
            this.m_pbx_logo = new System.Windows.Forms.PictureBox();
            this.m_pbx_mobileno = new System.Windows.Forms.PictureBox();
            this.m_pbx_password = new System.Windows.Forms.PictureBox();
            this.m_pbx_captcha_prompt = new System.Windows.Forms.PictureBox();
            this.m_lbl_separate1 = new System.Windows.Forms.Label();
            this.m_lbl_separate2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_captcha)).BeginInit();
            this.m_pnl_bg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_mobileno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_captcha_prompt)).BeginInit();
            this.SuspendLayout();
            // 
            // m_btn_resetpwd
            // 
            this.m_btn_resetpwd.BackColor = System.Drawing.Color.Transparent;
            this.m_btn_resetpwd.Font = new System.Drawing.Font("宋体", 10F);
            this.m_btn_resetpwd.Location = new System.Drawing.Point(227, 470);
            this.m_btn_resetpwd.Name = "m_btn_resetpwd";
            this.m_btn_resetpwd.Size = new System.Drawing.Size(126, 23);
            this.m_btn_resetpwd.TabIndex = 11;
            this.m_btn_resetpwd.Text = "忘记密码?";
            this.m_btn_resetpwd.UseVisualStyleBackColor = false;
            // 
            // m_btn_login
            // 
            this.m_btn_login.Location = new System.Drawing.Point(54, 399);
            this.m_btn_login.Name = "m_btn_login";
            this.m_btn_login.Size = new System.Drawing.Size(281, 27);
            this.m_btn_login.TabIndex = 10;
            this.m_btn_login.Text = "登录";
            this.m_btn_login.UseVisualStyleBackColor = true;
            // 
            // m_pbx_captcha
            // 
            this.m_pbx_captcha.Location = new System.Drawing.Point(221, 336);
            this.m_pbx_captcha.Name = "m_pbx_captcha";
            this.m_pbx_captcha.Size = new System.Drawing.Size(132, 26);
            this.m_pbx_captcha.TabIndex = 9;
            this.m_pbx_captcha.TabStop = false;
            // 
            // m_tbx_captcha
            // 
            this.m_tbx_captcha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_tbx_captcha.Font = new System.Drawing.Font("宋体", 12F);
            this.m_tbx_captcha.Location = new System.Drawing.Point(97, 339);
            this.m_tbx_captcha.Name = "m_tbx_captcha";
            this.m_tbx_captcha.Size = new System.Drawing.Size(118, 19);
            this.m_tbx_captcha.TabIndex = 8;
            // 
            // m_tbx_password
            // 
            this.m_tbx_password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_tbx_password.Font = new System.Drawing.Font("宋体", 12F);
            this.m_tbx_password.Location = new System.Drawing.Point(97, 283);
            this.m_tbx_password.Name = "m_tbx_password";
            this.m_tbx_password.Size = new System.Drawing.Size(253, 19);
            this.m_tbx_password.TabIndex = 7;
            this.m_tbx_password.Text = "hongka1018";
            // 
            // m_tbx_mobile
            // 
            this.m_tbx_mobile.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.m_tbx_mobile.Font = new System.Drawing.Font("宋体", 12F);
            this.m_tbx_mobile.Location = new System.Drawing.Point(97, 225);
            this.m_tbx_mobile.Name = "m_tbx_mobile";
            this.m_tbx_mobile.Size = new System.Drawing.Size(253, 19);
            this.m_tbx_mobile.TabIndex = 6;
            this.m_tbx_mobile.Text = "13488613602";
            // 
            // m_pnl_bg
            // 
            this.m_pnl_bg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("m_pnl_bg.BackgroundImage")));
            this.m_pnl_bg.Controls.Add(this.m_pbx_close);
            this.m_pnl_bg.Controls.Add(this.m_pbx_minimize);
            this.m_pnl_bg.Controls.Add(this.m_pbx_logo);
            this.m_pnl_bg.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_pnl_bg.Location = new System.Drawing.Point(0, 0);
            this.m_pnl_bg.Name = "m_pnl_bg";
            this.m_pnl_bg.Size = new System.Drawing.Size(396, 200);
            this.m_pnl_bg.TabIndex = 12;
            this.m_pnl_bg.Paint += new System.Windows.Forms.PaintEventHandler(this.m_pnl_bg_Paint);
            // 
            // m_pbx_close
            // 
            this.m_pbx_close.BackColor = System.Drawing.Color.Transparent;
            this.m_pbx_close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("m_pbx_close.BackgroundImage")));
            this.m_pbx_close.Location = new System.Drawing.Point(366, 12);
            this.m_pbx_close.Name = "m_pbx_close";
            this.m_pbx_close.Size = new System.Drawing.Size(18, 19);
            this.m_pbx_close.TabIndex = 2;
            this.m_pbx_close.TabStop = false;
            this.m_pbx_close.Click += new System.EventHandler(this.m_pbx_close_Click);
            // 
            // m_pbx_minimize
            // 
            this.m_pbx_minimize.BackColor = System.Drawing.Color.Transparent;
            this.m_pbx_minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("m_pbx_minimize.BackgroundImage")));
            this.m_pbx_minimize.Location = new System.Drawing.Point(333, 12);
            this.m_pbx_minimize.Name = "m_pbx_minimize";
            this.m_pbx_minimize.Size = new System.Drawing.Size(20, 20);
            this.m_pbx_minimize.TabIndex = 1;
            this.m_pbx_minimize.TabStop = false;
            this.m_pbx_minimize.Click += new System.EventHandler(this.m_pbx_minimize_Click);
            // 
            // m_pbx_logo
            // 
            this.m_pbx_logo.BackColor = System.Drawing.Color.Transparent;
            this.m_pbx_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("m_pbx_logo.BackgroundImage")));
            this.m_pbx_logo.Location = new System.Drawing.Point(143, 50);
            this.m_pbx_logo.Name = "m_pbx_logo";
            this.m_pbx_logo.Size = new System.Drawing.Size(110, 110);
            this.m_pbx_logo.TabIndex = 0;
            this.m_pbx_logo.TabStop = false;
            // 
            // m_pbx_mobileno
            // 
            this.m_pbx_mobileno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("m_pbx_mobileno.BackgroundImage")));
            this.m_pbx_mobileno.Location = new System.Drawing.Point(54, 222);
            this.m_pbx_mobileno.Name = "m_pbx_mobileno";
            this.m_pbx_mobileno.Size = new System.Drawing.Size(24, 24);
            this.m_pbx_mobileno.TabIndex = 13;
            this.m_pbx_mobileno.TabStop = false;
            // 
            // m_pbx_password
            // 
            this.m_pbx_password.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("m_pbx_password.BackgroundImage")));
            this.m_pbx_password.Location = new System.Drawing.Point(54, 280);
            this.m_pbx_password.Name = "m_pbx_password";
            this.m_pbx_password.Size = new System.Drawing.Size(24, 24);
            this.m_pbx_password.TabIndex = 14;
            this.m_pbx_password.TabStop = false;
            // 
            // m_pbx_captcha_prompt
            // 
            this.m_pbx_captcha_prompt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("m_pbx_captcha_prompt.BackgroundImage")));
            this.m_pbx_captcha_prompt.Location = new System.Drawing.Point(54, 335);
            this.m_pbx_captcha_prompt.Name = "m_pbx_captcha_prompt";
            this.m_pbx_captcha_prompt.Size = new System.Drawing.Size(24, 24);
            this.m_pbx_captcha_prompt.TabIndex = 15;
            this.m_pbx_captcha_prompt.TabStop = false;
            // 
            // m_lbl_separate1
            // 
            this.m_lbl_separate1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_lbl_separate1.Location = new System.Drawing.Point(43, 258);
            this.m_lbl_separate1.Name = "m_lbl_separate1";
            this.m_lbl_separate1.Size = new System.Drawing.Size(310, 2);
            this.m_lbl_separate1.TabIndex = 16;
            // 
            // m_lbl_separate2
            // 
            this.m_lbl_separate2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_lbl_separate2.Location = new System.Drawing.Point(43, 316);
            this.m_lbl_separate2.Name = "m_lbl_separate2";
            this.m_lbl_separate2.Size = new System.Drawing.Size(310, 2);
            this.m_lbl_separate2.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(43, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(310, 2);
            this.label1.TabIndex = 18;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(396, 518);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_lbl_separate2);
            this.Controls.Add(this.m_lbl_separate1);
            this.Controls.Add(this.m_pbx_captcha_prompt);
            this.Controls.Add(this.m_pbx_password);
            this.Controls.Add(this.m_pbx_mobileno);
            this.Controls.Add(this.m_pnl_bg);
            this.Controls.Add(this.m_btn_resetpwd);
            this.Controls.Add(this.m_btn_login);
            this.Controls.Add(this.m_pbx_captcha);
            this.Controls.Add(this.m_tbx_captcha);
            this.Controls.Add(this.m_tbx_password);
            this.Controls.Add(this.m_tbx_mobile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HGSystem";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_captcha)).EndInit();
            this.m_pnl_bg.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_mobileno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_captcha_prompt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button m_btn_resetpwd;
        private System.Windows.Forms.Button m_btn_login;
        private System.Windows.Forms.PictureBox m_pbx_captcha;
        private System.Windows.Forms.TextBox m_tbx_captcha;
        private System.Windows.Forms.TextBox m_tbx_password;
        private System.Windows.Forms.TextBox m_tbx_mobile;
        private System.Windows.Forms.Panel m_pnl_bg;
        private System.Windows.Forms.PictureBox m_pbx_logo;
        private System.Windows.Forms.PictureBox m_pbx_minimize;
        private System.Windows.Forms.PictureBox m_pbx_close;
        private System.Windows.Forms.PictureBox m_pbx_mobileno;
        private System.Windows.Forms.PictureBox m_pbx_password;
        private System.Windows.Forms.PictureBox m_pbx_captcha_prompt;
        private System.Windows.Forms.Label m_lbl_separate1;
        private System.Windows.Forms.Label m_lbl_separate2;
        private System.Windows.Forms.Label label1;


    }
}

