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
    public class OfficeCatalog
    {
        [DataMember]
        public List<Office> Offices { get; set; } = new List<Office>();

        public void DisplayOffices()
        {
            foreach (Office o in Offices)
            {
                Console.WriteLine(o);
            }
        }
    }
}