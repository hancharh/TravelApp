using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using TravelApp.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace TravelApp.Controllers.Web.API
{
    [Route("api/[controller]/{tripName}")]
    public class StopsController : Controller
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
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
            //The Get method for this controller will return all stops for a given trip. Use a trip name as a parameter for selecting a trip. A new method will be needed in the TripRepository to perform the lookup.
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            //The other action for the StopsController to perform is to add a stop to a given trip. Modify the Post method to provide this feature, and make the necessary changes to the TripsRepository.
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
