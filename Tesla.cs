using System;

namespace garys_garage
{
    public class Tesla : Vehicle
    {  // Electric car

        public double BatteryKWh { get; set; }
        public override void Drive()
        {
            Console.WriteLine($"The {MainColor} Tesla drives past. VROOOOOOM VROOOM! ");
        }
        public override void Stop(){
            Console.WriteLine($"The Tesla slows without a sound how silly.");
        }
        public void ChargeBattery() { Console.WriteLine("Bzzzz Chargin"); }
    }
}