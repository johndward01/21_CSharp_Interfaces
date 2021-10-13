using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        // Specific to the class
        public bool HasTrailer { get; set; }
        public bool IsCommercial { get; set; }

        // Specific to IVehicle
        public int NumberOfWheels { get; set; }
        public bool HasHeadLights { get; set; }
        public bool HasTailLights { get; set; }
        public int GasMileage { get; set; }
        public string Color { get; set; }

        // Specific to ICompany
        public string Logo { get; set; }
        public string Slogan { get; set; }
    }
}
