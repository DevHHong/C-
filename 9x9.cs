using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i <= 9; ++i)
            {
                Console.WriteLine("{0}단\n", i);
                for (int j = 1; j <= 9; j++)
                {
                    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
