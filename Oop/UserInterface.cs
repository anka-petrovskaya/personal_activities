using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Oop
{
    public class UserInterface
    {
        public void Greetings() => Console.WriteLine("Hello Dear User!");
        public int InterConnect()
        {
            Console.WriteLine($"Input 1 to sort\nInput 2 to search by field\nInput 3 to get some common value");
            var option = Convert.ToInt32(Console.ReadLine());
            if (option == 1 || option == 2 || option == 3) return option;
            else
            {
                Console.Clear();
                Console.WriteLine("Incorrect Input");
                return InterConnect();
            }
        }
        public void ShowResult(AirCompany company, int option)
        {
            switch (option)
            {
                case 1:
                    var sorting = company.Planes.OrderBy(x => x.EnginePower);
                    foreach (var plane in sorting)
                        Console.WriteLine($"type is {plane.GetType().Name} - model is {plane.Model}");
                    break;
                case 2:
                    var search = company.Planes.Where(x => x.Model == "Dream");
                    foreach (var plane in search)
                    {
                        Console.WriteLine($"{plane.GetType().Name} - {plane.Model}");
                    }
                    break;
                case 3:
                    var summary = company.Planes.Average(x => x.FlightCrew);
                    Console.WriteLine(summary);
                    break;
                default:
                    Console.WriteLine("Please, make your choice");
                    break;
            }
        }
    }
}