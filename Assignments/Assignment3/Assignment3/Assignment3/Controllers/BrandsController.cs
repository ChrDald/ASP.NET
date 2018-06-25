using Assignment3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment3.Controllers
{
    public class BrandsController : Controller
    {
        PhoneDbContextRepository repo = new PhoneDbContextRepository();

        // GET: Brands
        public ActionResult Index()
        {
            return View(repo.GetAllBrands());
        }

        public ActionResult PhonesByBrand(int id)
        {
            return View(repo.GetPhonesByBrand(id));
        }
        
    }
}