using System;
using System.Collections.Generic;
using System.Text;

namespace SinxPatern3
{
    class NegativeTintest:Tintest,Iinpout
    {
        public override void input() 
        {
            Console.WriteLine("Введите колличество элементов множества");
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                int inp = int.Parse(Console.ReadLine());
                if (inp >= 0) 
                {
                    Console.WriteLine("Элемент не может быть положительным");
                    i--;
                    continue;
                }
                planty.Add(inp);
            }
            Console.WriteLine("Множество успешно создано");
        }
    }
}
