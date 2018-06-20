using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_FirstProject.Controllers
{
    public class PracticeController : Controller
    {
        // GET: Practice
        public ActionResult Index()
        {
            return View();
        }

        // testing different action result returns
        public ActionResult Content()
        {
            return Content("Returning a basic string content");
        }

        // page not found (404)
        public ActionResult Error404()
        {
            return HttpNotFound();
        }

        // return empty page for some reason
        public ActionResult Empty()
        {
            return new EmptyResult();
        }

        // redirect to action
        public ActionResult RedirectToAction()
        {
            return RedirectToAction("Customer", "Customer", new { page = 1, sortBy = "name" });
            // note the new {} part is added to the Query String, so youd get ?page=1&sortBy=name
            // its an anonymous object
        }
    }
}