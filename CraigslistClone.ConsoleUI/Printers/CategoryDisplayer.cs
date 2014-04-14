using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CraigslistClone.BLL.Interfaces;
using CraigslistClone.BLL.Models;

namespace CraigslistClone.ConsoleUI.Printers
{
    public class CategoryDisplayer : IDisplayer
    {
        private readonly int _choice;
        private CraigslistManager manager = new CraigslistManager();

        public CategoryDisplayer(int choice)
        {
            this._choice = choice;
        }

        public void ExecuteOperation()
        {
            switch (_choice)
            {
                case 1:
                    PrintAllCategories();
                    break;
                case 2:
                    PrintSubCategories();
                    break;
            }
        }

        private void PrintAllCategories()
        {
            Console.Clear();
            
            var categories = manager.GetCategories();

            foreach (var category in categories)
            {
                Console.WriteLine("Category {0}: {1}", category.CategoryId, category.CategoryName);
            }
        }

        private void PrintSubCategories()
        {
            Console.Clear();

            Console.Write("Please enter a category: ");
            string categoryString = Console.ReadLine();

            var subcategories = manager.GetSubcategoriesFor(categoryString);

            if (!subcategories.Any())
            {
                Console.WriteLine("No matching subcategories found.");
            }
            else
            {
                Console.WriteLine("{0}", categoryString);

                foreach (var sub in subcategories)
                {
                    Console.WriteLine("\t{0}", sub.SubCatName);
                }
            }
        }
    }
}
