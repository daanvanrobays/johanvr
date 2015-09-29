using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JohanVanRobays.Controllers
{
    public class StamboomController : Controller
    {
        // GET: Stamboom
        public ActionResult Index()
        {
            return View();
        }

        // GET: Stamboom/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Stamboom/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Stamboom/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Stamboom/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Stamboom/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Stamboom/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Stamboom/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
