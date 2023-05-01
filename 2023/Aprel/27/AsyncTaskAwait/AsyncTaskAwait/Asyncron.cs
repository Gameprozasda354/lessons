using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncTaskAwait
{
    public class Asyncron
    {
        public async Task<Coffee> MakeCoffee()
        {
            Console.WriteLine("Kofe hazirlanir...");
            await Task.Delay(5000);
            Console.WriteLine("Kofe hazirdir...");
            return new Coffee();
        }

        public async Task<Tea> MakeTea()
        {
            Console.WriteLine("Cay hazirlanir...");
            await Task.Delay(5000);
            Console.WriteLine("Cay hazirdir...");
            return new Tea();
        }

        public async Task<Stake> MakeStake()
        {
            Console.WriteLine("Steyk hazirlanir...");
            await Task.Delay(5000);
            Console.WriteLine("Steyk hazirdir...");
            return new Stake();
        }

        public async Task<Cheeseburger> MakeCheeseburger()
        {
            Console.WriteLine("Cizburger hazirlanir...");
            await Task.Delay(5000);
            Console.WriteLine("Cizburger hazirdir...");
            return new Cheeseburger();
        }
    }
}
