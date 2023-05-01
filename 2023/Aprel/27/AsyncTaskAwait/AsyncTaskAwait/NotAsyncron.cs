using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncTaskAwait
{
    public class NotAsyncron
    {
        public Coffee MakeCoffee()
        {
            Console.WriteLine("Kofe hazirlanir...");
            Task.Delay(5000).Wait();
            Console.WriteLine("Kofe hazirdir...");
            return new Coffee();
        }

        public Tea MakeTea()
        {
            Console.WriteLine("Cay hazirlanir...");
            Task.Delay(5000).Wait();
            Console.WriteLine("Cay hazirdir...");
            return new Tea();
        }

        public Stake MakeStake()
        {
            Console.WriteLine("Steyk hazirlanir...");
            Task.Delay(5000).Wait();
            Console.WriteLine("Steyk hazirdir...");
            return new Stake();
        }

        public Cheeseburger MakeCheeseburger()
        {
            Console.WriteLine("Cizburger hazirlanir...");
            Task.Delay(5000).Wait();
            Console.WriteLine("Cizburger hazirdir...");
            return new Cheeseburger();
        }
    }
}
