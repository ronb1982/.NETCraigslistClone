using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CraigslistClone.BLL.Models;

namespace CraigslistClone.BLL.Interfaces
{
    public interface ICraigslistManager
    {
        List<Category> GetCategories();
        List<Subcategory> GetSubcategories();
        List<Subcategory> GetSubcategoriesFor(string category);
        List<Country> GetCountries();
        List<State> GetStates();
        List<City> GetCities();
        List<City> GetCitiesFor(string stateAbbrev);
        DAL.State GetStateBy(string stateCode);
    }
}
