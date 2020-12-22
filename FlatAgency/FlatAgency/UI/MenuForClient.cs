using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatAgency.UI;
using FlatAgency.DataManagers;
using FlatAgency.Exceptions;

namespace FlatAgency.UI
{
    class MenuForClient
    {
        DialogController dc = new DialogController();
        FlatCatalogManager fcm = new FlatCatalogManager();
        HouseCatalogManager hcm = new HouseCatalogManager();
        OfficeCatalogManager ocm = new OfficeCatalogManager();

        public void Display()
        {
            do
            {
                Console.Clear();
                Console.WriteLine("\nКлитентский модуль системы просмотра квартир 3000\n");
                dc.displayClient();
                Console.WriteLine("\nВыберите действие:");
                if (!Int32.TryParse(Console.ReadLine(), out int choice))
                    throw new InputException("Incorrect format", "Incorrect format");

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
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Неправильный ввод");
                        break;
                }
            } while (dc.allowContinue());
            Environment.Exit(0);
        }
    }
}
