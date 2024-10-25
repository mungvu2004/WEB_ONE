using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DatabaseMy;
using System.Data.Entity;

namespace DatabaseIO
{
    public class Class1
    {
        Model1 mydb = new Model1();

        //public Shirt GetShirt(int id, string name, string img, int price, decimal discount, int? final_price, int shirt_type_id)
        //{
        //    //return mydb.Database.SqlQuery<Shirt>(
        //    //    "SELECT * FROM Shirt WHERE id=@id AND name=@name AND img=@img AND price=@price AND discount=@discount AND final_price=@final_price AND shirt_type_id=@shirt_type_id",
        //    //    new SqlParameter("id", id),
        //    //    new SqlParameter("name", name),
        //    //    new SqlParameter("img", img),
        //    //    new SqlParameter("price", price),
        //    //    new SqlParameter("discount", discount),
        //    //    new SqlParameter("final_price", final_price),
        //    //    new SqlParameter("shirt_type_id", shirt_type_id)
        //    //).FirstOrDefault();


        //    return mydb.Shirts
        //        .Where(c => c.id == id &&
        //                    c.name == name &&
        //                    c.img == img &&
        //                    c.price == price &&
        //                    c.discount == discount &&
        //                    (final_price == null ? c.final_price == null : c.final_price == final_price) &&
        //                    c.shirt_type_id == shirt_type_id)
        //        .FirstOrDefault();
        //}

        //public List<Shirt> GetShirts()
        //{
        //    return mydb.Shirts.ToList();
        //}
        
        public List<Shirt> GetShirts()
        {
            return mydb.Shirts.ToList();
        }
        public List<Tshirt> GetAllTshirt()
        {
            return mydb.Tshirts.ToList();
        }

        public List<PoloShirt> GetAllPoloShirt()
        {
            return mydb.PoloShirts.ToList();
        }
        public List<Aokhoac> GetAllAokhoac()
        {
            return mydb.Aokhoacs.ToList();
        }
        public List<Quan> GetAllQuan()
        {
            return mydb.Quans.ToList();
        }
        public List<Hoodee> GetAllHoodee()
        {
            return mydb.Hoodees.ToList();
        }
        public List<Somi> GetAllSomi()
        {
            return mydb.Somis.ToList();
        }
        public List<Phukien> GetAllPhukien()
        {
            return mydb.Phukiens.ToList();
        }

        public List<User> GetUser()
        {
            return mydb.Users.ToList();
        }
        public List<Tshirt> GetTshirts()
        {
            return mydb.Tshirts.Take(4).ToList();
        }

        public List<PoloShirt> GetPoloShirt()
        {
            return mydb.PoloShirts.Take(4).ToList();
        }

    }

}
