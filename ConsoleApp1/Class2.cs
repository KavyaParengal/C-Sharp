
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the values : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("Both are equal");
            }
            else
            {
                if (a > b)
                {
                    Console.WriteLine("a is greatest");
                }
                else {
                    Console.WriteLine("b is greatest");
                }
            }
            
        }
    }
}
