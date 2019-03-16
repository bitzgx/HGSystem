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
            this.m_btx_albumno = new System.Windows.Forms.TextBox();
            this.m_tbx_albumname = new System.Windows.Forms.TextBox();
            this.m_cbx_category = new System.Windows.Forms.ComboBox();
            this.m_btn_search = new HGSystem.ButtonEx();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // m_btx_albumno
            // 
            this.m_btx_albumno.Location = new System.Drawing.Point(24, 12);
            this.m_btx_albumno.Name = "m_btx_albumno";
            this.m_btx_albumno.Size = new System.Drawing.Size(100, 21);
            this.m_btx_albumno.TabIndex = 0;
            // 
            // m_tbx_albumname
            // 
            this.m_tbx_albumname.Location = new System.Drawing.Point(148, 12);
            this.m_tbx_albumname.Name = "m_tbx_albumname";
            this.m_tbx_albumname.Size = new System.Drawing.Size(100, 21);
            this.m_tbx_albumname.TabIndex = 1;
            // 
            // m_cbx_category
            // 
            this.m_cbx_category.FormattingEnabled = true;
            this.m_cbx_category.Location = new System.Drawing.Point(274, 13);
            this.m_cbx_category.Name = "m_cbx_category";
            this.m_cbx_category.Size = new System.Drawing.Size(121, 20);
            this.m_cbx_category.TabIndex = 2;
            // 
            // m_btn_search
            // 
            this.m_btn_search.BaseColor = System.Drawing.Color.Firebrick;
            this.m_btn_search.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.m_btn_search.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.m_btn_search.Location = new System.Drawing.Point(420, 10);
            this.m_btn_search.Name = "m_btn_search";
            this.m_btn_search.Size = new System.Drawing.Size(75, 23);
            this.m_btn_search.TabIndex = 3;
            this.m_btn_search.Text = "搜索";
            this.m_btn_search.UseVisualStyleBackColor = true;
            // 
            // ContentPublish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_btn_search);
            this.Controls.Add(this.m_cbx_category);
            this.Controls.Add(this.m_tbx_albumname);
            this.Controls.Add(this.m_btx_albumno);
            this.Name = "ContentPublish";
            this.Size = new System.Drawing.Size(778, 485);
            this.Load += new System.EventHandler(this.ContentPublish_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox m_btx_albumno;
        private System.Windows.Forms.TextBox m_tbx_albumname;
        private System.Windows.Forms.ComboBox m_cbx_category;
        private ButtonEx m_btn_search;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
