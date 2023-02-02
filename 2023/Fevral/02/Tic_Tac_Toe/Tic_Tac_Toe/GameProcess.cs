using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tic_Tac_Toe
{
    public static class GameProcess
    {
        #region GameMap
        public static List<string> xMap = new List<string>();
        public static List<string> oMap = new List<string>();
        #endregion
        public static bool Queue { get; set; }
        public static int user1Point = 0;
        public static int user2Point = 0;
        public static bool EndGame { get; set; }
        public static void ChangeQueue()
        {
            if (Queue)
            {
                Queue = false;
            }
            else
            {
                Queue = true;
            }
        }
        public static void WriteCharachter(Button button)
        {
            if (Queue)
            {
                button.Text = "X";
                xMap.Add(button.Name);
            }
            else
            {
                button.Text = "O";
                oMap.Add(button.Name);
            }
            button.Enabled = false;
        }
    }
}
