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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_cover)).BeginInit();
            this.m_pnl_albuminfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_pbx_cover
            // 
            this.m_pbx_cover.Location = new System.Drawing.Point(54, 20);
            this.m_pbx_cover.Name = "m_pbx_cover";
            this.m_pbx_cover.Size = new System.Drawing.Size(167, 155);
            this.m_pbx_cover.TabIndex = 0;
            this.m_pbx_cover.TabStop = false;
            // 
            // m_lbl_albumname
            // 
            this.m_lbl_albumname.AutoSize = true;
            this.m_lbl_albumname.Font = new System.Drawing.Font("宋体", 16F, System.Drawing.FontStyle.Bold);
            this.m_lbl_albumname.Location = new System.Drawing.Point(244, 20);
            this.m_lbl_albumname.Name = "m_lbl_albumname";
            this.m_lbl_albumname.Size = new System.Drawing.Size(102, 22);
            this.m_lbl_albumname.TabIndex = 1;
            this.m_lbl_albumname.Text = "专辑标题";
            // 
            // m_lbl_albumlabel
            // 
            this.m_lbl_albumlabel.AutoSize = true;
            this.m_lbl_albumlabel.Font = new System.Drawing.Font("宋体", 11F);
            this.m_lbl_albumlabel.Location = new System.Drawing.Point(245, 56);
            this.m_lbl_albumlabel.Name = "m_lbl_albumlabel";
            this.m_lbl_albumlabel.Size = new System.Drawing.Size(52, 15);
            this.m_lbl_albumlabel.TabIndex = 2;
            this.m_lbl_albumlabel.Text = "标签：";
            // 
            // m_lbl_cat
            // 
            this.m_lbl_cat.AutoSize = true;
            this.m_lbl_cat.Font = new System.Drawing.Font("宋体", 11F);
            this.m_lbl_cat.Location = new System.Drawing.Point(245, 85);
            this.m_lbl_cat.Name = "m_lbl_cat";
            this.m_lbl_cat.Size = new System.Drawing.Size(52, 15);
            this.m_lbl_cat.TabIndex = 3;
            this.m_lbl_cat.Text = "分类：";
            // 
            // m_pnl_albuminfo
            // 
            this.m_pnl_albuminfo.BackColor = System.Drawing.Color.Transparent;
            this.m_pnl_albuminfo.Controls.Add(this.label1);
            this.m_pnl_albuminfo.Controls.Add(this.m_pbx_cover);
            this.m_pnl_albuminfo.Controls.Add(this.m_lbl_albumname);
            this.m_pnl_albuminfo.Controls.Add(this.m_lbl_cat);
            this.m_pnl_albuminfo.Controls.Add(this.m_lbl_albumlabel);
            this.m_pnl_albuminfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.m_pnl_albuminfo.Location = new System.Drawing.Point(0, 0);
            this.m_pnl_albuminfo.Name = "m_pnl_albuminfo";
            this.m_pnl_albuminfo.Size = new System.Drawing.Size(1200, 206);
            this.m_pnl_albuminfo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 11F);
            this.label1.Location = new System.Drawing.Point(245, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 65);
            this.label1.TabIndex = 4;
            this.label1.Text = "简介：回不去的故乡 暖暖的心，贴近彼此 今冬无雪 年少当有为 一念起，天涯咫尺 永远不落的追忆。乡村炊烟，让人魂牵梦萦 孤岛山城，后会无期 清风不扰客，留香等人寻" +
    " 曾经 芳华当惜取 忘不掉和记不起";
            // 
            // ProgramPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_pnl_albuminfo);
            this.Enabled = false;
            this.Name = "ProgramPanel";
            this.Size = new System.Drawing.Size(1200, 768);
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
        private System.Windows.Forms.Label label1;
    }
}
