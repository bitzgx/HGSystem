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
            this.m_pbx_cover = new System.Windows.Forms.PictureBox();
            this.m_lbl_albumname = new System.Windows.Forms.Label();
            this.m_lbl_albumlabel = new System.Windows.Forms.Label();
            this.m_lbl_cat = new System.Windows.Forms.Label();
            this.m_pnl_albuminfo = new System.Windows.Forms.Panel();
            this.m_lbl_albumintro = new System.Windows.Forms.Label();
            this.m_tc_no = new XPTable.Models.TextColumn();
            this.m_bc_name = new XPTable.Models.ButtonColumn();
            this.m_tc_timelen = new XPTable.Models.TextColumn();
            this.m_tc_cat = new XPTable.Models.TextColumn();
            this.m_tc_createat = new XPTable.Models.TextColumn();
            this.m_tc_play_times = new XPTable.Models.TextColumn();
            this.m_tc_share_times = new XPTable.Models.TextColumn();
            this.m_bt_operations = new XPTable.Models.ButtonColumn();
            this.m_lbl_sep1 = new System.Windows.Forms.Label();
            this.m_lbl_sep2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_cover)).BeginInit();
            this.m_pnl_albuminfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_pbx_cover
            // 
            this.m_pbx_cover.Location = new System.Drawing.Point(44, 17);
            this.m_pbx_cover.Name = "m_pbx_cover";
            this.m_pbx_cover.Size = new System.Drawing.Size(167, 155);
            this.m_pbx_cover.TabIndex = 0;
            this.m_pbx_cover.TabStop = false;
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
            // m_tc_no
            // 
            this.m_tc_no.Editable = false;
            this.m_tc_no.Sortable = false;
            this.m_tc_no.Text = "序号";
            // 
            // m_bc_name
            // 
            this.m_bc_name.Text = "节目名称";
            this.m_bc_name.Width = 175;
            // 
            // m_tc_timelen
            // 
            this.m_tc_timelen.Editable = false;
            this.m_tc_timelen.Text = "时长";
            this.m_tc_timelen.Width = 100;
            // 
            // m_tc_cat
            // 
            this.m_tc_cat.Text = "类别";
            // 
            // m_tc_createat
            // 
            this.m_tc_createat.Text = "上传时间";
            // 
            // m_tc_play_times
            // 
            this.m_tc_play_times.Text = "播放量";
            // 
            // m_tc_share_times
            // 
            this.m_tc_share_times.Text = "转发量";
            // 
            // m_bt_operations
            // 
            this.m_bt_operations.Text = "操作";
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
            // m_lbl_sep2
            // 
            this.m_lbl_sep2.BackColor = System.Drawing.Color.Transparent;
            this.m_lbl_sep2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_lbl_sep2.Location = new System.Drawing.Point(0, 180);
            this.m_lbl_sep2.Name = "m_lbl_sep2";
            this.m_lbl_sep2.Size = new System.Drawing.Size(1200, 3);
            this.m_lbl_sep2.TabIndex = 6;
            // 
            // ProgramPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_lbl_sep2);
            this.Controls.Add(this.m_pnl_albuminfo);
            this.Enabled = false;
            this.Name = "ProgramPanel";
            this.Size = new System.Drawing.Size(1200, 768);
            this.Load += new System.EventHandler(this.ProgramPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_cover)).EndInit();
            this.m_pnl_albuminfo.ResumeLayout(false);
            this.m_pnl_albuminfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox m_pbx_cover;
        private System.Windows.Forms.Label m_lbl_albumname;
        private System.Windows.Forms.Label m_lbl_albumlabel;
        private System.Windows.Forms.Label m_lbl_cat;
        private System.Windows.Forms.Panel m_pnl_albuminfo;
        private System.Windows.Forms.Label m_lbl_albumintro;
        private XPTable.Models.TextColumn m_tc_no;
        private XPTable.Models.ButtonColumn m_bc_name;
        private XPTable.Models.TextColumn m_tc_timelen;
        private XPTable.Models.TextColumn m_tc_cat;
        private XPTable.Models.TextColumn m_tc_createat;
        private XPTable.Models.TextColumn m_tc_play_times;
        private XPTable.Models.TextColumn m_tc_share_times;
        private XPTable.Models.ButtonColumn m_bt_operations;
        private System.Windows.Forms.Label m_lbl_sep1;
        private System.Windows.Forms.Label m_lbl_sep2;
    }
}
