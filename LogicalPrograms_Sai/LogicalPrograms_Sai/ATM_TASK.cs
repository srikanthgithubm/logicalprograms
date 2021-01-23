using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms_Sai
{
    class ATM_TASK
    {

      

        static void Main(String[] args)
        {
            for (int i = 1; i <= 3; i++)
            {
                int choice = 3;
                Console.Write("\nEnter a number between 1-100 : ");
                int a = int.Parse(Console.ReadLine());
                choice = choice - 1;

                if (a == 65)
                {
                    Console.WriteLine("Congratulations You Entered Correct Number");
                    break;
                }
                if (a < 65)
                {
                    Console.WriteLine("you entered small number then actual number");
                    Console.WriteLine("You have {0} choices", choice);
                    // Console.WriteLine("You have 2 choices only");

                }
                if (a > 65)
                {
                    Console.WriteLine("you entered big number then actual number");
                    Console.WriteLine("You have {0} choices", choice);
                    break;
                    // Console.WriteLine("You have 2 choices only");
                }
            }
            Console.ReadLine();
        }
    }
}
