﻿namespace HGSystem
{
    partial class FloatWindow
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
            this.SuspendLayout();
            // 
            // FloatWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 192);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FloatWindow";
            this.Text = "FloatWindow";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FloatWindow_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.FloatWindow_Paint);
            this.DoubleClick += new System.EventHandler(this.FloatWindow_DoubleClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FloatWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FloatWindow_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FloatWindow_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

    }
}