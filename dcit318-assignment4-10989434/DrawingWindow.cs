using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dcit318_assignment4_10989434
{
    public partial class DrawingWindow : Form
    {
        private bool isDrawing = false;
        private Point startPoint;
        private Bitmap drawingBitmap;
        private Graphics graphics;

        public DrawingWindow()
        {
            InitializeComponent();
            drawingBitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(drawingBitmap);
            graphics.Clear(Color.White);
            pictureBox.Image = drawingBitmap;
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                startPoint = e.Location;
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                graphics.DrawLine(Pens.Black, startPoint, e.Location);
                startPoint = e.Location;
                pictureBox.Invalidate(); // Refresh the PictureBox to show the drawing
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = false;
            }
        }
    }
}
