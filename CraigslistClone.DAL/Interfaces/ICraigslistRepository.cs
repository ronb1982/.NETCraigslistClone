using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CraigslistClone.DAL.Interfaces
{
    public interface ICraigslistRepository
    {
        List<Category> GetAllCategories();
        List<Subcategory> GetAllSubcategories();
        List<Subcategory> GetSubCategoriesByCat(string category);
        List<State> GetAllStates();
        List<City> GetAllCities();
        List<City> GetCitiesByState(string stateAbbrev);
        State GetStateByCode(string stateAbbrev);
        List<Country> GetAllCountries();
    }
}
