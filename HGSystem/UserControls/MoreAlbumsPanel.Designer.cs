namespace HGSystem.UserControls
{
    partial class MoreAlbumsPanel
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
            this.m_lbl_albumtypename = new System.Windows.Forms.Label();
            this.m_lbl_back = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_lbl_albumtypename
            // 
            this.m_lbl_albumtypename.AutoSize = true;
            this.m_lbl_albumtypename.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.m_lbl_albumtypename.Location = new System.Drawing.Point(50, 25);
            this.m_lbl_albumtypename.Name = "m_lbl_albumtypename";
            this.m_lbl_albumtypename.Size = new System.Drawing.Size(76, 16);
            this.m_lbl_albumtypename.TabIndex = 12;
            this.m_lbl_albumtypename.Text = "视频专辑";
            // 
            // m_lbl_back
            // 
            this.m_lbl_back.AutoSize = true;
            this.m_lbl_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_lbl_back.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_lbl_back.Location = new System.Drawing.Point(1050, 25);
            this.m_lbl_back.Name = "m_lbl_back";
            this.m_lbl_back.Size = new System.Drawing.Size(56, 16);
            this.m_lbl_back.TabIndex = 13;
            this.m_lbl_back.Text = "< 返回";
            this.m_lbl_back.Click += new System.EventHandler(this.m_lbl_back_Click);
            // 
            // MoreAlbumsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_lbl_back);
            this.Controls.Add(this.m_lbl_albumtypename);
            this.Name = "MoreAlbumsPanel";
            this.Size = new System.Drawing.Size(1200, 618);
            this.Load += new System.EventHandler(this.MoreAlbumsPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label m_lbl_albumtypename;
        private System.Windows.Forms.Label m_lbl_back;
    }
}
