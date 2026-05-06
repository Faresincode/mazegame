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

        public List<Rectangle> GetGameWallsList()
        {
            return _GameWalls;
        }

        private void FillWalesToList(List<Rectangle> AllGameWalls)
        {

            // outer borders
            AllGameWalls.Add(new Rectangle(0, 0, 600, 20));
            AllGameWalls.Add(new Rectangle(0, 0, 20, 400));
            AllGameWalls.Add(new Rectangle(580, 0, 20, 332));
            AllGameWalls.Add(new Rectangle(0, 372, 600, 20));

            // inner maze blocks (with a clear path!)
            AllGameWalls.Add(new Rectangle(100, 40, 20, 250));
            AllGameWalls.Add(new Rectangle(200, 100, 20, 280));
            AllGameWalls.Add(new Rectangle(300, 0, 20, 200));
            AllGameWalls.Add(new Rectangle(300, 250, 20, 150));
            AllGameWalls.Add(new Rectangle(400, 50, 20, 300));
            AllGameWalls.Add(new Rectangle(150, 300, 200, 20));
            AllGameWalls.Add(new Rectangle(250, 150, 100, 20));
            AllGameWalls.Add(new Rectangle(450, 200, 100, 20));
            AllGameWalls.Add(new Rectangle(500, 100, 20, 200));
        }

        private void ResetGame()
        {

            _Player = new Rectangle(30, 30, 15, 15);
            _PlayerColor = Brushes.Black;
            panel1.Refresh();
        }
        private void BlinkingPlayer()
        {
            BlinkingTimer.Start();
            _BlinkingTimes++;
            _Blinking = (_Blinking) ? false : true;
            if (_BlinkingTimes > 10)
            {
                _BlinkingTimes = 0;
                _Blinking = false;
                BlinkingTimer.Stop();
                ResetGame();
            }
            panel1.Refresh();
        }
        private void SetPlayerColor(ePlayerColors playerColors)
        {
            switch (playerColors)
            {
                case ePlayerColors.Green:
                    _PlayerColor = Brushes.Green;
                    break;
                case ePlayerColors.Blue:
                    _PlayerColor = Brushes.Blue;

                    break;
                case ePlayerColors.Red:
                    _PlayerColor = Brushes.Red;
                    break;
                default:
                    _PlayerColor = Brushes.Black;

                    break;
            }

        }

    }
}
