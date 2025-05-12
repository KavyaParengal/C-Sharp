using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class4
    {
        static void Main(string[] args)
        {
            //int n=0;
            //do
            //{
            //    Console.WriteLine(n);
            //    n++;
            //}while (n<=10);

            //while (n <= 17)
            //{
            //    Console.WriteLine(n);
            //    n++;
            //}

            //for (int n = 0; n <= 100; n=n+5)
            //{
            //    Console.WriteLine(n);
            //}
            int even=0, odd=0;
            for (int n = 0; n < 10; n++)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                //sum += a;
                if (a%2==0)
                {
                   even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("Number of even : " +even);
            Console.WriteLine("Number of odd : " + odd);
        }
    }
}
