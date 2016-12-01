using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JohanVanRobays.Controllers
{
    public class PatholoogController : Controller
    {
        // GET: Patholoog
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HumoArtikel()
        {
            return View();
        }
        public ActionResult Virtopsie()
        {
            return View();
        }
        public ActionResult ZolExit()
        {
            return View();
        }

    }
}
