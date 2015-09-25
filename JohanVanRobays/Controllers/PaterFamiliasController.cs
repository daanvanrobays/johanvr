using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JohanVanRobays.Controllers
{
    public class PaterFamiliasController : Controller
    {
        // GET: PaterFamilias
        public ActionResult Index()
        {
            return View();
        }

        // GET: PaterFamilias/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PaterFamilias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PaterFamilias/Create
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

        // GET: PaterFamilias/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PaterFamilias/Edit/5
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

        // GET: PaterFamilias/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PaterFamilias/Delete/5
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
