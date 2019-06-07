using System;
using System.Collections.Generic;

namespace garys_garage{
    public class BatteryStation: Station, IRefuel<Vehicle>{
        public int Capacity { get; set; }
        public new void Refuel(List<Vehicle> cars){
            foreach(Vehicle car in cars){
                Console.WriteLine($"The {car.GetType().Name} is chargin up!");
            }
        }
    }
}