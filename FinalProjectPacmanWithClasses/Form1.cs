using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectPacmanWithClasses
{
    public partial class Form1 : Form
    {
        //BOOLEAN OPERATIONS TO MAKE DECISIONS IN THE GAMES
        bool upMove;
        bool downMove;
        bool leftMove;
        bool rightMove;
        bool gameover;

        List<Coin> myPicList = new List<Coin>();
        List<Wall> wallList = new List<Wall>();

        private enum KeyMove { none, up, down, left, right }

        Pacman Pac;

        // private Coin coin;
        private Wall wall1;
        private Wall wall2;
        private Wall wall3;
        private Wall wall4;
        private Wall wall5;
        private Wall wall6;
        Alien Pinkalien;
        Alien RedAlien;
        Alien YellowAlien;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            this.Width = 1700;
            this.Height = 1000;


            Pac = new Pacman(100, 500, this, new Bitmap("rightPac.gif"));


            Pinkalien = new Alien(450, this.ClientSize.Height - 670, this, new Bitmap("p.gif"));
            RedAlien = new Alien(1200, this.ClientSize.Height - 800, this, new Bitmap("r.gif"));
            YellowAlien = new Alien(1100, this.ClientSize.Height - 150, this, new Bitmap("y.gif"));
            Coin coin;
            // to place my coins in specific locations on the form

            for (int i = 0; i < 10; i++)
            {
                coin = new Coin(450 + (100*i), this.ClientSize.Height/4, this);
                myPicList.Add(coin);

            }

            for (int i = 0; i < 5; i++)
            {
                coin = new Coin(450 + (100 * i), this.ClientSize.Height / 6, this);
                myPicList.Add(coin);
            }


            for (int i = 0; i < 10; i++)
            {
                coin = new Coin(450 + (100 * i), this.ClientSize.Height / 10, this);
                myPicList.Add(coin);
            }

            for (int i = 0; i < 10; i++)
            {
                coin = new Coin(450 + (100 * i), this.ClientSize.Height / 25, this);
                myPicList.Add(coin);
            }

            for (int i = 0; i < 10; i++)
            {
                coin = new Coin(450 + (100 * i), this.ClientSize.Height - 50, this);
                myPicList.Add(coin);

            }

            for (int i = 0; i < 10; i++)
            {
                coin = new Coin(450 + (100 * i), this.ClientSize.Height - 150, this);
                myPicList.Add(coin);
            }

            for (int i = 0; i < 10; i++)
            {
                coin = new Coin(450 + (100 * i), this.ClientSize.Height - 250, this);
                myPicList.Add(coin);
            }
            // for collision
            //foreach (Coin c in myPicList)
            //{
            //    if (c.myPic.Bounds.IntersectsWith(c.myPic.Bounds))
            //}

            //create instances for the wall borders
            wall1 = new Wall(350, 0, this);
            wallList.Add(wall1);
            wall2 = new Wall(900, 0, this);
           
            wall3 = new Wall(1300, 0, this);
            wall4 = new Wall(500, 650, this);
            wall5 = new Wall(1000, 650, this);
            wall6 = new Wall(1550, 650, this);
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
            Pinkalien.MoveLeftRight();
            RedAlien.Move();
            YellowAlien.MoveLeftRight();
            //Collision code for Pinkalien
            if (BallPaddleCollisionTest(wall1, Pinkalien))
            {
                Pinkalien.ChangeDir();
            }
            if (BallPaddleCollisionTest(wall2, Pinkalien))
            {
                Pinkalien.ChangeDir();
            }
            //collison code for YellowAlien
            if (BallPaddleCollisionTest(wall5, YellowAlien))
            {
                YellowAlien.ChangeDir();
            }

            if (BallPaddleCollisionTest(wall6, YellowAlien))
            {
                YellowAlien.ChangeDir();
            }
            //collision code for Red Alien
            if (BallPaddleCollisionTest(wall1, RedAlien))
            {
                RedAlien.ChangeDir();
            }
            if (BallPaddleCollisionTest(wall2, RedAlien))
            {
                RedAlien.ChangeDir();
            }
            if (BallPaddleCollisionTest(wall3, RedAlien))
            {
                RedAlien.ChangeDir();
            }
            if (BallPaddleCollisionTest(wall4, RedAlien))
            {
                RedAlien.ChangeDir();
            }
            if (BallPaddleCollisionTest(wall5, RedAlien))
            {
                RedAlien.ChangeDir();
            }
            if (BallPaddleCollisionTest(wall6, RedAlien))
            {
                RedAlien.ChangeDir();
            }

            if (leftMove == true)
            {
                Pac.leftMove(new Bitmap("leftPac.gif"));            
            }
            if (rightMove == true)
            {
                Pac.Rightmove(new Bitmap("rightPac.gif"));
            }
            if (downMove == true)
            {
                Pac.downMove(new Bitmap("downPac.gif"));
            }
            if (upMove == true)
            {
                Pac.UpMove(new Bitmap("upPac.gif"));
            }


            if (Pac.myPic.Left < 0)
            {
                Pac.myPic.Left = 1700;
            }
            if (Pac.myPic.Left > 1700)
            {
                Pac.myPic.Left = 0;
            }
            if (Pac.myPic.Top < -10)
            {
                Pac.myPic.Top = 951;
            }
            if (Pac.myPic.Top > 951)
            {
                Pac.myPic.Top = 0;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //Draw the differnt walls on the form
            wall1.Draw(e.Graphics);
            wall2.Draw(e.Graphics);
            wall3.Draw(e.Graphics);
            wall4.Draw(e.Graphics);
            wall5.Draw(e.Graphics);
            wall6.Draw(e.Graphics);
            



        }

        private bool BallPaddleCollisionTest(Wall wall, Alien Alien)
        {
            if (wall.X + wall.Width < Alien.X)
                return false;
            if (Alien.X + Alien.Width < wall.X)
                return false;
            if (wall.Y + wall.Height < Alien.Y)
                return false;
            if (Alien.Y + Alien.Height < wall.Y)
                return false;

            return true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //this is to activate the arrow keys to be able to move Pacman
            if (e.KeyCode == Keys.Up)
            {
                upMove = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                downMove = true;
            }

            if (e.KeyCode == Keys.Left)
            {
                leftMove = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                rightMove = true;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            //this is to activate the arrow keys to be able to move Pacman
            if (e.KeyCode == Keys.Up)
            {
                upMove = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                downMove = false;
            }

            if (e.KeyCode == Keys.Left)
            {
                leftMove = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                rightMove = false;
            }
        }
    }
}
