using System;
using System.Collections.Generic;

namespace TestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var side= 1.1234D;
            var radius = 1.1234D;
            var Base = 5D;
            var height = 2D;
            var shapes = new List<Shape>{ new Square(side),
                                          new Circle(radius),
                                          new Triangle(Base, height),
                                          new Rectangle(side,height)};

            shapes.Sort();
        }
    }
}
