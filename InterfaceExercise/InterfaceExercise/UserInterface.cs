using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public static class UserInterface
    {
        public static void PrintProperties(IVehicle vehicle)
        {
            Console.WriteLine(PrintVehicleType(vehicle)); 
            Console.WriteLine($"Vehicle Color: {vehicle.Color}");
            Console.WriteLine($"Vehicle Fuel Mileage: {vehicle.FuelMileage}");
            Console.WriteLine($"Vehicle Has Head Lights: {vehicle.HasHeadLights}");
            Console.WriteLine($"Vehicle Has Tail Lights: {vehicle.HasTailLights}");
            Console.WriteLine($"Vehicle Logo: {vehicle.Logo}");
            Console.WriteLine($"Mission Statement: {vehicle.MissionStatement}");
            Console.WriteLine($"Number of Wheels: {vehicle.NumberOfWheels}");
            Console.WriteLine($"Slogan: {vehicle.Slogan}");
        }

        public static string PrintVehicleType(IVehicle vehicle)
        {
            if (vehicle is Truck)
            {
                return "Truck";
            }
            else if (vehicle is Car)
            {
                return "Car";
            }
            else
            {
                return "SUV";
            }
        }

    }
}
