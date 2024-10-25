using DatabaseMy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB_ONE.Models
{
    public class ProductDetailViewModel
    {
        //public Tshirts Tshirt { get; set; }
        //public PoloShirt PoloShirt { get; set; }
        public List<Shirt> shirts { get; set; }
        public List<User> users { get; set; }
        public dynamic Product { get; set; }
        public int UserId { get; set; }
    }
}