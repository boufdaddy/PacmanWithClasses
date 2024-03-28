using FinalProjectPacmanWithClasses.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectPacmanWithClasses
{
    public partial class Form1 : Form
    {
        SoundPlayer Death = new SoundPlayer(Resources.male_scream_in_fear_123079);
        SoundPlayer GameSound = new SoundPlayer(Resources.Monkey_sounds);

        //BOOLEAN OPERATIONS TO MAKE DECISIONS IN THE GAMES
        bool upMove;
        bool downMove;
        bool leftMove;
        bool rightMove;
        bool gameover;

        int scorecount;

        List<Coin> myPicList = new List<Coin>();
        List<Wall> wallList = new List<Wall>();
        List<Alien> AlienList = new List<Alien>();

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
            Restart();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.UserPaint, true);
            this.Width = 1700;
            this.Height = 1000;
            PacTimer.Enabled = true;
            //Restart();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            
            if (gameover)
            {
                PacTimer.Enabled = false;
                return;
            }
            Invalidate();
            Pinkalien.MoveLeftRight();
            RedAlien.Move();
            YellowAlien.MoveLeftRight();

            

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

            //this will make the pacman enter from all angles in the game window
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
            // to check collision between Pacman and the wall
            foreach(Wall w in wallList)
            {
                if (PacmanWallCollisionTest(Pac, w))
                {
                    Death.Play();
                    GameOverloss();
                    //return;
                }

            }


            // to check for collision between Pacman and the alien
            foreach(Alien a in AlienList)
            {
                if(PacmanAlienCollisionTest(Pac, a))
                {
                    Death.Play();
                    GameOverloss();
                }
            }
            // to check collision of coin and add a numbr to score count
            List<int> ints = new List<int>();
            for (int i = 0; i < myPicList.Count; i++)
            {
                if (PacmanCoinCollisionTest(Pac, myPicList[i]))
                {

                    scorecount++;
                    ints.Add(i);
                    myPicList[i].myPic.Visible = false;
                }
            }

            foreach (int i in ints)
            {
                myPicList.RemoveAt(i);
            }

            

            //Collision code for Pinkalien
            if (WallAlienCollisionTest(wall1, Pinkalien))
            {
                Pinkalien.ChangeDir();
            }
            if (WallAlienCollisionTest(wall2, Pinkalien))
            {
                Pinkalien.ChangeDir();
            }
            //collison code for YellowAlien
            if (WallAlienCollisionTest(wall5, YellowAlien))
            {
                YellowAlien.ChangeDir();
            }

            if (WallAlienCollisionTest(wall6, YellowAlien))
            {
                YellowAlien.ChangeDir();
            }
            //collision code for Red Alien
            if (WallAlienCollisionTest(wall1, RedAlien))
            {
                RedAlien.ChangeDir();
            }
            if (WallAlienCollisionTest(wall2, RedAlien))
            {
                RedAlien.ChangeDir();
            }
            if (WallAlienCollisionTest(wall3, RedAlien))
            {
                RedAlien.ChangeDir();
            }
            if (WallAlienCollisionTest(wall4, RedAlien))
            {
                RedAlien.ChangeDir();
            }
            if (WallAlienCollisionTest(wall5, RedAlien))
            {
                RedAlien.ChangeDir();
            }
            if (WallAlienCollisionTest(wall6, RedAlien))
            {
                RedAlien.ChangeDir();
            }


            //label to display scorecount

            lblscorecount.Text = scorecount.ToString();

            if (scorecount == 65)
            {
                GameOverWin();
            }

        }
        private void Restart()
        {
            GameSound.PlayLooping();

            // codes to place elements at various sections of the screen
            Pac = new Pacman(100, 500, this, new Bitmap("rightPac.gif"));


            Pinkalien = new Alien(450, this.ClientSize.Height - 670, this, new Bitmap("p.gif"));
            AlienList.Add(Pinkalien);
            RedAlien = new Alien(1200, this.ClientSize.Height - 800, this, new Bitmap("r.gif"));
            AlienList.Add(RedAlien);
            YellowAlien = new Alien(1100, this.ClientSize.Height - 150, this, new Bitmap("y.gif"));
            AlienList.Add(YellowAlien);
            Coin coin;
            // to place my coins in specific locations on the form

            for (int i = 0; i < 10; i++)
            {
                coin = new Coin(450 + (100 * i), this.ClientSize.Height / 4, this);
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
           

            //create instances for the wall borders
            wall1 = new Wall(350, 0, this);
            wallList.Add(wall1);
            wall2 = new Wall(900, 0, this);
            wallList.Add(wall2);

            wall3 = new Wall(1300, 0, this);
            wallList.Add(wall3);
            wall4 = new Wall(500, 650, this);
            wallList.Add(wall4);
            wall5 = new Wall(1000, 650, this);
            wallList.Add(wall5);
            wall6 = new Wall(1550, 650, this);
            wallList.Add(wall6);

            PacTimer.Start();
        }

        private void GameOverloss()
        {
            gameover = true;
            DeathPhase death = new DeathPhase();
            
            this.Hide();

          
            death.Show();
         
        }

        private void GameOverWin()
        {
            gameover = true;
            WinningPhase winning = new WinningPhase();

            this.Hide();
            winning.Show();
            
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

        private bool WallAlienCollisionTest(Wall wall, Alien Alien)
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

        private bool PacmanWallCollisionTest(Pacman pacman, Wall wall)
        {
            if (pacman.X + pacman.Width < wall.X)
                return false;
            if (wall.X + wall.Width < pacman.X)
                return false;
            if (pacman.Y + pacman.Height < wall.Y)
                return false;
            if (wall.Y + wall.Height < pacman.Y)
                return false;

            return true;
        }

        private bool PacmanAlienCollisionTest(Pacman pacman, Alien Alien)
        {
            if (pacman.X + pacman.Width < Alien.X)
                return false;
            if (Alien.X + Alien.Width < pacman.X)
                return false;
            if (pacman.Y + pacman.Height < Alien.Y)
                return false;
            if (Alien.Y + Alien.Height < pacman.Y)
                return false;

            return true;
        }
        private bool PacmanCoinCollisionTest(Pacman pacman, Coin coin)
        {
            if (pacman.X + pacman.Width < coin.X)
                return false;
            if (coin.X + coin.Width < pacman.X)
                return false;
            if (pacman.Y + pacman.Height < coin.Y)
                return false;
            if (coin.Y + coin.Height < pacman.Y)
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
