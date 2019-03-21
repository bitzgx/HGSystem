namespace HGSystem
{
    partial class ContentPublish
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
            this.m_tbx_albumno = new System.Windows.Forms.TextBox();
            this.m_tbx_albumname = new System.Windows.Forms.TextBox();
            this.m_cbx_category = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.m_lbl_video = new System.Windows.Forms.Label();
            this.m_lbl_morevideo = new System.Windows.Forms.Label();
            this.m_lbl_moreaudio = new System.Windows.Forms.Label();
            this.m_lbl_audio = new System.Windows.Forms.Label();
            this.m_btn_search = new HGSystem.ButtonEx();
            this.SuspendLayout();
            // 
            // m_tbx_albumno
            // 
            this.m_tbx_albumno.BackColor = System.Drawing.SystemColors.ControlLight;
            this.m_tbx_albumno.Font = new System.Drawing.Font("宋体", 12F);
            this.m_tbx_albumno.Location = new System.Drawing.Point(50, 16);
            this.m_tbx_albumno.Name = "m_tbx_albumno";
            this.m_tbx_albumno.Size = new System.Drawing.Size(186, 26);
            this.m_tbx_albumno.TabIndex = 0;
            this.m_tbx_albumno.Text = "专辑编号";
            // 
            // m_tbx_albumname
            // 
            this.m_tbx_albumname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.m_tbx_albumname.Font = new System.Drawing.Font("宋体", 12F);
            this.m_tbx_albumname.Location = new System.Drawing.Point(262, 16);
            this.m_tbx_albumname.Name = "m_tbx_albumname";
            this.m_tbx_albumname.Size = new System.Drawing.Size(186, 26);
            this.m_tbx_albumname.TabIndex = 1;
            this.m_tbx_albumname.Text = "专辑名称";
            // 
            // m_cbx_category
            // 
            this.m_cbx_category.BackColor = System.Drawing.SystemColors.ControlLight;
            this.m_cbx_category.Font = new System.Drawing.Font("宋体", 12F);
            this.m_cbx_category.FormattingEnabled = true;
            this.m_cbx_category.Items.AddRange(new object[] {
            "全部",
            "视频",
            "音频"});
            this.m_cbx_category.Location = new System.Drawing.Point(474, 16);
            this.m_cbx_category.Name = "m_cbx_category";
            this.m_cbx_category.Size = new System.Drawing.Size(186, 24);
            this.m_cbx_category.TabIndex = 2;
            this.m_cbx_category.Text = "全部";
            // 
            // m_lbl_video
            // 
            this.m_lbl_video.AutoSize = true;
            this.m_lbl_video.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.m_lbl_video.Location = new System.Drawing.Point(48, 70);
            this.m_lbl_video.Name = "m_lbl_video";
            this.m_lbl_video.Size = new System.Drawing.Size(76, 16);
            this.m_lbl_video.TabIndex = 4;
            this.m_lbl_video.Text = "视频专辑";
            // 
            // m_lbl_morevideo
            // 
            this.m_lbl_morevideo.AutoSize = true;
            this.m_lbl_morevideo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_lbl_morevideo.Location = new System.Drawing.Point(1056, 70);
            this.m_lbl_morevideo.Name = "m_lbl_morevideo";
            this.m_lbl_morevideo.Size = new System.Drawing.Size(56, 16);
            this.m_lbl_morevideo.TabIndex = 5;
            this.m_lbl_morevideo.Text = "更多 >";
            this.m_lbl_morevideo.Click += new System.EventHandler(this.m_lbl_morevideo_Click);
            // 
            // m_lbl_moreaudio
            // 
            this.m_lbl_moreaudio.AutoSize = true;
            this.m_lbl_moreaudio.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_lbl_moreaudio.Location = new System.Drawing.Point(1055, 570);
            this.m_lbl_moreaudio.Name = "m_lbl_moreaudio";
            this.m_lbl_moreaudio.Size = new System.Drawing.Size(56, 16);
            this.m_lbl_moreaudio.TabIndex = 7;
            this.m_lbl_moreaudio.Text = "更多 >";
            this.m_lbl_moreaudio.Click += new System.EventHandler(this.m_lbl_moreaudio_Click);
            // 
            // m_lbl_audio
            // 
            this.m_lbl_audio.AutoSize = true;
            this.m_lbl_audio.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.m_lbl_audio.Location = new System.Drawing.Point(47, 570);
            this.m_lbl_audio.Name = "m_lbl_audio";
            this.m_lbl_audio.Size = new System.Drawing.Size(76, 16);
            this.m_lbl_audio.TabIndex = 6;
            this.m_lbl_audio.Text = "音频专辑";
            // 
            // m_btn_search
            // 
            this.m_btn_search.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(92)))));
            this.m_btn_search.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.m_btn_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_btn_search.Location = new System.Drawing.Point(686, 12);
            this.m_btn_search.Name = "m_btn_search";
            this.m_btn_search.Size = new System.Drawing.Size(88, 28);
            this.m_btn_search.TabIndex = 3;
            this.m_btn_search.Text = "搜索";
            this.m_btn_search.UseVisualStyleBackColor = true;
            // 
            // ContentPublish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.m_lbl_moreaudio);
            this.Controls.Add(this.m_lbl_audio);
            this.Controls.Add(this.m_lbl_morevideo);
            this.Controls.Add(this.m_lbl_video);
            this.Controls.Add(this.m_btn_search);
            this.Controls.Add(this.m_cbx_category);
            this.Controls.Add(this.m_tbx_albumname);
            this.Controls.Add(this.m_tbx_albumno);
            this.Name = "ContentPublish";
            this.Size = new System.Drawing.Size(1200, 618);
            this.Load += new System.EventHandler(this.ContentPublish_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_tbx_albumno;
        private System.Windows.Forms.TextBox m_tbx_albumname;
        private System.Windows.Forms.ComboBox m_cbx_category;
        private ButtonEx m_btn_search;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label m_lbl_video;
        private System.Windows.Forms.Label m_lbl_morevideo;
        private System.Windows.Forms.Label m_lbl_moreaudio;
        private System.Windows.Forms.Label m_lbl_audio;
    }
}
