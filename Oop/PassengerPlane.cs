using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    public class PassengerPlane : Plane
    {
        public int Passengers { get; set; }
        public PassengerPlane (int FlightCrew, double EnginePower, int Passengers, string Model = "Dream", bool IsTranscontinental = true) 
            : base(FlightCrew, EnginePower, Model, IsTranscontinental)
        {
            this.Passengers = Passengers;
        }
    }
}