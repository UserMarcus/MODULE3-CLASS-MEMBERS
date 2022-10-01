using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheCircle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radius;
            double PI = 3.142;
            double area, circumference;
            Console.Write("Enter the radius of the Circle = ");
            radius = double.Parse(Console.ReadLine());
            area = PI * radius * radius;
            circumference = 2 * PI * radius;
            Console.WriteLine("The area of the Circle is = " + circumference);
            Console.WriteLine("The circumference of the Circle is = " + area);
            Console.ReadKey();

        }
    }
}
