using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatAgency.UI;
using FlatAgency.DataManagers;


namespace FlatAgency.UI
{
    class MenuForManager
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
                Console.WriteLine("\nМенеджерский модуль системы просмотра квартир 3000\n");
                dc.displayManager();
                Console.WriteLine("\nВыберите действие:");
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
                        fcm.EditFlat();
                        break;
                    case 5:
                        hcm.EditHouse();
                        break;
                    case 6:
                        ocm.EditOffice();
                        break;
                    case 7:
                        fcm.AddFlat();
                        break;
                    case 8:
                        hcm.AddHouse();
                        break;
                    case 9:
                        ocm.AddOffice();
                        break;
                    case 10:
                        fcm.DelFlat();
                        break;
                    case 11:
                        hcm.DelHouse();
                        break;
                    case 12:
                        ocm.DelOffice();
                        break;
                    case 0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Неправильный ввод");
                        break;
                }

            } while (dc.allowContinue());
        }
    }
}
