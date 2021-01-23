using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms_Sai
{
    class AgeCalculator
    {
        interface i1
        {
            void Hyd();
        }
        interface i2
        {
            void Hyd();
        }
        class interview : i1, i2
        {
            public void Hyd()
            {
                Console.Write("i am hyderabad");
            }
            void i2.Hyd()
            {
                Console.Write("i am hyderabad");
            }

        }
        class Program
        {
            static void Main(string[] args)
            {

                //int result = 0;
                //int[] arr = { 10,20,30,50,60};
                //int[] brr = { 30,40,50,60,70};
                //int[] crr = new int[arr.Length + brr.Length];

                //for (int i = 0; i < arr.Length; i++)
                //{
                //    crr[i] = arr[i];
                //}

                //int c = 0;
                //for(int i=arr.Length;i<crr.Length;i++)
                //{
                //    crr[i] = brr[c];
                //    c++;
                //}
                //for(int i=0;i<crr.Length;i++)
                //{
                //    Console.Write(crr[i]+" ");
                //}
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                //string s = "SAThya123hj7u8";

                //int sum = 0;
                //for(int i=0;i<s.Length; i++)
                //{
                //    if(s[i] >= '0' && s[i] <='9')
                //    {
                //      string ss = "" + s[i];
                //        int n = Convert.ToInt32(ss);
                //        sum = sum + n;
                //    }
                //}
                //Console.WriteLine("sum = " + sum);


                Console.Write("Enter DOB (dd/mm/yyyy) : "); // 15/05/2015  
                string dob = Console.ReadLine();

                int dobday = int.Parse("" + dob[0] + dob[1]);
                int dobmonth = int.Parse("" + dob[3] + dob[4]);
                int dobyear = int.Parse("" + dob[6] + dob[7] + dob[8] + dob[9]);



                DateTime dt = DateTime.Now;
                string cdd1 = dt.Day.ToString();
                string cmm1 = dt.Month.ToString();
                string cyy1 = dt.Year.ToString();
                int cday = int.Parse(cdd1);
                int cmonth = int.Parse(cmm1);
                int cyear = int.Parse(cyy1);

                int day = 0, month = 0, year = 0;


                if (cday < dobday)
                {
                    cmonth = cmonth - 1;
                    cday = cday + 31;
                    day = cday - dobday;
                }
                else
                {
                    day = cday - dobday;
                }

                if (cmonth < dobmonth)
                {
                    cyear = cyear - 1;
                    cmonth = cmonth + 12;
                    month = cmonth - dobmonth;
                }

                else
                {
                    month = cmonth - dobmonth;
                }

                year = cyear - dobyear;

                Console.WriteLine(year + " years " + month + " months " + day + " days");
                Console.Write("Enter DOB (dd/mm/yyyy) : "); // 15/05/2015             string dob = Console.ReadLine(); 




                Console.ReadLine();
            }
        }
        }
}
