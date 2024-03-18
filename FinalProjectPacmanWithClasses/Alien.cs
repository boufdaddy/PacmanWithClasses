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
        private int xSpeed = 4;
        private int ySpeed = 6;
        public Alien(int x, int y, Form mainForm)    // Constructor. same name as class itself, called at instantiation
        {
            myPic = new PictureBox();
            myPic.Image = new Bitmap("happy.jpg");
            myPic.SizeMode = PictureBoxSizeMode.StretchImage;
            myPic.Width = rand.Next(20, 100);
            myPic.Height = myPic.Width;
            myPic.Left = rand.Next(100, 1000);
            myPic.Top = rand.Next(50, 300);
            mainForm.Controls.Add(myPic);
            form = mainForm;

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
    }
}
