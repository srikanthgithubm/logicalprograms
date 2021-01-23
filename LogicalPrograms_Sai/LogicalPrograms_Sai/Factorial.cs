using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms_Sai
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int fact = 1;
            Console.WriteLine("enter a number");
            int a=int.Parse(Console.ReadLine());
            for(int i=a;i>=1;i--)
            {
                fact = fact * i;
               
            }
            Console.Write(fact);
            Console.ReadLine();
        }
    }
}
