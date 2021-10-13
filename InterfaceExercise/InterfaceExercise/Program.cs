using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region TODOs

            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            // In each of your car, truck, and suv classes
            // TODO -  Create 2 members that are specific to each class
            // Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             
            // TODO - Set each class to inherit from both IVehicle and ICompany and implement their members.
             

            //TODO - create objects of your 3 classes and give their members values;

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            #endregion

            Truck myTruck = new Truck();
            myTruck.HasTrailer = true;
            myTruck.HasHeadLights = true;
            myTruck.IsCommercial = false;
            myTruck.HasHeadLights = true;
            myTruck.NumberOfWheels = 4;
            myTruck.GasMileage = 15;
            myTruck.Color = "blue";
            myTruck.Logo = "Ford Logo";
            myTruck.Slogan = "Built Ford Tough";


            // Object initializer syntax
            Car myCar = new Car()
            {
                HasOnly2Doors = true,
                HasTrunk = true,
                IsConvertible = true,
                NumberOfWheels = 4,
                HasHeadLights = true,
                HasTailLights = true,
                GasMileage = 25,
                Color = "silver",
                Logo = "BMW Logo",
                Slogan = "The Ultimate Driving Machine"
            };

            // Parameterized Constructor
            SUV mySUV = new SUV(true, true, 4, true, true, 15, "black", "Cadillac Logo", "Standard of the World");

            //Creatively display and organize their values
            List<IVehicle> vehicles = new List<IVehicle>();

            vehicles.Add(myTruck);
            vehicles.Add(mySUV);
            vehicles.Add(myCar);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"{vehicle.FuelMileage}");
            }
                        
        }
    }
}
