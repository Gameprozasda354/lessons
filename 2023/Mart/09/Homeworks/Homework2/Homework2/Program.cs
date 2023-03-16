using Homework2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>();
            Car car = new Car()
            {
                City = "Baki",
                Brand = "Hyundai",
                Model = "Sonata",
                MadeYear = 2014,
                Color = Color.White,
                Engine = 2000,
                Hp = 165,
                Km = 165000,
                GearBox = GearBox.Automatic,
                Price = 28700
            };
            Car car2 = new Car()
            {
                City = "Baki",
                Brand = "Toyota",
                Model = "Camry",
                MadeYear = 2020,
                Color = Color.White,
                Engine = 2500,
                Hp = 200,
                Km = 30000,
                GearBox = GearBox.Automatic,
                Price = 65110
            };
            Car car3 = new Car()
            {
                City = "Baki",
                Brand = "Land Rover",
                Model = "RR Sport",
                MadeYear = 2022,
                Color = Color.Black,
                Engine = 4400,
                Hp = 537,
                Km = 0,
                GearBox = GearBox.Automatic,
                Price = 384200  
            };
            Car car4 = new Car()
            {
                City = "Ganca",
                Brand = "Mercedes",
                Model = "CLS 350",
                MadeYear = 2011,
                Color = Color.White,
                Engine = 3500,
                Hp = 306,
                Km = 156000,
                GearBox = GearBox.Automatic,
                Price = 45560
            };
            Car car5 = new Car()
            {
                City = "Baki",
                Brand = "Mercedes",
                Model = "S500",
                MadeYear = 2012,
                Color = Color.Black,
                Engine = 4700,
                Hp = 435,
                Km = 101000,
                GearBox = GearBox.Automatic,
                Price = 46750
            };
            Car car6 = new Car()
            {
                City = "Baki",
                Brand = "BMW",
                Model = "528",
                MadeYear = 2015,
                Color = Color.Black,
                Engine = 2000,
                Hp = 245,
                Km = 30000,
                GearBox = GearBox.Automatic,
                Price = 40800
            };
            carList.Add(car);
            carList.Add(car2);
            carList.Add(car3);
            carList.Add(car4);
            carList.Add(car5);
            carList.Add(car6);

            var carList1 = carList.Where(x => x.Brand == "Mercedes" && x.Engine <= 4200 &&
                                          x.City == "Baki").ToList();

            var carList2 = carList.Where(x => x.City != "Baki" && x.MadeYear >= 2015 &&
                                          x.MadeYear <= 2020).ToList();

            var carList3 = carList.Where(x => x.Km == 0 && x.Model.Contains("ml")).ToList();

            var carList4 = carList.Where(x => x.GearBox == GearBox.Automatic && x.Price > 15000 &&
                                          x.Price < 17500).ToList();

            var carList5 = carList.Where(x => x.Color != Color.Black && x.Color != Color.Red &&
                                          x.Engine > 2000 && x.Engine < 4000 && x.MadeYear >= 2010 &&
                                          x.GearBox != GearBox.Robot).ToList();

            var carList6 = carList.Where(x => (x.Brand == "Lexus" && x.Price <= 30000) || 
                                          (x.Brand == "Mercedes" && x.Price <= 45000)).ToList();
        }
        /*
             Homework 2:
             Bir Car class'ınız olsun. (Property'ləri: Şəhər (satıldığı), Marka, Model, Buraxılış ili, Rəngi, Mühərrik Həcmi, At Gücü, Kilometrajı, Sürətlər Qutusunun tipi, Qiyməti).
             Bir list'in içinə bir neçə dənə Car əlavə edib nümunədən aşağıdakı sorğuları yazacaqsınız.
             Nümunə data:
             Şəhər: Bakı
             Marka: Lexus
             Model: GX460
             Buraxılış ili: 2021
             Rəngi: Black (Enum olacaq və 10-15 dənə rəng olsun Enum'da)
             Mühərrik Həcmi: 4500
             At Gücü: 296
             Kilometrajı: 15777
             Sürətlər Qutusunun tipi: Automatic (Enum olacaq. Dəyərləri də Automatic, Manual, Robot)
             Qiyməti: 200.000

             Aşağıdakı sorğuları yazın:
             1. Markası Mercedes olub, mühərrik həcmi 4200'dən az olan və ya bərabər olan, Bakıda satılan.
             2. Bakıda satılmayan, buraxılış ili 2015-ci il daxil olmaqla 2020-ci ilə qədər olan (2020 də daxildir buna)
             3. Kilometrajı 0 olan və Modelində "ml" sözü olan
             4. Sürətlər qutusu avtomatik olan və qiyməti 15.000-17.500 arasında olan
             5. Rəngi Red, Black olmayan, mühərrik həcmi 2000-4000 arasında olan, sürətlər qutusu Robot olmayan, buraxılış ili 2010-dan köhnə olmayan.
             6. Ya markası Lexus olub, qiyməti 30.000-ə qədər olan ya da markası Mercedes olub qiyməti 45.000-ə qədər olan.
         */
    }
}
