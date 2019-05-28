//Page41　配列の初期化

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayInitialize100
{
    class ArrayInitialize100
    {
        static void Main(string[] args)
        {
            var intArray = new int[100];

            for (int i = 0; i < 100; i++)
            {
                intArray[i] = i+1;
                Console.WriteLine("intArray[" + i + "]=" + intArray[i]);
                Console.ReadKey();
            }
        }
    }
}








