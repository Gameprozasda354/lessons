using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe
{
    public static class GameRules
    {
        public static string CheckWinScenaries()
        {
            if(XScenario1() || XScenario2() || XScenario3())
            {
                return "X";
            }
            else if (OScenario1() || OScenario2())
            {
                return "O";
            }
            else
            {
                return null;
            }
        }
        /*
        public static string CheckGameEnded()
        {
            
            if(GameProcess.user1Point == 3)
            {
                return "X";
            }
            else if(GameProcess.user2Point == 3)
            {
                return "O";
            }
            else
            {
                return null;
            }
        }*/

        #region X_Win_Scenaries
        public static bool XScenario1()
        {
            var lt = GameProcess.xMap.Any(m => m == "lt");
            var tt = GameProcess.xMap.Any(m => m == "tt");
            var rt = GameProcess.xMap.Any(m => m == "rt");
            return (lt && tt && rt);

        }
        public static bool XScenario2()
        {
            return true;
        }
        public static bool XScenario3()
        {
            return true;
        }
        public static bool XScenario4()
        {
            return true;
        }
        public static bool XScenario5()
        {
            return true;
        }
        public static bool XScenario6()
        {
            return true;
        }
        public static bool XScenario7()
        {
            return true;
        }
        public static bool XScenario8()
        {
            return true;
        }
        #endregion


        #region O_Win_Scenaries
        public static bool OScenario1()
        {
            return true;
        }
        public static bool OScenario2()
        {
            return true;
        }
        public static bool OScenario3()
        {
            return true;
        }
        public static bool OScenario4()
        {
            return true;
        }
        public static bool OScenario5()
        {
            return true;
        }
        public static bool OScenario6()
        {
            return true;
        }
        public static bool OScenario7()
        {
            return true;
        }
        public static bool OScenario8()
        {
            return true;
        }

        #endregion
    }
}
