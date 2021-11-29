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
        public ActionResult Index(string sortOrder)
        {
            var zlecenia = from z in db.Zlecenia.ToList()
                           where z.IsDone == false
                           select z;
            switch (sortOrder)
            {
                case "FName":
                    zlecenia = zlecenia.OrderBy(z => z.First_Name);
                    break;
                case "LName":
                    zlecenia = zlecenia.OrderBy(z => z.Last_Name);
                    break;
                case "status":
                    zlecenia = zlecenia.OrderBy(z => z.Status);
                    break;
                default:
                    zlecenia = zlecenia.OrderBy(z => z.CaseDate);
                    break;
            }
            
        

            return View(zlecenia);
        }

        public ActionResult AllOrders(string sortOrder)
        {
            var zlecenia = from z in db.Zlecenia
                           select z;
            switch (sortOrder)
            {
                case "FName":
                    zlecenia = zlecenia.OrderBy(z => z.First_Name);
                    break;
                case "LName":
                    zlecenia = zlecenia.OrderBy(z => z.Last_Name);
                    break;
                case "status":
                    zlecenia = zlecenia.OrderBy(z => z.Status);
                    break;
                default:
                    zlecenia = zlecenia.OrderBy(z => z.CaseDate);
                    break;
            }
            return View(zlecenia);
        }

        public ActionResult ListDone(string sortOrder)
        {
            var zlecenia = from z in db.Zlecenia
                           where z.IsDone == true
                           select z;
            switch (sortOrder)
            {
                case "FName":
                    zlecenia = zlecenia.OrderBy(z => z.First_Name);
                    break;
                case "LName":
                    zlecenia = zlecenia.OrderBy(z => z.Last_Name);
                    break;
                case "status":
                    zlecenia = zlecenia.OrderBy(z => z.Status);
                    break;
                default:
                    zlecenia = zlecenia.OrderBy(z => z.CaseDate);
                    break;
            }

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
                    TempData["AlertMessage"] = "Prawidłowo dodano zlecenie...!";

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
                    TempData["AlertMessage"] = "Zapisano zmiany...!";
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
                TempData["AlertMessage"] = "Zlecenie usunięte...!";
                return RedirectToAction("Index");
                
                
            }
            catch
            {
                return View();
            }
        }
    }
}
