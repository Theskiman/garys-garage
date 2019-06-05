using System;

namespace garys_garage
{
    public class Ram : Vehicle
    {  // Gas powered truck


        public double FuelCapacity { get; set; }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Ram drives past. VROOOOOOM VROOOM! ");
        }
        public void RefuelTank() { Console.WriteLine("Fueling Up Bro!"); }
    }
}