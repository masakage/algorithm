//C#で書いてみました。
//Training 1-6
//Page46 9行9列の2次元配列 kukuに、九九の表を作成する

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KuKu
{
    class Kuku
    {
        static void Main(string[] args)
        {
            var kuku = new int[9,9];
            int i, j;

            for (i = 0; i < 9; i++)
            {
                for (j = 0; j < 9; j++)
                {
                    kuku[i,j] = (i + 1) * (j + 1);
                    Console.Write("{0,3:d}",(i+1) * (j+1));
                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
