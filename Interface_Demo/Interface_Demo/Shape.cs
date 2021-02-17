using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Demo
{
    class Shape : _2Dimensional, _3Dimensional, _4Dimensional
    {
        public int MyProperty { get; set; }

        public double GetArea(double x, double y)
        {
            throw new NotImplementedException();
        }

        public double GetVolume(double x, double y, double z)
        {
            throw new NotImplementedException();
        }
    }
}
