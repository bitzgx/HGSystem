namespace HGSystem.UserControls
{
    partial class ProgramPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramPanel));
            this.m_lbl_albumlabel = new System.Windows.Forms.Label();
            this.m_lbl_cat = new System.Windows.Forms.Label();
            this.m_lbl_albumname = new System.Windows.Forms.Label();
            this.m_pbx_cover = new System.Windows.Forms.PictureBox();
            this.m_lbl_albumintro = new System.Windows.Forms.Label();
            this.m_lbl_sep1 = new System.Windows.Forms.Label();
            this.m_pnl_albuminfo = new System.Windows.Forms.Panel();
            this.m_lbl_sep2 = new System.Windows.Forms.Label();
            this.m_lbl_no = new System.Windows.Forms.Label();
            this.m_lbl_name = new System.Windows.Forms.Label();
            this.m_lbl_timelen = new System.Windows.Forms.Label();
            this.m_lbl_header_cat = new System.Windows.Forms.Label();
            this.m_lbl_updatetime = new System.Windows.Forms.Label();
            this.m_lbl_play_times = new System.Windows.Forms.Label();
            this.m_lbl_share_times = new System.Windows.Forms.Label();
            this.m_lbl_op = new System.Windows.Forms.Label();
            this.m_pnl_header = new System.Windows.Forms.Panel();
            this.m_lbl_sep3 = new System.Windows.Forms.Label();
            this.m_lbl_sep4 = new System.Windows.Forms.Label();
            this.m_pc_programs = new HGSystem.UserControls.PagerControl();
            this.m_bte_upload = new HGSystem.ButtonEx();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_cover)).BeginInit();
            this.m_pnl_albuminfo.SuspendLayout();
            this.m_pnl_header.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_lbl_albumlabel
            // 
            this.m_lbl_albumlabel.AutoSize = true;
            this.m_lbl_albumlabel.Font = new System.Drawing.Font("宋体", 11F);
            this.m_lbl_albumlabel.Location = new System.Drawing.Point(235, 53);
            this.m_lbl_albumlabel.Name = "m_lbl_albumlabel";
            this.m_lbl_albumlabel.Size = new System.Drawing.Size(52, 15);
            this.m_lbl_albumlabel.TabIndex = 2;
            this.m_lbl_albumlabel.Text = "标签：";
            // 
            // m_lbl_cat
            // 
            this.m_lbl_cat.AutoSize = true;
            this.m_lbl_cat.Font = new System.Drawing.Font("宋体", 11F);
            this.m_lbl_cat.Location = new System.Drawing.Point(235, 82);
            this.m_lbl_cat.Name = "m_lbl_cat";
            this.m_lbl_cat.Size = new System.Drawing.Size(52, 15);
            this.m_lbl_cat.TabIndex = 3;
            this.m_lbl_cat.Text = "分类：";
            // 
            // m_lbl_albumname
            // 
            this.m_lbl_albumname.AutoSize = true;
            this.m_lbl_albumname.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold);
            this.m_lbl_albumname.Location = new System.Drawing.Point(234, 17);
            this.m_lbl_albumname.Name = "m_lbl_albumname";
            this.m_lbl_albumname.Size = new System.Drawing.Size(102, 22);
            this.m_lbl_albumname.TabIndex = 1;
            this.m_lbl_albumname.Text = "专辑标题";
            // 
            // m_pbx_cover
            // 
            this.m_pbx_cover.Location = new System.Drawing.Point(44, 17);
            this.m_pbx_cover.Name = "m_pbx_cover";
            this.m_pbx_cover.Size = new System.Drawing.Size(167, 155);
            this.m_pbx_cover.TabIndex = 0;
            this.m_pbx_cover.TabStop = false;
            // 
            // m_lbl_albumintro
            // 
            this.m_lbl_albumintro.Font = new System.Drawing.Font("宋体", 11F);
            this.m_lbl_albumintro.Location = new System.Drawing.Point(235, 107);
            this.m_lbl_albumintro.Name = "m_lbl_albumintro";
            this.m_lbl_albumintro.Size = new System.Drawing.Size(454, 65);
            this.m_lbl_albumintro.TabIndex = 4;
            this.m_lbl_albumintro.Text = "简介：回不去的故乡 暖暖的心，贴近彼此 今冬无雪 年少当有为 一念起，天涯咫尺 永远不落的追忆。乡村炊烟，让人魂牵梦萦 孤岛山城，后会无期 清风不扰客，留香等人寻" +
    " 曾经 芳华当惜取 忘不掉和记不起";
            // 
            // m_lbl_sep1
            // 
            this.m_lbl_sep1.BackColor = System.Drawing.Color.Transparent;
            this.m_lbl_sep1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_lbl_sep1.Location = new System.Drawing.Point(0, 1);
            this.m_lbl_sep1.Name = "m_lbl_sep1";
            this.m_lbl_sep1.Size = new System.Drawing.Size(1200, 3);
            this.m_lbl_sep1.TabIndex = 5;
            // 
            // m_pnl_albuminfo
            // 
            this.m_pnl_albuminfo.BackColor = System.Drawing.Color.Transparent;
            this.m_pnl_albuminfo.Controls.Add(this.m_lbl_sep1);
            this.m_pnl_albuminfo.Controls.Add(this.m_lbl_albumintro);
            this.m_pnl_albuminfo.Controls.Add(this.m_pbx_cover);
            this.m_pnl_albuminfo.Controls.Add(this.m_lbl_albumname);
            this.m_pnl_albuminfo.Controls.Add(this.m_lbl_cat);
            this.m_pnl_albuminfo.Controls.Add(this.m_lbl_albumlabel);
            this.m_pnl_albuminfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_pnl_albuminfo.Location = new System.Drawing.Point(0, 0);
            this.m_pnl_albuminfo.Name = "m_pnl_albuminfo";
            this.m_pnl_albuminfo.Size = new System.Drawing.Size(1200, 172);
            this.m_pnl_albuminfo.TabIndex = 5;
            // 
            // m_lbl_sep2
            // 
            this.m_lbl_sep2.BackColor = System.Drawing.Color.Transparent;
            this.m_lbl_sep2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_lbl_sep2.Location = new System.Drawing.Point(0, 180);
            this.m_lbl_sep2.Name = "m_lbl_sep2";
            this.m_lbl_sep2.Size = new System.Drawing.Size(1200, 3);
            this.m_lbl_sep2.TabIndex = 6;
            // 
            // m_lbl_no
            // 
            this.m_lbl_no.AutoSize = true;
            this.m_lbl_no.Font = new System.Drawing.Font("宋体", 11F);
            this.m_lbl_no.Location = new System.Drawing.Point(38, 7);
            this.m_lbl_no.Name = "m_lbl_no";
            this.m_lbl_no.Size = new System.Drawing.Size(37, 15);
            this.m_lbl_no.TabIndex = 0;
            this.m_lbl_no.Text = "序号";
            // 
            // m_lbl_name
            // 
            this.m_lbl_name.AutoSize = true;
            this.m_lbl_name.Font = new System.Drawing.Font("宋体", 11F);
            this.m_lbl_name.Location = new System.Drawing.Point(152, 7);
            this.m_lbl_name.Name = "m_lbl_name";
            this.m_lbl_name.Size = new System.Drawing.Size(67, 15);
            this.m_lbl_name.TabIndex = 1;
            this.m_lbl_name.Text = "节目名称";
            // 
            // m_lbl_timelen
            // 
            this.m_lbl_timelen.AutoSize = true;
            this.m_lbl_timelen.Font = new System.Drawing.Font("宋体", 11F);
            this.m_lbl_timelen.Location = new System.Drawing.Point(338, 7);
            this.m_lbl_timelen.Name = "m_lbl_timelen";
            this.m_lbl_timelen.Size = new System.Drawing.Size(37, 15);
            this.m_lbl_timelen.TabIndex = 2;
            this.m_lbl_timelen.Text = "时长";
            // 
            // m_lbl_header_cat
            // 
            this.m_lbl_header_cat.AutoSize = true;
            this.m_lbl_header_cat.Font = new System.Drawing.Font("宋体", 11F);
            this.m_lbl_header_cat.Location = new System.Drawing.Point(470, 7);
            this.m_lbl_header_cat.Name = "m_lbl_header_cat";
            this.m_lbl_header_cat.Size = new System.Drawing.Size(37, 15);
            this.m_lbl_header_cat.TabIndex = 3;
            this.m_lbl_header_cat.Text = "类别";
            // 
            // m_lbl_updatetime
            // 
            this.m_lbl_updatetime.AutoSize = true;
            this.m_lbl_updatetime.Font = new System.Drawing.Font("宋体", 11F);
            this.m_lbl_updatetime.Location = new System.Drawing.Point(589, 7);
            this.m_lbl_updatetime.Name = "m_lbl_updatetime";
            this.m_lbl_updatetime.Size = new System.Drawing.Size(67, 15);
            this.m_lbl_updatetime.TabIndex = 4;
            this.m_lbl_updatetime.Text = "上传时间";
            // 
            // m_lbl_play_times
            // 
            this.m_lbl_play_times.AutoSize = true;
            this.m_lbl_play_times.Font = new System.Drawing.Font("宋体", 11F);
            this.m_lbl_play_times.Location = new System.Drawing.Point(736, 7);
            this.m_lbl_play_times.Name = "m_lbl_play_times";
            this.m_lbl_play_times.Size = new System.Drawing.Size(52, 15);
            this.m_lbl_play_times.TabIndex = 5;
            this.m_lbl_play_times.Text = "播放量";
            // 
            // m_lbl_share_times
            // 
            this.m_lbl_share_times.AutoSize = true;
            this.m_lbl_share_times.Font = new System.Drawing.Font("宋体", 11F);
            this.m_lbl_share_times.Location = new System.Drawing.Point(837, 7);
            this.m_lbl_share_times.Name = "m_lbl_share_times";
            this.m_lbl_share_times.Size = new System.Drawing.Size(52, 15);
            this.m_lbl_share_times.TabIndex = 6;
            this.m_lbl_share_times.Text = "转发量";
            // 
            // m_lbl_op
            // 
            this.m_lbl_op.AutoSize = true;
            this.m_lbl_op.Font = new System.Drawing.Font("宋体", 11F);
            this.m_lbl_op.Location = new System.Drawing.Point(969, 7);
            this.m_lbl_op.Name = "m_lbl_op";
            this.m_lbl_op.Size = new System.Drawing.Size(37, 15);
            this.m_lbl_op.TabIndex = 7;
            this.m_lbl_op.Text = "操作";
            // 
            // m_pnl_header
            // 
            this.m_pnl_header.Controls.Add(this.m_lbl_op);
            this.m_pnl_header.Controls.Add(this.m_lbl_share_times);
            this.m_pnl_header.Controls.Add(this.m_lbl_play_times);
            this.m_pnl_header.Controls.Add(this.m_lbl_updatetime);
            this.m_pnl_header.Controls.Add(this.m_lbl_header_cat);
            this.m_pnl_header.Controls.Add(this.m_lbl_timelen);
            this.m_pnl_header.Controls.Add(this.m_lbl_name);
            this.m_pnl_header.Controls.Add(this.m_lbl_no);
            this.m_pnl_header.Location = new System.Drawing.Point(0, 186);
            this.m_pnl_header.Name = "m_pnl_header";
            this.m_pnl_header.Size = new System.Drawing.Size(1200, 30);
            this.m_pnl_header.TabIndex = 7;
            // 
            // m_lbl_sep3
            // 
            this.m_lbl_sep3.BackColor = System.Drawing.Color.Transparent;
            this.m_lbl_sep3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_lbl_sep3.Location = new System.Drawing.Point(0, 219);
            this.m_lbl_sep3.Name = "m_lbl_sep3";
            this.m_lbl_sep3.Size = new System.Drawing.Size(1200, 3);
            this.m_lbl_sep3.TabIndex = 8;
            // 
            // m_lbl_sep4
            // 
            this.m_lbl_sep4.BackColor = System.Drawing.Color.Transparent;
            this.m_lbl_sep4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_lbl_sep4.Location = new System.Drawing.Point(0, 420);
            this.m_lbl_sep4.Name = "m_lbl_sep4";
            this.m_lbl_sep4.Size = new System.Drawing.Size(1200, 7);
            this.m_lbl_sep4.TabIndex = 15;
            // 
            // m_pc_programs
            // 
            this.m_pc_programs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.m_pc_programs.CurrentPage = 1;
            this.m_pc_programs.Location = new System.Drawing.Point(563, 439);
            this.m_pc_programs.Name = "m_pc_programs";
            this.m_pc_programs.RecordCount = 0;
            this.m_pc_programs.RowsPerPage = 5;
            this.m_pc_programs.Size = new System.Drawing.Size(509, 26);
            this.m_pc_programs.TabIndex = 16;
            this.m_pc_programs.TotalPage = 0;
            this.m_pc_programs.PageChange += new System.Action(this.m_pc_programs_PageChange);
            // 
            // m_bte_upload
            // 
            this.m_bte_upload.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(92)))));
            this.m_bte_upload.Font = new System.Drawing.Font("宋体", 11F);
            this.m_bte_upload.ForeColor = System.Drawing.Color.Black;
            this.m_bte_upload.Image = ((System.Drawing.Image)(resources.GetObject("m_bte_upload.Image")));
            this.m_bte_upload.Location = new System.Drawing.Point(44, 436);
            this.m_bte_upload.Name = "m_bte_upload";
            this.m_bte_upload.Size = new System.Drawing.Size(116, 36);
            this.m_bte_upload.TabIndex = 14;
            this.m_bte_upload.Text = "上传视频 ";
            this.m_bte_upload.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.m_bte_upload.UseVisualStyleBackColor = true;
            this.m_bte_upload.Click += new System.EventHandler(this.m_bte_upload_Click);
            // 
            // ProgramPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_pc_programs);
            this.Controls.Add(this.m_lbl_sep4);
            this.Controls.Add(this.m_bte_upload);
            this.Controls.Add(this.m_lbl_sep3);
            this.Controls.Add(this.m_pnl_header);
            this.Controls.Add(this.m_lbl_sep2);
            this.Controls.Add(this.m_pnl_albuminfo);
            this.Name = "ProgramPanel";
            this.Size = new System.Drawing.Size(1200, 480);
            this.Load += new System.EventHandler(this.ProgramPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_cover)).EndInit();
            this.m_pnl_albuminfo.ResumeLayout(false);
            this.m_pnl_albuminfo.PerformLayout();
            this.m_pnl_header.ResumeLayout(false);
            this.m_pnl_header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private XPTable.Models.TextColumn m_tc_no;
        private XPTable.Models.ButtonColumn m_bc_name;
        private XPTable.Models.TextColumn m_tc_timelen;
        private XPTable.Models.TextColumn m_tc_cat;
        private XPTable.Models.TextColumn m_tc_createat;
        private XPTable.Models.TextColumn m_tc_play_times;
        private XPTable.Models.TextColumn m_tc_share_times;
        private XPTable.Models.ButtonColumn m_bt_operations;
        private System.Windows.Forms.Label m_lbl_albumlabel;
        private System.Windows.Forms.Label m_lbl_cat;
        private System.Windows.Forms.Label m_lbl_albumname;
        private System.Windows.Forms.PictureBox m_pbx_cover;
        private System.Windows.Forms.Label m_lbl_albumintro;
        private System.Windows.Forms.Label m_lbl_sep1;
        private System.Windows.Forms.Panel m_pnl_albuminfo;
        private System.Windows.Forms.Label m_lbl_sep2;
        private System.Windows.Forms.Label m_lbl_no;
        private System.Windows.Forms.Label m_lbl_name;
        private System.Windows.Forms.Label m_lbl_timelen;
        private System.Windows.Forms.Label m_lbl_header_cat;
        private System.Windows.Forms.Label m_lbl_updatetime;
        private System.Windows.Forms.Label m_lbl_play_times;
        private System.Windows.Forms.Label m_lbl_share_times;
        private System.Windows.Forms.Label m_lbl_op;
        private System.Windows.Forms.Panel m_pnl_header;
        private System.Windows.Forms.Label m_lbl_sep3;
        private ButtonEx m_bte_upload;
        private System.Windows.Forms.Label m_lbl_sep4;
        private PagerControl m_pc_programs;
    }
}
