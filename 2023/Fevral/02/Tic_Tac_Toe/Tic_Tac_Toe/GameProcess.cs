using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

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
        public static void ResetRound()
        {
            ControlCollection control = Application.OpenForms.Cast<Game>()
                .FirstOrDefault(m => m.GetType() == typeof(Game))?.Controls;

            foreach (Control item in control)
            {
                if (item is Button)
                {
                    Button button = (Button)item;
                    button.Text = "";
                    button.Enabled = true;
                }
            }

            xMap.Clear();
            xMap.TrimExcess();

            oMap.Clear();
            oMap.TrimExcess();

            ChangeQueue();
        }
        public static void ResetGame()
        {
            ControlCollection control = Application.OpenForms.Cast<Game>()
                .FirstOrDefault(m => m.GetType() == typeof(Game))?.Controls;

            control["user1Score"].Text = "-";
            control["user2Score"].Text = "-";

            foreach  (Control item in control)
            {
                if(item is Button)
                {
                    Button button = (Button)item;
                    button.Text = "";
                    button.Enabled = true;
                }
            }

            user1Point = 0;
            user2Point = 0;

            xMap.Clear();
            xMap.TrimExcess();

            oMap.Clear();
            oMap.TrimExcess();
        }
    }
}
