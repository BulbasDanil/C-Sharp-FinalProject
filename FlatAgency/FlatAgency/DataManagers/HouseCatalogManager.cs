using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatAgency.Catalogs;
using FlatAgency.Models;
using System.Runtime.Serialization.Json;
using System.IO;

namespace FlatAgency.DataManagers
{
    class HouseCatalogManager
    {
        public HouseCatalog HouseCatalog = new HouseCatalog();
        string path = @"..\..\Data\houses.json";
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(HouseCatalog));

        public HouseCatalogManager()
        {
            LoadData();
        }

        public void SaveData()
        {
            using (FileStream fs = new FileStream(path, FileMode.Truncate, FileAccess.Write))
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
            House buf = new House();

            try
            {
                Console.WriteLine("Введите адрес дома: ");
                buf.Adress = Console.ReadLine();

                Console.WriteLine("Введите цену дома: ");
                buf.Price = Double.Parse(Console.ReadLine());

                Console.WriteLine("Введите количство этажей дома: ");
                buf.Floors = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Введите площадь дома: ");
                buf.Square = Int32.Parse(Console.ReadLine());

                HouseCatalog.Houses.Add(buf);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            SaveData();
        }

        public void DelHouse()
        {
            try
            {
                HouseCatalog.DisplayHouses();

                Console.WriteLine("\nВведите адрес для удаления:");
                string buf = Console.ReadLine();

                House toDel = HouseCatalog.Houses.Single(f => f.Adress == buf);
                HouseCatalog.Houses.Remove(toDel);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            SaveData();
        }

        public void EditHouse()
        {
            try
            {
                // Какой обьект менять будем
                HouseCatalog.DisplayHouses();
                Console.WriteLine("\nВведите адрес дома для изменения:");
                string buf = Console.ReadLine();

                // Ищем ид офиса
                int id = 0;
                for (int i = 0; i < HouseCatalog.Houses.Count; i++)
                {
                    if (HouseCatalog.Houses[i].Adress == buf)
                    {
                        id = i;
                    }
                    else
                    {
                        if (i == HouseCatalog.Houses.Count - 1)
                            Console.WriteLine("Дом не найден");
                    }
                }

                //Выбор параметров
                Console.WriteLine("\nВведите параметр для изменения: \n1 - адрес \n2 - цена \n3 - этажи \n4 - площадь\n");
                int n = Int32.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.WriteLine("Введите новое значение: ");
                        HouseCatalog.Houses[id].Adress = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Введите новое значение: ");
                        HouseCatalog.Houses[id].Price = Double.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Введите новое значение: ");
                        HouseCatalog.Houses[id].Floors = Int32.Parse(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Введите новое значение: ");
                        HouseCatalog.Houses[id].Square = Int32.Parse(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Неправильный ввод");
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            SaveData();
        }

    }
}