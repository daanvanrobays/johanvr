using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JohanVanRobays.Controllers
{
    public class AndreasController : Controller
    {
        // GET: Andreas
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Samenvatting()
        {
            return View();
        }
        public ActionResult OntstaansGeschiedenis()
        {
            return View();
        }
    }
}
