using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelSite.Models.Siniflar;

namespace TravelSite.Controllers
{
    public class AnaMenuController : Controller
    {
        Context c = new Context();
        // GET: AnaMenu
        public ActionResult Index()
        {
            var degerler = c.blogs.Take(4).ToList();
            return View(degerler);
        }
        public PartialViewResult Partial1()
        {
            var degerler = c.blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial2()
        {
            var degerler = c.blogs.Where(x => x.ID == 1).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial3()
        {
            var degerler = c.blogs.Take(10).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial4()
        {
            var degerler = c.blogs.Take(3).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult Partial5()
        {
            var degerler = c.blogs.OrderByDescending(x => x.ID).Take(3).ToList();
            return PartialView(degerler);
        }
        [HttpGet]
        public ActionResult İletisim()
        {

            return View();
        }


        [HttpPost]
        public ActionResult İletisim(Iletisim i)
        {
            c.iletisims.Add(i);
            c.SaveChanges();
            return View();
        }
    }
}