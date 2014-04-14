using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CraigslistClone.BLL.Interfaces;
using CraigslistClone.DAL;
using CraigslistClone.DAL.Interfaces;
using CraigslistClone.DAL.Repositories;
using AutoMapper;

namespace CraigslistClone.BLL.Models
{
    public class CraigslistManager : ICraigslistManager
    {
        private ICraigslistRepository _repository = new CraigslistRepository();
       
        public List<Category> GetCategories()
        {
            Mapper.CreateMap<DAL.Category, BLL.Models.Category>();

            var entities = _repository.GetAllCategories();

            var categories = Mapper.Map<List<BLL.Models.Category>>(entities);
            return categories;
        }

        public List<Subcategory> GetSubcategories()
        {
            var entities = _repository.GetAllSubcategories();

            var subcategories = Mapper.Map<List<BLL.Models.Subcategory>>(entities);
            return subcategories;
            //return _repository.GetAllSubcategories().Cast<BLL.Models.Subcategory>().ToList();
        }

        public List<Subcategory> GetSubcategoriesFor(string category)
        {
            return _repository.GetSubCategoriesByCat(category).Cast<BLL.Models.Subcategory>().ToList();
        }

        public List<Country> GetCountries()
        {
            Mapper.CreateMap<DAL.Country, BLL.Models.Country>();

            var entities = _repository.GetAllCountries();
            var countries = Mapper.Map<List<BLL.Models.Country>>(entities);

            return countries;
        }

        public List<State> GetStates()
        {
            Mapper.CreateMap<DAL.State, BLL.Models.State>();

            var entities = _repository.GetAllStates();
            var states = Mapper.Map<List<BLL.Models.State>>(entities);

            return states;
        }

        public List<City> GetCities()
        {
            Mapper.CreateMap<DAL.City, BLL.Models.City>();

            var entities = _repository.GetAllCities();
            var cities = Mapper.Map<List<BLL.Models.City>>(entities);

            return cities;
        }

        public List<City> GetCitiesFor(string stateAbbrev)
        {
            return _repository.GetCitiesByState(stateAbbrev).Cast<BLL.Models.City>().ToList();
        }

        public DAL.State GetStateBy(string stateCode)
        {
            var singleState = _repository.GetStateByCode(stateCode);
            return singleState;
        }

    }

}
