using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_FirstProject.Models;
using System.Data.Entity;

namespace MVC_FirstProject.Controllers
{
    public class CustomerController : Controller
    {

        // GET: Customer
        /*
        public ActionResult Index()
        {
            return View();
        }
        */

        // attribute routing below 
        // you can add everything you need in there, like range and maxlength
        // add question marks to make the attributes optional
        /*
        [Route("Customer/Index/{pageIndex(1,100)}/{sortby?}")]
        public ActionResult Index(int? pageIndex, string sortby)
        {
            // NOTE the int? means its an int BUT can be NULL
            // if you dont do that the page will required a pageIndex value, so the 2 Index() methods will conflict
            // nevermind it still conflicts
            return Content("Page Index is: " + pageIndex + " Sort By: " + sortby);

        }
        */

        public ActionResult Index()
        {
            return View(GetCustomers());
        }

        public ActionResult Customer()
        {
            Customer c = new Customer();
            c.ID = 101;
            c.Name = "Customer One";
            return View(c);
        }

        public ActionResult Edit(int id)
        {
            // NOTE the paramater HAS to be lowercase id BECAUSE you specified that in the route map (done by default)
            // you can change or add a route but thats the old way of doing things
            return Content("Provided customer ID: " + id);
        }

        public ActionResult Detail(int id)
        {
            int validID = 0;
            Customer customer = new Customer();

            foreach(Customer c in GetCustomers())
            {
                if (c.ID == id)
                {
                    validID = c.ID;
                    customer = c;
                }
            }

            if (validID != 0)
            {
                return View(customer);
            }
            else
            {
                return null;
            }
        }

        private List<Customer> GetCustomers()
        {
            var context = new ApplicationDbContext();

            return context.Customer.Include(c => c.MembershipType).ToList();

            /*
            var customers = new List<Customer>
            {
                new Customer { ID = 10, Name = "TestCust1"},
                new Customer { ID = 11, Name = "Staged Cust"}
            };
            return customers;
            */
        }
    }
}