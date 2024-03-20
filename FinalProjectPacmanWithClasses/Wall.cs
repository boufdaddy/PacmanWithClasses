using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectPacmanWithClasses
{
    internal class Wall
    {
        private Form form;
        private int xLoc;
        private int yLoc;
        private int width;
        private int height;
        private Pen pen;
        private SolidBrush solidBrush;
        
        private Random rand = new Random();
        private int xSpeed = -10;
        private int ySpeed = 0;

        public int X { get { return xLoc; } }
        public int Y { get { return yLoc; } }
        public int Width { get { return width; } }
        public int Height { get { return height; } }

        public Wall (int x, int y, Form mainform)
        {
            xLoc = x;
            yLoc = y;
            width = 30;
            height = 350;
            pen = new Pen(Color.Red);
            solidBrush = new SolidBrush(Color.FromArgb(255, 255, 0, 0));
            
            form = mainform;
        }

        public void Draw(Graphics gr)
        {
            //gr.DrawEllipse(pen, xLoc, yLoc, width, height);
            gr.DrawRectangle(pen, xLoc, yLoc, width, height);
            gr.FillRectangle(solidBrush, xLoc, yLoc, width, height);
            //xLoc += xSpeed;
            //yLoc += ySpeed;
            //if (xLoc + width >= form.ClientSize.Width) xSpeed *= -1;
            //if (xLoc <= 0) xSpeed *= -1;
            //if (yLoc + height >= form.ClientSize.Height) ySpeed *= -1;
            //if (yLoc <= 0) ySpeed *= -1;
        }
    }
}
