using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class DerivedClass1
    {
        protected string color = "Red";
        public char a= 'a';
    }
    class DerivedClass : DerivedClass1 {
        public string brand = "XYZ";
        public void show()
        {
            Console.WriteLine("Showing things");
        }

        static void Main(string[] args)
        {
            DerivedClass d = new DerivedClass();
            Console.WriteLine("Brand " + d.brand);
            d.show();
            Console.WriteLine("Color " + d.color);
            Console.WriteLine(d.a);
        }
    }
}

