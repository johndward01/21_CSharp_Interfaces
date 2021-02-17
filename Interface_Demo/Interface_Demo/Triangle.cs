using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Demo
{
    class Triangle : _2Dimensional
    {
        public bool Has3Sides { get; set; }
        
        public double GetVolume(double x, double y, double z)
        {
            throw new NotImplementedException();
        }

        public double GetArea(double @base, double height)
        {
            return .5 * @base * height;
        }
    }
}
