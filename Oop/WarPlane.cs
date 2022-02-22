using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    class WarPlane : Plane
    {
        public double WingSpace { get; set; }
        public string WeaponType { get; set; }
        public double MaxLoad { get; set; }
        public WarPlane(int FlightCrew, double EnginePower, double WingSpace, string WeaponType, double MaxLoad, string Model = "World", bool IsTranscontinental = false)
           : base (FlightCrew, EnginePower, Model, IsTranscontinental)
        {
            this.WingSpace = WingSpace;
            this.WeaponType = WeaponType;
            this.MaxLoad = MaxLoad;
        }
    }
}