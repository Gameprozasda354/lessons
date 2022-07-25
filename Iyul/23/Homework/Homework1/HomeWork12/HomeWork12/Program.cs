using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Implicit Conversion

            short rainbow = 123;
            int count = rainbow;

            int purchasedGames = 20;
            long gamesCount = purchasedGames;

            byte data = 123;
            short datasCount = data;

            int cakesInTheParty = 4;
            long cakesCount = cakesInTheParty;

            short eggsCount = 12;
            int purchasedEggs = eggsCount;

            #endregion


            #region Explicit Conversion

            long apple = 123890;
            ulong apple2 = (ulong)apple;


            sbyte clock = 32;
            byte clock2 = (byte)clock;

            long animal = 1234567890987;
            byte animal2 = (byte)animal;

            float map = 123.678f;
            long map2= (long)map;

            double toys = 754.342;
            int toys1 = (int)toys;

            #endregion

            #region Helper Class Conversion

            char toys2 = 'G';
            string toys3 = Convert.ToString(toys);

            string age = "45";
            short age1 = Convert.ToInt16(age);

            byte day = 1;
            bool day1 = Convert.ToBoolean(day);

            bool night = true;
            string night1 = Convert.ToString(night);

            bool fight = false;
            double fight1 = Convert.ToDouble(fight);



            #endregion

        }
    }
}
