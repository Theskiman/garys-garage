using System;

namespace garys_garage
{

    public class Vehicle
    {
        public string MainColor { get; set; }
        public int MaximumOccupancy { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine($"The {MainColor} Car drives past. VROOOOOOM VROOOM! ");
        }
        public virtual void Turn(string direction)
        {
            Console.WriteLine($"The vehicle carefully turns {direction}");
        }
        public virtual void Stop()
        {
            Console.WriteLine($"The vehicle slams to a stop to avoid the cops.");
        }
    }
}