using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGame
{
    partial class MazeGame
    {

        private bool IsPlayerWin()
        {
            if (_Player.IntersectsWith(_GameGoal))
            {

                return true;
            }
            return false;
        }

        private bool IsPlayerIntersectWall()
        {
            foreach (Rectangle r in _GameWalls)
            {

                if (_Player.IntersectsWith(r))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
