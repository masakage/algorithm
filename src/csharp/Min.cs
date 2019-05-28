using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Min
    {
        static void Main(string[] args)
        {

            var T = new int[] { 8, 4, 2, 1, 6 };
            int Idx = 0;
            int Min = 0;

            Min = T[0];

            for (Idx = 0; Idx < 5; Idx++)
            {
                while (Min > T[Idx])
                {
                    Min = T[Idx];
                }
            }

            Console.WriteLine(Min);
            Console.ReadKey();
        }
    }
}
