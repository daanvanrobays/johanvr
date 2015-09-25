using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JohanVanRobays.Controllers
{
    public class ConstructionController : Controller
    {
        // GET: Construction
        public ActionResult FourOhFour()
        {
            return View();
        }

        // GET: Construction/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Construction/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Construction/Create
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

        // GET: Construction/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Construction/Edit/5
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

        // GET: Construction/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Construction/Delete/5
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
