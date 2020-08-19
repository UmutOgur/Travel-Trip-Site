using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelSite.Models.Siniflar;
namespace TravelSite.Controllers
{
    public class AboutController : Controller
    {

        Context c = new Context();
        // GET: About
        public ActionResult Index()
        {
            var degerler = c.hakkimizdas.ToList();
            return View(degerler);
        }
    }
}