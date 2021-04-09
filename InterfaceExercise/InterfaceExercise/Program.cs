using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO - Be sure to follow BEST PRACTICES when creating classes and interfaces

            // TODO - Create 2 Interfaces called IVehicle & ICompany

            // TODO - Create 3 classes called Car , Truck , & SUV

            // Inside of IVehicle
            // TODO -  Create 4 members that Car, Truck, & SUV all have in common.
            // Example: All vehicles have a number of wheels...

            // Inside of ICompany
            // TODO - Create 2 members that are specific to each every company regardless of vehicle type.
            // Example: public string Logo { get; set; }
             

            // In each of your car, truck, and suv classes
            // TODO -  Create 2 members that are specific to each class
            // Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             
            // TODO - Set each class to inherit from both IVehicle and ICompany and implement their members.
             

            //TODO - create objects of your 3 classes and give their members values;
            var myTruck = new Truck();
            myTruck.HasTrailer = true;
            myTruck.HasHeadLights = true;
            myTruck.IsCommercial = false;
            myTruck.HasHeadLights = true;
            myTruck.NumberOfWheels = 4;
            myTruck.GasMileage = 15;
            myTruck.Color = "blue";
            myTruck.Logo = "Ford Logo";
            myTruck.Slogan = "Built Ford Tough";
            myTruck.MissionStatement = "To make people's lives better by making mobility accessible and affordable.";


            //// Object initializer syntax
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
                Slogan = "The Ultimate Driving Machine",
                MissionStatement = "The BMW Group is the world's leading provider of premium products and premium services for individual mobility."
            };

            string cadillacMissionStatement = "Our mission is to earn our Customer’s loyalty by delivering sales and service experiences with high quality, excellent value, integrity and enthusiasm. We will function as a team, work ethically, and focus on meeting and striving to exceed the expectations of our Customers.";
            SUV mySUV = new SUV(true, true, 4, true, true, 15, "black", "Cadillac Logo", "Standard of the World", cadillacMissionStatement);

            // TODO - Creatively display and organize their values
            List<IVehicle> vehicles = new List<IVehicle>
            {
                myTruck,
                mySUV,
                myCar
            };
            
            foreach (var vehicle in vehicles)
            {
                UserInterface.PrintProperties(vehicle); // prints out the vehicle's type and all of the properties for each vehicle                
                Console.WriteLine();
                Console.WriteLine();
            }

        }
    }
}
