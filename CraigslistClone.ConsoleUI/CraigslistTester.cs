using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CraigslistClone.ConsoleUI.Printers;
using CraigslistClone.BLL;
using CraigslistClone.BLL.Models;
using CraigslistClone.BLL.Interfaces;
using CraigslistClone.BLL.Factories;

namespace CraigslistClone
{
    public class CraigslistTester
    {
        static CraigslistManager manager = new CraigslistManager();

        static void Main(string[] args)
        {            
            var displayer = new MenuDisplayer();  
            displayer.ShowMenu();

            int choice = int.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                case 2:
                    new DisplayerFactory(new CategoryDisplayer(choice));
                    break;
                case 3:
                case 4:
                case 5:
                case 6:
                    new DisplayerFactory(new LocationDisplayer(choice));
                    break;
                default:
                    Console.WriteLine("Sorry, no matching option.");
                    break;
            }

            Console.ReadLine();
        }

        






    }
}
