using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace DragNDrop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pbGraphic.AllowDrop = true;
        }

        private void dragItem1_MouseDown(object sender, MouseEventArgs e)
        {
            dragItem1.DoDragDrop(dragItem1, DragDropEffects.Copy);
        }

        private void pbGraphic_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(typeof(PictureBox)))
            {
                Debug.WriteLine("DragEnter triggered with an acceptable datatype!");
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                Debug.WriteLine("DragEnter triggered with no acceptable datatypes :-(");
            }
        }

        private void pbGraphic_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(PictureBox)))
            {
                Debug.WriteLine("DragDrop triggered with an acceptable datatype!");
                Image img = ((PictureBox)e.Data.GetData(typeof(PictureBox))).Image;
                Point relLocation = new Point(e.X, e.Y);
                Point controlLocation = this.PointToScreen(pbGraphic.Location);
                relLocation.Offset(-controlLocation.X, -controlLocation.Y);
                using (Graphics g = pbGraphic.CreateGraphics())
                {
                    g.DrawImageUnscaled(img, relLocation);
                }
            }
            else
            {
                Debug.WriteLine("DragDrop triggered with no acceptable datatypes :-(");
            }
        }
    }
}
