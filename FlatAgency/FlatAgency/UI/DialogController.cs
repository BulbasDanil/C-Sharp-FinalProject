using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatAgency.UI
{
    class DialogController
    {

        public bool allowContinue()
        {
            Console.WriteLine("\n> Продолжаем? (Да/Нет)");
            string ans = Console.ReadLine();
            if (ans == "Да" || ans == "да")
                return true;
            else
                return false;
        }

        public void displayClient()
        {
            Console.WriteLine(" 1. Просмотреть квартиры");
            Console.WriteLine(" 2. Просмотреть дома");
            Console.WriteLine(" 3. Просмотреть офисы");
            Console.WriteLine(" 4. Позвать консультанта для оформления заказа");
            Console.WriteLine(" 0. Выход");
        }

        public void displayManager()
        {
            Console.WriteLine(" 1. Просмотреть квартиры");
            Console.WriteLine(" 2. Просмотреть дома");
            Console.WriteLine(" 3. Просмотреть офисы");
            Console.WriteLine(" 4. Изменить квартиру");
            Console.WriteLine(" 5. Изменить дом");
            Console.WriteLine(" 6. Изменить офис");
            Console.WriteLine(" 7. Добавить квартиру");
            Console.WriteLine(" 8. Добавить дом");
            Console.WriteLine(" 9. Добавить офис");
            Console.WriteLine(" 10. Продать квартиру");
            Console.WriteLine(" 11. Продать дом");
            Console.WriteLine(" 12. Продать офис");
            Console.WriteLine(" 0. Выход");
        }
    }
}
