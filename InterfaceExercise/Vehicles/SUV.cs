using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise.Vehicles
{
    public class SUV : IVehicle, ICompany
    {
        public string WheelEngagedSystem { get; set; }
        public bool HasBikeRack { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string TransmissionType { get; set; }
        public string Country { get; set; }
        public string Logo { get; set; }

        public void DisplayDetails()
        {
            Console.WriteLine($"{Make} {Model} {Year} is a SUV originated from {Country}. It has {TransmissionType} transmission/ engine. Its logo is {Logo}.");
        }
        public void DisplayUniqueDetails()
        {
            Console.WriteLine($"Other features: \nWheel system: {WheelEngagedSystem} \nBike rack attached: {HasBikeRack}");
        }
    }
}
