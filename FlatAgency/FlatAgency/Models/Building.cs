using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace FlatAgency.Models
{
    [DataContract]
    public class Building
    {
        [DataMember]
        public string Adress { get; set; }
        [DataMember]
        public double Price { get; set; }

    }
}
