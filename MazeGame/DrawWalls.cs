using MazeGame;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MazeGame
{
    internal class DrawWalls
    {



        internal void DrawWals(PaintEventArgs e, MazeGame MazeGame1)
        {

            List<Rectangle> WallsList = MazeGame1.GetGameWallsList();
            foreach (Rectangle wall in WallsList)
            {
                e.Graphics.FillRectangle(Brushes.Aqua, wall);

            }

            // draw player



        }


    }
}
