using System;
using System.Collections.Generic;
using System.Text;

namespace SinxPatern3
{
    class Tintest : Iinpout
    {
       protected int MaxCount;
       public  List<int> planty;

        public Tintest() 
        {
            MaxCount = -1;
            planty = new List<int>();
        }

        public Tintest(int count) 
        {
            MaxCount = count;
            planty = new List<int>();
        }

        public virtual void input()
        {
            Console.WriteLine("Введите колличество элементов множества");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0;i<count;i++ ) 
            {
                planty.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Множество успешно создано");
        }

        public virtual void output()
        {
            foreach (var i in planty) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
