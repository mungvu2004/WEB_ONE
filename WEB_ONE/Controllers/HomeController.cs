using DatabaseIO;
using DatabaseMy;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WEB_ONE.Models;
namespace WEB_ONE.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Class1 db = new Class1();
            //Shirt u = db.GetShirt(1,"Basic T-shirt", "img/tshirt1.png", 200000, 0.10m, 180000, 1);
            //return View(u);

            //List<Shirt> list = db.GetShirts();
            //return View(list);
            List<Tshirt> list = db.GetTshirts();
            List<PoloShirt> Plist = db.GetPoloShirt();
            var ViewModel = new DataModel
            {
                Tshirts = list,
                PoloShirts = Plist
            };
            return View(ViewModel);
        }

        //public ActionResult Details(int id, string type)
        //{
        //    Class1 db = new Class1();
        //    var viewModel = new ProductDetailViewModel();

        //    // Dựa vào type để quyết định truy vấn từ bảng nào
        //    if (type == "Tshirt")
        //    {
        //        viewModel.Tshirt = db.GetTshirts().FirstOrDefault(p => p.id == id);
        //    }
        //    else if (type == "PoloShirt")
        //    {
        //        viewModel.PoloShirt = db.GetPoloShirt().FirstOrDefault(p => p.id == id);
        //    }
        //    // Thêm các loại sản phẩm khác nếu cần

        //    if (viewModel.Tshirt == null && viewModel.PoloShirt == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    return View(viewModel);
        //}
        public ActionResult Details(int id, string type)
        {
            Class1 db = new Class1();
            var viewModel = new ProductDetailViewModel();
            List<Shirt> shirts = db.GetShirts();
            List<User> users = db.GetUser();
            int userId = User.Identity.GetUserId<int>();

            viewModel.UserId = userId;
            if (type == "Tshirt")
            {
                viewModel.Product = db.GetAllTshirt().FirstOrDefault(p => p.id == id);
            }
            else if (type == "PoloShirt")
            {
                viewModel.Product = db.GetAllPoloShirt().FirstOrDefault(p => p.id == id);
            }
            else if(type == "Aokhoac")
            {
                viewModel.Product = db.GetAllAokhoac().FirstOrDefault(p => p.id == id);
            }
            else if (type == "Somi")
            {
                viewModel.Product = db.GetAllSomi().FirstOrDefault(p => p.id == id);
            }
            else if (type == "Hoodee")
            {
                viewModel.Product = db.GetAllHoodee().FirstOrDefault(p => p.id == id);
            }
            else if (type == "Quan")
            {
                viewModel.Product = db.GetAllQuan().FirstOrDefault(p => p.id == id);
            }
            else if (type == "Phukien")
            {
                viewModel.Product = db.GetAllPhukien().FirstOrDefault(p => p.id == id);
            }
            else
            {
                return HttpNotFound();
            }

            if (viewModel.Product == null)
            {
                return HttpNotFound();
            }

            return View(viewModel);
        }


        
    }
}