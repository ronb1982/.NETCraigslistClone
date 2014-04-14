using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CraigslistClone.BLL.Interfaces;
using CraigslistClone.BLL.Models;

namespace CraigslistClone.ConsoleUI.Printers
{
    public class LocationDisplayer : IDisplayer
    {
        private readonly int _choice;
        private CraigslistManager manager = new CraigslistManager();

        public LocationDisplayer(int choice)
        {
            this._choice = choice;
        }

        public void ExecuteOperation()
        {
            switch (_choice)
            {
                case 3:
                    PrintAllStates();
                    break;
                case 4:
                    PrintCities();
                    break;
                case 5:
                    PrintSingleState();
                    break;
                case 6:
                    PrintAllCountries();
                    break;
            }
        }


        private void PrintAllStates()
        {
            Console.Clear();

            var states = manager.GetStates();

            if (states.Any())
            {
                foreach (var state in states)
                {
                    Console.WriteLine("{0} - {1}", state.StateName, state.StateAbbrev);
                }
            }
            else
            {
                Console.WriteLine("No state information found in database.");
            }

        }

        private void PrintSingleState()
        {
            Console.Clear();

            Console.Write("Enter state code: ");
            string stateCode = Console.ReadLine();

            var state = manager.GetStateBy(stateCode);

            Console.WriteLine("State: {0}", state.StateName);
        }

        private void PrintCities()
        {
            Console.Clear();

            Console.WriteLine("Enter state 2-letter code: ");
            string stateCode = Console.ReadLine();

            var cities = manager.GetCitiesFor(stateCode);

            if (cities.Any())
            {
                foreach (var c in cities)
                {
                    Console.WriteLine("\t{0}", c.CityName);
                }
            }
            else
            {
                Console.WriteLine("No matching cities found for that state.");
            }
        }

        private void PrintAllCountries()
        {

        }

    }
}
