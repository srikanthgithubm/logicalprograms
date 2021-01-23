using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms_Sai
{
    class multidimenstionalarray
    {
        static void Main(string[] args)
        {
            int[,] arr = {{1,2,3} ,{4,5,6},{7,8,9},{10,11,12}
            
            };
            Console.WriteLine("array of length is"+arr.Length);
            Console.WriteLine("NO OF ROWS ARE" + arr.GetLength(0));
            Console.WriteLine("no of columns are" + arr.GetLength(1));
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++) 
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();

                //Console.Write(arr[i, j] + "");


                
            }
            Console.ReadLine();
        }

    }
}
