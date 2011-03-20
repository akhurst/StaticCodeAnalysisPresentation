using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CodeAnalysisDemo.Controllers
{
    using DataAccess;

    public class ProductController : Controller
    {

        //
        // GET: /Product/

        // [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Reliability", "CA2000:Dispose objects before losing scope")]
        public ActionResult Details(int id)
        {
            // using(var entities = new AdventureWorksEntities()) {
            var entities = new AdventureWorksEntities();
            var product = from p in entities.Products where p.ProductID == id select p;
            return View(product.SingleOrDefault());
            // }
        }
    }
}
