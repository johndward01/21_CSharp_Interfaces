using System;
using System.Collections.Generic;

namespace Interface_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Triangle triangle1 = new Triangle();
            Square square1 = new Square();
            Cube cube1 = new Cube();


            var shapeList = new List<I2Dimensional>
            {
                square1,
                triangle1,
                cube1
            };
                        
            I3Dimensional shape = new Shape();
            I3Dimensional tetrahedron = new Triangle();
            I3Dimensional dodecahedron = new Square();

            I2Dimensional triangle2 = new Triangle();
            I3Dimensional cube2 = new Cube();
            I4Dimensional hypercube1 = new Shape();
        }
    }
}
