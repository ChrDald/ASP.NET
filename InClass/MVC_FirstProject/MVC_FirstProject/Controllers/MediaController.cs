using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_FirstProject.Models;

namespace MVC_FirstProject.Controllers
{
    public class MediaController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        // GET: Media
        public ActionResult Index()
        {
            return View(GetMedia());
        }

        public IEnumerable<Media> GetMedia()
        {
            ApplicationDbContext context = new ApplicationDbContext();

            return context.Media.ToList();
        }

        public Media GetMediaByID(int id)
        {
            return (from m in context.Media where m.ID == id select m).SingleOrDefault();
        }

        
        public ActionResult Detail(int id)
        {
            Media media = GetMediaByID(id);

            if (media != null)
            {
                return View(media);
            }
            else
            {
                return null;
            }
        }
        

    }
}