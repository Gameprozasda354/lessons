using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region work1
            bool continue1 = true;

            ArrayList numbers = new ArrayList();
            Hashtable translate = new Hashtable();
            translate.Add("1 - Element elave et", "1 - Add the Element");
            translate.Add("2 - Elementleri goster", "2 - Show the Elements");
            translate.Add("3 - Element axtar", "3 - Search the Elements");
            translate.Add("4 - Element editle", "4 - Edit the Element");
            translate.Add("5 - Element sil", "5 - Delete the Element");
            translate.Add("Emeliyyat novunu secin:", "Choose the type of the action");
            translate.Add("Zehmet olmasa elave etmek istediyiniz elementi daxil edin:", "Please enter the element which do you want to add.");
            translate.Add("Element elave olundu.", "Element added.");
            translate.Add("Davam etmek ucun Enter'e basin", "Press Enter for continue");
            translate.Add("Axtarmaq istediyiniz elementi daxil edin:", "Enter the element you want to look for.");
            translate.Add("Element tapildi.", "Element found");
            translate.Add("Deyer:", "Value:");
            translate.Add("Axtardiginiz element tapilmadi.", "The element you are looking for has not been found.");
            translate.Add("Editlemek istediyiniz elementi daxil edin :", "Choose the element that you want to edit.");
            translate.Add("elementini ne ile evezlemek isteyirsiniz?", "What do you want to replace this element with?");
            translate.Add("Butun elementleri silmek isteyirsiniz? (H/Y)", "Do you want to delete all elements? (Y/N)");
            translate.Add("Butun elementler silindi", "All Elements Deleted");
            translate.Add("Silmek istediyiniz elementi daxil edin:", "Enter the element that you want to Delete.");
            translate.Add("Element silindi.", "Element Deleted");
            translate.Add("Silmek istediyiniz element tapilmadi!", "Silmek istediyiniz element tapilmadi!");

            Console.WriteLine("1.Aze, 2.Eng");
            int language = Convert.ToInt32(Console.ReadLine());



            while (continue1)
            {
                if (language == 1)
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine("1 - Element elave et");
                    Console.WriteLine("2 - Elementleri goster");
                    Console.WriteLine("3 - Element axtar");
                    Console.WriteLine("4 - Element editle");
                    Console.WriteLine("5 - Element sil");
                    Console.WriteLine("6 - Exit");
                    Console.WriteLine("Emeliyyat novunu secin:");
                }
                else if (language == 2)
                {
                    Console.WriteLine("Menu:");
                    Console.WriteLine(translate["1 - Element elave et"]);
                    Console.WriteLine(translate["2 - Elementleri goster"]);
                    Console.WriteLine(translate["3 - Element axtar"]);
                    Console.WriteLine(translate["4 - Element editle"]);
                    Console.WriteLine(translate["5 - Element sil"]);
                    Console.WriteLine("6 - Exit");
                    Console.WriteLine(translate["Emeliyyat novunu secin:"]);
                }

                int type = Convert.ToInt32(Console.ReadLine());

                switch (type)
                {
                    case 1:
                        if (language == 1)
                        {
                            Console.WriteLine("Zehmet olmasa elave etmek istediyiniz elementi daxil edin: ");
                            numbers.Add(Console.ReadLine());
                            Console.WriteLine("Element elave olundu.");
                            Console.WriteLine("Davam etmek ucun Enter'e basin");
                            Console.ReadLine();
                        }

                        else if (language == 2)
                        {
                            Console.WriteLine(translate["Zehmet olmasa elave etmek istediyiniz elementi daxil edin: "]);
                            numbers.Add(Console.ReadLine());
                            Console.WriteLine(translate["Element elave olundu."]);
                            Console.WriteLine(translate["Davam etmek ucun Enter'e basin"]);
                            Console.ReadLine();
                        }

                        break;
                    case 2:
                        if (language == 1)
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. Element = {numbers[i]}");
                            }
                            Console.WriteLine("Davam etmek ucun Enter'e basin");
                            Console.ReadLine();
                        }
                        else if (language == 2)
                        {
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                Console.WriteLine($"{i + 1}. Element = {numbers[i]}");
                            }
                            Console.WriteLine(translate["Davam etmek ucun Enter'e basin"]);
                            Console.ReadLine();
                        }

                        break;
                    case 3:
                        if (language == 1)
                        {
                            Console.WriteLine("Axtarmaq istediyiniz elementi daxil edin:");
                            var count = Console.ReadLine();
                            if (numbers.Contains(count))
                            {
                                Console.WriteLine($"Element tapildi: Index:{numbers.IndexOf(count)} - Deyer:{count}");
                            }
                            else
                                Console.WriteLine("Axtardiginiz element tapilmadi.");
                            Console.WriteLine("Davam etmek ucun Enter'e basin");
                            Console.ReadLine();
                        }
                        else if (language == 2)
                        {
                            Console.WriteLine(translate["Axtarmaq istediyiniz elementi daxil edin:"]);
                            var count = Console.ReadLine();
                            if (numbers.Contains(count))
                            {
                                Console.WriteLine(translate["Element tapildi:"] + $" Index:{numbers.IndexOf(count)} - " + translate["Deyer:"] + count);
                            }
                            else
                                Console.WriteLine(translate["Axtardiginiz element tapilmadi."]);
                            Console.WriteLine(translate["Davam etmek ucun Enter'e basin"]);
                            Console.ReadLine();
                        }

                        break;
                    case 4:
                        if (language == 1)
                        {
                            Console.WriteLine("Editlemek istediyiniz elementi daxil edin : ");
                            var count1 = Console.ReadLine();
                            if (numbers.Contains(count1))
                            {
                                Console.WriteLine($"{count1} elementini ne ile evezlemek isteyirsiniz?");
                                numbers[numbers.IndexOf(count1)] = Console.ReadLine();
                                Console.WriteLine("Element editlendi!");
                            }
                            else
                                Console.WriteLine("Axtardiginiz element tapilmadi.");
                            Console.WriteLine("Davam etmek ucun Enter'e basin");
                            Console.ReadLine();
                        }
                        else if (language == 2)
                        {
                            Console.WriteLine(translate["Editlemek istediyiniz elementi daxil edin : "]);
                            var count1 = Console.ReadLine();
                            if (numbers.Contains(count1))
                            {
                                Console.WriteLine(count1 + translate["elementini ne ile evezlemek isteyirsiniz?"]);
                                numbers[numbers.IndexOf(count1)] = Console.ReadLine();
                                Console.WriteLine(translate["Element editlendi!"]);
                            }
                            else
                                Console.WriteLine(translate["Axtardiginiz element tapilmadi."]);
                            Console.WriteLine(translate["Davam etmek ucun Enter'e basin"]);
                            Console.ReadLine();
                        }

                        break;
                    case 5:
                        if (language == 1)
                        {
                            Console.WriteLine("Butun elementleri silmek isteyirsiniz? (H/Y)");
                            var answer = Console.ReadLine();
                            if (answer == "H")
                            {
                                numbers.Clear();
                                Console.WriteLine("Butun elementler silindi");
                            }
                            if (answer == "Y")
                            {
                                Console.WriteLine("Silmek istediyiniz elementi daxil edin:");
                                var count4 = Console.ReadLine();
                                if (numbers.Contains(count4))
                                {
                                    numbers.RemoveAt(numbers.IndexOf(count4));
                                    Console.WriteLine("Element silindi.");
                                }
                                else
                                    Console.WriteLine("Silmek istediyiniz element tapilmadi!");
                            }
                            Console.WriteLine(translate["Davam etmek ucun Enter'e basin"]);
                            Console.ReadLine();
                        }
                        else if (language == 2)
                        {
                            Console.WriteLine(translate["Butun elementleri silmek isteyirsiniz? (H/Y)"]);
                            var answer = Console.ReadLine();
                            if (answer.ToUpper() == "Y")
                            {
                                numbers.Clear();
                                Console.WriteLine(translate["Butun elementler silindi"]);
                            }
                            if (answer.ToUpper() == "N")
                            {
                                Console.WriteLine(translate["Silmek istediyiniz elementi daxil edin:"]);
                                var count4 = Console.ReadLine();
                                if (numbers.Contains(count4))
                                {
                                    numbers.RemoveAt(numbers.IndexOf(count4));
                                    Console.WriteLine(translate["Element silindi."]);
                                }
                                else
                                    Console.WriteLine(translate["Silmek istediyiniz element tapilmadi!"]);
                            }
                            Console.WriteLine(translate["Davam etmek ucun Enter'e basin"]);
                            Console.ReadLine();
                        }

                        break;
                    case 6:
                        continue1 = false;
                        break;
                        #endregion


                }
            }
        }
    }
}
