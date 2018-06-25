using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment3.Models;
using Assignment3.ViewModels;

namespace Assignment3.Controllers
{
    public class PhoneController : Controller
    {
        PhoneDbContextRepository repo = new PhoneDbContextRepository();
        
        // GET: Phone
        public ActionResult Index()
        {
            
            return View(repo.GetAllPhones());
        }

        public ActionResult Details(int id)
        {

            return View(repo.GetPhoneById(id));
        }

        public ActionResult AddPhone()
        {

            return View(repo.AddPhoneModel());
        }

        [HttpPost]
        public ActionResult AddPhoneConfirm(AddPhoneViewModel newPhone)
        {
            

            // Validate the model
            if (!ModelState.IsValid)
            {
             
                return View("AddPhone", repo.AddPhoneModel());

            }

            // if its valid
            Phone phone = new Phone
            {
                ID = newPhone.ID,
                PhoneName = newPhone.PhoneName,
                BrandId = newPhone.BrandId,
                PhoneTypeId = newPhone.PhoneTypeId,
                DateReleased = newPhone.DateReleased,
                ScreenSize = newPhone.ScreenSize
            };

            if (phone.ID == 0)
            {
                repo.AddNewPhone(phone);
            }
            
            else
            {
                repo.EditPhone(phone);
                
            }
            
            return RedirectToAction("Index", "Phone");          
        }
        public ActionResult Edit(int id)
        {
            // the method returns a view model
            var existingPhone = repo.GetPhoneById(id);

            if (existingPhone == null)
                return HttpNotFound();

            return View("EditPhone", repo.AddPhoneModel(existingPhone));
        }
        public ActionResult Delete(int id)
        {
            var existingPhone = repo.GetSimplePhoneById(id);

            if (existingPhone == null)
                return HttpNotFound();

            repo.DeletePhone(existingPhone);

            return RedirectToAction("Index", "Phone");
        }
    }
}