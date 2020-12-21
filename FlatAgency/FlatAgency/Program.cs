using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlatAgency.UI;

// Система управления квартирным агентством

namespace FlatAgency
{
    class Program
    {
        
        static void Main(string[] args)
        {
            MenuForClient Mfc = new MenuForClient();
            MenuForManager Mfm = new MenuForManager();

            Mfm.Display();
        }
    }
}

//Пользовательские исключения

//Сохранение и удаление колизия

//Меню в класе програм
