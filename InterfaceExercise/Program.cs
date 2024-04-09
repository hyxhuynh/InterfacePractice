using InterfaceExercise.Vehicles;
using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
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
