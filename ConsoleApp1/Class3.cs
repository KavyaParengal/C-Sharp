using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Class3
    {
        public void checkEvenOdd()
        {
            Console.WriteLine("Enter the value : ");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a % 2 == 0)
            {
                Console.WriteLine(a + " is a even number");
            }
            else
            {
                Console.WriteLine(a + " is a odd number");
            }
        }
        static void Main(string[] args)
        {
            Class3 c = new Class3();
            c.checkEvenOdd();
        }
    }
}
