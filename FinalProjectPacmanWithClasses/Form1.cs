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
        

        private Coin coin;
        private Wall wall1;
        private Wall wall2;
        private Wall wall3;
        private Wall wall4;
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

            //coin = new Coin(400,this.ClientSize.Height / 4, this);
            wall1 = new Wall(350, 0, this);
            wall2 = new Wall(900, 0, this);
            wall3 = new Wall(700, 640, this);

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            wall1.Draw(e.Graphics);
            wall2.Draw(e.Graphics);
            wall3.Draw(e.Graphics);
            
            for (int i = 0; i < 10; i++)
            {
                coin = new Coin(450 + (100*i), this.ClientSize.Height / 4, this);
                coin.Draw(e.Graphics);
               
            }

            for (int i = 0; i < 10; i++)
            {
                coin = new Coin(450 + (100 * i), this.ClientSize.Height / 6, this);
                coin.Draw(e.Graphics);

            }

            for (int i = 0; i < 10; i++)
            {
                coin = new Coin(450 + (100 * i), this.ClientSize.Height / 10, this);
                coin.Draw(e.Graphics);

            }
            //for (int i = 0; i < 10; i++)
            //{
            //    coin = new Coin(450 + (100 * i), this.ClientSize.Height / 14, this);
            //    coin.Draw(e.Graphics);

            //}

        }
    }
}
