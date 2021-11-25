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

        public ActionResult OrderBy()
        {
            var zlecenia = from z in db.Zlecenia
                           orderby z.First_Name ascending
                           select z;
                           return View(zlecenia);
        }

        public ActionResult ListDone()
        {
            var zlecenia = from z in db.Zlecenia
                           where z.IsDone == true
                           select z;

            return View(zlecenia);
        }

        // GET: Zlecenie/Details/5
        public ActionResult Details(int? id)
        { if (id == null)
            { 
                return View("Error");
        }
        Zlecenie zlecenie = db.Zlecenia.Find(id);
            if(zlecenie == null)
                { return HttpNotFound(); }

            return View(zlecenie);
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
                if (ModelState.IsValid)
                {
                    db.Zlecenia.Add(zlecenie);
                    db.SaveChanges();

                    return RedirectToAction("Index");
                }
                return View(zlecenie);
            }
            catch
            {
                return View(zlecenie);
            }
        }

        // GET: Zlecenie/Edit/5
        public ActionResult Edit(int? id)
        {   if (id == null)
            { return View("Error"); }
            Zlecenie zlecenie = db.Zlecenia.Find(id);
            if (zlecenie == null)
                return HttpNotFound();
            return View(zlecenie);
        }

        // POST: Zlecenie/Edit/5
        [HttpPost]
        public ActionResult Edit(Zlecenie zlecenie)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    db.Entry(zlecenie).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(zlecenie);
            }
            catch
            {
                return View();
            }
        }

        // GET: Zlecenie/Delete/5
        public ActionResult Delete(int? id)
                 
        {    if (id == null)
                { return View("Error"); }
            Zlecenie zlecenie = db.Zlecenia.Find(id);
            if (zlecenie == null)
            {
                return HttpNotFound();
            }

            
                return View(zlecenie);
        }

        // POST: Zlecenie/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                Zlecenie zlecenie = db.Zlecenia.Find(id);
                db.Entry(zlecenie).State = System.Data.Entity.EntityState.Deleted;
                db.SaveChanges();
                return RedirectToAction("Index");
                
                
            }
            catch
            {
                return View();
            }
        }
    }
}
