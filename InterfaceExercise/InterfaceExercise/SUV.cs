using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public bool HasCargoHold { get; set; }
        public bool HasTVScreens { get; set; }

        public int NumberOfWheels { get; set; }
        public bool HasHeadLights { get; set; }
        public bool HasTailLights { get; set; }
        public int GasMileage { get; set; }
        public string Color { get; set; }

        public string Logo { get; set; }
        public string Slogan { get; set; }

        public SUV()
        {

        }

        public SUV(bool hasCargohold, bool hasTvScreens, int numberOfWheels, bool hasHeadLights, bool hasTailLights,
                                      int gasMileage, string color, string logo, string slogan)
        {
            HasCargoHold = hasCargohold;
            HasTVScreens = hasTvScreens;
            NumberOfWheels = numberOfWheels;
            HasHeadLights = hasHeadLights;
            HasTailLights = hasTailLights;
            GasMileage = gasMileage;
            Color = color;
            Logo = logo;
            Slogan = slogan;
        }

        
    }
}
