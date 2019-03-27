namespace HGSystem.UserControls
{
    partial class UCSettings
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.m_lbl_transferlist = new System.Windows.Forms.Label();
            this.m_lbl_logout = new System.Windows.Forms.Label();
            this.m_lbl_resetpwd = new System.Windows.Forms.Label();
            this.m_lbl_faq = new System.Windows.Forms.Label();
            this.m_lbl_vertical_sep = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_lbl_transferlist
            // 
            this.m_lbl_transferlist.AutoSize = true;
            this.m_lbl_transferlist.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.m_lbl_transferlist.Location = new System.Drawing.Point(82, 40);
            this.m_lbl_transferlist.Name = "m_lbl_transferlist";
            this.m_lbl_transferlist.Size = new System.Drawing.Size(93, 20);
            this.m_lbl_transferlist.TabIndex = 0;
            this.m_lbl_transferlist.Text = "传输列表";
            // 
            // m_lbl_logout
            // 
            this.m_lbl_logout.AutoSize = true;
            this.m_lbl_logout.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.m_lbl_logout.Location = new System.Drawing.Point(82, 218);
            this.m_lbl_logout.Name = "m_lbl_logout";
            this.m_lbl_logout.Size = new System.Drawing.Size(93, 20);
            this.m_lbl_logout.TabIndex = 1;
            this.m_lbl_logout.Text = "退出登录";
            // 
            // m_lbl_resetpwd
            // 
            this.m_lbl_resetpwd.AutoSize = true;
            this.m_lbl_resetpwd.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.m_lbl_resetpwd.Location = new System.Drawing.Point(82, 158);
            this.m_lbl_resetpwd.Name = "m_lbl_resetpwd";
            this.m_lbl_resetpwd.Size = new System.Drawing.Size(93, 20);
            this.m_lbl_resetpwd.TabIndex = 2;
            this.m_lbl_resetpwd.Text = "修改密码";
            // 
            // m_lbl_faq
            // 
            this.m_lbl_faq.AutoSize = true;
            this.m_lbl_faq.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.m_lbl_faq.Location = new System.Drawing.Point(82, 97);
            this.m_lbl_faq.Name = "m_lbl_faq";
            this.m_lbl_faq.Size = new System.Drawing.Size(93, 20);
            this.m_lbl_faq.TabIndex = 3;
            this.m_lbl_faq.Text = "热门问答";
            // 
            // m_lbl_vertical_sep
            // 
            this.m_lbl_vertical_sep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_lbl_vertical_sep.Location = new System.Drawing.Point(240, 0);
            this.m_lbl_vertical_sep.Name = "m_lbl_vertical_sep";
            this.m_lbl_vertical_sep.Size = new System.Drawing.Size(3, 730);
            this.m_lbl_vertical_sep.TabIndex = 4;
            // 
            // UCSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_lbl_vertical_sep);
            this.Controls.Add(this.m_lbl_faq);
            this.Controls.Add(this.m_lbl_resetpwd);
            this.Controls.Add(this.m_lbl_logout);
            this.Controls.Add(this.m_lbl_transferlist);
            this.Name = "UCSettings";
            this.Size = new System.Drawing.Size(682, 340);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_lbl_transferlist;
        private System.Windows.Forms.Label m_lbl_logout;
        private System.Windows.Forms.Label m_lbl_resetpwd;
        private System.Windows.Forms.Label m_lbl_faq;
        private System.Windows.Forms.Label m_lbl_vertical_sep;
    }
}
