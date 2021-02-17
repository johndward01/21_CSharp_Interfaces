using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age: ");
            var age = int.Parse(Console.ReadLine());

            var response = $"Hey John, you are {age} years old";
            Console.WriteLine(response);
            

            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //DONE ---Create 2 Interfaces called IVehicle & ICompany

            //DONE ---Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Truck myTruck = new Truck();
            //myTruck.HasTrailer = true;
            //myTruck.HasHeadLights = true;
            //myTruck.IsCommercial = false;
            //myTruck.HasHeadLights = true;
            //myTruck.NumberOfWheels = 4;
            //myTruck.GasMileage = 15;
            //myTruck.Color = "blue";
            //myTruck.Logo = "Ford Logo";
            //myTruck.Slogan = "Built Ford Tough";

          


            //// Object initializer syntax
            //Car myCar = new Car()
            //{
            //    HasOnly2Doors = true,
            //    HasTrunk = true,
            //    IsConvertible = true,
            //    NumberOfWheels = 4,
            //    HasHeadLights = true,
            //    HasTailLights = true,
            //    GasMileage = 25,
            //    Color = "silver",
            //    Logo = "BMW Logo",
            //    Slogan = "The Ultimate Driving Machine"
            //};

            //SUV myOtherSUV = new SUV();

            //SUV mySUV = new SUV(true, true, 4, true, true, 15, "black", "Cadillac Logo", "Standard of the World");

            ////Creatively display and organize their values



            ////We can use the Interface instead of the class as the List<T> (T = Type) as long as the classes conform to that interface
            ////List<IVehicle> vehicles = new List<IVehicle>();

            ////vehicles.Add(myTruck);
            ////vehicles.Add(mySUV);
            ////vehicles.Add(myCar);

            ////foreach (var vehicle in vehicles)
            ////{
            ////    Console.WriteLine($"{vehicle.GasMileage}");
            ////}

            ////Let's use the ICompany Interface as the List<T>

            //List<ICompany> company_Vehicles = new List<ICompany>();

            //company_Vehicles.Add(myTruck);
            //company_Vehicles.Add(myCar);
            //company_Vehicles.Add(mySUV);

            //foreach (ICompany vehicle in company_Vehicles)
            //{
            //    Console.WriteLine($"{vehicle.Logo}: ");
            //}







        }
    }
}
