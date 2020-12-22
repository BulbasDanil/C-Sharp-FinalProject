using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using FlatAgency.Models;

namespace FlatAgency.Catalogs
{
    [DataContract]
    public class HouseCatalog
    {
        [DataMember]
        public List<House> Houses { get; set; } = new List<House>();

        public void DisplayHouses()
        {
            foreach (House h in Houses)
            {
                Console.WriteLine(h);
            }
        }
    }
}