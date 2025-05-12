using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class6
    {
        public void calc()
        {
            Console.WriteLine("Calling the 1st calc function");
        }
        public void calc(string a)
        {
            Console.WriteLine("The value of a " + a);
        }
        public bool calc(int b)
        {
            if (b < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int calc(int a, int b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Class6 class6 = new Class6();
            class6.calc();

            Console.WriteLine("Enter the name : ");
            string s = Console.ReadLine();
            class6.calc(s);

            Console.WriteLine("Enter the number : ");
            int x= Convert.ToInt32(Console.ReadLine());
            bool c = class6.calc(x);
            Console.WriteLine(c);

            Console.WriteLine("Enter 2 numbers : ");
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());
            int sum = class6.calc(y,z);
            Console.WriteLine("Sum of 2 number : "+sum);
        }
    }
}
