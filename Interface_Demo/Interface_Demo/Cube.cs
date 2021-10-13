using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Demo
{
    class Cube : I2Dimensional, I3Dimensional
    {
        public double GetVolume(double length, double width, double height)
        {
            return Math.Pow(length, 3);
        }

        public double GetArea(double x, double y)
        {
            return x * x;
        }
    }
}
