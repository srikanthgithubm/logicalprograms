using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms_Sai
{
    class Array
    {
        static void Main()
        {
            Console.Write("eneter array range of value");
            int a = int.Parse(Console.ReadLine());

            int[] arr = new int[a];
            Console.Write("enter values");

            for(int i=0;i<arr.Length;i++)
            {
                arr[i]= int.Parse(Console.ReadLine());
                //Console.WriteLine(arr[i]); we cant print here values need another for loop required
            }

            Console.WriteLine("display array values");
            for (int j = 0; j < arr.Length; j++)
            {
                //Console.WriteLine(arr[j]);
               Console.WriteLine("arr[{0}]={1}",j,arr[j]);
            }
            DateTime[] dt = new DateTime[2];
            foreach (DateTime s in dt)
            {
                Console.WriteLine(s);//date 2 times print standard time
            }
                Console.WriteLine(DateTime.Now.ToString());//date with time
                Console.WriteLine(DateTime.Today);//12am standard time

            

            Console.ReadLine();
        }
    }
}
