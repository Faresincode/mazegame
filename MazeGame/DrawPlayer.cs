using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MazeGame;

namespace MazeGame
{
    internal class DrawPlayer
    {
        public void DrawGamePlayer(PaintEventArgs e, MazeGame MazeGame1)
        {
            if (!MazeGame1.Blinking)
            {
                e.Graphics.FillRectangle(MazeGame1.PlayerColor, MazeGame1.Player);
            }

        }

    }
}
