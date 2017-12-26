using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Management;
namespace _2048
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }
        private bool flag = false;
        public struct POINTAPI
        {
            public uint x;
            public uint y;
        }

      
        Point MousePos;
        Image img;
        private void timer2_Tick(object sender, EventArgs e)
        {
            MousePos = new Point
            (
                MousePosition.X*(int)GetCorrectScreenSize.Scale,
                MousePosition.Y * (int)GetCorrectScreenSize.Scale
            );
            using(Bitmap bmp=new Bitmap(img))
            {
                Color PixelColor = bmp.GetPixel(MousePos.X, MousePos.Y);
                ColorDisplay.BackColor = PixelColor;
                RGBTextBox.Text =
                    PixelColor.R.ToString() + "," +
                    PixelColor.G.ToString() + "," +
                    PixelColor.B.ToString();
                ArgbTextBox.Text =
                    PixelColor.A.ToString() + "," +
                    PixelColor.R.ToString() + "," +
                    PixelColor.G.ToString() + "," +
                    PixelColor.B.ToString();
            }
            PositionTextBox.Text = MousePos.X.ToString() + "," + MousePos.Y.ToString();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Shift)
            {
                timer2.Enabled = true;
                ColorDisplay.Text = null;
                int iWidth = GetCorrectScreenSize.ScreenSize.Width;
                int iHeight = GetCorrectScreenSize.ScreenSize.Height;
                img = new Bitmap(iWidth, iHeight);
                Graphics graph = Graphics.FromImage(img);
                this.WindowState = FormWindowState.Minimized;
                graph.CopyFromScreen(new Point(0, 0), new Point(0, 0), new Size(iWidth, iHeight));
                this.WindowState = FormWindowState.Normal;
            }
            if (e.KeyCode == Keys.Escape)
            {
                timer2.Enabled = false;
            }
        }
    }
}
