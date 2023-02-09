using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Tic_Tac_Toe
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                if (item is Button)
                {
                    Button button = (Button)item;
                    item.Click += ButtonClicked;
                }
            }
        }
        private void ButtonClicked(object sender, EventArgs e)
        {
            GameProcess.WriteCharachter((Button)sender);
            string winResult = GameRules.CheckWinScenaries();

            if (winResult != null)
            {
                if(winResult == "X")
                {
                    GameProcess.user1Point++;
                    user1Score.Text = GameProcess.user1Point.ToString();
                }
                else if (winResult == "O")
                {
                    GameProcess.user2Point++;
                    user2Score.Text = GameProcess.user2Point.ToString();
                }

                var gameEndCheckResult = GameRules.CheckGameEnded();

                if (gameEndCheckResult != null)
                {
                    MessageBox.Show(gameEndCheckResult + " won!");
                    GameProcess.ResetGame();
                }
                else
                {
                    GameProcess.ResetRound();
                }
            }
            else
            {
                var disabledBtnCount = Controls.OfType<Button>().Where(m => m.Enabled == false).Count();
                if(disabledBtnCount == 9)
                {
                    GameProcess.ResetRound();
                }
            }

            GameProcess.ChangeQueue();
        }
    }
}
