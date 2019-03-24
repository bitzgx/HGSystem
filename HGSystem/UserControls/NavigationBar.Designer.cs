namespace HGSystem.UserControls
{
    partial class NavigationBar
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
            this.m_lbl_back = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_lbl_back
            // 
            this.m_lbl_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_lbl_back.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Bold);
            this.m_lbl_back.Location = new System.Drawing.Point(50, 16);
            this.m_lbl_back.Name = "m_lbl_back";
            this.m_lbl_back.Size = new System.Drawing.Size(28, 23);
            this.m_lbl_back.TabIndex = 0;
            this.m_lbl_back.Text = "<";
            this.m_lbl_back.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.m_lbl_back.Click += new System.EventHandler(this.m_lbl_back_Click);
            // 
            // NavigationBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.m_lbl_back);
            this.Name = "NavigationBar";
            this.Size = new System.Drawing.Size(1160, 50);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label m_lbl_back;
    }
}
