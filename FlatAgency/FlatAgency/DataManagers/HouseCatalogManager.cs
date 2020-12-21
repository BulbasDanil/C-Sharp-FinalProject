using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatAgency.Catalogs;
using System.Runtime.Serialization.Json;
using System.IO;

namespace FlatAgency.DataManagers
{
    class HouseCatalogManager
    {
        HouseCatalog HouseCatalog = new HouseCatalog();
        string path = @"..\..\Data\houses.json";
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(HouseCatalog));

        public void SaveData()
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                serializer.WriteObject(fs, HouseCatalog);
            }
        }

        public void LoadData()
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                HouseCatalog = (HouseCatalog)serializer.ReadObject(fs);
            }
        }

        public void AddHouse()
        {

        }

        public void DelHouse()
        {

        }

        public void EditHouse()
        {

        }

    }
}