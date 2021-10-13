using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Demo
{
    public class Square : ISample, I2Dimensional, I3Dimensional
    {
        public double GetArea(double x, double y)
        {
            return x * x;
        }

        public double GetVolume(double x, double y, double z)
        {
            return x * y * z;
        }

        public void SampleMethod1()
        {
            Console.WriteLine("A different implementation...");
        }
    }
}
