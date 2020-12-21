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
    class FlatCatalogManager
    {
        FlatCatalog FlatCatalog = new FlatCatalog();
        string path = @"..\..\Data\flats.json";
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(FlatCatalog));

        public void SaveData()
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                serializer.WriteObject(fs, FlatCatalog);
            }
        }

        public void LoadData()
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                FlatCatalog = (FlatCatalog)serializer.ReadObject(fs);
            }
        }

        public void AddFlat()
        {

        }

        public void DelFlat()
        {

        }

        public void EditFlat()
        {

        }

    }
}
