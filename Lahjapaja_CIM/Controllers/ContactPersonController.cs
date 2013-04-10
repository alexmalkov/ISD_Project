using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lahjapaja_CIM.Models;

namespace Lahjapaja_CIM.Controllers
{ 
    public class ContactPersonController : Controller
    {
        private CIM_dbEntities db = new CIM_dbEntities();

        //
        // GET: /ContactPerson/

        public ViewResult Index()
        {
            var contact_person = db.contact_person.Include("address");
            return View(contact_person.ToList());
        }

        //
        // GET: /ContactPerson/Details/5

        public ViewResult Details(int id)
        {
            contact_person contact_person = db.contact_person.Single(c => c.personId == id);
            return View(contact_person);
        }

        //
        // GET: /ContactPerson/Create

        public ActionResult Create()
        {
            ViewBag.addressId = new SelectList(db.addresses, "addressId", "town");
            return View();
        } 

        //
        // POST: /ContactPerson/Create

        [HttpPost]
        public ActionResult Create(contact_person contact_person)
        {
            if (ModelState.IsValid)
            {
                db.contact_person.AddObject(contact_person);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.addressId = new SelectList(db.addresses, "addressId", "town", contact_person.addressId);
            return View(contact_person);
        }
        
        //
        // GET: /ContactPerson/Edit/5
 
        public ActionResult Edit(int id)
        {
            contact_person contact_person = db.contact_person.Single(c => c.personId == id);
            ViewBag.addressId = new SelectList(db.addresses, "addressId", "town", contact_person.addressId);
            return View(contact_person);
        }

        //
        // POST: /ContactPerson/Edit/5

        [HttpPost]
        public ActionResult Edit(contact_person contact_person)
        {
            if (ModelState.IsValid)
            {
                db.contact_person.Attach(contact_person);
                db.ObjectStateManager.ChangeObjectState(contact_person, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.addressId = new SelectList(db.addresses, "addressId", "town", contact_person.addressId);
            return View(contact_person);
        }

        //
        // GET: /ContactPerson/Delete/5
 
        public ActionResult Delete(int id)
        {
            contact_person contact_person = db.contact_person.Single(c => c.personId == id);
            return View(contact_person);
        }

        //
        // POST: /ContactPerson/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            contact_person contact_person = db.contact_person.Single(c => c.personId == id);
            db.contact_person.DeleteObject(contact_person);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}