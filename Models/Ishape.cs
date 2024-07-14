﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject.Models
{
    internal interface Ishape
    {
        double getArea();
    }
    class Circle : Ishape
    {
        private double _radius;
        public Circle(double radius)
        {
            _radius = radius;
        }
        public double getArea() {
        return Math.PI * _radius * _radius;
        }
    }
    class Rectangle : Ishape {
        double _height;
        double _width;
        public Rectangle(double length, double width) {
            _height = length;
            _width = width;
        }
        public double getArea() { return _width * _height; }

    }
}
