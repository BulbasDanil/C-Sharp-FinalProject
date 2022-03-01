using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatAgency.Exceptions;

namespace FlatAgency.UI
{
    class MainMenu
    {
        DialogController dc = new DialogController();
        MenuForClient Mfc = new MenuForClient();
        MenuForManager Mfm = new MenuForManager();

        string password = "admin";

        public void dispay()
        {
            Console.Clear();
            Console.WriteLine("\nFlat agency manager. Select module\n");
            Console.WriteLine(" 1. Client menu");
            Console.WriteLine(" 2. Manager menu");
        }

        public void displayMenu()
        {
            do
            {
                dispay();
                Console.WriteLine("\nSelect menu: ");

                if (!Int32.TryParse(Console.ReadLine(), out int n)) 
                    throw new InputException("Incorrect format", "Incorrect format");

                switch (n)
                {
                    case 1:
                        Mfc.Display();
                        break;
                    case 2:
                        Console.WriteLine("Enter password (try for demo 'admin' ):");
                        string buf = Console.ReadLine();
                        if (buf == password)
                            Mfm.Display();
                        else
                            Console.WriteLine("Incorrect password, try 'admin'");
                        break;
                    default:
                        Console.WriteLine("There is no such action");
                        break;
                }

            } while (dc.allowContinue());
        }
    }
}
