using System;
using System.Collections.Generic;
using System.Text;

namespace SinxPatern3
{
    class ZeroTintest:Tintest,Iinpout
    {
        public ZeroTintest() 
        {
            MaxCount = 0;
            planty = null;
        }

        public override void input()
        {
            Console.WriteLine("Нельзя инициализировать пустое множество");
        }

        public override void output()
        {
            Console.WriteLine("пустое множество не содержит в себе элементов");
        }

    }
}
