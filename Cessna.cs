using System;

namespace garys_garage
{

    public class Cessna : Vehicle
    {  // Propellor light aircraft

        public double FuelCapacity { get; set; }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Cessna drives past. VROOOOOOM VROOOM! ");
        }
        public override void Stop()
        {
            Console.WriteLine($"The Cessna Crashes to the ground in a ball of fire");
        }
        public void RefuelTank() { Console.WriteLine("Fueling Up Bro!"); }
    }
}