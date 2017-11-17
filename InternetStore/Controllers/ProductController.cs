using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InternetStore.Models;
using System.Net;

namespace InternetStore.Controllers
{
    public class ProductController : Controller
    {
        private StoreEntities db = new StoreEntities();

        // GET: Product
        public ActionResult Index()
        {
            var CategoryModel = db.Categories.ToList();
            return View(CategoryModel);
        }

        public ActionResult Browse(string category)
        {
            var CategoryItems = db.Items.Include("Category").Where(x => x.Category.Name == category).ToList();
            return View(CategoryItems);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Item ItemModel = db.Items.Find(id);

            if (ItemModel == null)
            {
                return HttpNotFound();
            }
            
            return View(ItemModel);
        }
    }
}