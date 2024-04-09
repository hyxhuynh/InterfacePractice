using InterfaceExercise.Vehicles;
using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle:

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; }
             */


            //In ICompany: 

            /* Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; }
             */

            //In each of your Car, Truck, and SUV classes

            /* Create 2 members that are specific to each class
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.


            // List of vehicles
            List<IVehicle> vehicles = new List<IVehicle>();

            Truck truck1 = new Truck()
            {
                Year = 2024,
                Make = "Tesla",
                Model = "Cybertruck",
                TransmissionType = "single speed",
                Country = "the United States",
                Logo = "a letter T",
                NumberOfWheels = 4,
                IsPickUpTruck = true
            };
            vehicles.Add(truck1);

            // Second vehicle 
            Car car1 = new Car()
            {
                Year = 2025,
                Make = "Lamborghini",
                Model = "Revuelto",
                TransmissionType = "automated manual",
                Country = "Italy",
                Logo = "a golden bull",
                Color = "orange",
                NumberOfDoors = 2
            };
            vehicles.Add(car1);

            // Third vehicle
            SUV SUV1 = new SUV()
            {
                Year = 2020,
                Make = "Honda",
                Model = "CR-V",
                TransmissionType = "automatic",
                Country = "Japan",
                Logo = "a letter H in bold, sans-serif font",
                WheelEngagedSystem = "AWD",
                HasBikeRack = true
            };
            vehicles.Add(SUV1);

            // Display to the console
            foreach (var v in vehicles) 
            {
                v.DisplayDetails();
                v.DisplayUniqueDetails();
                Console.WriteLine("--------------------------");
            }
        }
    }
}
