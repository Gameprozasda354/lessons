using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Part_1
{
    public class Student
    {
        /*
         Method nece yazilir?
         [access modifier] [return type] [method name] ( parameters ) {
            method'un body hissesi
         }

         Access Modifiers:
         1. Public
         Bir methodu public təyin etdiyimiz zaman biz əslində deyirik ki, class'a əli çatan hər yerdə bu methoddan istifadə etmək icazəsi veririk.

         2. Private
         Əgər methodumuzu private təyin etsək o zaman bu methoda yalnız və yalnız təyin etdiyimiz class daxilindən əlimiz çatır. Yəni class'ın
         içində private method təyin edəndə, bu method'u ancaq həmin class'ın içindən çağırmaq olur. Class'ları private təyin edə bilmirik.
         */

        public void HelloStudent()
        {
            Console.WriteLine("Salam telebe!");
        }

        private void ShowStudentInfo(string name, string surname)
        {
            Console.WriteLine("Telebe melumatlari: {0} {1}", name, surname);
        }

        public void ShowHasanInfo()
        {
            ShowStudentInfo("Hesen", "Haciyev");
        }

        //Task in lesson 1
        //Bir dənə class içində 2 fərqli method yaradacaqsız. Biri public digəri private olacaq şəkildə edib public method'u program class'ında çağıracaqsız.
        //Method ekrana hər hansısa bir şey yazdırsın kifayətdir.
    }
}
