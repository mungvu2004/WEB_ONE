using DatabaseMy;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WEB_ONE.Models
{
    public class DataModel
    {
            public List<Tshirt> Tshirts { get; set; }
            public List<PoloShirt> PoloShirts { get; set; }
            public List<Aokhoac> Aokhoacs { get; set; }
        public List<Quan> Quans { get; set; }
        public List<Somi> Somis { get; set; }
        public List<Hoodee> Hoodees { get; set; }
        public List<Phukien> Phukiens { get; set; }

            //public List<Shirt> Shirt { get; set; }
    }

    public class CartItemViewModel
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public string ProductName { get; set; }
        public string ProductImage { get; set; }
        public decimal FinalPrice { get; set; }
    }


    public class RegisterViewModel
    {
        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [EmailAddress]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }


}