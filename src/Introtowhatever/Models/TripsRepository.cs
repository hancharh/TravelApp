using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelApp.Models
{
    public class TripsRepository
    {
        TripContext db = new TripContext();

        public IEnumerable<Trip> getAllTrips()
        {
            return db.Trips.OrderBy(t => t.Name).ToList();
        }

        public IEnumerable<Trip> addTrip()
        {
            //The TripRepository class will need a method to add a trip to the database.Write that method and call it in Post to save the new trip.Finally, convert the newTrip back to a TripViewModel and return it as Json so the client is provided with feedback of the result.
            //t = new Trip();

            return db.Trips.ToList();
        }

    }

}
