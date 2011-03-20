using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeAnalysisDemo.Controllers
{
    using DataAccess;

    public class CategoryController : Controller
    {
        private AdventureWorksEntities entities;

        public CategoryController()
        {
            entities = new AdventureWorksEntities();
        }

        public ActionResult Index()
        {
            var categories = from pc in entities.ProductCategories select pc;
            return View(categories);
        }

        public ActionResult Details(int id)
        {
            var productsInCategory = from p in entities.Products where p.ProductSubcategoryID == id select p;
            return View(productsInCategory);
        }
    }
}
