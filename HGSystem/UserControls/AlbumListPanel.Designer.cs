namespace HGSystem.UserControls
{
    partial class AlbumListPanel
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
            this.m_lbl_morealbum = new System.Windows.Forms.Label();
            this.m_lbl_albumtypename = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_lbl_morealbum
            // 
            this.m_lbl_morealbum.AutoSize = true;
            this.m_lbl_morealbum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_lbl_morealbum.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_lbl_morealbum.Location = new System.Drawing.Point(1050, 25);
            this.m_lbl_morealbum.Name = "m_lbl_morealbum";
            this.m_lbl_morealbum.Size = new System.Drawing.Size(56, 16);
            this.m_lbl_morealbum.TabIndex = 6;
            this.m_lbl_morealbum.Text = "更多 >";
            this.m_lbl_morealbum.Click += new System.EventHandler(this.m_lbl_morealbum_Click);
            // 
            // m_lbl_albumtypename
            // 
            this.m_lbl_albumtypename.AutoSize = true;
            this.m_lbl_albumtypename.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.m_lbl_albumtypename.Location = new System.Drawing.Point(49, 25);
            this.m_lbl_albumtypename.Name = "m_lbl_albumtypename";
            this.m_lbl_albumtypename.Size = new System.Drawing.Size(76, 16);
            this.m_lbl_albumtypename.TabIndex = 5;
            this.m_lbl_albumtypename.Text = "视频专辑";
            // 
            // AlbumListPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_lbl_morealbum);
            this.Controls.Add(this.m_lbl_albumtypename);
            this.Name = "AlbumListPanel";
            this.Size = new System.Drawing.Size(1160, 500);
            this.Load += new System.EventHandler(this.AlbumListPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label m_lbl_morealbum;
        private System.Windows.Forms.Label m_lbl_albumtypename;


    }
}
