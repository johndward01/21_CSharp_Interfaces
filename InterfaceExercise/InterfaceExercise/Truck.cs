using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle
    {
        public bool HasTrailer { get; set; }
        public bool IsCommercial { get; set; }

        public int NumberOfWheels { get; set; }
        public bool HasHeadLights { get; set; }
        public bool HasTailLights { get; set; }
        public int GasMileage { get; set; }
        public string Color { get; set; }

        public string Logo { get; set; }
        public string Slogan { get; set; }
        public int FuelMileage { get; set; }
        public string MissionStatement { get; set; }

        public void Drive()
        {
            Console.WriteLine("Truck is Driving"); 
        }
    }
}
