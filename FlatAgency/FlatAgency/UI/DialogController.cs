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
            Console.WriteLine("\n> Continue? (Y/N)");
            string ans = Console.ReadLine();
            if (ans == "Y" || ans == "y")
                return true;
            else
                return false;
        }

        public void displayClient()
        {
            Console.WriteLine(" 1. See flats");
            Console.WriteLine(" 2. See houses");
            Console.WriteLine(" 3. See offices");
            Console.WriteLine(" 4. Help me");
            Console.WriteLine(" 0. Exit");
        }

        public void displayManager()
        {
            Console.WriteLine(" 1. See flats");
            Console.WriteLine(" 2. See houses");
            Console.WriteLine(" 3. See offices");
            Console.WriteLine(" \n 4. Edit flat");
            Console.WriteLine(" 5. Edit house");
            Console.WriteLine(" 6. Edit office");
            Console.WriteLine(" \n 7. Add flat");
            Console.WriteLine(" 8. Add house");
            Console.WriteLine(" 9. Add office");
            Console.WriteLine(" \n 10. Sell flat");
            Console.WriteLine(" 11. Sell hous");
            Console.WriteLine(" 12. Sell office");
            Console.WriteLine(" \n 0. Exit");
        }
    }
}
