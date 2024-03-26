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
    public partial class DeathPhase : Form
    {
        Form1 gameform = new Form1();
        public DeathPhase()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnretry_Click(object sender, EventArgs e)
        {
            //gameform.Refresh();
            //gameform.Show();

        }
    }
}
