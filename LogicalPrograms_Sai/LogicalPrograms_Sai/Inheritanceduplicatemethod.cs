using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms_Sai
{
    class Inheritanceduplicatemethod
    {
        public void display()
        {
            Console.Write("i am parent display method");
        }
    }
    class hyd : Inheritanceduplicatemethod
    {
    public static double pi = 3.14;
        public  void display()     //or public new void display()
        {
            Console.Write("i am child display method");
        }
    }

    class test
    {
        static void Main()
        {
            hyd obj = new hyd();
            
            obj.display();//out put is i am child display

            Console.WriteLine(hyd.pi);
            Console.ReadLine();
            
        }
    }
}
