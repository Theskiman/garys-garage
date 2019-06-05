using System;

namespace garys_garage
{
    public class Zero : Vehicle
    {  // Electric motorcycle

        public double BatteryKWh { get; set; }

        public override void Drive(){
            Console.WriteLine($"The {MainColor} Zero drives past. VROOOOOOM VROOOM! ");
        }
        public override void Turn(string direction){
            Console.WriteLine($"The Zero leans to the {direction} with the biker");
        }
        public void ChargeBattery() { Console.WriteLine("Bzzzz Chargin"); }
    }
}