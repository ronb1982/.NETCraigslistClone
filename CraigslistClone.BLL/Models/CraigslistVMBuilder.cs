using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CraigslistClone.BLL.Interfaces;

namespace CraigslistClone.BLL.Models
{
    public class CraigslistVMBuilder
    {
        private ICraigslistManager _manager;

        public CraigslistVMBuilder()
        {

        }

        public CraigslistVMBuilder(ICraigslistManager manager)
        {
            _manager = manager;
        }

        public List<State> FetchStates()
        {
            return _manager.GetStates();
        }

        public List<Country> FetchCountries()
        {
            return _manager.GetCountries();
        }

        public List<City> FetchCities()
        {
            return _manager.GetCities();
        }

        public List<Category> FetchCategories()
        {
            return _manager.GetCategories();
        }

        public List<Subcategory> FetchSubcategories()
        {
            return _manager.GetSubcategories();
        }

        public List<Subcategory> FetchSubcategoriesFor(Category category)
        {
            return _manager.GetSubcategoriesFor(category.CategoryName);
        }
    }
}
