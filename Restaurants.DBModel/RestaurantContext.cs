using Restaurants.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.DBModel
{
    public class RestaurantContext : DbContext 
    {
        public RestaurantContext()
            : base("name=RestaurantConnection")
        {
            //Database.SetInitializer(new SchoolDBInitializer());   //if you want to seed your database
        }
        
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Suburb> Suburbs { get; set; }
    }
}
