using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.ServiceReturns1;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CountriesController : Controller
    {
        // GET: Countries
        public ActionResult Index()
        {
            Vidly.ServiceReturns1.Service1Client client = new Service1Client();
            IndexCountriesViewModel icvm = new IndexCountriesViewModel();
            icvm.Name = "Current List of Countries";


            try
            {
                icvm.Countries = client.GetCountries().ToList();
            }
            catch (Exception ex)
            {
            }

            return View(icvm);
        }
    }
}