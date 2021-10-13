using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Demo
{
    public class Shape : ISample, I2Dimensional, I3Dimensional, I4Dimensional
    {
        public void ASampleMethod()
        {
            Console.WriteLine("Implemented");
        }

        public double GetArea(double x, double y)
        {
            return x * y;
        }

        public double GetVolume(double x, double y, double z)
        {
            return x * y * z;
        }

        public void SampleMethod1()
        {
            Console.WriteLine("Running SampleMethod1()...");
        }
    }
}
