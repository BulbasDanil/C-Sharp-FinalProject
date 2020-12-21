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
            Office buf = new Office();

            try
            {
                Console.WriteLine("Введите адрес офиса: ");
                buf.Adress = Console.ReadLine();

                Console.WriteLine("Введите цену офиса: ");
                buf.Price = Double.Parse(Console.ReadLine());

                Console.WriteLine("Введите номер входа офиса: ");
                buf.Entrance = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Введите этаж офиса: ");
                buf.Floor = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Введите площадь офиса: ");
                buf.Square = Int32.Parse(Console.ReadLine());

                OfficeCatalog.Offices.Add(buf);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void DelOffice()
        {
            try
            {
                OfficeCatalog.DisplayOffices();

                Console.WriteLine("\nВведите адрес для удаления:");
                string buf = Console.ReadLine();

                for(int i=0;i<OfficeCatalog.Offices.Count;i++)
                {
                    if(OfficeCatalog.Offices[i].Adress == buf)
                    {
                        OfficeCatalog.Offices.RemoveAt(i);
                    }
                    else
                    {
                        if (i == OfficeCatalog.Offices.Count - 1)
                            Console.WriteLine("Офис не найден");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void EditOffice()
        {
            try
            {
                // Какой обьект менять будем
                OfficeCatalog.DisplayOffices();
                Console.WriteLine("\nВведите адрес офиса для изменения:");
                string buf = Console.ReadLine();

                // Ищем ид офиса
                int id = 0;
                for (int i = 0; i < OfficeCatalog.Offices.Count; i++)
                {
                    if (OfficeCatalog.Offices[i].Adress == buf)
                    {
                       id = i;
                    }
                    else
                    {
                        if (i == OfficeCatalog.Offices.Count - 1)
                            Console.WriteLine("Офис не найден");
                    }
                }

                //Выбор параметров
                Console.WriteLine("\nВведите параметр для изменения: \n1 - адрес \n2 - цена \n3 - номер входа \n4 - этаж \n5 - площадь\n");
                int n = Int32.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.WriteLine("Введите новое значение: ");
                        OfficeCatalog.Offices[id].Adress = Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Введите новое значение: ");
                        OfficeCatalog.Offices[id].Price = Double.Parse(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Введите новое значение: ");
                        OfficeCatalog.Offices[id].Entrance = Int32.Parse(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Введите новое значение: ");
                        OfficeCatalog.Offices[id].Floor = Int32.Parse(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("Введите новое значение: ");
                        OfficeCatalog.Offices[id].Square = Int32.Parse(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Неправильный ввод");
                        break;
                }
            }
            catch (Exception e )
            {
                Console.WriteLine(e);
            }
        }

    }
}