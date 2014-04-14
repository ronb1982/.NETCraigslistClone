using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CraigslistClone.BLL.Interfaces;
using CraigslistClone.BLL.Models;

namespace CraigslistClone.ConsoleUI.Printers
{
    public class MenuDisplayer
    {
        internal void ShowMenu()
        {
            Console.WriteLine("Craigslist Console Manager");
            Console.WriteLine("========================================");
            Console.WriteLine();

            Console.WriteLine("How can I help you today?");
            Console.WriteLine();

            Console.WriteLine("1. Show all categories");
            Console.WriteLine("2. Show subcategories by category");
            Console.WriteLine("3. Show all states");
            Console.WriteLine("4. Show cities by state");
            Console.WriteLine("5. Show state by abbreviation");
            Console.WriteLine("6. Show all countries");
        }
    }
}
