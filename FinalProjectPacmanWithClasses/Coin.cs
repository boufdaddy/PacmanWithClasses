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
        private Form form;
        private int xLoc;
        private int yLoc;
        private int width;
        private int height;
        private Pen pen;
        private Random rand = new Random();
        private bool active = true;
       

        public int X { get { return xLoc; } }
        public int Y { get { return yLoc; } }
        public int Width { get { return width; } }
        public int Height { get { return height; } }

        public Coin(int x, int y, Form mainForm)
        {
            xLoc = x;
            yLoc = y;
            width = 20;
            height = 20;

            pen = new Pen(Color.Yellow);
            form = mainForm;
        }

        public void Draw(Graphics gr)
        {
            //xLoc += 1;
            //yLoc += 1;
            if (active== true)
            {
                gr.DrawEllipse(pen, xLoc, yLoc, width, height);

            }
           
            //gr.DrawRectangle(pen, xLoc, yLoc, width, height);

           
        }
    }
}
