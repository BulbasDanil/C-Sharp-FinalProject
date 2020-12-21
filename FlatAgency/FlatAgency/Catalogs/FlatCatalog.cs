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
    public class FlatCatalog
    {
        [DataMember]
        public List<Flat> Flats { get; set; } = new List<Flat>();

        public void DisplayFlats()
        {
            foreach (Flat f in Flats)
            {
                Console.WriteLine(f);
            }
        }

    }
}
