namespace HGSystem.UI
{
    partial class UploadVideoForm
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
            this.m_lbl_caption = new System.Windows.Forms.Label();
            this.m_lbl_separate1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.m_bte_upload = new HGSystem.ButtonEx();
            this.m_bte_cancel = new HGSystem.ButtonEx();
            this.label11 = new System.Windows.Forms.Label();
            this.m_bte_shortvideo = new HGSystem.ButtonEx();
            this.m_bte_video = new HGSystem.ButtonEx();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.m_bte_video);
            this.panel1.Controls.Add(this.m_bte_shortvideo);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.m_lbl_caption);
            this.panel1.Controls.Add(this.m_lbl_separate1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.m_bte_upload);
            this.panel1.Controls.Add(this.m_bte_cancel);
            this.panel1.Location = new System.Drawing.Point(348, 150);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 438);
            this.panel1.TabIndex = 24;
            // 
            // m_lbl_caption
            // 
            this.m_lbl_caption.AutoSize = true;
            this.m_lbl_caption.Font = new System.Drawing.Font("新宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.m_lbl_caption.Location = new System.Drawing.Point(216, 25);
            this.m_lbl_caption.Name = "m_lbl_caption";
            this.m_lbl_caption.Size = new System.Drawing.Size(76, 16);
            this.m_lbl_caption.TabIndex = 0;
            this.m_lbl_caption.Text = "上传视频";
            // 
            // m_lbl_separate1
            // 
            this.m_lbl_separate1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.m_lbl_separate1.ForeColor = System.Drawing.Color.Gray;
            this.m_lbl_separate1.Location = new System.Drawing.Point(15, 55);
            this.m_lbl_separate1.Name = "m_lbl_separate1";
            this.m_lbl_separate1.Size = new System.Drawing.Size(475, 3);
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
            this.label9.Text = "视频要求：";
            // 
            // m_bte_upload
            // 
            this.m_bte_upload.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(92)))));
            this.m_bte_upload.Font = new System.Drawing.Font("宋体", 10F);
            this.m_bte_upload.ForeColor = System.Drawing.Color.White;
            this.m_bte_upload.Location = new System.Drawing.Point(280, 393);
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
            this.m_bte_cancel.Location = new System.Drawing.Point(123, 393);
            this.m_bte_cancel.Name = "m_bte_cancel";
            this.m_bte_cancel.Size = new System.Drawing.Size(75, 28);
            this.m_bte_cancel.TabIndex = 6;
            this.m_bte_cancel.Text = "取消";
            this.m_bte_cancel.UseVisualStyleBackColor = false;
            this.m_bte_cancel.Click += new System.EventHandler(this.m_bte_cancel_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 12F);
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label11.Location = new System.Drawing.Point(35, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(344, 16);
            this.label11.TabIndex = 23;
            this.label11.Text = "1. 视频文件大小不超过1G，时长不超过5分钟。";
            // 
            // m_bte_shortvideo
            // 
            this.m_bte_shortvideo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(92)))));
            this.m_bte_shortvideo.Font = new System.Drawing.Font("宋体", 11F);
            this.m_bte_shortvideo.Location = new System.Drawing.Point(38, 83);
            this.m_bte_shortvideo.Name = "m_bte_shortvideo";
            this.m_bte_shortvideo.Size = new System.Drawing.Size(75, 23);
            this.m_bte_shortvideo.TabIndex = 24;
            this.m_bte_shortvideo.Text = "短视频";
            this.m_bte_shortvideo.UseVisualStyleBackColor = true;
            this.m_bte_shortvideo.Click += new System.EventHandler(this.m_bte_shortaudio_Click);
            // 
            // m_bte_video
            // 
            this.m_bte_video.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(100)))), ((int)(((byte)(92)))));
            this.m_bte_video.Font = new System.Drawing.Font("宋体", 11F);
            this.m_bte_video.Location = new System.Drawing.Point(153, 83);
            this.m_bte_video.Name = "m_bte_video";
            this.m_bte_video.Size = new System.Drawing.Size(75, 23);
            this.m_bte_video.TabIndex = 24;
            this.m_bte_video.Text = "视频";
            this.m_bte_video.UseVisualStyleBackColor = true;
            this.m_bte_video.Click += new System.EventHandler(this.m_bte_audio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Location = new System.Drawing.Point(35, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "3. 请勿上传色情、反动等违法视频";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Location = new System.Drawing.Point(35, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(344, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "2. 视频格式必须为MP4，推荐分辨率为1280*720";
            // 
            // UploadVideoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(1200, 786);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UploadVideoForm";
            this.Opacity = 0.97D;
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
        private System.Windows.Forms.Label m_lbl_caption;
        private System.Windows.Forms.Label m_lbl_separate1;
        private System.Windows.Forms.Label label9;
        private ButtonEx m_bte_video;
        private ButtonEx m_bte_shortvideo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}