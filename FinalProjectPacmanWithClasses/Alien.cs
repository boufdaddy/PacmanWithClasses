using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Windows.Forms;

namespace FinalProjectPacmanWithClasses
{
    internal class Alien
    {
        public PictureBox myPic;
        private Random rand = new Random();
        private Form form;
        private int xLoc;
        private int yLoc;
        private int xSpeed = 10;
        private int ySpeed = 6;

        public int X { get { return myPic.Left; } }
        public int Y { get { return myPic.Top; } }
        public int Width { get { return myPic.Width; } }
        public int Height { get { return myPic.Height; } }
        public Alien(int x, int y, Form mainForm, Bitmap bitmap)    // Constructor. same name as class itself, called at instantiation
        {
            myPic = new PictureBox();
            myPic.Image = bitmap;
            myPic.SizeMode = PictureBoxSizeMode.StretchImage;
            myPic.Width = 70;
            myPic.Height = myPic.Width;
            myPic.Left = x;
            myPic.Top = y;
            //xLoc = x;
           // yLoc = y;
            mainForm.Controls.Add(myPic);
            form = mainForm;

        }
        public void MoveLeftRight()
        {
            myPic.Left += xSpeed;
            //myPic.Top += ySpeed;
            if (myPic.Right >= form.ClientSize.Width) xSpeed *= -1;
            if (myPic.Left <= 0) xSpeed *= -1;
       

        }

        public void Move()
        {
            myPic.Left += xSpeed;
            myPic.Top += ySpeed;
            if (myPic.Right >= form.ClientSize.Width) xSpeed *= -1;
            if (myPic.Left <= 0) xSpeed *= -1;
            if (myPic.Bottom >= form.ClientSize.Height) ySpeed *= -1;
            if (myPic.Top <= 0) ySpeed *= -1;


        }

        public void ChangeDir()
        {
            xSpeed *= -1;
            //ySpeed *= -1;
        }
    }
}

