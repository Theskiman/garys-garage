using System;

namespace garys_garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Cessna flyBoy = new Cessna();
            flyBoy.FuelCapacity = 29.92;
            flyBoy.MainColor = "Purple";
            flyBoy.MaximumOccupancy = 670;

            Ram notFordTough = new Ram();
            notFordTough.FuelCapacity = 1.1;
            notFordTough.MainColor = "Magenta";
            notFordTough.MaximumOccupancy = 0;

            Tesla electricBoy = new Tesla();
            electricBoy.BatteryKWh = 32.23;
            electricBoy.MainColor = "Turquoise";
            electricBoy.MaximumOccupancy = 69;

            Zero wheelieBoy = new Zero();
            wheelieBoy.BatteryKWh = 100.32;
            wheelieBoy.MaximumOccupancy = 2;
            wheelieBoy.MainColor = "Aquamarine";

            flyBoy.Drive();
            flyBoy.Stop();
            flyBoy.Turn("right");
            Console.WriteLine("- - - - - - - - - - - - -");
            notFordTough.Drive();
            notFordTough.Turn("backwards");
            notFordTough.Stop();
            Console.WriteLine("- - - - - - - - - - - - -");
            electricBoy.Drive();
            electricBoy.Stop();
            electricBoy.Turn("up");
            Console.WriteLine("- - - - - - - - - - - - -");
            wheelieBoy.Drive();
            wheelieBoy.Turn("underground");
            wheelieBoy.Stop();
        }
    }
}
