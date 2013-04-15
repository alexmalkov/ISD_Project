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
    [Authorize(Users="admin")]
    public class CustomerController : Controller
    {
        private CIM_dbEntities db = new CIM_dbEntities();

        //
        // GET: /Customer/

        public ViewResult Index()
        {
            var customers = db.customers.Include("address").Include("address1").Include("contact_person").Include("contract");
            return View(customers.ToList());
        }

        //
        // GET: /Customer/Details/5

        public ViewResult Details(int id)
        {
            customer customer = db.customers.Single(c => c.customerId == id);
            return View(customer);
        }

        //
        // GET: /Customer/Create

        public ActionResult Create()
        {
            ViewBag.groupId = new SelectList(db.customer_group, "groupId", "name");
            ViewBag.postalAddressId = new SelectList(db.addresses, "addressId", "town");
            ViewBag.visitingAddressId = new SelectList(db.addresses, "addressId", "town");
            ViewBag.contactPersonId = new SelectList(db.contact_person, "personId", "fName");
            ViewBag.contractId = new SelectList(db.contracts, "contractId", "contractId");
            ViewBag.cred_code = new SelectList(db.payment_disorder, "creditabilityCode", "creditabilityCode");
            ViewBag.daysForPayment = new SelectList(db.term_of_payment, "numberOfDaysForPayment", "numberOfDaysForPayment");
            ViewBag.status = new SelectList(db.status, "statusText", "statusText");
            return View();
        } 

        //
        // POST: /Customer/Create

        [HttpPost]
        public ActionResult Create(customer customer)
        {
            if (ModelState.IsValid)
            {
                db.customers.AddObject(customer);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }
            ViewBag.groupId = new SelectList(db.customer_group, "groupId", "name", customer.groupId);
            ViewBag.postalAddressId = new SelectList(db.addresses, "addressId", "town", customer.postalAddressId);
            ViewBag.visitingAddressId = new SelectList(db.addresses, "addressId", "town", customer.visitingAddressId);
            ViewBag.contactPersonId = new SelectList(db.contact_person, "personId", "fName", customer.contactPersonId);
            ViewBag.contractId = new SelectList(db.contracts, "contractId", "contractId", customer.contractId);
            return View(customer);
        }
        
        //
        // GET: /Customer/Edit/5
 
        public ActionResult Edit(int id)
        {
            customer customer = db.customers.Single(c => c.customerId == id);
            ViewBag.postalAddressId = new SelectList(db.addresses, "addressId", "town", customer.postalAddressId);
            ViewBag.visitingAddressId = new SelectList(db.addresses, "addressId", "town", customer.visitingAddressId);
            ViewBag.contactPersonId = new SelectList(db.contact_person, "personId", "fName", customer.contactPersonId);
            ViewBag.contractId = new SelectList(db.contracts, "contractId", "contractId", customer.contractId);
            return View(customer);
        }

        //
        // POST: /Customer/Edit/5

        [HttpPost]
        public ActionResult Edit(customer customer)
        {
            if (ModelState.IsValid)
            {
                db.customers.Attach(customer);
                db.ObjectStateManager.ChangeObjectState(customer, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.postalAddressId = new SelectList(db.addresses, "addressId", "town", customer.postalAddressId);
            ViewBag.visitingAddressId = new SelectList(db.addresses, "addressId", "town", customer.visitingAddressId);
            ViewBag.contactPersonId = new SelectList(db.contact_person, "personId", "fName", customer.contactPersonId);
            ViewBag.contractId = new SelectList(db.contracts, "contractId", "contractId", customer.contractId);
            return View(customer);
        }

        //
        // GET: /Customer/Delete/5
 
        public ActionResult Delete(int id)
        {
            customer customer = db.customers.Single(c => c.customerId == id);
            return View(customer);
        }

        //
        // POST: /Customer/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            customer customer = db.customers.Single(c => c.customerId == id);
            db.customers.DeleteObject(customer);
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