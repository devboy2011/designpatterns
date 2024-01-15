using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BuilderPattern.CarParts;

namespace BuilderPattern
{
    class CarBuilder : ICarBuilder
    {
        public int NumberOfWheels { get; set; }

        public SeatBelt SeatBelt { get; set; }

        public string Color { get; set; }

        public WindScreen WindScreen { get; set; }

        public Engine Engine { get; set; }

        public CarBuilder AddEngine(Engine engine)
        {
            Engine = engine;
            return this;
        }

        public CarBuilder AddSeatBelt(SeatBelt seatBelt)
        {
            SeatBelt = seatBelt;
            return this;
        }

        public CarBuilder AddWheels(int numberOfWheels)
        {
            NumberOfWheels = numberOfWheels;
            return this;
        }

        public CarBuilder AddWindScreen(WindScreen windScreen)
        {
            WindScreen = windScreen;
            return this;
        }

        public CarBuilder Paint(string color)
        {
            Color = color;
            return this;
        }
        public Car Build()
        {
            return new Car(NumberOfWheels, SeatBelt, Color, WindScreen, Engine);
        }
    }
}
