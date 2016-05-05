using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using TravelApp.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TravelApp.Controllers.Web
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {

            TripsRepository db = new TripsRepository();

            @ViewBag.Trip = new Trip()
            {

                Name = “Sample Trip”,
                DateCreated = DateTime.Now

            };

            var trips = db.getAllTrips();

            return View();

        }

    }
}
