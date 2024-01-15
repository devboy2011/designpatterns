using BuilderPattern.CarParts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Car
    {
        public int NumberOfWheels { get; set; }

        public SeatBelt SeatBelt { get; set; }

        public string Color { get; set; }

        public WindScreen WindScreen { get; set; }

        public Engine Engine { get; set; }

        public Car( int numberOfWheels, 
                SeatBelt seatBelt,
                string color,
                WindScreen windScreen,
                Engine engine)
        {
            NumberOfWheels = numberOfWheels;
            SeatBelt = seatBelt;
            Color = color;
            WindScreen = windScreen;
            Engine = engine;
        }

        public override string ToString ()
        {
            var content = "";
            content += $"Number of wheels   : \t {NumberOfWheels}\n";
            content += $"Brand of Seatbelt  : \t {SeatBelt}\n";
            content += $"Color              : \t {Color}\n";
            content += $"Windscreen         : \t {WindScreen}\n";
            content += $"Engine             : \t {Engine}\n";
            return content;
        }
    }
}
