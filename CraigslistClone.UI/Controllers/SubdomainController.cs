using CraigslistClone.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CraigslistClone.UI.Controllers
{
    public class SubdomainController : Controller
    {

        private CraigslistVMBuilder _VMBuilder;

        //
        // GET: /cities/albany
        [Route("cities/{city}")]
        public ActionResult GetCityHomePage(int cityId, string city, string originalCityName)
        {
            var craigslistVM = new CraigslistViewModel();
            _VMBuilder = new CraigslistVMBuilder(new CraigslistManager());
            
            craigslistVM.Categories = _VMBuilder.FetchCategories();
            craigslistVM.Subcategories = _VMBuilder.FetchSubcategories();
         
            craigslistVM.States = _VMBuilder.FetchStates();
            craigslistVM.Countries = _VMBuilder.FetchCountries();
            craigslistVM.Cities = _VMBuilder.FetchCities();

            craigslistVM.City = (from c in craigslistVM.Cities
                                 where c.CityName == originalCityName
                                 select c).FirstOrDefault();

            craigslistVM.State = (from s in craigslistVM.States
                                  where s.StateId == craigslistVM.City.StateId
                                  select s).FirstOrDefault();

            return View(craigslistVM);
        }

        [Route("{category}")]
        public ActionResult GetCategoryForCity(int cityId, string city, string originalCityName)
        {
            return null;
        }

    }
}