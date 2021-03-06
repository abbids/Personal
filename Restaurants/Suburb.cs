﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Entities
{
    public class Suburb
    {
        //[Key] //key is automatically generated with identity increment
        public int Id { get; set; }
        
        [Required]
        [MaxLength(50)]
        public string SuburbName { get; set; }
        
        [Required]
        [MaxLength(5)]
        public string PostCode { get; set; }
        
        public List<Restaurant> Restaurants { get; set; }
    }
}
