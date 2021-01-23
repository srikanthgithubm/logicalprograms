using System;
namespace LogicalPrograms_Sai
{
    class a2b3count
    {
        static void Main(string[] args)
        {
            string s = "aabbb";
            bool[] b = new bool[s.Length];

            string s2 = "";
            string s3 = "";
            int count = 0;

            for (int i = 0; i < s.Length; i++)
            {
                s2 = "" + s[i];
                count = 0;
                for (int j=i;j<s.Length; j++)
                {
                    if (s[i] == s[j] && b[j] == false)
                    {
                        b[j] = true;
                        count++;
                    }
                }
                if(count>0)
                {
                    s3 = s3 + s2 + count;
                    s2 = "";
                }
            }

            Console.WriteLine(s);
            Console.WriteLine(s3);

            Console.ReadLine();
        }
        
    }
}
