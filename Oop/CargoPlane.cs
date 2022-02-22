using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    class CargoPlane : Plane
    {
        public double MaxLoad { get; set; }
        public string CargoType { get; set; }
        public CargoPlane(int FlightCrew, double EnginePower, double MaxLoad, string CargoType, string Model = "Busy", bool IsTranscontinental = true)
           : base(FlightCrew, EnginePower, Model, IsTranscontinental)
        {
            this.MaxLoad = MaxLoad;
            this.CargoType = CargoType;
        }
    }
}