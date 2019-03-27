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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCSettings));
            this.m_lbl_transferlist = new System.Windows.Forms.Label();
            this.m_lbl_logout = new System.Windows.Forms.Label();
            this.m_lbl_resetpwd = new System.Windows.Forms.Label();
            this.m_lbl_faq = new System.Windows.Forms.Label();
            this.m_lbl_vertical_sep = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_lbl_uploading = new System.Windows.Forms.Label();
            this.m_lbl_downloading = new System.Windows.Forms.Label();
            this.m_lbl_downloaded = new System.Windows.Forms.Label();
            this.m_lbl_tableheader = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_lbl_transferlist
            // 
            this.m_lbl_transferlist.AutoSize = true;
            this.m_lbl_transferlist.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.m_lbl_transferlist.Location = new System.Drawing.Point(82, 65);
            this.m_lbl_transferlist.Name = "m_lbl_transferlist";
            this.m_lbl_transferlist.Size = new System.Drawing.Size(93, 20);
            this.m_lbl_transferlist.TabIndex = 0;
            this.m_lbl_transferlist.Text = "传输列表";
            this.m_lbl_transferlist.Click += new System.EventHandler(this.m_lbl_transferlist_Click);
            // 
            // m_lbl_logout
            // 
            this.m_lbl_logout.AutoSize = true;
            this.m_lbl_logout.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.m_lbl_logout.Location = new System.Drawing.Point(82, 243);
            this.m_lbl_logout.Name = "m_lbl_logout";
            this.m_lbl_logout.Size = new System.Drawing.Size(93, 20);
            this.m_lbl_logout.TabIndex = 1;
            this.m_lbl_logout.Text = "退出登录";
            this.m_lbl_logout.Click += new System.EventHandler(this.m_lbl_logout_Click);
            // 
            // m_lbl_resetpwd
            // 
            this.m_lbl_resetpwd.AutoSize = true;
            this.m_lbl_resetpwd.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.m_lbl_resetpwd.Location = new System.Drawing.Point(82, 183);
            this.m_lbl_resetpwd.Name = "m_lbl_resetpwd";
            this.m_lbl_resetpwd.Size = new System.Drawing.Size(93, 20);
            this.m_lbl_resetpwd.TabIndex = 2;
            this.m_lbl_resetpwd.Text = "修改密码";
            this.m_lbl_resetpwd.Click += new System.EventHandler(this.m_lbl_resetpwd_Click);
            // 
            // m_lbl_faq
            // 
            this.m_lbl_faq.AutoSize = true;
            this.m_lbl_faq.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.m_lbl_faq.Location = new System.Drawing.Point(82, 122);
            this.m_lbl_faq.Name = "m_lbl_faq";
            this.m_lbl_faq.Size = new System.Drawing.Size(93, 20);
            this.m_lbl_faq.TabIndex = 3;
            this.m_lbl_faq.Text = "热门问答";
            this.m_lbl_faq.Click += new System.EventHandler(this.m_lbl_faq_Click);
            // 
            // m_lbl_vertical_sep
            // 
            this.m_lbl_vertical_sep.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_lbl_vertical_sep.Location = new System.Drawing.Point(240, 0);
            this.m_lbl_vertical_sep.Name = "m_lbl_vertical_sep";
            this.m_lbl_vertical_sep.Size = new System.Drawing.Size(3, 730);
            this.m_lbl_vertical_sep.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_lbl_tableheader);
            this.panel1.Controls.Add(this.m_lbl_downloaded);
            this.panel1.Controls.Add(this.m_lbl_downloading);
            this.panel1.Controls.Add(this.m_lbl_uploading);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(-90, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 473);
            this.panel1.TabIndex = 5;
            // 
            // m_lbl_uploading
            // 
            this.m_lbl_uploading.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_lbl_uploading.Image = ((System.Drawing.Image)(resources.GetObject("m_lbl_uploading.Image")));
            this.m_lbl_uploading.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_lbl_uploading.Location = new System.Drawing.Point(41, 24);
            this.m_lbl_uploading.Name = "m_lbl_uploading";
            this.m_lbl_uploading.Size = new System.Drawing.Size(88, 23);
            this.m_lbl_uploading.TabIndex = 0;
            this.m_lbl_uploading.Text = "上传中";
            this.m_lbl_uploading.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // m_lbl_downloading
            // 
            this.m_lbl_downloading.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_lbl_downloading.Image = ((System.Drawing.Image)(resources.GetObject("m_lbl_downloading.Image")));
            this.m_lbl_downloading.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_lbl_downloading.Location = new System.Drawing.Point(150, 24);
            this.m_lbl_downloading.Name = "m_lbl_downloading";
            this.m_lbl_downloading.Size = new System.Drawing.Size(88, 23);
            this.m_lbl_downloading.TabIndex = 1;
            this.m_lbl_downloading.Text = "下载中";
            this.m_lbl_downloading.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // m_lbl_downloaded
            // 
            this.m_lbl_downloaded.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_lbl_downloaded.Image = ((System.Drawing.Image)(resources.GetObject("m_lbl_downloaded.Image")));
            this.m_lbl_downloaded.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.m_lbl_downloaded.Location = new System.Drawing.Point(259, 24);
            this.m_lbl_downloaded.Name = "m_lbl_downloaded";
            this.m_lbl_downloaded.Size = new System.Drawing.Size(88, 23);
            this.m_lbl_downloaded.TabIndex = 2;
            this.m_lbl_downloaded.Text = "已下载";
            this.m_lbl_downloaded.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // m_lbl_tableheader
            // 
            this.m_lbl_tableheader.BackColor = System.Drawing.Color.DarkGray;
            this.m_lbl_tableheader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_lbl_tableheader.Font = new System.Drawing.Font("宋体", 15F);
            this.m_lbl_tableheader.Location = new System.Drawing.Point(0, 65);
            this.m_lbl_tableheader.Name = "m_lbl_tableheader";
            this.m_lbl_tableheader.Size = new System.Drawing.Size(886, 38);
            this.m_lbl_tableheader.TabIndex = 3;
            this.m_lbl_tableheader.Text = "文件名称                                   进度                            操作";
            this.m_lbl_tableheader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_lbl_vertical_sep);
            this.Controls.Add(this.m_lbl_faq);
            this.Controls.Add(this.m_lbl_resetpwd);
            this.Controls.Add(this.m_lbl_logout);
            this.Controls.Add(this.m_lbl_transferlist);
            this.Name = "UCSettings";
            this.Size = new System.Drawing.Size(796, 473);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_lbl_transferlist;
        private System.Windows.Forms.Label m_lbl_logout;
        private System.Windows.Forms.Label m_lbl_resetpwd;
        private System.Windows.Forms.Label m_lbl_faq;
        private System.Windows.Forms.Label m_lbl_vertical_sep;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label m_lbl_uploading;
        private System.Windows.Forms.Label m_lbl_downloading;
        private System.Windows.Forms.Label m_lbl_downloaded;
        private System.Windows.Forms.Label m_lbl_tableheader;


    }
}
