using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HGSystem
{
    public partial class FloatWindow : Form
    {
        private MainForm m_parent;
        private Point ptMouseCurrrnetPos, ptMouseNewPos, ptFormPos, ptFormNewPos;
        private bool blnMouseDown = false;

        public FloatWindow(MainForm parent)
        {
            InitializeComponent();
            m_parent = parent;
        }

        private void FloatWindow_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath mp = new System.Drawing.Drawing2D.GraphicsPath();
            mp.AddEllipse(0, 0, this.Width, this.Height);
            
            // mp.AddEllipse(60, 20, 20, 20);
            this.Region = new Region(mp);

            Graphics g = e.Graphics;
            /*Color FColor = Color.Red;
            Color TColor = Color.Yellow;
            Brush b = new LinearGradientBrush(this.ClientRectangle, FColor, TColor, LinearGradientMode.ForwardDiagonal);
            g.FillRectangle(b, this.ClientRectangle);*/

            Bitmap myBitmap = new Bitmap(@"D:\zhangguixin\myapps\HGSystem\res\float2.png");
            // Graphics g3 = Graphics.FromImage(myBitmap);
            g.DrawImage(myBitmap, 1, 1);

        }

        private void FloatWindow_Load(object sender, EventArgs e)
        {
            this.Top = Screen.PrimaryScreen.Bounds.Height - 500;
            this.Left = Screen.PrimaryScreen.Bounds.Width - 100;
            this.Width = 75;
            this.Height = 75;
        }

        /*
        // drag and drop
        const int WM_NCHITTEST = 0x0084;
        const int HTCLIENT = 0x0001;
        const int HTCAPTION = 0x0002;
        protected override void WndProc(ref System.Windows.Forms.Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    if (m.Result == (IntPtr)HTCLIENT)
                        m.Result = (IntPtr)HTCAPTION;
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
         * */

        private void FloatWindow_DoubleClick(object sender, EventArgs e)
        {
            SwitchToMain();
        }

        private void SwitchToMain()
        {
            //Change main window status here
            m_parent.RestoreWindow();
            //Hide top most window
            this.Hide();
        }

        private void FloatWindow_MouseMove(object sender, MouseEventArgs e)
        {
            if (blnMouseDown)
            {
                //Get the current position of the mouse in the screen
                ptMouseNewPos = Control.MousePosition;

                //Set window position
                ptFormNewPos.X = ptMouseNewPos.X - ptMouseCurrrnetPos.X + ptFormPos.X;
                ptFormNewPos.Y = ptMouseNewPos.Y - ptMouseCurrrnetPos.Y + ptFormPos.Y;

                //Save window position
                Location = ptFormNewPos;
                ptFormPos = ptFormNewPos;

                //Save mouse position
                ptMouseCurrrnetPos = ptMouseNewPos;
            }      
        }

        private void FloatWindow_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                blnMouseDown = true;
                // Save window position and mouse position
                ptMouseCurrrnetPos = Control.MousePosition;
                ptFormPos = Location;
            }
        }

        private void FloatWindow_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                //Return back signal
                blnMouseDown = false;
        }
    }
}
