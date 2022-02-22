using System;
using System.Collections.Generic;
using System.Linq;

namespace Oop
{
    class Program
    {
        static void Main(string[] args)
        {
            var Boing1 = new PassengerPlane(4, 132.23, 140);
            var Boing2 = new PassengerPlane(5, 186.32, 180);
            var Boing3 = new PassengerPlane(5, 152.23, 150);
            var War1 = new WarPlane(FlightCrew: 2, EnginePower: 45.3, WingSpace: 12.2, WeaponType: "Rockets", MaxLoad: 23.2);
            var War2 = new WarPlane(FlightCrew: 2, EnginePower: 35.3, WingSpace: 12.2, WeaponType: "Chemist", MaxLoad: 13.2);
            var Cargo1 = new CargoPlane(FlightCrew: 3, EnginePower: 25.3, MaxLoad: 55.4, CargoType: "Cars");
            var Cargo2 = new CargoPlane(FlightCrew: 3, EnginePower: 44.3, MaxLoad: 65.4, CargoType: "Insruments");
            var Cargo3 = new CargoPlane(FlightCrew: 3, EnginePower: 35.3, MaxLoad: 35.4, CargoType: "Books");
            var planes = new Plane[] { Boing1, Boing2, Boing3, War1, War2, Cargo1, Cargo2, Cargo3 };
            AirCompany company = new AirCompany(planes);
            UserInterface u1 = new UserInterface();
            u1.Greetings();
            var result = u1.InterConnect();
            u1.ShowResult(company, result);
        }
    }
}