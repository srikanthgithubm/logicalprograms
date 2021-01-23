using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms_Sai
{
    class inputargs
    {
        private int a, b, c;
        public void show(int x,int y)
        {
            a = x;   //local variablea are assigned to field members//int.Parse(Console.ReadLine());
            b = y;  //int.Parse(Console.ReadLine());
        }
        public void display()
        {
            c = a * b;
            Console.Write(c);
        }
        
    }
    class inputarguments
    {
        public static void Main(string[] args)
        {
          

            inputargs obj = new inputargs();
             // int aw = int.Parse(args[0]);     //`here getting error find once
            //int ka = int.Parse(args[1]);
             int aw= int.Parse(Console.ReadLine());
            int ka=int.Parse(Console.ReadLine());
            obj.show(aw,ka);
            obj.display();
            Console.ReadLine();
        }
    }
}
