using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern.CarParts
{
    class SeatBelt
    {
        public string Name;

        public SeatBelt(string name) {
            Name = name;
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
