using System;

namespace Exercies_4._1
{
    internal class Program
    {
        
        public abstract class GeometricObject
        {
            protected string color;
            protected double weight;

            protected GeometricObject()
            {
                color = "White";
                weight = 1.0;
            }

            protected GeometricObject(string color, double weight)
            {
                this.color = color;
                this.weight = weight;
            }

            public string Pcolor
            {
                get { return color;}
                set { color = value; }
            }

            public double Pweight
            {
                get { return weight; }
                set { weight = value; }
            }

            public abstract double findArea();
            public abstract double findPerimeter();
        }
        
        public class Circle : GeometricObject
        {
            private double radius;

            public Circle(double x)
            {
                this.radius = x;
            }

            public Circle(double x, string c, double w) : base(c, w)
            {
                this.radius = x;
            }

            public override string ToString()
            {
                return "Circle has: radius is " + radius + ", color is: " + Pcolor + " weight is: " + Pweight;
            }

            public override double findArea()
            {
                return Math.PI * radius * radius;
            }

            public override double findPerimeter()
            {
                return 2 * Math.PI * radius;
            }
        } 
            
        public static void Main(string[] args)
        {
            Circle circle = new Circle(2.45,"Blue",23);
            Console.WriteLine("Circle before change: "+circle.ToString());
            circle.Pcolor = "red";
            circle.Pweight = 2.56;
            Console.WriteLine("Circle after change: "+circle.ToString());
            Console.ReadLine();
        }
    }
}