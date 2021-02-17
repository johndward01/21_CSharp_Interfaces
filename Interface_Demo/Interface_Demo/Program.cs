using System;
using System.Collections.Generic;

namespace Interface_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // An interface cannot be instantiated directly, but it can be instantiated by a class or struct that implements it

            // An interface can contain ONLY declarations of methods, properties, indexers, and events

            // All members of an interface must be public

            // A class CAN inherit from multiple interfaces

            // All members of an interface must be implemented

            
            Triangle triangle1 = new Triangle();
            Square square1 = new Square();
            Cube cube1 = new Cube();


            List<_2Dimensional> shapeList = new List<_2Dimensional>
            {
                square1,
                triangle1,
                cube1
            };

            _3Dimensional shape = new Shape();
            _3Dimensional tetrahedron = new Shape();
            _3Dimensional dodecahedron = new Shape();

            _2Dimensional triangle2 = new Triangle();
            _3Dimensional cube2 = new Cube();
            _4Dimensional hypercube1 = new Shape();
        }
    }
}
