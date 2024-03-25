using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectPacmanWithClasses
{
    internal class Coin
    {
        //private Form form;
        //private int xLoc;
        //private int yLoc;
        //private int width;
        //private int height;
        //private Pen pen;
        //private Random rand = new Random();
        //private bool active = true;


        //public int X { get { return xLoc; } }
        //public int Y { get { return yLoc; } }
        //public int Width { get { return width; } }
        //public int Height { get { return height; } }

        public PictureBox myPic;
        private Random rand = new Random();
        private Form form;
        private int xLoc;
        private int yLoc;
        private int xSpeed = 4;
        private int ySpeed = 6;

        public int X { get { return myPic.Left; } }
        public int Y { get { return myPic.Top; } }
        public int Width { get { return myPic.Width; } }
        public int Height { get { return myPic.Height; } }
        public Coin(int x, int y, Form mainForm)    // Constructor. same name as class itself, called at instantiation
        {
            myPic = new PictureBox();
            myPic.Image = new Bitmap("wincoin.gif");
            myPic.SizeMode = PictureBoxSizeMode.StretchImage;
            myPic.Width = 20;
            myPic.Height = 20;
            myPic.Left = x;
            myPic.Top = y;
            myPic.Location = new System.Drawing.Point(x, y);
            //myPic.Left = rand.Next(100, 1000);
            // myPic.Top = rand.Next(50, 300);
            mainForm.Controls.Add(myPic);
            form = mainForm;

        }
        //public Coin(int x, int y, Form mainForm)
        //{
        //    xLoc = x;
        //    yLoc = y;
        //    width = 20;
        //    height = 20;

        //    pen = new Pen(Color.Yellow);
        //    form = mainForm;
        //}

        //public void Draw(Graphics gr)
        //{
        //    //xLoc += 1;
        //    //yLoc += 1;
        //    if (active== true)
        //    {
        //        gr.DrawEllipse(pen, xLoc, yLoc, width, height);

        //    }
           
        //    //gr.DrawRectangle(pen, xLoc, yLoc, width, height);

           
        //}
    }
}
