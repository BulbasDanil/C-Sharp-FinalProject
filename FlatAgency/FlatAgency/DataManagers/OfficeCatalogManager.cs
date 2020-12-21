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
    class OfficeCatalogManager
    {
        OfficeCatalog OfficeCatalog = new OfficeCatalog();
        string path = @"..\..\Data\offices.json";
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(OfficeCatalog));

        public void SaveData()
        {
            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write))
            {
                serializer.WriteObject(fs, OfficeCatalog);
            }
        }

        public void LoadData()
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                OfficeCatalog = (OfficeCatalog)serializer.ReadObject(fs);
            }
        }

        public void AddOffice()
        {

        }

        public void DelOffice()
        {

        }

        public void EditOffice()
        {

        }

    }
}