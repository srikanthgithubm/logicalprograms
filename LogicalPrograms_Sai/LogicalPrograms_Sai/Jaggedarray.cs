using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms_Sai
{
    class Jaggedarray
    {
        static void Main()
        {
            int[][] arr = { new int[5] {1,2,3,4,5 },
                             new int[4] {1,2,3,4 },
                             new int[3]{1,2,3}
            };

            string[][] brr = { new string[3] {"aaa","bbb","ccc"},
                               new string[2]{ "sree","yadav"}        
            };

            foreach(int[] s in arr)
            {
                foreach (int k in s)
                {
                    Console.WriteLine(k + "");
                }
            }
            foreach(string[] s in brr)
            {
                foreach (string k in s)
                {
                    Console.Write(k+"");
                }
            }
            Console.ReadLine();
        }
    }
}
