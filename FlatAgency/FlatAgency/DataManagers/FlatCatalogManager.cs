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
            Flat buf = new Flat();

            try
            {
                Console.WriteLine("Введите адрес квартиры: ");
                buf.Adress = Console.ReadLine();

                Console.WriteLine("Введите цену квартиры: ");
                buf.Price = Double.Parse(Console.ReadLine());

                Console.WriteLine("Введите номер входа квартиры: ");
                buf.Entrance = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Введите этажей квартиры: ");
                buf.Floor = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Введите площадь квартиры: ");
                buf.Rooms = Int32.Parse(Console.ReadLine());

                FlatCatalog.Flats.Add(buf);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void DelFlat()
        {
            try
            {
                FlatCatalog.DisplayFlats();

                Console.WriteLine("\nВведите адрес для удаления:");
                string buf = Console.ReadLine();

                for (int i = 0; i < FlatCatalog.Flats.Count; i++)
                {
                    if (FlatCatalog.Flats[i].Adress == buf)
                    {
                        FlatCatalog.Flats.RemoveAt(i);
                    }
                    else
                    {
                        if (i == FlatCatalog.Flats.Count - 1)
                            Console.WriteLine("Квартира не найдена");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void EditFlat()
        {
            try
            {
                // Какой обьект менять будем
                FlatCatalog.DisplayFlats();
                Console.WriteLine("\nВведите адрес квартиры для изменения:");
                string buf = Console.ReadLine();

                // Ищем ид офиса
                int id = 0;
                for (int i = 0; i < FlatCatalog.Flats.Count; i++)
                {
                    if (FlatCatalog.Flats[i].Adress == buf)
                    {
                        id = i;
                    }
                    else
                    {
                        if (i == FlatCatalog.Flats.Count - 1)
                            Console.WriteLine("Квартира не найдена");
                    }
                }

                //Выбор параметров
                Console.WriteLine("\nВведите параметр для изменения: \n1 - адрес \n2 - цена \n3 - номер входа \n4 - этаж \n5 - комнаты\n");
                int n = Int32.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.WriteLine("Введите новое значение: ");
                        FlatCatalog.Flats[id].Adress = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Введите новое значение: ");
                        FlatCatalog.Flats[id].Price = Double.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Введите новое значение: ");
                        FlatCatalog.Flats[id].Entrance = Int32.Parse(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Введите новое значение: ");
                        FlatCatalog.Flats[id].Floor = Int32.Parse(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("Введите новое значение: ");
                        FlatCatalog.Flats[id].Rooms = Int32.Parse(Console.ReadLine());
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
        }

    }
}
