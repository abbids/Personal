using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.DBModel.Repository
{
    public class RestaurantRepository : IRestaurantRepository
    {
        IRestaurantRepository _repository;
        RestaurantContext _context;
        public RestaurantRepository(RestaurantContext context)
        {
            _context = context;
        }


        public List<Entities.Restaurant> GetAll()
        {
            return _context.Restaurants.ToList();
        }
    }
}
