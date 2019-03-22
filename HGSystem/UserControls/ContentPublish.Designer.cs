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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.m_lbl_video = new System.Windows.Forms.Label();
            this.m_lbl_morevideo = new System.Windows.Forms.Label();
            this.m_lbl_moreaudio = new System.Windows.Forms.Label();
            this.m_lbl_audio = new System.Windows.Forms.Label();
            this.searchBar1 = new HGSystem.UserControls.SearchBar();
            this.SuspendLayout();
            // 
            // m_lbl_video
            // 
            this.m_lbl_video.AutoSize = true;
            this.m_lbl_video.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.m_lbl_video.Location = new System.Drawing.Point(50, 70);
            this.m_lbl_video.Name = "m_lbl_video";
            this.m_lbl_video.Size = new System.Drawing.Size(76, 16);
            this.m_lbl_video.TabIndex = 4;
            this.m_lbl_video.Text = "视频专辑";
            // 
            // m_lbl_morevideo
            // 
            this.m_lbl_morevideo.AutoSize = true;
            this.m_lbl_morevideo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_lbl_morevideo.Location = new System.Drawing.Point(1058, 70);
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
            this.m_lbl_moreaudio.Location = new System.Drawing.Point(1057, 570);
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
            this.m_lbl_audio.Location = new System.Drawing.Point(49, 570);
            this.m_lbl_audio.Name = "m_lbl_audio";
            this.m_lbl_audio.Size = new System.Drawing.Size(76, 16);
            this.m_lbl_audio.TabIndex = 6;
            this.m_lbl_audio.Text = "音频专辑";
            // 
            // searchBar1
            // 
            this.searchBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.searchBar1.Location = new System.Drawing.Point(0, 0);
            this.searchBar1.Name = "searchBar1";
            this.searchBar1.Size = new System.Drawing.Size(1200, 50);
            this.searchBar1.TabIndex = 8;
            // 
            // ContentPublish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.searchBar1);
            this.Controls.Add(this.m_lbl_moreaudio);
            this.Controls.Add(this.m_lbl_audio);
            this.Controls.Add(this.m_lbl_morevideo);
            this.Controls.Add(this.m_lbl_video);
            this.Name = "ContentPublish";
            this.Size = new System.Drawing.Size(1200, 618);
            this.Load += new System.EventHandler(this.ContentPublish_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label m_lbl_video;
        private System.Windows.Forms.Label m_lbl_morevideo;
        private System.Windows.Forms.Label m_lbl_moreaudio;
        private System.Windows.Forms.Label m_lbl_audio;
        private UserControls.SearchBar searchBar1;
    }
}
