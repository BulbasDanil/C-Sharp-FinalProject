using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatAgency.Models;
using System.Runtime.Serialization;

namespace FlatAgency.Models
{
    [DataContract]
    public class Flat :  Building
    {
        [DataMember]
        public int Entrance { get; set; }
        [DataMember]
        public int Floor { get; set; }
        [DataMember]
        public int Rooms { get; set; }

        public override string ToString()
        {
            return $"Flat {Adress,10} {Entrance,10} - entrance {Floor,10} - floor {Rooms,10} - rooms {Price,10} - price (USD)";
        }
    }
}
