using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.CarParts;

namespace BuilderPattern
{
    interface ICarBuilder
    {
        CarBuilder AddWheels(int numberOfWheels);
        CarBuilder AddSeatBelt(SeatBelt seatBelt);
        CarBuilder AddWindScreen(WindScreen windScreen);
        CarBuilder Paint(string color);
        CarBuilder AddEngine(Engine engine);

        Car Build();
    }
}
