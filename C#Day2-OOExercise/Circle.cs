using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myappAug10
{
    class Circle
    {
        /// <summary>
        /// Circle is a class with property radius and methods setRadius(), getRadius(), calcDiameter(), calcArea().
        /// Use double precision for everything. Write appropriate driver program to test the methods.
        /// </summary>
        double radius;
        public string getRadius()
        {
            return $"Radius of the circle is {this.radius}";
        }
        public void setRadius(double r)
        {
            this.radius = r;
        }
        public string calcDiameter()
        {
            double d = 2 * this.radius;
            return $"Diameter={d}";
        }
        public string calcArea()
        {
            double area;
            area = Math.PI * this.radius * this.radius;
            return $"Area ={area}";
        }

    }
    class CircleTest
    {
        public static void Main()
        {
            Circle c = new Circle();
            Console.WriteLine("Enter the radius");
            double rad = double.Parse(Console.ReadLine());
            c.setRadius(rad);
            Console.WriteLine(c.getRadius());
            Console.WriteLine("Diameter=" + c.calcDiameter());
            Console.WriteLine("Radius=" + c.calcArea());
        }
    }
}
