using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    internal class Methods
    {
        List<string> names = new List<string> { "Omer", "Eli", "Xaliq", "Revan" };
        public void ShowMenu()
        {
            Console.WriteLine("1-Ad elave et.");
            Console.WriteLine("2-Adlari goster.");
            Console.WriteLine("3-Adi deyisdir.");
            Console.WriteLine("4-Ad sil.");
            int a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Add();
                    break;
                case 2:
                    Show();
                    break;
                case 3:
                    Uptade();
                    break;
                case 4:
                    Delete();
                    break;
            }
        }
        public void Add()
        {
            Console.WriteLine("Elave etmek istediyiniz adi daxil edin.");
            string a = Console.ReadLine();
            if (!names.Contains(a))
            {
                names.Add(a);
                Console.WriteLine("Ad elave olundu.");
            }
            else
                Console.WriteLine("Bu adi daxil ede bilmersiniz(bir addan en cox 1 dene olmalidir).");


            Console.WriteLine();
            Console.WriteLine("Davam etmek ucun entere basin!");
            Console.ReadLine();
            Console.Clear();
            ShowMenu();
        }
        public void Show()
        {
            names.ForEach(x => Console.WriteLine(names.IndexOf(x) + 1  + "-" + x));
            Console.WriteLine();
            Console.WriteLine("Davam etmek ucun entere basin!");
            Console.ReadLine();
            Console.Clear();
            ShowMenu();
        }
        public void Uptade()
        {
            Console.WriteLine("Evezlemek istediyiniz adi daxil edin.");
            string a = Console.ReadLine();
            if (names.Contains(a))
            {
                Console.WriteLine("Adi ne ile evezlemek isteyirsiniz?");
                names[names.IndexOf(a)] = Console.ReadLine();
                Console.WriteLine("Ad evezlendi.");
            }
            else
                Console.WriteLine("Evezlemek istediyiniz ad tapilmadi.");

            Console.WriteLine();
            Console.WriteLine("Davam etmek ucun entere basin!");
            Console.ReadLine();
            Console.Clear();
            ShowMenu();
        }
        public void Delete()
        {
            Console.WriteLine("Silmek istediyiniz adi daxil edin.");
            string a = Console.ReadLine();
            if (names.Contains(a))
            {
                names.Remove(a);
                Console.WriteLine("Ad silindi.");
            }
            else
                Console.WriteLine("Silmek istediyiniz ad tapilmadi.");

            Console.WriteLine();
            Console.WriteLine("Davam etmek ucun entere basin!");
            Console.ReadLine();
            Console.Clear();
            ShowMenu();
        }
    }
}
