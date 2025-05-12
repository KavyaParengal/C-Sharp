using System;
namespace ConsoleApp1
{
    internal class Class1
    {
        int a;
        int b;
        int c;
        public Class1()
        {
            Console.WriteLine("My Constructor");
            a = 10;
            b = 20;
        }
        public void add_num()
        {
            c = a + b;
            Console.WriteLine("Sum is = " + c);
        }
        static void Main(string[] args)
        {
            Class1 x = new Class1();
            x.add_num();
            Console.WriteLine("Hello World!");
        }
    }
}
