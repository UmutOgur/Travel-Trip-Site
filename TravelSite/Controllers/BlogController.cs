using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelSite.Models.Siniflar;
using PagedList;
using PagedList.Mvc;

namespace TravelSite.Controllers
{
    public class BlogController : Controller
    {
        Context c = new Context();
        BlogYorum by = new BlogYorum();
        // GET: Blog
        public ActionResult Index()
        {
            //  var degerler = c.blogs.ToList();
            by.Deger1 = c.blogs.ToList();
            by.Deger3 = c.blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return View(by);
        }

        public ActionResult BlogDetay(int id)
        {
            //  var blogbul = c.blogs.Where(x => x.ID == id).ToList();
            by.Deger1 = c.blogs.Where(x => x.ID == id).ToList();
            by.Deger2 = c.yorumlars.Where(x => x.blogId == id).ToList();
            return View(by);
        }
        [HttpGet]
        public PartialViewResult YorumYap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }
        
        [HttpPost]
        public PartialViewResult YorumYap(Yorumlar y)
        {
            c.yorumlars.Add(y);
            c.SaveChanges();
            return PartialView();
        }
    }
}