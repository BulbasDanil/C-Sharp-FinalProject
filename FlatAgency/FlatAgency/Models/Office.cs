using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatAgency.Models;

namespace FlatAgency.DataManagers
{
    class Office : Building
    {
        public int Entrance { get; set; }
        public int Floor { get; set; }
        public int Square { get; set; }

        public override string ToString()
        {
            return $"Office {Adress,10} {Entrance,10} - entrance {Floor,10} - floor {Square,10} - square (M2) {Price,10} - price (USD)";
        }

    }
}
