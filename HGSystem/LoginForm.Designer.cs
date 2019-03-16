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
            this.m_tbx_mobile = new System.Windows.Forms.TextBox();
            this.m_tbx_password = new System.Windows.Forms.TextBox();
            this.m_tbx_captcha = new System.Windows.Forms.TextBox();
            this.m_pbx_captcha = new System.Windows.Forms.PictureBox();
            this.m_btn_login = new System.Windows.Forms.Button();
            this.m_btn_resetpwd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_captcha)).BeginInit();
            this.SuspendLayout();
            // 
            // m_tbx_mobile
            // 
            this.m_tbx_mobile.Location = new System.Drawing.Point(410, 326);
            this.m_tbx_mobile.Name = "m_tbx_mobile";
            this.m_tbx_mobile.Size = new System.Drawing.Size(244, 21);
            this.m_tbx_mobile.TabIndex = 0;
            // 
            // m_tbx_password
            // 
            this.m_tbx_password.Location = new System.Drawing.Point(410, 376);
            this.m_tbx_password.Name = "m_tbx_password";
            this.m_tbx_password.Size = new System.Drawing.Size(244, 21);
            this.m_tbx_password.TabIndex = 1;
            // 
            // m_tbx_captcha
            // 
            this.m_tbx_captcha.Location = new System.Drawing.Point(410, 425);
            this.m_tbx_captcha.Name = "m_tbx_captcha";
            this.m_tbx_captcha.Size = new System.Drawing.Size(152, 21);
            this.m_tbx_captcha.TabIndex = 2;
            // 
            // m_pbx_captcha
            // 
            this.m_pbx_captcha.Location = new System.Drawing.Point(577, 420);
            this.m_pbx_captcha.Name = "m_pbx_captcha";
            this.m_pbx_captcha.Size = new System.Drawing.Size(77, 26);
            this.m_pbx_captcha.TabIndex = 3;
            this.m_pbx_captcha.TabStop = false;
            // 
            // m_btn_login
            // 
            this.m_btn_login.Location = new System.Drawing.Point(357, 469);
            this.m_btn_login.Name = "m_btn_login";
            this.m_btn_login.Size = new System.Drawing.Size(301, 45);
            this.m_btn_login.TabIndex = 4;
            this.m_btn_login.Text = "登录";
            this.m_btn_login.UseVisualStyleBackColor = true;
            // 
            // m_btn_resetpwd
            // 
            this.m_btn_resetpwd.Location = new System.Drawing.Point(583, 523);
            this.m_btn_resetpwd.Name = "m_btn_resetpwd";
            this.m_btn_resetpwd.Size = new System.Drawing.Size(70, 23);
            this.m_btn_resetpwd.TabIndex = 5;
            this.m_btn_resetpwd.Text = "忘记密码?";
            this.m_btn_resetpwd.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1008, 730);
            this.Controls.Add(this.m_btn_resetpwd);
            this.Controls.Add(this.m_btn_login);
            this.Controls.Add(this.m_pbx_captcha);
            this.Controls.Add(this.m_tbx_captcha);
            this.Controls.Add(this.m_tbx_password);
            this.Controls.Add(this.m_tbx_mobile);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HGSystem";
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_captcha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_tbx_mobile;
        private System.Windows.Forms.TextBox m_tbx_password;
        private System.Windows.Forms.TextBox m_tbx_captcha;
        private System.Windows.Forms.PictureBox m_pbx_captcha;
        private System.Windows.Forms.Button m_btn_login;
        private System.Windows.Forms.Button m_btn_resetpwd;

    }
}

