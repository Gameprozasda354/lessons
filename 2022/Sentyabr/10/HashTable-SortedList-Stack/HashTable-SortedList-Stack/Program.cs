using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_SortedList_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList

            #region Adding values to ArrayList

            string[] arr = new string[2];

            string[] arr2 = new string[] {
                "Bir",
                "Iki"
            };

            int capacity = 0;
            int count = 0;

            ArrayList students = new ArrayList();

            students.Add("Samir");
            students.Add("Omer");
            students.Add("Ceyhun");
            students.Add("Orxan");
            students.Add("Ruzgar");

            capacity = students.Capacity;
            count = students.Count;

            students.Add(5);
            students.Add(true);
            #endregion

            #region Adding Collection to ArrayList
            //A1 sinifi
            ArrayList A1 = new ArrayList();
            A1.Add("Konul");
            A1.Add("Gunel");
            A1.Add("Melahet");

            //A2 sinifi
            ArrayList A2 = new ArrayList();
            A2.Add("Orxan");
            A2.Add("Cavid");
            A2.Add("Omer");

            A1.AddRange(A2);
            #endregion

            #region Getting values from ArrayList
            var cavid = A2[1];
            object objOmer = A2[2];
            string strKonul = A1[0].ToString();

            ArrayList mixArray = new ArrayList();
            mixArray.Add("string value");
            mixArray.Add(1);
            mixArray.Add(5.5F);
            mixArray.Add('C');
            mixArray.Add(1.2D);
            mixArray.Add(true);

            var strVal = mixArray[0].ToString();
            var numVal = (int)mixArray[1];
            var floatVal = (float)mixArray[2];
            var charVal = (char)mixArray[3];
            var doubleVal = (double)mixArray[4];
            var boolVal = (bool)mixArray[5];
            #endregion

            #region Sorting values in ArrayList
            //ters siralama
            A1.Reverse();

            //A-Z siralama
            A1.Sort();
            #endregion

            #region Removing values
            A1.RemoveAt(3);
            A1.RemoveRange(2, 2);
            A1.Remove("Cavid");
            #endregion

            #region Checking if value exists
            A1.Add("Malik");

            bool ct = A1.Contains("Malik");

            if (A1.Contains("Malik"))
            {
                int indexOfName = A1.IndexOf("Malik");
                A1.RemoveAt(indexOfName);
            }
            #endregion

            #region Clearing (TrimToSize) Array
            var capacityOfA1 = A1.Capacity;
            var countOfA1 = A1.Count;
            A1.Clear();
            A1.TrimToSize();
            #endregion

            #region Task in Lesson 1
            /*
             İlk öncə aşağıdakı kimi bir menu çıxsın ekranda.

                Menu:
                1 - Element elave et
                2 - Elementleri goster
                3 - Element axtar
                4 - Element editle
                5 - Element sil
                6 - Exit
                Emeliyyat novunu secin:

                Əməliyyat növünü user seçdikdən sonra aşağıdakı kimi proses davam edəcək...
                1:
                Soruşacaq: "Zehmet olmasa elave etmek istediyiniz elementi daxil edin: "
                Daxil edəndən sonra: "Element elave olundu!"

                2:
                Bunu seçəndə bütün elementlər aşağıdakı kimi göstəriləcək.
                1. Element = 15
                2. Element = Salam
                3. Element = Hi
                Burdan çıxmaq üçündə "Davam etmek ucun Enter'e basin" yazısı görsənəcək.

                3:
                Bunu seçəndə aşağıdakı yazı çıxacaq.
                "Axtarmaq istediyiniz elementi daxil edin: "
                Daxil edəndən sonra əgər tapılıbsa, aşağıdakı yazı çıxsın
                "Element tapildi : Index :0 - Deyer: Salam"
                tapılmayıbsa bu yazı çıxsın
                "Axtardiginiz element tapilmadi".

                4:
                "Editlemek istediyiniz elementi daxil edin : " yazısı çıxsın və məsələn Salam sözünü editləmək istəyirsə,
                ilk öncə yoxlayın Salam elementi var mı? Yoxdursa bu yazı çıxsın:
                "Axtardiginiz element tapilmadi"
                Varsa:
                "Salam elementini ne ile evezlemek isteyirsiniz?"
                Editləyəndən sonra da "Element editlendi!" yazısı çıxsın.

                5:
                İlk öncə bunu soruşsun:
                "Butun elementleri silmek isteyirsiniz? (H/Y)"
                əgər cavab H olarsa o zaman bütün elementləri silib "Butun elementler silindi" yazısı çıxsın.
                əgər cavab Y olarsa o zaman "Silmek istediyiniz elementi daxil edin: " yazısı çıxsın və məsələn adam Salam daxil etdisə 
                ilk öncə yoxlayın Salam var mı? Varsa silib "Element silindi" yazın yoxdursa "Silmek istediyiniz element tapilmadi!" yazısı
                çıxsın.
             */

            //{
            //    string choose;
            //    ArrayList array = new ArrayList();

            //    do
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Menu");
            //        Console.WriteLine("1 - Element elave et");
            //        Console.WriteLine("2 - Elementleri goster");
            //        Console.WriteLine("3 - Element axtar");
            //        Console.WriteLine("4 - Element editle");
            //        Console.WriteLine("5 - Element sil");
            //        Console.WriteLine("6 - Exit");
            //        Console.WriteLine("Emeliyyat novunu secin: ");
            //        choose = Console.ReadLine();

            //        switch (choose)
            //        {
            //            case "1":
            //                Console.WriteLine("Zehmet olmasa elave etmek istediyiniz elementi daxil edin: ");
            //                string val = Console.ReadLine();
            //                array.Add(val);
            //                Console.WriteLine("Element elave olundu");

            //                System.Threading.Thread.Sleep(2000);
            //                break;
            //            case "2":
            //                for (int i = 0; i < array.Count; i++)
            //                {
            //                    Console.WriteLine("{0}. Element = {1}", i, array[i]);
            //                }
            //                Console.WriteLine("Davam etmek ucun enter'e basin...");
            //                Console.ReadLine();
            //                break;
            //            case "3":
            //                Console.WriteLine("Axtarmaq istediyiniz elementi daxil edin: ");
            //                string searchKey = Console.ReadLine();
            //                bool control = array.Contains(searchKey);
            //                if (control)
            //                {
            //                    int index = array.IndexOf(searchKey);
            //                    string foundValue = array[index].ToString();
            //                    Console.WriteLine("Element tapildi : index : {0} - Deyer : {1}", index, foundValue);
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Axtardiginiz element tapilmadi");
            //                }

            //                System.Threading.Thread.Sleep(2000);
            //                break;
            //            case "4":
            //                Console.WriteLine("Editlemek istediyiniz elementi daxil edin : ");
            //                string editElement = Console.ReadLine();

            //                if (!array.Contains(editElement))
            //                {
            //                    Console.WriteLine("Axtardiginiz element tapilmadi!");
            //                    break;
            //                }

            //                Console.WriteLine("{0} elementini ne ile evezlemek isteyirsiniz?", editElement);
            //                string newElement = Console.ReadLine();

            //                int indexEdit = array.IndexOf(editElement);
            //                array[indexEdit] = newElement;
            //                Console.WriteLine("Element editlendi!");

            //                System.Threading.Thread.Sleep(2000);
            //                break;
            //            case "5":
            //                Console.WriteLine("Butun elementleri silmek isteyirsiniz? (H/Y)");
            //                string answer = Console.ReadLine();

            //                if(answer.ToUpper() == "H")
            //                {
            //                    array.Clear();
            //                    array.TrimToSize();
            //                    Console.WriteLine("Butun elementler silindi!");
            //                }
            //                else
            //                {
            //                    Console.WriteLine("Silmek istediyiniz elementi daxil edin: ");
            //                    string delElement = Console.ReadLine();

            //                    if (array.Contains(delElement))
            //                    {
            //                        array.Remove(delElement);
            //                        Console.WriteLine("Element silindi!");
            //                    }
            //                    else
            //                    {
            //                        Console.WriteLine("Silmek istediyiniz element tapilmadi!");
            //                    }
            //                }

            //                System.Threading.Thread.Sleep(2000);
            //                break;

            //            default:
            //                break;
            //        }
            //    } while (choose != "6");
            //}
            #endregion
            #endregion




            #region HashTable
            #region What is HashTable and how to use it?
            Hashtable ht = new Hashtable();

            ht.Add("Human", "Insan");
            ht.Add("House", "Ev");
            ht.Add("You", "Sen");

            //Key'e gore axtarmaq
            bool ct1 = ht.Contains("House");
            bool ct2 = ht.Contains("You");

            //Key ve Value'ye gore axtarmaq
            bool ctKey = ht.ContainsKey("House");
            bool ctVal = ht.ContainsValue("Ev");

            //Elementi index operator'uyla value'e gore tapmaq
            ht["House"] = "Villa"; //editledik

            //Elementi key'e gore silmek
            ht.Remove("House");

            int countOfht = ht.Count;
            ht.Clear();
            #endregion

            #region Task in Lesson 2
            /*
             Hashtable içinə ENG - AZ olaraq data əlavə ediləcək.

                Soruşulacaq:
                Yeni element əlavə etmək istəyirsiniz? H/Y
                H : Yeni element əlavə etsin
                Y : Bütün elementləri göstərsin

                Qeyd: Əgər user mövcud olan Key əlavə edirsə, bu məlumat sistemdə mövcuddur xətası versin.
             */

            Hashtable translateBase = new Hashtable();

            do
            {
                Console.Clear();
                Console.WriteLine("Elave etmek istediyiniz tercume sozunu yazin: ");
                Console.WriteLine("ENG: ");
                string eng = Console.ReadLine();

                bool check = translateBase.ContainsKey(eng);

                if (check)
                {
                    Console.WriteLine("Elave etmek istediyiniz soz {0} artiq sistemde movcuddur! {1} deyerinin qarsiligidir.", eng, translateBase[eng].ToString());
                }
                else
                {
                    Console.WriteLine("{0} sozunun tercumesini daxil edin: ", eng);
                    string az = Console.ReadLine();
                    translateBase.Add(eng, az);
                    Console.WriteLine("Elave olundu!");
                }

                Console.WriteLine("Yeni soz elave etmek isteyirsiniz mi? ( H/Y )");
            } while (Console.ReadLine().ToUpper() != "Y");

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("1. Yol");

            foreach (var item in translateBase.Keys)
            {
                Console.WriteLine("ENG: {0} = AZ: {1}", item, translateBase[item]);
            }

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("2. Yol");

            foreach (DictionaryEntry item in translateBase)
            {
                Console.WriteLine("ENG: {0} = AZ: {1}", item.Key, item.Value);
            }
            #endregion
            #endregion


            #region SortedList
            SortedList sortedListEngAz = new SortedList();

            sortedListEngAz.Add("Hello", "Salam");
            sortedListEngAz.Add("Car", "Avtomobil");
            sortedListEngAz.Add("Home", "Ev");
            sortedListEngAz.Add("One", "Bir");
            //sortedListEngAz.Add(100, "Bir"); //compare (qarsilasdirma) ede bilmir int ile string'i
            #endregion


            #region Stack
            Stack stack = new Stack();

            stack.Push("One");
            stack.Push("Two");
            stack.Push("Three");
            stack.Push("Four");

            object O1 = stack.Pop(); //Sonuncu datani qaytarir ve collection icinden silir

            object O2 = stack.Peek(); //Sonuncu datani qaytarir amma collection icinden silmir
            #endregion

            #region Queue
            Queue queue = new Queue();

            queue.Enqueue("One");
            queue.Enqueue("Two");
            queue.Enqueue("Three");
            queue.Enqueue("Four");

            object obj = queue.Peek(); //Peek method'u ilk deyeri qaytarir amma collection icinden silmir

            object obj1 = queue.Dequeue(); //Dequeue method'u ise ilk deyeri qaytardiqdan sonra deyeri silir ve siralamadan cixardir
            #endregion
        }
    }
}
