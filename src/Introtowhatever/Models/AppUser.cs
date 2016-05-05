using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;

namespace TravelApp.Models
{
    public class AppUser : IdentityDbContext<AppUser>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
