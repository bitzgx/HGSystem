namespace HGSystem.UI
{
    partial class UploadAudioForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.m_lbl_caption = new System.Windows.Forms.Label();
            this.m_lbl_separate1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.m_bte_upload = new HGSystem.ButtonEx();
            this.m_bte_cancel = new HGSystem.ButtonEx();
            this.m_bte_shortaudio = new HGSystem.ButtonEx();
            this.m_bte_audio = new HGSystem.ButtonEx();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.m_bte_audio);
            this.panel1.Controls.Add(this.m_bte_shortaudio);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.m_lbl_caption);
            this.panel1.Controls.Add(this.m_lbl_separate1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.m_bte_upload);
            this.panel1.Controls.Add(this.m_bte_cancel);
            this.panel1.Location = new System.Drawing.Point(283, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(592, 600);
            this.panel1.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Location = new System.Drawing.Point(35, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(320, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "音频文件大小不超过1G，时长不超过5分钟。";
            // 
            // m_lbl_caption
            // 
            this.m_lbl_caption.AutoSize = true;
            this.m_lbl_caption.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_lbl_caption.Location = new System.Drawing.Point(266, 31);
            this.m_lbl_caption.Name = "m_lbl_caption";
            this.m_lbl_caption.Size = new System.Drawing.Size(76, 16);
            this.m_lbl_caption.TabIndex = 0;
            this.m_lbl_caption.Text = "上传音频";
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label9.Location = new System.Drawing.Point(35, 129);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "音频要求：";
            // 
            // m_bte_upload
            // 
            this.m_bte_upload.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(92)))));
            this.m_bte_upload.Font = new System.Drawing.Font("宋体", 10F);
            this.m_bte_upload.ForeColor = System.Drawing.Color.White;
            this.m_bte_upload.Location = new System.Drawing.Point(347, 545);
            this.m_bte_upload.Name = "m_bte_upload";
            this.m_bte_upload.Size = new System.Drawing.Size(75, 28);
            this.m_bte_upload.TabIndex = 7;
            this.m_bte_upload.Text = "开始上传";
            this.m_bte_upload.UseVisualStyleBackColor = true;
            this.m_bte_upload.Click += new System.EventHandler(this.m_bte_add_Click);
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
            // m_bte_shortaudio
            // 
            this.m_bte_shortaudio.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(92)))));
            this.m_bte_shortaudio.Font = new System.Drawing.Font("宋体", 11F);
            this.m_bte_shortaudio.Location = new System.Drawing.Point(38, 83);
            this.m_bte_shortaudio.Name = "m_bte_shortaudio";
            this.m_bte_shortaudio.Size = new System.Drawing.Size(75, 23);
            this.m_bte_shortaudio.TabIndex = 24;
            this.m_bte_shortaudio.Text = "短音频";
            this.m_bte_shortaudio.UseVisualStyleBackColor = true;
            this.m_bte_shortaudio.Click += new System.EventHandler(this.m_bte_shortaudio_Click);
            // 
            // m_bte_audio
            // 
            this.m_bte_audio.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(92)))));
            this.m_bte_audio.Font = new System.Drawing.Font("宋体", 11F);
            this.m_bte_audio.Location = new System.Drawing.Point(153, 83);
            this.m_bte_audio.Name = "m_bte_audio";
            this.m_bte_audio.Size = new System.Drawing.Size(75, 23);
            this.m_bte_audio.TabIndex = 24;
            this.m_bte_audio.Text = "音频";
            this.m_bte_audio.UseVisualStyleBackColor = true;
            this.m_bte_audio.Click += new System.EventHandler(this.m_bte_audio_Click);
            // 
            // UploadAudioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1200, 786);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UploadAudioForm";
            this.Opacity = 0.95D;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UploadAudioForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonEx m_bte_cancel;
        private ButtonEx m_bte_upload;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label m_lbl_caption;
        private System.Windows.Forms.Label m_lbl_separate1;
        private System.Windows.Forms.Label label9;
        private ButtonEx m_bte_audio;
        private ButtonEx m_bte_shortaudio;
    }
}