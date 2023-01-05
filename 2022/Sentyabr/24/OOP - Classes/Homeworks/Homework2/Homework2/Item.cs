using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Item
    {

        public string Company;
        public string Model;
        public int Year;
        public int Km;
        public string FuelType;
        public decimal Motor;
        public int BuyPrice;
        public int SellPrice;
        public int MinimumPrice;
        private int Price;

        public Item()
        {

        }
        public Item(string company)
        {
            Company = company;
        }
        public Item(string company, string model)
        {
            Company = company;
            Model = model;
        }
        public Item(string company, string model, int year)
        {
            Company = company;
            Model = model;
            Year = year;
        }
        public Item(string company, string model, int year, int km)
        {
            Company = company;
            Model = model;
            Year = year;
            Km = km;
        }
        public Item(string company, string model, int year, int km, string fuelType)
        {
            Company = company;
            Model = model;
            Year = year;
            Km = km;
            FuelType = fuelType;
        }
        public Item(string company, string model, int year, int km, string fuelType, decimal motor)
        {
            Company = company;
            Model = model;
            Year = year;
            Km = km;
            FuelType = fuelType;
            Motor = motor;
        }
        public Item(string company, string model, int year, int km, string fuelType, decimal motor, int buyPrice)
        {
            Company = company;
            Model = model;
            Year = year;
            Km = km;
            FuelType = fuelType;
            Motor = motor;
            BuyPrice = buyPrice;
        }
        public Item(string company, string model, int year, int km, string fuelType, decimal motor, int buyPrice, int sellPrice)
        {
            Company = company;
            Model = model;
            Year = year;
            Km = km;
            FuelType = fuelType;
            Motor = motor;
            BuyPrice = buyPrice;
            SellPrice = sellPrice;
        }
        public Item(string company, string model, int year, int km, string fuelType, decimal motor, int buyPrice, int sellPrice, int minimumPrice)
        {
            Company = company;
            Model = model;
            Year = year;
            Km = km;
            FuelType = fuelType;
            Motor = motor;
            BuyPrice = buyPrice;
            SellPrice = sellPrice;
            MinimumPrice = minimumPrice;
        }
        public void Print()
        {
            Console.WriteLine("Marka:" + Company);
            Console.WriteLine("Model:" + Model);
            Console.WriteLine("İstehsal ili:" + Year);
            Console.WriteLine("Km:" + Km);
            Console.WriteLine("Yanacaq növü:" + FuelType);
            Console.WriteLine("Sürətlər qutusu:" + Motor);
            Console.WriteLine("Alış qiyməti:" + BuyPrice);
            Console.WriteLine("Qiymət:" + Price);
        }

        public void Calculator(int price)
        {
            int price1 = SellPrice - MinimumPrice;

            if(price < price1)
            {
                Console.WriteLine("Max. endirim qiymətindən aşağı bir qiymət təyin etməyə çalışdınız!");
            }

            else
                Price = price1;

        }

    }
}
