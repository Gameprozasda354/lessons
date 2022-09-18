using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region work1
            bool continue1 = true;

            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            ArrayList numbers = new ArrayList();
            //Hashtable[] check = new Hashtable[3];
            Hashtable multiLanguages = new Hashtable();
            /*
             Key: add_element
             Aze: 1 - Element elave et
             Eng: 1 - Add the Element
             Tur: 1 - Yeni element ekle
             */
            Hashtable translateEng = new Hashtable();
            translateEng.Add("menu_add_element", "1 - Add the Element");
            translateEng.Add("menu_show_element", "2 - Show the Elements");
            translateEng.Add("menu_search_element", "3 - Search the Elements");
            translateEng.Add("menu_edit_element", "4 - Edit the Element");
            translateEng.Add("menu_delete_element", "5 - Delete the Element");
            translateEng.Add("menu_exit", "6 - Exit");
            translateEng.Add("menu_change_language", "7 - Change the language");
            translateEng.Add("menu_action_type", "Choose the type of the action:");
            translateEng.Add("added_element", "Please enter the element which do you want to add.");
            translateEng.Add("element_added", "Element added.");
            translateEng.Add("press_enter", "Press Enter for continue");
            translateEng.Add("searched_element", "Enter the element you want to look for.");
            translateEng.Add("found_element", "Element found");
            translateEng.Add("value", "Value:");
            translateEng.Add("notfound_element", "The element you are looking for has not been found.");
            translateEng.Add("choose_edit", "Choose the element that you want to edit.");
            translateEng.Add("replace_element", "What do you want to replace this element with?");
            translateEng.Add("element_edited", "Element replaced");
            translateEng.Add("delete_all", "Do you want to delete all elements? (Y/N)");
            translateEng.Add("Y", "Y");
            translateEng.Add("N", "N");
            translateEng.Add("all_deleted", "All Elements Deleted");
            translateEng.Add("deleted_element", "Enter the element that you want to Delete.");
            translateEng.Add("element_deleted", "Element Deleted");
            translateEng.Add("notfound_delete", "Element not found that you want to delete");

            Hashtable translateAze = new Hashtable();
            translateAze.Add("menu_add_element", "1 - Element əlavə et");
            translateAze.Add("menu_show_element", "2 - Elementleri göstər");
            translateAze.Add("menu_search_element", "3 - Element axtar");
            translateAze.Add("menu_edit_element", "4 - Element editlə");
            translateAze.Add("menu_delete_element", "5 - Element sil");
            translateAze.Add("menu_exit", "6 - Çıxış");
            translateAze.Add("menu_change_language", "7 - Dili dəyişdir");
            translateAze.Add("menu_action_type", "Əməliyyat novünü seçin:");
            translateAze.Add("added_element", "Əlave etmək istədiyiniz elementi daxil edin");
            translateAze.Add("element_added", "Element əlave olundu");
            translateAze.Add("press_enter", "Davam etmək üçün enterə basın");
            translateAze.Add("searched_element", "Axtarmaq istədiyiniz elementi daxil edin");
            translateAze.Add("found_element", "Element tapıldı");
            translateAze.Add("value", "Dəyər:");
            translateAze.Add("notfound_element", "Axtardığınız element tapılmadı");
            translateAze.Add("choose_edit", "Editləmək istədiyiniz elementi daxil edin");
            translateAze.Add("element_edited", "Element editləndi");
            translateAze.Add("replace_element", "elementi nə ilə əvəzləmək istəyirsiniz?");
            translateAze.Add("delete_all", "Bütün elementləri silmək istəyirsiniz? (H/Y)");
            translateAze.Add("Y", "H");
            translateAze.Add("N", "Y");
            translateAze.Add("all_deleted", "Bütün elementlər silindi");
            translateAze.Add("deleted_element", "Silmək istədiyiniz elementi daxil edin.");
            translateAze.Add("element_deleted", "Element Silindi");
            translateAze.Add("notfound_delete", "Silmək istədiyiniz element tapılmadı!");

            Hashtable translateTur = new Hashtable();
            translateTur.Add("menu_add_element", "1 - Element ekle");
            translateTur.Add("menu_show_element", "2 - Elementleri çıkar");
            translateTur.Add("menu_search_element", "3 - Element ara");
            translateTur.Add("menu_edit_element", "4 - Element editle");
            translateTur.Add("menu_delete_element", "5 - Element sil");
            translateTur.Add("menu_exit", "6 - Çıkış");
            translateTur.Add("menu_change_language", "7 - Dili değiştir");
            translateTur.Add("menu_action_type", "İşlemin türünü seçin:");
            translateTur.Add("added_element", "Eklemek istediğiniz elementi yazın");
            translateTur.Add("element_added", "Element eklendi");
            translateTur.Add("press_enter", "Devam etmek için entere tıklayın");
            translateTur.Add("searched_element", "Aramak istediğiniz elementi yazın");
            translateTur.Add("found_element", "Element bulundu");
            translateTur.Add("value", "Değer:");
            translateTur.Add("notfound_element", "Aradığınız element bulunmadı");
            translateTur.Add("choose_edit", "Değiştirmek istediğiniz elementi yazın");
            translateTur.Add("element_edited", "Element değişdirildi");
            translateTur.Add("replace_element", "elementi ne ile değiştirmek istiyorsunuz");
            translateTur.Add("delete_all", "Tüm elementler silinsin mi?(E/H)");
            translateTur.Add("Y", "E");
            translateTur.Add("N", "H");
            translateTur.Add("all_deleted", "Tüm elementler silindi");
            translateTur.Add("deleted_element", "Silmek istediğiniz elementi yazın");
            translateTur.Add("element_deleted", "Element silindi");
            translateTur.Add("notfound_delete", "Silmek istediğiniz element bulunamadı!");


            multiLanguages.Add("eng", translateEng);
            multiLanguages.Add("aze", translateAze);
            multiLanguages.Add("tur", translateTur);





            Console.WriteLine("1.Aze, 2.Eng, 3.Tur");
            int language = Convert.ToInt32(Console.ReadLine());
            Hashtable selectedLanguage = (Hashtable)multiLanguages["eng"];

            while (continue1)
            {
                if (language == 1)
                {
                    selectedLanguage = (Hashtable)multiLanguages["aze"];
                }
                else if (language == 2)
                {
                    selectedLanguage = (Hashtable)multiLanguages["eng"];
                }
                else if (language == 3)
                {
                    selectedLanguage = (Hashtable)multiLanguages["tur"];
                }

                Console.WriteLine("Menu:");
                Console.WriteLine(selectedLanguage["menu_add_element"]);
                Console.WriteLine(selectedLanguage["menu_show_element"]);
                Console.WriteLine(selectedLanguage["menu_search_element"]);
                Console.WriteLine(selectedLanguage["menu_edit_element"]);
                Console.WriteLine(selectedLanguage["menu_delete_element"]);
                Console.WriteLine(selectedLanguage["menu_exit"]);
                Console.WriteLine(selectedLanguage["menu_change_language"]);
                Console.WriteLine(selectedLanguage["menu_action_type"]);
                int type = Convert.ToInt32(Console.ReadLine());

                switch (type)
                {
                    case 1:
                        Console.WriteLine(selectedLanguage["added_element"]);
                        numbers.Add(Console.ReadLine());
                        Console.WriteLine(selectedLanguage["element_added"]);
                        Console.WriteLine(selectedLanguage["press_enter"]);
                        Console.ReadLine();

                        break;
                    case 2:

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. Element = {numbers[i]}");
                        }
                        Console.WriteLine(selectedLanguage["press_enter"]);
                        Console.ReadLine();

                        break;
                    case 3:

                        Console.WriteLine(selectedLanguage["searched_element"]);
                        var count = Console.ReadLine();
                        if (numbers.Contains(count))
                        {
                            Console.WriteLine(selectedLanguage["found_element"]);
                            Console.WriteLine("Index:" + numbers.IndexOf(count) + selectedLanguage["value"] + count);
                        }
                        else
                            Console.WriteLine(selectedLanguage["notfound_element"]);
                        Console.WriteLine(selectedLanguage["press_enter"]);
                        Console.ReadLine();

                        break;
                    case 4:

                        Console.WriteLine(selectedLanguage["choose_edit"]);
                        var count1 = Console.ReadLine();
                        if (numbers.Contains(count1))
                        {
                            Console.WriteLine(count1 + selectedLanguage["replace_element"]);
                            numbers[numbers.IndexOf(count1)] = Console.ReadLine();
                            Console.WriteLine(selectedLanguage["element_edited"]);
                        }
                        else
                            Console.WriteLine(selectedLanguage["notfound_element"]);
                        Console.WriteLine(selectedLanguage["press_enter"]);
                        Console.ReadLine();

                        break;
                    case 5:

                        Console.WriteLine(selectedLanguage["delete_all"]);
                        var answer = Console.ReadLine();
                        if (answer.ToUpper() == (string)selectedLanguage["Y"])
                        {
                            numbers.Clear();
                            Console.WriteLine(selectedLanguage["all_deleted"]);
                        }
                        if (answer.ToUpper() == (string)selectedLanguage["N"])
                        {
                            Console.WriteLine(selectedLanguage["delete_element"]);
                            var count4 = Console.ReadLine();
                            if (numbers.Contains(count4))
                            {
                                numbers.RemoveAt(numbers.IndexOf(count4));
                                Console.WriteLine(selectedLanguage["element_deleted"]);
                            }
                            else
                                Console.WriteLine(selectedLanguage["notfound_delete"]);
                        }
                        Console.WriteLine(selectedLanguage["press_enter"]);
                        Console.ReadLine();

                        break;
                    case 6:
                        continue1 = false;
                        break;

                    case 7:
                        Console.WriteLine("1.Aze, 2.Eng, 3.Tur");
                        int c = Convert.ToInt32(Console.ReadLine());
                        language = c;

                        break;
                        #endregion


                }
            }

        }
    }
}
