using System;
using System.Collections.Generic;

namespace garys_garage{
    public interface IRefuel<T>
    {
        int Capacity { get; set; }

        void Refuel(List<T> vehicles);
            
        
    }
}