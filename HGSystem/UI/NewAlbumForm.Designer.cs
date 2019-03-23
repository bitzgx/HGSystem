namespace HGSystem.UI
{
    partial class NewAlbumForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAlbumForm));
            this.m_lbl_caption = new System.Windows.Forms.Label();
            this.m_lbl_separate1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.m_tbx_albumname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_tbx_albumtags = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.m_tbx_albumintro = new System.Windows.Forms.TextBox();
            this.m_cbx_albumcat1 = new System.Windows.Forms.ComboBox();
            this.m_cbx_albumcat2 = new System.Windows.Forms.ComboBox();
            this.m_cbx_albumcat3 = new System.Windows.Forms.ComboBox();
            this.m_pbx_albumcover = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.m_bte_add = new HGSystem.ButtonEx();
            this.m_bte_cancel = new HGSystem.ButtonEx();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_albumcover)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_lbl_caption
            // 
            this.m_lbl_caption.AutoSize = true;
            this.m_lbl_caption.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_lbl_caption.Location = new System.Drawing.Point(266, 31);
            this.m_lbl_caption.Name = "m_lbl_caption";
            this.m_lbl_caption.Size = new System.Drawing.Size(76, 16);
            this.m_lbl_caption.TabIndex = 0;
            this.m_lbl_caption.Text = "新建专辑";
            // 
            // m_lbl_separate1
            // 
            this.m_lbl_separate1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_lbl_separate1.ForeColor = System.Drawing.Color.Gray;
            this.m_lbl_separate1.Location = new System.Drawing.Point(15, 59);
            this.m_lbl_separate1.Name = "m_lbl_separate1";
            this.m_lbl_separate1.Size = new System.Drawing.Size(562, 2);
            this.m_lbl_separate1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(34, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 14);
            this.label1.TabIndex = 2;
            this.label1.Text = "专辑名称：";
            // 
            // m_tbx_albumname
            // 
            this.m_tbx_albumname.Font = new System.Drawing.Font("宋体", 12F);
            this.m_tbx_albumname.Location = new System.Drawing.Point(124, 74);
            this.m_tbx_albumname.Name = "m_tbx_albumname";
            this.m_tbx_albumname.Size = new System.Drawing.Size(287, 26);
            this.m_tbx_albumname.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(25, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 14);
            this.label2.TabIndex = 4;
            this.label2.Text = "*";
            // 
            // m_tbx_albumtags
            // 
            this.m_tbx_albumtags.Font = new System.Drawing.Font("宋体", 12F);
            this.m_tbx_albumtags.Location = new System.Drawing.Point(124, 114);
            this.m_tbx_albumtags.Name = "m_tbx_albumtags";
            this.m_tbx_albumtags.Size = new System.Drawing.Size(287, 26);
            this.m_tbx_albumtags.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F);
            this.label3.Location = new System.Drawing.Point(34, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "专辑标签：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10F);
            this.label4.Location = new System.Drawing.Point(34, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "专辑分类：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10F);
            this.label5.Location = new System.Drawing.Point(34, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "专辑简介：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10F);
            this.label6.Location = new System.Drawing.Point(34, 351);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 14);
            this.label6.TabIndex = 10;
            this.label6.Text = "专辑封面：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10F);
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(25, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 14);
            this.label7.TabIndex = 11;
            this.label7.Text = "*";
            // 
            // m_tbx_albumintro
            // 
            this.m_tbx_albumintro.Location = new System.Drawing.Point(124, 196);
            this.m_tbx_albumintro.Multiline = true;
            this.m_tbx_albumintro.Name = "m_tbx_albumintro";
            this.m_tbx_albumintro.Size = new System.Drawing.Size(432, 140);
            this.m_tbx_albumintro.TabIndex = 5;
            // 
            // m_cbx_albumcat1
            // 
            this.m_cbx_albumcat1.Font = new System.Drawing.Font("宋体", 12F);
            this.m_cbx_albumcat1.FormattingEnabled = true;
            this.m_cbx_albumcat1.Location = new System.Drawing.Point(124, 153);
            this.m_cbx_albumcat1.Name = "m_cbx_albumcat1";
            this.m_cbx_albumcat1.Size = new System.Drawing.Size(134, 24);
            this.m_cbx_albumcat1.TabIndex = 2;
            this.m_cbx_albumcat1.SelectedIndexChanged += new System.EventHandler(this.m_cbx_albumcat1_SelectedIndexChanged);
            // 
            // m_cbx_albumcat2
            // 
            this.m_cbx_albumcat2.Font = new System.Drawing.Font("宋体", 12F);
            this.m_cbx_albumcat2.FormattingEnabled = true;
            this.m_cbx_albumcat2.Location = new System.Drawing.Point(273, 153);
            this.m_cbx_albumcat2.Name = "m_cbx_albumcat2";
            this.m_cbx_albumcat2.Size = new System.Drawing.Size(134, 24);
            this.m_cbx_albumcat2.TabIndex = 3;
            this.m_cbx_albumcat2.SelectedIndexChanged += new System.EventHandler(this.m_cbx_albumcat2_SelectedIndexChanged);
            // 
            // m_cbx_albumcat3
            // 
            this.m_cbx_albumcat3.Font = new System.Drawing.Font("宋体", 12F);
            this.m_cbx_albumcat3.FormattingEnabled = true;
            this.m_cbx_albumcat3.Location = new System.Drawing.Point(422, 153);
            this.m_cbx_albumcat3.Name = "m_cbx_albumcat3";
            this.m_cbx_albumcat3.Size = new System.Drawing.Size(134, 24);
            this.m_cbx_albumcat3.TabIndex = 4;
            // 
            // m_pbx_albumcover
            // 
            this.m_pbx_albumcover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.m_pbx_albumcover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.m_pbx_albumcover.Image = ((System.Drawing.Image)(resources.GetObject("m_pbx_albumcover.Image")));
            this.m_pbx_albumcover.InitialImage = null;
            this.m_pbx_albumcover.Location = new System.Drawing.Point(124, 351);
            this.m_pbx_albumcover.Name = "m_pbx_albumcover";
            this.m_pbx_albumcover.Size = new System.Drawing.Size(180, 180);
            this.m_pbx_albumcover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_pbx_albumcover.TabIndex = 16;
            this.m_pbx_albumcover.TabStop = false;
            this.m_pbx_albumcover.Click += new System.EventHandler(this.m_pbx_albumcover_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(321, 366);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 16);
            this.label8.TabIndex = 20;
            this.label8.Text = "推荐最佳尺寸为600*600";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(321, 409);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(176, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "最小尺寸应大于300*300";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F);
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label10.Location = new System.Drawing.Point(321, 450);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(112, 16);
            this.label10.TabIndex = 22;
            this.label10.Text = "图片应小于1MB";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Location = new System.Drawing.Point(321, 489);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(256, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "图片支持格式jpeg, jpg, png, bmp";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.m_tbx_albumintro);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.m_lbl_caption);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.m_lbl_separate1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.m_tbx_albumname);
            this.panel1.Controls.Add(this.m_bte_add);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.m_bte_cancel);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.m_pbx_albumcover);
            this.panel1.Controls.Add(this.m_tbx_albumtags);
            this.panel1.Controls.Add(this.m_cbx_albumcat3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.m_cbx_albumcat2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.m_cbx_albumcat1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(283, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 600);
            this.panel1.TabIndex = 24;
            // 
            // m_bte_add
            // 
            this.m_bte_add.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(92)))));
            this.m_bte_add.Font = new System.Drawing.Font("宋体", 10F);
            this.m_bte_add.ForeColor = System.Drawing.Color.White;
            this.m_bte_add.Location = new System.Drawing.Point(347, 545);
            this.m_bte_add.Name = "m_bte_add";
            this.m_bte_add.Size = new System.Drawing.Size(75, 28);
            this.m_bte_add.TabIndex = 7;
            this.m_bte_add.Text = "创建";
            this.m_bte_add.UseVisualStyleBackColor = true;
            this.m_bte_add.Click += new System.EventHandler(this.m_bte_add_Click);
            // 
            // m_bte_cancel
            // 
            this.m_bte_cancel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.m_bte_cancel.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.m_bte_cancel.Font = new System.Drawing.Font("宋体", 10F);
            this.m_bte_cancel.ForeColor = System.Drawing.Color.Black;
            this.m_bte_cancel.Location = new System.Drawing.Point(190, 545);
            this.m_bte_cancel.Name = "m_bte_cancel";
            this.m_bte_cancel.Size = new System.Drawing.Size(75, 28);
            this.m_bte_cancel.TabIndex = 6;
            this.m_bte_cancel.Text = "取消";
            this.m_bte_cancel.UseVisualStyleBackColor = false;
            this.m_bte_cancel.Click += new System.EventHandler(this.m_bte_cancel_Click);
            // 
            // NewAlbumForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1200, 786);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewAlbumForm";
            this.Opacity = 0.95D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NewAlbumForm";
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_albumcover)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label m_lbl_caption;
        private System.Windows.Forms.Label m_lbl_separate1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_tbx_albumname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_tbx_albumtags;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox m_tbx_albumintro;
        private System.Windows.Forms.ComboBox m_cbx_albumcat1;
        private System.Windows.Forms.ComboBox m_cbx_albumcat2;
        private System.Windows.Forms.ComboBox m_cbx_albumcat3;
        private System.Windows.Forms.PictureBox m_pbx_albumcover;
        private ButtonEx m_bte_cancel;
        private ButtonEx m_bte_add;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
    }
}