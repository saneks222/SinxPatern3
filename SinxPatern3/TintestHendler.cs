using System;
using System.Collections.Generic;
using System.Text;

namespace SinxPatern3
{
    class TintestHendler
    {
      static  Tintest tintest1;
       static Tintest tintest2;
        static Tintest tintestunific;

        public static void run() 
        {
            Console.WriteLine("Введите:\n\r1-создание первого множества \n\r2-создание второго множества \n\r3-вывод первого множества \n\r4-вывод второго множества \n\r5- обьединение первого и второго \n\r6-обьединение первого и второго без повторов \n\r7-обьединение и сортеровка первого и второго \n\r8-выход из программы");
            while (true) 
            {
                int inp = int.Parse(Console.ReadLine());
                if (inp==1) 
                {
                    Console.WriteLine("Введите диапозон [а,b] каждое число с новой строки");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());

                    if (a < 0&&b < 0)
                        {
                        tintest1 = new NegativeTintest();
                        tintest1.input();
                        }

                    if (a == 0 && b == 0) 
                    {
                        tintest1 = new ZeroTintest();
                        tintest1.input();
                    }

                    if (a >= 0 && b > 0) 
                    {
                        tintest1 = new PositiveTintest();
                        tintest1.input();
                    }

                }
                if (inp == 2)
                {
                    Console.WriteLine("Введите диапозон [а,b] каждое число с новой строки");
                    int a = int.Parse(Console.ReadLine());
                    int b = int.Parse(Console.ReadLine());

                    if (a < 0 && b < 0)
                    {
                        tintest2 = new NegativeTintest();
                        tintest2.input();
                    }

                    if (a == 0 && b == 0)
                    {
                        tintest2 = new ZeroTintest();
                        tintest2.input();
                    }

                    if (a >= 0 && b > 0)
                    {
                        tintest2 = new PositiveTintest();
                        tintest2.input();
                    }

                }
                if (inp == 3)
                {
                    tintest1.output();
                }
                if (inp == 4)
                {
                    tintest2.output();
                }
                if (inp == 5)
                {
                    tintestunific = new Tintest();
                    tintestunific.planty = tintest1.planty;
                    tintestunific.planty.AddRange(tintest2.planty);
                    Console.WriteLine("Обьединенное множество");
                    tintestunific.output();
                }
                if (inp == 6)
                {
                    HashSet<int> set = new HashSet<int>();
                    for (int i = 0; i < tintest1.planty.Count; i++) 
                    {
                        set.Add(tintest1.planty[i]);
                    }

                    for (int i = 0; i < tintest2.planty.Count; i++)
                    {
                        set.Add(tintest2.planty[i]);
                    }

                    int[] z = new int[set.Count];
                    set.CopyTo(z);
                    List<int> c = new List<int>();
                    c.AddRange(z);
                    tintestunific = new Tintest();
                    tintestunific.planty = c;
                    tintestunific.output();
                }
                if (inp == 7)
                {
                    List<int> z = new List<int>();
                    z.AddRange(tintest1.planty);
                    z.AddRange(tintest2.planty);
                    z.Sort();
                    tintestunific = new Tintest();
                    tintestunific.planty = z;
                    tintestunific.output();

                }
                if (inp == 8)
                {
                    break;
                }

            }
        }

    }
}
