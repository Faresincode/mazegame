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

        private List<Rectangle> _GameWalls = new List<Rectangle>();
        private Rectangle _GameGoal = new Rectangle(580, 332, 20, 40);
        private Rectangle _Player = new Rectangle(30, 30, 15, 15);
        private Brush _PlayerColor = Brushes.Black;
        private enum ePlayerColors { Green, Blue, Red };
        private bool _Blinking = false;
        private byte _BlinkingTimes = 0;

        public Rectangle GameGoal
        {
            get
            {
                return _GameGoal;
            }

            private set
            {
                _GameGoal = value;
            }

        }

        public Rectangle Player
        {
            get
            {
                return _Player;
            }

            private set
            {
                _Player = value;
            }

        }

        public Brush PlayerColor
        {
            get
            {
                return _PlayerColor;
            }

            private set
            {
                _PlayerColor = value;
            }

        }

        public List<Rectangle> GameWalls
        {

            get
            {
                return _GameWalls;

            }

            private set
            {
                _GameWalls = value;

            }


        }

        public bool Blinking
        {
            get { return _Blinking; }
            private set { _Blinking = value; }
        }


    }
}
