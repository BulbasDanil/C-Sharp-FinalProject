using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatAgency.Models;

namespace FlatAgency.DataManagers
{
    class Flat : Building
    {
        public int Entrance { get; set; }
        public int Floor { get; set; }
        public int Rooms { get; set; }

        public override string ToString()
        {
            return $"Flat {Adress,10} {Entrance,10} - entrance {Floor,10} - floor {Rooms,10} - rooms {Price,10} - price (USD)";
        }
    }
}
