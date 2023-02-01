using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calendar2_KrutiNayee
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int i, j, k = -1;
                Console.WriteLine(" Su  Mo  Tu  We  Th  Fr  Sa");

                for (i = 1; i <= 31; i = i + 7)
                {

                    for (j = 1; j <= 7; j++)
                    {
                        if (k <= 0)
                            Console.Write("    ");
                        else if (k > 0 & k < 10)
                            Console.Write("  " + k + " ");
                        else if (k == 32)
                            break;
                        else
                            Console.Write("  " + k);
                        k++;

                    }
                    Console.WriteLine("\n");
                    Console.ReadKey();
                }

            }
        }
    }
}
