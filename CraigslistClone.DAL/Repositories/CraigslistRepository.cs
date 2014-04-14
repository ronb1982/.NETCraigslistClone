using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CraigslistClone.DAL.Interfaces;

namespace CraigslistClone.DAL.Repositories
{
    public class CraigslistRepository : ICraigslistRepository
    {

        // Data Access Layer Collections

        private List<Category> Categories { get; set; }
        private List<Subcategory> Subcategories { get; set; }
        private List<State> States { get; set; }
        private List<City> Cities { get; set; }
        private List<Country> Countries { get; set; }

        public List<Category> GetAllCategories()
        {
            using (var context = new CraigslistCloneEntities())
            {
                var categories = context.Categories;

                if (!categories.Any())
                {
                    throw new ApplicationException("No records exist.");
                }
                else
                {

                    Categories = new List<Category>();

                    foreach (var category in categories)
                    {
                        Categories.Add(category);
                    }

                    return Categories;
                }
            }
        }

        public List<Subcategory> GetAllSubcategories()
        {
            using (var context = new CraigslistCloneEntities())
            {
                var subcategories = from s in context.Subcategories
                                    join c in context.Categories on s.CategoryId equals c.CategoryId
                                    select s;

                Subcategories = new List<Subcategory>();

                if (subcategories.Any())
                {
                    foreach (var sub in subcategories)
                    {
                        Subcategories.Add(sub);
                    }
                }

                return Subcategories;

            }
        }
        
        public List<Subcategory> GetSubCategoriesByCat(string category)
        {
            using (var context = new CraigslistCloneEntities())
            {
                var subcategories = from s in context.Subcategories
                                    join c in context.Categories on s.CategoryId equals c.CategoryId
                                    where c.CategoryName == category
                                    select s;

                Subcategories = new List<Subcategory>();

                if (subcategories.Any())
                {
                    foreach (var sub in subcategories)
                    {
                        Subcategories.Add(sub);
                    }
                }

                return Subcategories;

            }

        }

        public List<State> GetAllStates()
        {
            using (var context = new CraigslistCloneEntities())
            {
                var states = context.States;

                States = new List<State>();

                if (states.Any())
                {
                    foreach (var state in states)
                    {
                        States.Add(state);
                    }
                }

                return States;
            }
        }

        public List<City> GetAllCities()
        {
            using (var context = new CraigslistCloneEntities())
            {
                var cities = context.Cities;

                Cities = new List<City>();

                foreach (var city in cities)
                {
                    Cities.Add(city);
                }
            }

            return Cities;
        }

        public List<City> GetCitiesByState(string stateAbbrev)
        {
            using (var context = new CraigslistCloneEntities())
            {
                var cities = from c in context.Cities
                             join s in context.States on c.StateId equals s.StateId
                             where s.StateAbbrev == stateAbbrev
                             select c;

                Cities = new List<City>();

                if (cities.Any())
                {
                    foreach (var city in cities)
                    {
                        Cities.Add(city);
                    }
                }

                return Cities;
            }
        }

        public State GetStateByCode(string stateAbbrev)
        {
            try
            {
                using (var context = new CraigslistCloneEntities())
                {
                    var singleState = context.States.First(s => s.StateAbbrev == stateAbbrev);
                    return singleState;
                }

            }
            catch (Exception e)
            {
                throw new ApplicationException(e.Message + " " + e.StackTrace);
            }

        }


        public List<Country> GetAllCountries()
        {
            using (var context = new CraigslistCloneEntities())
            {
                var countries = context.Countries;
                Countries = new List<Country>();

                if (countries.Any())
                {
                    foreach (var country in countries)
                    {
                        Countries.Add(country);
                    }
                }

                return Countries;
                
            }
        }
    }
}
