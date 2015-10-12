using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JohanVanRobays.Controllers
{
    public class CuratorController : Controller
    {
        // GET: Curator
        public ActionResult Index()
        {
            return View();
        }

        // GET: Artikel
        public ActionResult Artikel()
        {
            return View();
        }
    }
}
