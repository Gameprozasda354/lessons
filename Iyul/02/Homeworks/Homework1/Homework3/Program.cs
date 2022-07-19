using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region int
            Console.WriteLine("int:");

            short q = -1234;

            int i = 1233333333;

            long l = -1111111111111122222;

            Console.WriteLine(q);
            Console.WriteLine(i);
            Console.WriteLine(l);
            l = i;

            Console.WriteLine(l);
            i = q;


            Console.WriteLine(i);

            l = q;

            Console.WriteLine(l);

            Console.WriteLine("------------------------------------------------------------------");
            #endregion

            #region byte

            Console.WriteLine("byte:");

            sbyte o = -123;
            byte b = 124;
            sbyte c = 120;
            Console.WriteLine(o);
            Console.WriteLine(b);
            Console.WriteLine(c);

            o = (sbyte)b;
            b = (byte)c;

            Console.WriteLine(o);
            Console.WriteLine(b);

            Console.WriteLine("------------------------------------------------------------------");
            #endregion

            #region uint
            Console.WriteLine("uint:");

            ushort m = 12;

            uint z = 1233333333;

            ulong k = 1111111111111122222;

            Console.WriteLine(m);
            Console.WriteLine(z);
            Console.WriteLine(k);
            k = z;

            Console.WriteLine(k);
            z = m;


            Console.WriteLine(z);

            k = z;

            Console.WriteLine(k);

            Console.WriteLine("------------------------------------------------------------------");
            #endregion

            #region float and double
            Console.WriteLine("float and double:");

            float f = 13.234f;
            float p = 234.0f;
            float e = 45.678f;
            float g = 26.0f;
            float h = 987.569f;
            f = e;
            e = p;
            p = f;
            h = g;
            g = e;
            
            Console.WriteLine(f);
            Console.WriteLine(p);
            Console.WriteLine(e);
            Console.WriteLine(g);
            Console.WriteLine(h);

            double d = 12.67;
            double s = 2516256125612.57656867586;
            double y = 124.7890;
            double doub = 143.5446;
            double qwert = 744.66536;

            Console.WriteLine(d);
            Console.WriteLine(doub);
            Console.WriteLine(qwert);
            Console.WriteLine(y);
            Console.WriteLine(s);

            Console.WriteLine("------------------------------------------------------------------");

            #endregion

            #region decimal and char

            Console.WriteLine("decimal and char:");

            decimal decim = 12.45M;
            decimal decim2 = decim * 3;
            decimal decim3 = decim2 * 43;
            decimal decim4 = decim2 + 13;
            decimal decim5 = decim + decim3;

            Console.WriteLine(decim);
            Console.WriteLine(decim2);
            Console.WriteLine(decim3);
            Console.WriteLine(decim4);
            Console.WriteLine(decim5);


            char ch = 'O';
            Console.WriteLine(ch);
            char ui = 'c';
            char io = 't';
            Console.WriteLine(ui);
            Console.WriteLine(io);
            char games = 'V';
            char games2 = 'M';
            char games3 = 'F';
            Console.WriteLine(games);
            Console.WriteLine(games2);
            Console.WriteLine(games3);

            Console.WriteLine("------------------------------------------------------------------");
            #endregion

            #region Boolean
            Console.WriteLine("Boolean:");
            bool beli = false;
            Console.WriteLine("azerbaycanda yasayirsiniz?(eger yasayirsinizsa y,yox eger yasmirsinizsa xyazin)");
            var yes = Console.ReadLine();

            if (yes == "y")
            {
                beli = true;
                if (beli == true)
                {
                    Console.WriteLine("Siz azerbaycanda yasayirsiniz.");
                }

                else
                {
                    Console.WriteLine("Siz azerbaycanda yasamirsiniz.");
                }
            
            }
            else
            {
                if (yes == "x")
                {
                    if (beli == true)
                    {
                        Console.WriteLine("Siz azerbaycanda yasayirsiniz.");
                    }

                    else
                    {
                        Console.WriteLine("Siz azerbaycanda yasamirsiniz.");
                    }
                }

                else
                {
                    Console.WriteLine("azerbaycanda yasayirsiniz?(eger yasayirsinizsa y,yox eger yasmirsinizsa xyazin)");
                    var yes1 = Console.ReadLine();

                    if (yes1 == "y")
                    {
                        beli = true;
                        if (beli == true)
                        {
                            Console.WriteLine("Siz azerbaycanda yasayirsiniz.");
                        }

                        else
                        {
                            Console.WriteLine("Siz azerbaycanda yasamirsiniz.");
                        }
                    }

                    if (yes1 == "x")
                    {
                        if (beli == true)
                        {
                            Console.WriteLine("Siz azerbaycanda yasayirsiniz.");
                        }

                        else
                        {
                            Console.WriteLine("Siz azerbaycanda yasamirsiniz.");
                        }
                    }
                }

            }

            Console.WriteLine("------------------------------------------------------------------");


            #endregion

            #region string
            Console.WriteLine("String:");

            string omer = "Omer isgenderli";
            string ad = "Omer";
            string soyad = "Isgenderli";
            string ad_Soyad = ad + " " + soyad;
            string oq = "Onun";
            string Men = "Menim";
            string Sen = "Senin";
            string car = "maşın";

            Console.WriteLine(omer);
            Console.WriteLine(ad);
            Console.WriteLine(soyad);
            Console.WriteLine(ad_Soyad);
            Console.WriteLine(oq + " " + car + "ı");
            Console.WriteLine(Men + " " + car + "ım");
            Console.WriteLine(Sen + " " + car + "ın");

            Console.WriteLine("------------------------------------------------------------------");

            #endregion

            #region object and dynamic

            Console.WriteLine("object and dynamic:");

            object gamer = "wasd";
            object agent1 = "Astra";
            object agent2 = "Viper";
            object agent3 = "Reyna";
            object agent4 = "Chamber";
            object agent5 = "Omen";
            object agent6 = "Jett";
            Console.WriteLine(gamer);
            Console.WriteLine(agent1);
            Console.WriteLine(agent2);
            Console.WriteLine(agent3);
            Console.WriteLine(agent4);
            Console.WriteLine(agent5);
            Console.WriteLine(agent6);

            dynamic gamer2 = 1234;
            dynamic gamer3 = "Cned";
            dynamic gamer4 = "Epha";
            dynamic gamer5 = "Bordo";
            dynamic gamer6 = gamer5 + " " + gamer4;
            Console.WriteLine(gamer2);
            Console.WriteLine(gamer3);
            Console.WriteLine(gamer4);
            Console.WriteLine(gamer5);
            Console.WriteLine(gamer6);

            Console.WriteLine("------------------------------------------------------------------");

            #endregion

            Console.ReadLine();
        }
    }
}
