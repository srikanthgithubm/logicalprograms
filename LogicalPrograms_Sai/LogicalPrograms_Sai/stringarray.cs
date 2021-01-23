using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms_Sai
{
    class stringarray
    {
        static int a=10 ;
       static string s = "static string abc";
        static string s2 = "nonstatic string";
        static string s3 = "add string";

        string ss = "hyd";
        static void Main()
        {
           int b = a;
            Console.Write(b);
            string s1 = s;
            Console.Write(s1);
            s1 = "sree";
            Console.Write(s1);//output  10 abc sree
            string s4=s2 + s3;
            Console.Write(s4);
            StringBuilder sb = new StringBuilder();
            sb.Append("chandra");
           
            //string[] str = { "sree","srikanth","yadav"};
            //foreach(var s in str)
            //{
            // Console.Write(s+"");//print 3 strings and length
            //  Console.Write(str.Length);
            //}
            //2ndprogram.............

            Console.ReadLine();
        }
    }
}
