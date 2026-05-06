using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
    internal class DrawGoal
    {

        public void DrawGameGoal(PaintEventArgs e,MazeGame MazeGame1)
        {

            // draw goal
            e.Graphics.FillRectangle(Brushes.Green, MazeGame1.GameGoal);


        }

    }
}
