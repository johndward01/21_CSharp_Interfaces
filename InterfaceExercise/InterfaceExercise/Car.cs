using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle
    {
        // Specific to the class
        public bool IsConvertible { get; set; }
        public bool HasTrunk { get; set; }
        public bool HasOnly2Doors { get; set; }

        // Specific to IVehicle 
        public int NumberOfWheels { get; set; }
        public bool HasHeadLights { get; set; }
        public bool HasTailLights { get; set; }
        public int GasMileage { get; set; }
        public string Color { get; set; }

        // Specific to ICompany
        public string Logo { get; set; }
        public string Slogan { get; set; }
        public int FuelMileage { get; set; }
        public string MissionStatement { get; set; }

        public void Drive()
        {
            Console.WriteLine("Car is Driving");
        }
    }
}
