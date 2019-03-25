namespace HGSystem.UserControls
{
    partial class ProgramItemRow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramItemRow));
            this.m_lbl_no = new System.Windows.Forms.Label();
            this.m_lbl_name = new System.Windows.Forms.Label();
            this.m_lbl_timelen = new System.Windows.Forms.Label();
            this.m_lbl_cat = new System.Windows.Forms.Label();
            this.m_lbl_createat = new System.Windows.Forms.Label();
            this.m_lbl_play_times = new System.Windows.Forms.Label();
            this.m_lbl_share_times = new System.Windows.Forms.Label();
            this.m_pbx_delete = new System.Windows.Forms.PictureBox();
            this.m_pbx_share = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_share)).BeginInit();
            this.SuspendLayout();
            // 
            // m_lbl_no
            // 
            this.m_lbl_no.Location = new System.Drawing.Point(38, 10);
            this.m_lbl_no.Name = "m_lbl_no";
            this.m_lbl_no.Size = new System.Drawing.Size(41, 16);
            this.m_lbl_no.TabIndex = 0;
            this.m_lbl_no.Text = "1";
            this.m_lbl_no.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_lbl_name
            // 
            this.m_lbl_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_lbl_name.ForeColor = System.Drawing.Color.Red;
            this.m_lbl_name.Location = new System.Drawing.Point(112, 10);
            this.m_lbl_name.Name = "m_lbl_name";
            this.m_lbl_name.Size = new System.Drawing.Size(157, 16);
            this.m_lbl_name.TabIndex = 1;
            this.m_lbl_name.Text = "2018年12月3日.mp3";
            this.m_lbl_name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_lbl_name.Click += new System.EventHandler(this.m_lbl_name_Click);
            // 
            // m_lbl_timelen
            // 
            this.m_lbl_timelen.Location = new System.Drawing.Point(320, 10);
            this.m_lbl_timelen.Name = "m_lbl_timelen";
            this.m_lbl_timelen.Size = new System.Drawing.Size(102, 16);
            this.m_lbl_timelen.TabIndex = 2;
            this.m_lbl_timelen.Text = "5分10秒";
            this.m_lbl_timelen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_lbl_cat
            // 
            this.m_lbl_cat.Location = new System.Drawing.Point(449, 10);
            this.m_lbl_cat.Name = "m_lbl_cat";
            this.m_lbl_cat.Size = new System.Drawing.Size(102, 16);
            this.m_lbl_cat.TabIndex = 3;
            this.m_lbl_cat.Text = "短视频";
            this.m_lbl_cat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_lbl_createat
            // 
            this.m_lbl_createat.Location = new System.Drawing.Point(574, 10);
            this.m_lbl_createat.Name = "m_lbl_createat";
            this.m_lbl_createat.Size = new System.Drawing.Size(102, 16);
            this.m_lbl_createat.TabIndex = 4;
            this.m_lbl_createat.Text = "2019-03-25";
            this.m_lbl_createat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_lbl_play_times
            // 
            this.m_lbl_play_times.Location = new System.Drawing.Point(711, 10);
            this.m_lbl_play_times.Name = "m_lbl_play_times";
            this.m_lbl_play_times.Size = new System.Drawing.Size(102, 16);
            this.m_lbl_play_times.TabIndex = 5;
            this.m_lbl_play_times.Text = "10万";
            this.m_lbl_play_times.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_lbl_share_times
            // 
            this.m_lbl_share_times.Location = new System.Drawing.Point(819, 10);
            this.m_lbl_share_times.Name = "m_lbl_share_times";
            this.m_lbl_share_times.Size = new System.Drawing.Size(102, 16);
            this.m_lbl_share_times.TabIndex = 6;
            this.m_lbl_share_times.Text = "10万";
            this.m_lbl_share_times.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // m_pbx_delete
            // 
            this.m_pbx_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_pbx_delete.Image = ((System.Drawing.Image)(resources.GetObject("m_pbx_delete.Image")));
            this.m_pbx_delete.Location = new System.Drawing.Point(951, 4);
            this.m_pbx_delete.Name = "m_pbx_delete";
            this.m_pbx_delete.Size = new System.Drawing.Size(23, 25);
            this.m_pbx_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_pbx_delete.TabIndex = 7;
            this.m_pbx_delete.TabStop = false;
            this.m_pbx_delete.Click += new System.EventHandler(this.m_pbx_delete_Click);
            // 
            // m_pbx_share
            // 
            this.m_pbx_share.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_pbx_share.Image = ((System.Drawing.Image)(resources.GetObject("m_pbx_share.Image")));
            this.m_pbx_share.Location = new System.Drawing.Point(980, 4);
            this.m_pbx_share.Name = "m_pbx_share";
            this.m_pbx_share.Size = new System.Drawing.Size(23, 25);
            this.m_pbx_share.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_pbx_share.TabIndex = 8;
            this.m_pbx_share.TabStop = false;
            this.m_pbx_share.Click += new System.EventHandler(this.m_pbx_share_Click);
            // 
            // ProgramItemRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_pbx_share);
            this.Controls.Add(this.m_pbx_delete);
            this.Controls.Add(this.m_lbl_share_times);
            this.Controls.Add(this.m_lbl_play_times);
            this.Controls.Add(this.m_lbl_createat);
            this.Controls.Add(this.m_lbl_cat);
            this.Controls.Add(this.m_lbl_timelen);
            this.Controls.Add(this.m_lbl_name);
            this.Controls.Add(this.m_lbl_no);
            this.Font = new System.Drawing.Font("宋体", 11F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProgramItemRow";
            this.Size = new System.Drawing.Size(1333, 38);
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_share)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label m_lbl_no;
        private System.Windows.Forms.Label m_lbl_name;
        private System.Windows.Forms.Label m_lbl_timelen;
        private System.Windows.Forms.Label m_lbl_cat;
        private System.Windows.Forms.Label m_lbl_createat;
        private System.Windows.Forms.Label m_lbl_play_times;
        private System.Windows.Forms.Label m_lbl_share_times;
        private System.Windows.Forms.PictureBox m_pbx_delete;
        private System.Windows.Forms.PictureBox m_pbx_share;
    }
}
