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
    public partial class StartingGame : Form
    {
        Form1 game = new Form1();
        public StartingGame()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("USE THE ARROW KEYS TO MOVE PACMAN");
        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            game.Show();
            this.Hide();
           //game.Shown += (s, arg) => this.Close();
        }

        private void ShowCredits_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GAME CREATED BY CHARLES");
        }

        private void ExitGame_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartingGame_Load(object sender, EventArgs e)
        {

        }
    }
}
