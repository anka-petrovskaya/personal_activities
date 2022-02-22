using System;
using System.Collections.Generic;
using System.Text;

namespace Oop
{
    public abstract class Plane
    {  
        public virtual string Model { get; set ; } 
        public virtual int FlightCrew { get; set; }
        public virtual bool IsTranscontinental { get; set; }
        public virtual double EnginePower { get; set; } 
        public Plane (int FlightCrew, double EnginePower, string Model, bool IsTranscontinental)
        {
            this.Model = Model;
            this.FlightCrew = FlightCrew;
            this.IsTranscontinental = IsTranscontinental;
            this.EnginePower = EnginePower;
        }
    }
}