using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms_Sai
{
    class Fibbanocci
    {
        static void Main(string[] args)
        {
            int f0 = 0, f1 = 1, f2=0;
            Console.Write("enter no of elements");
            int n=int.Parse(Console.ReadLine());
            Console.Write(f0+ " "+f1);//0 and 1 printed
            for (int i = 2; i<= n; i++)
            {
                
                f2 = f0 + f1;
                Console.Write(f2+"");
                f0 = f1;
                f1 = f2;
                
                
            }
            

            

            Console.ReadLine();
        }
        
    }
}
        //int len = 0;
       //int a = 0, b = 1, c = 0;
      //Console.Write("{0} {1}", a, b);
//            for (int i = 2; i<len; i++)
//            {
//                c = a + b;
//                Console.Write("{0}", c);
//                a = b;
//                b = c;
//            }
//            Console.ReadLine();
//            Console.ReadKey();