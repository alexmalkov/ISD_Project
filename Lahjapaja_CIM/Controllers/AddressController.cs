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
    public class AddressController : Controller
    {
        private CIM_dbEntities db = new CIM_dbEntities();

        //
        // GET: /Address/

        public ViewResult Index()
        {
            return View(db.addresses.ToList());
        }

        //
        // GET: /Address/Details/5

        public ViewResult Details(int id)
        {
            address address = db.addresses.Single(a => a.addressId == id);
            return View(address);
        }

        //
        // GET: /Address/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Address/Create

        [HttpPost]
        public ActionResult Create(address address)
        {
            if (ModelState.IsValid)
            {
                db.addresses.AddObject(address);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(address);
        }
        
        //
        // GET: /Address/Edit/5
 
        public ActionResult Edit(int id)
        {
            address address = db.addresses.Single(a => a.addressId == id);
            return View(address);
        }

        //
        // POST: /Address/Edit/5

        [HttpPost]
        public ActionResult Edit(address address)
        {
            if (ModelState.IsValid)
            {
                db.addresses.Attach(address);
                db.ObjectStateManager.ChangeObjectState(address, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(address);
        }

        //
        // GET: /Address/Delete/5
 
        public ActionResult Delete(int id)
        {
            address address = db.addresses.Single(a => a.addressId == id);
            return View(address);
        }

        //
        // POST: /Address/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            address address = db.addresses.Single(a => a.addressId == id);
            db.addresses.DeleteObject(address);
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