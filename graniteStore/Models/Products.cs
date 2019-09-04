using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace graniteStore.Models
{
    public class Products
    {

        public int id { get; set; }

        public string name { get; set; }

        public double price { get; set; }

        public bool avaliable { get; set; }

        public string image { get; set; }


        [Display(Name ="Product Type")]
        public int productTypeID { get; set; }

        [ForeignKey("productTypeID")]
        public virtual ProductTypes ProductTypes { get; set; }


    }
}
