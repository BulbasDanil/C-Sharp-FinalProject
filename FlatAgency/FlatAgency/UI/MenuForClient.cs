using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatAgency.UI;
using FlatAgency.DataManagers;

namespace FlatAgency.UI
{
    class MenuForClient
    {
        DialogController dc = new DialogController();
        FlatCatalogManager fcm = new FlatCatalogManager();
        HouseCatalogManager hcm = new HouseCatalogManager();
        OfficeCatalogManager ocm = new OfficeCatalogManager();

        int choice;

        public void Display()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Клитентский модуль системы просмотра квартир 3000");
                dc.displayClient();
                Console.WriteLine("Выберите действие:");
                try
                {
                    choice = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }

                switch (choice)
                {
                    case 1:
                        fcm.FlatCatalog.DisplayFlats();
                        break;
                    case 2:
                        hcm.HouseCatalog.DisplayHouses();
                        break;
                    case 3:
                        ocm.OfficeCatalog.DisplayOffices();
                        break;
                    case 4:
                        Console.WriteLine("На данный момент консультантов нет =(");
                        break;
                    default:
                        Console.WriteLine("Неправильный ввод");
                        break;
                }

            } while (dc.allowContinue());
        }
    }
}
