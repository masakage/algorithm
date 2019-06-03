using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class BinarySearchTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BinarySearch(13));
            Console.ReadKey();

            //以下関数
            int BinarySearch(int x)
            {
                var T = new int[] { 1, 4, 8, 13, 16, 22 };
                int Low = 0;
                int High = 5;
                int Mid = 0;

                while (Low <= High)
                {
                    if (T[Mid] == x)
                    {
                        return (Mid);
                    }
                    else if (T[Mid]>x) {
                        High = Mid - 1;
                    }

                    else
                    {
                        Low = Mid + 1;
                    }

                    Mid = (Low + High) / 2;
                }
                return -1;
            }
        }
    }
}