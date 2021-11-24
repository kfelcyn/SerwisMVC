using Serwis.Context;
using Serwis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Serwis.Controllers
{
    public class ZlecenieController : Controller
    {
        ZlecenieContext db = new ZlecenieContext();
        // GET: Zlecenie
        public ActionResult Index()
        {
            var zlecenia = db.Zlecenia.ToList(); 

            return View(zlecenia);
        }

        // GET: Zlecenie/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Zlecenie/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Zlecenie/Create
        [HttpPost]
        public ActionResult Create(Zlecenie zlecenie)
        {
            try
            {
                // TODO: Add insert logic here
                db.Zlecenia.Add(zlecenie);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View(zlecenie);
            }
        }

        // GET: Zlecenie/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Zlecenie/Edit/5
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

        // GET: Zlecenie/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Zlecenie/Delete/5
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
