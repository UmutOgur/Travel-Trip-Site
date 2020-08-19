using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelSite.Models.Siniflar;

namespace TravelSite.Controllers
{
    public class BlogController : Controller
    {
        Context c = new Context();
        // GET: Blog
        public ActionResult Index()
        {
            var degerler = c.blogs.ToList();
            return View(degerler);
        }
        public ActionResult BlogDetay(int id)
        {
            var blogbul = c.blogs.Where(x => x.ID == id).ToList();
            return View(blogbul);
        }
    }
}