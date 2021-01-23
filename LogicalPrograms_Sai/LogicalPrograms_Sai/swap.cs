using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms_Sai
{
    class swap
    {
        static void Main(string[] args)
        {
            int i = 5, j = 10;
            Console.Write("before swap" +i+""+j);

            i = i /j;
            j = i /j;
            j = i * j;

            Console.Write("after swap" + i + "" + j);

            Console.ReadLine();

        }
        
    }
}
