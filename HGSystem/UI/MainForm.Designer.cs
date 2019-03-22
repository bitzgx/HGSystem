namespace HGSystem
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.m_pbx_logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_btn_close = new HGSystem.ButtonEx();
            this.m_btn_minimize = new HGSystem.ButtonEx();
            this.m_btn_notifications = new HGSystem.ButtonEx();
            this.m_btn_settings = new HGSystem.ButtonEx();
            this.m_btn_profile = new HGSystem.ButtonEx();
            this.m_btn_material = new HGSystem.ButtonEx();
            this.m_btn_hgplan = new HGSystem.ButtonEx();
            this.m_btn_content = new HGSystem.ButtonEx();
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // m_pbx_logo
            // 
            this.m_pbx_logo.Image = ((System.Drawing.Image)(resources.GetObject("m_pbx_logo.Image")));
            this.m_pbx_logo.Location = new System.Drawing.Point(50, 21);
            this.m_pbx_logo.Name = "m_pbx_logo";
            this.m_pbx_logo.Size = new System.Drawing.Size(180, 38);
            this.m_pbx_logo.TabIndex = 1;
            this.m_pbx_logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(0, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1200, 3);
            this.label1.TabIndex = 10;
            // 
            // m_btn_close
            // 
            this.m_btn_close.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(78)))), ((int)(((byte)(45)))));
            this.m_btn_close.Image = ((System.Drawing.Image)(resources.GetObject("m_btn_close.Image")));
            this.m_btn_close.Location = new System.Drawing.Point(1137, 21);
            this.m_btn_close.Name = "m_btn_close";
            this.m_btn_close.Radius = 60;
            this.m_btn_close.Size = new System.Drawing.Size(34, 30);
            this.m_btn_close.TabIndex = 8;
            this.m_btn_close.UseVisualStyleBackColor = true;
            this.m_btn_close.Click += new System.EventHandler(this.m_btn_close_Click);
            // 
            // m_btn_minimize
            // 
            this.m_btn_minimize.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(78)))), ((int)(((byte)(45)))));
            this.m_btn_minimize.Image = ((System.Drawing.Image)(resources.GetObject("m_btn_minimize.Image")));
            this.m_btn_minimize.Location = new System.Drawing.Point(1080, 21);
            this.m_btn_minimize.Name = "m_btn_minimize";
            this.m_btn_minimize.Radius = 50;
            this.m_btn_minimize.Size = new System.Drawing.Size(34, 30);
            this.m_btn_minimize.TabIndex = 7;
            this.m_btn_minimize.UseVisualStyleBackColor = true;
            // 
            // m_btn_notifications
            // 
            this.m_btn_notifications.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(78)))), ((int)(((byte)(45)))));
            this.m_btn_notifications.Image = ((System.Drawing.Image)(resources.GetObject("m_btn_notifications.Image")));
            this.m_btn_notifications.Location = new System.Drawing.Point(1023, 21);
            this.m_btn_notifications.Name = "m_btn_notifications";
            this.m_btn_notifications.Radius = 40;
            this.m_btn_notifications.Size = new System.Drawing.Size(34, 30);
            this.m_btn_notifications.TabIndex = 6;
            this.m_btn_notifications.UseVisualStyleBackColor = true;
            // 
            // m_btn_settings
            // 
            this.m_btn_settings.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(78)))), ((int)(((byte)(45)))));
            this.m_btn_settings.Image = ((System.Drawing.Image)(resources.GetObject("m_btn_settings.Image")));
            this.m_btn_settings.Location = new System.Drawing.Point(973, 21);
            this.m_btn_settings.Name = "m_btn_settings";
            this.m_btn_settings.Radius = 40;
            this.m_btn_settings.Size = new System.Drawing.Size(32, 30);
            this.m_btn_settings.TabIndex = 5;
            this.m_btn_settings.UseVisualStyleBackColor = true;
            // 
            // m_btn_profile
            // 
            this.m_btn_profile.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(78)))), ((int)(((byte)(45)))));
            this.m_btn_profile.Image = ((System.Drawing.Image)(resources.GetObject("m_btn_profile.Image")));
            this.m_btn_profile.Location = new System.Drawing.Point(923, 21);
            this.m_btn_profile.Name = "m_btn_profile";
            this.m_btn_profile.Radius = 40;
            this.m_btn_profile.Size = new System.Drawing.Size(27, 30);
            this.m_btn_profile.TabIndex = 4;
            this.m_btn_profile.UseVisualStyleBackColor = true;
            this.m_btn_profile.Click += new System.EventHandler(this.m_btn_profile_Click);
            // 
            // m_btn_material
            // 
            this.m_btn_material.BaseColor = System.Drawing.Color.White;
            this.m_btn_material.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.m_btn_material.Location = new System.Drawing.Point(683, 21);
            this.m_btn_material.Name = "m_btn_material";
            this.m_btn_material.Radius = 42;
            this.m_btn_material.Size = new System.Drawing.Size(116, 36);
            this.m_btn_material.TabIndex = 3;
            this.m_btn_material.Text = "素材专栏";
            this.m_btn_material.UseVisualStyleBackColor = true;
            this.m_btn_material.Click += new System.EventHandler(this.m_btn_material_Click);
            // 
            // m_btn_hgplan
            // 
            this.m_btn_hgplan.BaseColor = System.Drawing.Color.White;
            this.m_btn_hgplan.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.m_btn_hgplan.ForeColor = System.Drawing.Color.Black;
            this.m_btn_hgplan.Location = new System.Drawing.Point(521, 21);
            this.m_btn_hgplan.Name = "m_btn_hgplan";
            this.m_btn_hgplan.Radius = 42;
            this.m_btn_hgplan.Size = new System.Drawing.Size(116, 36);
            this.m_btn_hgplan.TabIndex = 2;
            this.m_btn_hgplan.Text = "红广计划";
            this.m_btn_hgplan.UseVisualStyleBackColor = true;
            this.m_btn_hgplan.Click += new System.EventHandler(this.m_btn_hgplan_Click);
            // 
            // m_btn_content
            // 
            this.m_btn_content.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(92)))));
            this.m_btn_content.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Bold);
            this.m_btn_content.ForeColor = System.Drawing.Color.White;
            this.m_btn_content.Location = new System.Drawing.Point(357, 22);
            this.m_btn_content.Name = "m_btn_content";
            this.m_btn_content.Radius = 42;
            this.m_btn_content.Size = new System.Drawing.Size(116, 36);
            this.m_btn_content.TabIndex = 0;
            this.m_btn_content.Text = "内容发布";
            this.m_btn_content.UseVisualStyleBackColor = true;
            this.m_btn_content.Click += new System.EventHandler(this.m_btn_content_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1200, 786);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_btn_close);
            this.Controls.Add(this.m_btn_minimize);
            this.Controls.Add(this.m_btn_notifications);
            this.Controls.Add(this.m_btn_settings);
            this.Controls.Add(this.m_btn_profile);
            this.Controls.Add(this.m_btn_material);
            this.Controls.Add(this.m_btn_hgplan);
            this.Controls.Add(this.m_pbx_logo);
            this.Controls.Add(this.m_btn_content);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.m_pbx_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonEx m_btn_content;
        private System.Windows.Forms.PictureBox m_pbx_logo;
        private ButtonEx m_btn_hgplan;
        private ButtonEx m_btn_material;
        private ButtonEx m_btn_profile;
        private ButtonEx m_btn_settings;
        private ButtonEx m_btn_notifications;
        private ButtonEx m_btn_minimize;
        private ButtonEx m_btn_close;
        private System.Windows.Forms.Label label1;


    }
}