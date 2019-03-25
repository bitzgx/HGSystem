namespace HGSystem.UserControls
{
    partial class UCUploadAudioItem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCUploadAudioItem));
            this.m_lbl_name = new System.Windows.Forms.Label();
            this.m_lbl_timelen = new System.Windows.Forms.Label();
            this.m_pbx_delete = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_delete)).BeginInit();
            this.SuspendLayout();
            // 
            // m_lbl_name
            // 
            this.m_lbl_name.Cursor = System.Windows.Forms.Cursors.Default;
            this.m_lbl_name.ForeColor = System.Drawing.SystemColors.WindowText;
            this.m_lbl_name.Location = new System.Drawing.Point(21, 8);
            this.m_lbl_name.Name = "m_lbl_name";
            this.m_lbl_name.Size = new System.Drawing.Size(217, 20);
            this.m_lbl_name.TabIndex = 2;
            this.m_lbl_name.Text = "2018年12月3日.mp3";
            this.m_lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // m_lbl_timelen
            // 
            this.m_lbl_timelen.Location = new System.Drawing.Point(260, 10);
            this.m_lbl_timelen.Name = "m_lbl_timelen";
            this.m_lbl_timelen.Size = new System.Drawing.Size(97, 16);
            this.m_lbl_timelen.TabIndex = 3;
            this.m_lbl_timelen.Text = "5分10秒";
            this.m_lbl_timelen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_pbx_delete
            // 
            this.m_pbx_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_pbx_delete.Image = ((System.Drawing.Image)(resources.GetObject("m_pbx_delete.Image")));
            this.m_pbx_delete.Location = new System.Drawing.Point(382, 8);
            this.m_pbx_delete.Name = "m_pbx_delete";
            this.m_pbx_delete.Size = new System.Drawing.Size(22, 20);
            this.m_pbx_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_pbx_delete.TabIndex = 4;
            this.m_pbx_delete.TabStop = false;
            this.m_pbx_delete.Click += new System.EventHandler(this.m_pbx_delete_Click);
            // 
            // UCUploadAudioItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.m_pbx_delete);
            this.Controls.Add(this.m_lbl_timelen);
            this.Controls.Add(this.m_lbl_name);
            this.Name = "UCUploadAudioItem";
            this.Size = new System.Drawing.Size(426, 38);
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_delete)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label m_lbl_name;
        private System.Windows.Forms.Label m_lbl_timelen;
        private System.Windows.Forms.PictureBox m_pbx_delete;
    }
}
