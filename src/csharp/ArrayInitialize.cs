//Page40　配列の初期化

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInitialize
{
    class ArrayInitialize
    {
        static void Main(string[] args)
        {
            var intArray = new int[10];

            for (int i = 0; i < 10; i++)
            {
                intArray[i] = i;
                Console.WriteLine(intArray[i]);
                Console.ReadKey();
            }
        }
    }
}


