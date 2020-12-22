using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlatAgency.UI
{
    class MainMenu
    {
        DialogController dc = new DialogController();
        MenuForClient Mfc = new MenuForClient();
        MenuForManager Mfm = new MenuForManager();

        string password = "QwertyPepega123";

        public void dispay()
        {
            Console.Clear();
            Console.WriteLine("\nWelcome to систему просмотра квартир 3000. Выберите нужный вам модуль\n");
            Console.WriteLine(" 1. Меню для клиента");
            Console.WriteLine(" 2. Меню для менеджера");
        }

        public void displayMenu()
        {
            do
            {
                dispay();
                Console.WriteLine("\nВыберите меню: ");
                int n = Int32.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Mfc.Display();
                        break;
                    case 2:
                        Console.WriteLine("Введите пароль:");
                        string buf = Console.ReadLine();
                        if (buf == password)
                            Mfm.Display();
                        else
                            Console.WriteLine("Неправильный пароль");
                        break;
                    default:
                        Console.WriteLine("Нет такого действия!");
                        break;
                }

            } while (dc.allowContinue());
        }
    }
}
