namespace HGSystem
{
    partial class AlbumInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlbumInfo));
            this.m_pbx_album = new System.Windows.Forms.PictureBox();
            this.m_lbl_album = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_album)).BeginInit();
            this.SuspendLayout();
            // 
            // m_pbx_album
            // 
            this.m_pbx_album.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_pbx_album.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_pbx_album.Image = ((System.Drawing.Image)(resources.GetObject("m_pbx_album.Image")));
            this.m_pbx_album.InitialImage = null;
            this.m_pbx_album.Location = new System.Drawing.Point(0, 0);
            this.m_pbx_album.Name = "m_pbx_album";
            this.m_pbx_album.Size = new System.Drawing.Size(180, 180);
            this.m_pbx_album.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_pbx_album.TabIndex = 0;
            this.m_pbx_album.TabStop = false;
            this.m_pbx_album.Click += new System.EventHandler(this.m_pbx_album_Click);
            // 
            // m_lbl_album
            // 
            this.m_lbl_album.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.m_lbl_album.Font = new System.Drawing.Font("宋体", 13F);
            this.m_lbl_album.Location = new System.Drawing.Point(0, 180);
            this.m_lbl_album.Name = "m_lbl_album";
            this.m_lbl_album.Size = new System.Drawing.Size(180, 30);
            this.m_lbl_album.TabIndex = 1;
            this.m_lbl_album.Text = "专辑名";
            this.m_lbl_album.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AlbumInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_lbl_album);
            this.Controls.Add(this.m_pbx_album);
            this.Name = "AlbumInfo";
            this.Size = new System.Drawing.Size(180, 210);
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_album)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox m_pbx_album;
        private System.Windows.Forms.Label m_lbl_album;
    }
}
