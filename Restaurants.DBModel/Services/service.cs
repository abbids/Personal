using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.DBModel.Services
{
    public class Service
    {
        IRestaurantRepository _repo;
        public Service(IRestaurantRepository repo)
        {
            _repo = repo;
        }

        //public List<Restaurant> GetAll()
        //{
        //    //convert the entity to ViewModel
        //    //return _repo.GetAll();

            
        //}


    }
}
