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
    public partial class WinningPhase : Form
    {
        Form1 Pacgame = new Form1();
        StartingGame titlescreen = new StartingGame();
        public WinningPhase()
        {
            InitializeComponent();
        }

        private void btnPlayagain_Click(object sender, EventArgs e)
        {
            Pacgame.Refresh();
            Pacgame.Show();
            Pacgame.Shown += (s, arg) => this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            titlescreen.Show();
            titlescreen.Shown += (s, arg) => this.Close();
        }
    }
}
