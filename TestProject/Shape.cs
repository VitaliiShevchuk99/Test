using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestProject
{
    class Shape:IComparable
    {
        private double Side { get; set; }
        private double Area { get; set; }

        public int CompareTo(object obj)
        {
            Shape s = obj as Shape;
            return this.Area.CompareTo(s.Area);
        }
    }

    class Triangle: Shape
    {
        private double Area { get; set; }
        private double Base { get; set; }
        private double Heigth { get; set; }
        public Triangle(double bas, double heigth )
        {
            Base = bas;
            Heigth = heigth;
            Area = (Base * Heigth) / 2;
        }
    }
    class Rectangle : Shape
    {
        private double Area { get; set; }
        private double Width { get; set; }
        private double Heigth { get; set; }
        public Rectangle(double bas, double heigth)
        {
            Width = bas;
            Heigth = heigth;
            Area = Width * Heigth;
        }
    }
    class Square : Shape
    {
        private double Area { get; set; }
        private double Side { get; set; }
        public Square(double side)
        {
            Side = side;
            Area= Side * Side;
        }
    }
    class Circle : Shape
    {
        public const double pi = System.Math.PI;
        private double Area { get; set; }
        private double Radius { get; set; }
        public Circle(double radius)
        {
            Radius = radius;
            Area = pi * Radius * Radius;
        }
    }
}
