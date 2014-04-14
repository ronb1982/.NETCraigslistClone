using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CraigslistClone.BLL.Models;

namespace CraigslistClone.UI.Controllers
{
    public class HomeController : Controller
    {
        private CraigslistVMBuilder _VMBuilder;

        //
        // GET: /Home/
        public ActionResult Index()
        {
            var craigslistVM = new CraigslistViewModel();

            _VMBuilder = new CraigslistVMBuilder(new CraigslistManager());

            craigslistVM.States = _VMBuilder.FetchStates();      
            craigslistVM.Countries = _VMBuilder.FetchCountries();
            craigslistVM.Cities = _VMBuilder.FetchCities();
            craigslistVM.Country.BoxDivValue = 1;

            return View(craigslistVM);
        }

        
	}
}