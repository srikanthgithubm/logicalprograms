using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms_Sai
{
    class Largeststringamonggivenstrings
    {
        public static void Main(string[] args)
        {

            string str = "aa,bbbb,cc,dd";  //  "Hyd!& ! to day"
            // Console.WriteLine(" " + str[4] + " = " + str.Length);
            //string[] max;
            int max=0;
            //index 3 and length 4   int s=str.Length;
            char[] mychar = { ',' };
            string[] s = str.Split(mychar);
            Console.WriteLine("str = " + str.Length + "\ns[] = " + s.Length);
            string res = "";

            //string k = null;
            //int maxLength = 0;
            //if (s.Length > maxLength)
            //{
            //    maxLength = s.Length;
            //  k = s;
            //}

            //for (int i = 0; i < s.Length; i++)
            //{
            //    for (int j = i + 1; j<s.Length; j++)
            //    {
            //        if(s[0].Length >= s[j].Length)
            //        {
            //             k = s[j];
            //        }
            //    }
            //}
            //Console.Write(k);
            //for(int i=1; i<=4;i++)
            //if(s[i].Length>=s[i+1].Length)
            //{
            //   res =res+s[i];
            //    Console.Write(res);
            //}
            //foreach(var item in s)
            //{
            //    Console.Write(item);
            //}
            //for (int i = str.Length - 1; i >= 1; i--)
            //{
            //    if (max < s[i])
            //    {
            //        max = s[i];
            //        Console.Write(max);
            //    }
            //}
            // Console.Write();
            //string s = "sai kumar kanaka satya";
            //string[] s1 = s.Split(' ');
            Console.ReadLine();
        }
    }
}