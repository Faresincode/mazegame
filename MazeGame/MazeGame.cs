using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MazeGame
{
    public partial class MazeGame : Form
    {
        public MazeGame()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            FillWalesToList(_GameWalls);

        }
        
        DrawWalls GameWales = new DrawWalls();
        DrawPlayer DrawPlayer1 = new DrawPlayer();
        DrawGoal DrawGoal1=new DrawGoal();


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            GameWales.DrawWals(e,this);
            DrawPlayer1.DrawGamePlayer(e,this);
            DrawGoal1.DrawGameGoal(e, this  );


        }

        public void PlayMazeGame(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                _Player.X += 5;

            }
            if (e.KeyCode == Keys.Left)
            {
                _Player.X -= 5;
            }
            if (e.KeyCode == Keys.Up)
            {
                _Player.Y -= 5;
            }
            if (e.KeyCode == Keys.Down)
            {
                _Player.Y += 5;
            }

            if (IsPlayerIntersectWall())
            {
                SetPlayerColor(ePlayerColors.Red);
                panel1.Refresh();
                BlinkingPlayer();
                //MessageBox.Show("Fail in the game try again!");
                return;
            }
            if (IsPlayerWin())
            {
                SetPlayerColor(ePlayerColors.Green);
                panel1.Refresh();
                BlinkingPlayer();                //panel1.Refresh();
                DialogResult WinerMessageBoxDialog = MessageBox.Show("Congratulation You are the winner", "Do you want to try again", MessageBoxButtons.RetryCancel);
                if (WinerMessageBoxDialog == DialogResult.Retry)
                {
                    ResetGame();
                }
                if (WinerMessageBoxDialog == DialogResult.Cancel)
                {
                    this.Close();
                }
                return;
            }

            panel1.Refresh();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            PlayMazeGame(e);

        }

        private void ReportingTimer_Tick(object sender, EventArgs e)
        {
            BlinkingPlayer();
        }
    }
}
