using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms_Sai
{
    class Class1
    {
         public static void Main(string[] args)
        {
            //Console.Write("hello");
            Console.Write("Enter large number : ");
            int l1 = int.Parse(Console.ReadLine());  // 149
            Console.Write("enter single digit number : ");
            int d= int.Parse(Console.ReadLine());

            int l2 = 0;

            for(int i=1; i<l1; i++)
            {
                int n = i;
                int c = 0;


                do
                {
                    int r = n % 10;
                    n = n / 10;
                    if (r == d)
                    {
                        c++;
                    }
                } while (n > 0);
                if (c == 0)
                {
                    l2 = i;
                }
            }
            Console.WriteLine("l2 = " + l2);

            //string s = a.ToString();
            // arr=(Convert.ToInt32( s.ToCharArray()));


            //for(int i=a;i>i; i--)
            //{
            //    res=res+arr[i];                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     
            //    Console.Write(res);
            //}
             //int c = a / 10;
            Console.ReadLine();
        }
    }
}
