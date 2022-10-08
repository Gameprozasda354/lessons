namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Recursive methods
            int faktorial10 = Faktorial(10);
            int faktorial0 = Faktorial(0);
            int faktorial5 = Faktorial(5);
            #endregion

            #region What is static?
            /*
             -Static nədir?
             -Static'in ram'dakı yeri
             -Static field, method, class nədir və içindəki constructor static olarsa nə olar, standart olarsa nə olar və s.
             */

            Student student;
            //student.Name = "a"; //error
            //Student.Name

            Student.Test1();


            student = new Student();
            student.Name = "Orkhan";
            student.Surname = "Farajov";
            student.Email = "orkhankhf@gmail.com";
            student.Test();
            #endregion



            #region Where and why to use static?
            /*
             1. Helper class'lar
             2. Static field
             */
            #endregion

            #region Task in Lesson 1
            /*
             Task description:
             Ad ve soyad parametrleri qebul eden method yaz.
             ad ve soyadin uzunlugu 20 xarakterden uzundursa, adin ilk herfi, noqte bosluq soyad (O. Farajov).
             Yox eger 20 simvoldan qisadirsa ad bosluq soyad qaytarsin. Icindeki bosluq simvolunu da nezere al.
             */
            var normalName = StringHelper.CheckFullName("Orkhan", "Farajov");
            var longFullname = StringHelper.CheckFullName("OrkhanOrkhanOrkhan", "Farajov");
            var longFullname2 = StringHelper.CheckFullName("Orkhan Middlename", "Farajov");
            var longFullname3 = StringHelper.CheckFullName("Orkhan Ibn Khayyam", "Farajov");
            #endregion

            #region Task In Lesson 2
            /*
             Staff = Isci
             Ad, Soyad, Email, Cins
             "orkhan.farajov"
             @gmail.com
             */

            Staff st = new Staff();
            st.Name = "Orkhan";
            st.Surname = "Farajov";
            st.Email = "orkhan.farajov";
            st.Gender = 1;
            #endregion

            #region Task in Lesson 3
            EmailHelper.SendWelcomeMail(st.Email);

            EmailHelper.SendWelcomeMail(student.Email);

            EmailHelper.SendPasswordChangeMail(st.Email);
            #endregion
        }

        #region Faktorial method
        static int Faktorial(int num)
        {
            if (num == 0)
                return 1;

            return num * Faktorial(num - 1);
        }
        #endregion
    }
}
