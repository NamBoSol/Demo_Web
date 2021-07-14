using Demo_Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering; 

namespace Demo_Web.Controllers
{
    public class DefaultController : Controller
    {
        List<Product> products;
        List<Category> categories;
        public string Index()
        {
            return "Hello Nam Dep Trai";
        }

        public void InitData()
        {
            products = new List<Product>();
            products.Add(new Product(1, "Nam", 1));
            products.Add(new Product(2, "Lam", 2));
            products.Add(new Product(3, "Long", 2));

            categories = new List<Category>();
            categories.Add(new Category(1, "Ngoan"));
            categories.Add(new Category(1, "Ngu"));
        }
        public ActionResult List(int cat)
        {
            InitData();
            cat = (cat == 0) ? 1 : cat;
            var view = View("Views/list.cshtml");
            ViewBag.categories = new MultiSelectList(categories,"Id","Name");
            view.ViewData.Model = products.FindAll(x=>x.CatId==cat);
            return view;

        }
    }
}
