using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms_Sai
{
    public abstract class Calculator1
    {
        static int c;
        static double d;
        public static int add(int a, int b)
        {

            c = a + b;
            return c;
        }
        public static int sub(int a, int b)
        {
            int r = a - b;
            return r;
        }

        public static double mul(double a, double b)
        {
            d = a * b;
            return d;
        }
        public static double div(double a, double b)
        {
            d = a / b;
            return d;

        }
        public abstract double Calc();

        public virtual void GetTodayDate()
        {

            //string s = DateTime.Now.ToString();
            //Console.Write(s);
        }

    }

    class ScientificCalculator : Calculator1
    {
        public override double Calc()
        {

            {

                int addd = Calculator1.add(10, 20);
                // return add;
                Console.Write("addition is:" + addd);

                int subb = Calculator1.sub(10, 20);
                Console.Write("sub is:" + subb);
                // return sub;

                double multt = Calculator1.mul(10, 20);
                Console.Write("multiplication is:" + multt);
                //return mult;

                double divv = Calculator1.div(10, 20);
                Console.Write("div is:" + divv);
                // return divv;
                double lastresult = 0;
                lastresult = addd + subb + multt + divv;

                return lastresult;
                Console.Write("lastresult:" + lastresult);
            }
        }

        public override void GetTodayDate()
        {

            string s = DateTime.Now.ToString();
            Console.Write(s);
        }

        public static void square(int a)
        {
            int c = 0;
            c = a * a;
            Console.WriteLine("square num is :" + c);
        }
        public static void factorial(int a)
        {
            int resul = 0, fact = 1;
            for (int i = a; i >= 1; i--)
            {
                fact = fact * i;

            }
            Console.WriteLine("factorial of number is:" + fact);
        }
        // Console.ReadLine();
    }
    class ConversionCalculator : Calculator1
    {
        public override double Calc()
        {
            int addd = Calculator1.add(10, 20);
            // return add;
            Console.Write("addition is:" + addd);

            int subb = Calculator1.sub(10, 20);
            Console.Write("sub is:" + subb);
            // return sub;

            double multt = Calculator1.mul(10, 20);
            Console.Write("multiplication is:" + multt);
            //return mult;

            double divv = Calculator1.div(10, 20);
            Console.Write("div is:" + divv);
            // return divv;
            double lastresult = 0;
            lastresult = addd + subb + multt + divv;

            return lastresult;
            Console.Write("lastresult:" + lastresult);
        }

        public void metertocm(int i)
        {

            int c = i * 100;
            Console.WriteLine("meter in centemeter is:" + c);
        }
        public void kgtopounds(int j)
        {
            double c = j * 2.2;
            Console.WriteLine("kilograms in Pounds is:" + c);
        }
    }
    class ScientificCalcultor
    {
        static void Main(string[] args)
        {
            ScientificCalculator.square(5);
            ScientificCalculator.factorial(5);

            ScientificCalculator sf = new ScientificCalculator();
            sf.GetTodayDate();
            sf.Calc();

            ConversionCalculator cc = new ConversionCalculator();
            cc.kgtopounds(5);
            cc.metertocm(5);
            Console.ReadLine();
        }

    }
}