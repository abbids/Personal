using Restaurants.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.DBModel
{
    public interface IRestaurantRepository
    {
        List<Restaurant> GetAll();
    }
}
