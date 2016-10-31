using Restaurants.DBModel;
using Restaurants.DBModel.Repository;
using Restaurants.DBModel.Services;
using Restaurants.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Restaurants.UI.Controllers
{
    public class HomeController : Controller
    {
        Service _service;
        public HomeController(Service service)
        {
            _service = service;
        }
        public ActionResult Index()
        {
            var restaurants = _service.GetAll();
           
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}