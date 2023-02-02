using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    //ResetGame
                    //User1 label deyis
                }
                else if (winResult == "O")
                {
                    //ResetGame
                    //User2 label deyis
                }
            }
            GameProcess.ChangeQueue();
        }
    }
}
