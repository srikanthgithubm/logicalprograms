using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms_Sai
{
    class Pattern3
    {
        static void Main(string[] args)
        {
            for (int i = 5; i >= 1; i--)
            {
                for (int k = 5; k > i; k--)
                {
                    Console.Write("  ");
                }

                for (int j = i; j >= 1; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

            for (int i = 5; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i + " ");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}
//54321
// 4321
//  321
//   21
//    1 

//     1
//    12
//   123
// 1234
//12345