﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace graniteStore.Models
{
 
    public class ProductTypes
    {
        public int id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}