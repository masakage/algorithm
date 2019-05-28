//Page52 最大値を表示する

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Max
    {
        static void Main(string[] args)
        {

            var T = new int[5];
            int Idx = 0;
            int Max = 0;

            T[0] = 1;
            T[1] = 3;
            T[2] = 3;
            T[3] = 6;
            T[4] = 4;

            Max = T[1];

            for (Idx = 0; Idx < 5; Idx++)
            {
                while (Max < T[Idx])
                {
                    Max = T[Idx];
                }
            }

            Console.WriteLine(Max);
            Console.ReadKey();
        }
    }
}
