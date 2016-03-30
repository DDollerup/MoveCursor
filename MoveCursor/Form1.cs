using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoveCursor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int counter = 0;
        private void OnMoveCursorTick(object sender, EventArgs e)
        {
            switch (counter)
            {
                case 0:
                    MoveMouse(new Point(0, -5)); // Up
                    break;
                case 1:
                    MoveMouse(new Point(5, 0)); // Right
                    break;
                case 2:
                    MoveMouse(new Point(0, 5)); // Down
                    break;
                case 3:
                    MoveMouse(new Point(-5, 0)); // Left
                    break;
                default:
                    break;
            }

            if (counter < 3)
            {
                counter++;
            }
            else
            {
                counter = 0;
            }

        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            Point currentCurserPos = Cursor.Position;
            Point up = new Point(0, -15);
            Cursor.Position = new Point(currentCurserPos.X + up.X, currentCurserPos.Y + up.Y);
        }

        private void MoveMouse(Point direction)
        {
            Point currentCurserPos = Cursor.Position;
            Cursor.Position = new Point(currentCurserPos.X + direction.X, currentCurserPos.Y + direction.Y);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Timer_MoveCursor.Start();
        }
    }
}
