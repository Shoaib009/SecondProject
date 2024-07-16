using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject.Models
{
    internal interface IShape
    {
        double GetArea();
    }
    class Circle : IShape
    {
        private double _radius;
        public Circle(double radius)
        {
            _radius = radius;
        }
        public double GetArea() {
        return Math.PI * _radius * _radius;
        }
    }
    class Rectangle : IShape {
        double _height;
        double _width;
        public Rectangle(double length, double width) {
            _height = length;
            _width = width;
        }
        public double GetArea() { return _width * _height; }

    }
}
