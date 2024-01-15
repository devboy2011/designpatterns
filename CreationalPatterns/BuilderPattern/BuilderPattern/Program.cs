using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.CarParts;

namespace BuilderPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var CarBuilder = new CarBuilder()
                .AddEngine(new Engine("BMW"))
                .AddWheels(4)
                .AddSeatBelt(new SeatBelt("Thai Cong"))
                .AddWindScreen(new WindScreen("ThaCo"))
                .Paint("red");
            var car = CarBuilder.Build();

            Console.WriteLine(car.ToString());
            Console.ReadLine();
        }
    }
}
