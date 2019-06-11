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

            var T = new int[] { 1, 3, 3, 6, 4 };
            int Idx = 0;
            int Max = 0;

            Max = T[0];

            for (Idx = 0; Idx < 5; Idx++)
            {
                if (Max < T[Idx])
                {
                    Max = T[Idx];
                }
            }

            Console.WriteLine(Max);
            Console.ReadKey();
        }
    }
}
