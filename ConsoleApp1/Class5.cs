using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Shape
    {
        public abstract void areas();
        public void showdata()
        {
            Console.WriteLine("Show function");
        }
    }

    class Circle : Shape
    {
        public override void areas()
        {
            int r;
            const double pi = 3.14;
            Console.WriteLine("Enter the radius of circle");
            r = Convert.ToInt32(Console.ReadLine());
            double area = pi * r * r;
            Console.WriteLine("Area of circle : " +area);
        }
    }

    class Rectangle : Shape
    {
        public override void areas()
        {
            Console.WriteLine("Enter the lenth and width");
            double l = Convert.ToInt32(Console.ReadLine());
            double w = Convert.ToInt32(Console.ReadLine());
            double a = l * w;
            Console.WriteLine("Area of rectangle : " + a);
        }
    }

    internal class Class5
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.showdata();
            circle.areas();
            Rectangle rectangle = new Rectangle();  
            rectangle.areas();
        }
    }
}
