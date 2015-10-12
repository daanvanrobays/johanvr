using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JohanVanRobays.Controllers
{
    public class CarnavalController : Controller
    {
        // GET: Carnaval
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult FotosessieThuis()
        {
            return View();
        }
        public ActionResult Carnavalstoet()
        {
            return View();
        }
        public ActionResult Rusthuis()
        {
            return View();
        }
        public ActionResult Carnavalsbal()
        {
            return View();
        }
    }
}
