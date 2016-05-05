using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using TravelApp.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860


namespace TravelApp.Controllers.Web.API
{
    [Route("api/[controller]")]
    public class TripsController : Controller
    {

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

        // GET: api/values
        [HttpGet]
        public JsonResult Get()
        {
            var results = Mapper.Map<IEnumerable<TripViewModel>>(getAllTrips);
            return getAllTrips();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            //Modify the Get(int id) method to look up and return a single 
            //Trip object.The TripsRepository class will need a GetTrip method 
            //to provide the lookup of the desired Trip.

            return "value";
        }

        // POST api/values
        [HttpPost]
        public JsonResult Post()
        {
            //Next we'll complete the Post method so that a new Trip can be added. Modify the parameter to be a TripViewModel and change the return type to JsonResult.
            //Think back or refer to earlier examples of Create methods in MVC for insights as to what this method needs to do.

            @ViewBag.Trip = new Trip()
            {

                UserName = “Aaaa”

            };

            var newTrip = Mapper.Map<Trip>(trip);

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
