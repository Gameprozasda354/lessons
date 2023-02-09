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
            if(XScenario1() || XScenario2() || XScenario3() || XScenario4() || XScenario5()
                || XScenario6() || XScenario7() || XScenario8())
            {
                return "X";
            }
            else if (OScenario1() || OScenario2() || OScenario3() || OScenario4() || OScenario5()
                || OScenario6() || OScenario7() || OScenario8())
            {
                return "O";
            }
            else
            {
                return null;
            }
        }
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
        }

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
            var lm = GameProcess.xMap.Any(m => m == "lm");
            var mm = GameProcess.xMap.Any(m => m == "mm");
            var rm = GameProcess.xMap.Any(m => m == "rm");
            return (lm && mm && rm);
        }
        public static bool XScenario3()
        {
            var lb = GameProcess.xMap.Any(m => m == "lb");
            var bb = GameProcess.xMap.Any(m => m == "bb");
            var rb = GameProcess.xMap.Any(m => m == "rb");
            return (lb && bb && rb);
        }
        public static bool XScenario4()
        {
            var rt = GameProcess.xMap.Any(m => m == "rt");
            var rm = GameProcess.xMap.Any(m => m == "rm");
            var rb = GameProcess.xMap.Any(m => m == "rb");
            return (rt && rm && rb);
        }
        public static bool XScenario5()
        {
            var tt = GameProcess.xMap.Any(m => m == "tt");
            var mm = GameProcess.xMap.Any(m => m == "mm");
            var bb = GameProcess.xMap.Any(m => m == "bb");
            return (tt && mm && bb);
        }
        public static bool XScenario6()
        {
            var lt = GameProcess.xMap.Any(m => m == "lt");
            var lm = GameProcess.xMap.Any(m => m == "lm");
            var lb = GameProcess.xMap.Any(m => m == "lb");
            return (lt && lm && lb);
        }
        public static bool XScenario7()
        {
            var lt = GameProcess.xMap.Any(m => m == "lt");
            var mm = GameProcess.xMap.Any(m => m == "mm");
            var rb = GameProcess.xMap.Any(m => m == "rb");
            return (lt && mm && rb);
        }
        public static bool XScenario8()
        {
            var rt = GameProcess.xMap.Any(m => m == "rt");
            var mm = GameProcess.xMap.Any(m => m == "mm");
            var lb = GameProcess.xMap.Any(m => m == "lb");
            return (rt && mm && lb);
        }
        #endregion


        #region O_Win_Scenaries
        public static bool OScenario1()
        {
            var lt = GameProcess.oMap.Any(m => m == "lt");
            var tt = GameProcess.oMap.Any(m => m == "tt");
            var rt = GameProcess.oMap.Any(m => m == "rt");
            return (lt && tt && rt);
        }
        public static bool OScenario2()
        {
            var lm = GameProcess.oMap.Any(m => m == "lm");
            var mm = GameProcess.oMap.Any(m => m == "mm");
            var rm = GameProcess.oMap.Any(m => m == "rm");
            return (lm && mm && rm);
        }
        public static bool OScenario3()
        {
            var lb = GameProcess.oMap.Any(m => m == "lb");
            var bb = GameProcess.oMap.Any(m => m == "bb");
            var rb = GameProcess.oMap.Any(m => m == "rb");
            return (lb && bb && rb);
        }
        public static bool OScenario4()
        {
            var rt = GameProcess.oMap.Any(m => m == "rt");
            var rm = GameProcess.oMap.Any(m => m == "rm");
            var rb = GameProcess.oMap.Any(m => m == "rb");
            return (rt && rm && rb);
        }
        public static bool OScenario5()
        {
            var tt = GameProcess.oMap.Any(m => m == "tt");
            var mm = GameProcess.oMap.Any(m => m == "mm");
            var bb = GameProcess.oMap.Any(m => m == "bb");
            return (tt && mm && bb);
        }
        public static bool OScenario6()
        {
            var lt = GameProcess.oMap.Any(m => m == "lt");
            var lm = GameProcess.oMap.Any(m => m == "lm");
            var lb = GameProcess.oMap.Any(m => m == "lb");
            return (lt && lm && lb);
        }
        public static bool OScenario7()
        {
            var lt = GameProcess.oMap.Any(m => m == "lt");
            var mm = GameProcess.oMap.Any(m => m == "mm");
            var rb = GameProcess.oMap.Any(m => m == "rb");
            return (lt && mm && rb);
        }
        public static bool OScenario8()
        {
            var rt = GameProcess.oMap.Any(m => m == "rt");
            var mm = GameProcess.oMap.Any(m => m == "mm");
            var lb = GameProcess.oMap.Any(m => m == "lb");
            return (rt && mm && lb);
        }

        #endregion
    }
}
