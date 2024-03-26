using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectPacmanWithClasses
{
    internal class Pacman
    {
        public PictureBox myPic;
        private Random rand = new Random();
        private Form form;
        private int xLoc;
        private int yLoc;
        private int pacmanSpeed = 10;
        //private int ySpeed = 6;

        public int X { get { return myPic.Left; } }
        public int Y { get { return myPic.Top; } }
        public int Width { get { return myPic.Width; } }
        public int Height { get { return myPic.Height; } }

        public Pacman(int x, int y, Form mainForm, Bitmap bitmap)    // Constructor. same name as class itself, called at instantiation
        {
            myPic = new PictureBox();
            myPic.Image = bitmap;
            myPic.SizeMode = PictureBoxSizeMode.StretchImage;
            myPic.Width = 60;
            myPic.Height = myPic.Width;
            myPic.Left = x;
            myPic.Top = y;
            //xLoc = x;
            // yLoc = y;
            mainForm.Controls.Add(myPic);
            form = mainForm;

        }

        public void leftMove(Bitmap bitmap)
        {
            myPic.Image = bitmap;
            myPic.Left -= pacmanSpeed;
        }

        public void Rightmove(Bitmap bitmap)
        {
            myPic.Image = bitmap;
            myPic.Left += pacmanSpeed;
        }

        public void downMove(Bitmap bitmap)
        {
            myPic.Image = bitmap;
            myPic.Top += pacmanSpeed;
        }

        public void UpMove(Bitmap bitmap)
        {
            myPic.Image = bitmap;
            myPic.Top -= pacmanSpeed;
        }
    }
}
