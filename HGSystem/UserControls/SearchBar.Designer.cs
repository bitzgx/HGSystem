namespace HGSystem.UserControls
{
    partial class SearchBar
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
            this.m_btn_search = new HGSystem.ButtonEx();
            this.m_cbx_category = new System.Windows.Forms.ComboBox();
            this.m_tbx_albumname = new System.Windows.Forms.TextBox();
            this.m_tbx_albumno = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // m_btn_search
            // 
            this.m_btn_search.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(92)))));
            this.m_btn_search.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.m_btn_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_btn_search.Location = new System.Drawing.Point(686, 9);
            this.m_btn_search.Name = "m_btn_search";
            this.m_btn_search.Size = new System.Drawing.Size(88, 28);
            this.m_btn_search.TabIndex = 7;
            this.m_btn_search.Text = "搜索";
            this.m_btn_search.UseVisualStyleBackColor = true;
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
            this.m_cbx_category.Location = new System.Drawing.Point(474, 13);
            this.m_cbx_category.Name = "m_cbx_category";
            this.m_cbx_category.Size = new System.Drawing.Size(186, 24);
            this.m_cbx_category.TabIndex = 6;
            this.m_cbx_category.Text = "全部";
            // 
            // m_tbx_albumname
            // 
            this.m_tbx_albumname.BackColor = System.Drawing.SystemColors.ControlLight;
            this.m_tbx_albumname.Font = new System.Drawing.Font("宋体", 12F);
            this.m_tbx_albumname.Location = new System.Drawing.Point(262, 13);
            this.m_tbx_albumname.Name = "m_tbx_albumname";
            this.m_tbx_albumname.Size = new System.Drawing.Size(186, 26);
            this.m_tbx_albumname.TabIndex = 5;
            this.m_tbx_albumname.Text = "专辑名称";
            // 
            // m_tbx_albumno
            // 
            this.m_tbx_albumno.BackColor = System.Drawing.SystemColors.ControlLight;
            this.m_tbx_albumno.Font = new System.Drawing.Font("宋体", 12F);
            this.m_tbx_albumno.Location = new System.Drawing.Point(50, 13);
            this.m_tbx_albumno.Name = "m_tbx_albumno";
            this.m_tbx_albumno.Size = new System.Drawing.Size(186, 26);
            this.m_tbx_albumno.TabIndex = 4;
            this.m_tbx_albumno.Text = "专辑编号";
            // 
            // SearchBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_btn_search);
            this.Controls.Add(this.m_cbx_category);
            this.Controls.Add(this.m_tbx_albumname);
            this.Controls.Add(this.m_tbx_albumno);
            this.Name = "SearchBar";
            this.Size = new System.Drawing.Size(1200, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonEx m_btn_search;
        private System.Windows.Forms.ComboBox m_cbx_category;
        private System.Windows.Forms.TextBox m_tbx_albumname;
        private System.Windows.Forms.TextBox m_tbx_albumno;
    }
}
