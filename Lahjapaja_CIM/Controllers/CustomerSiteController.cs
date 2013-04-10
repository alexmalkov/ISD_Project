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
    public class CustomerSiteController : Controller
    {
        private CIM_dbEntities db = new CIM_dbEntities();

        //
        // GET: /CustomerSite/

        public ViewResult Index()
        {
            var customer_site = db.customer_site.Include("address").Include("address1").Include("contact_person").Include("contract").Include("customer").Include("term_of_delivery").Include("way_of_delivery");
            return View(customer_site.ToList());
        }

        //
        // GET: /CustomerSite/Details/5

        public ViewResult Details(int id)
        {
            customer_site customer_site = db.customer_site.Single(c => c.customerSiteId == id);
            return View(customer_site);
        }

        //
        // GET: /CustomerSite/Create

        public ActionResult Create()
        {
            ViewBag.deliveryAddressId = new SelectList(db.addresses, "addressId", "town");
            ViewBag.postalAddressId = new SelectList(db.addresses, "addressId", "town");
            ViewBag.contactPersonId = new SelectList(db.contact_person, "personId", "fName");
            ViewBag.contractId = new SelectList(db.contracts, "contractId", "contractId");
            ViewBag.customerId = new SelectList(db.customers, "customerId", "name");
            ViewBag.termOfDeliveryId = new SelectList(db.term_of_delivery, "termOfDeliveryId", "text");
            ViewBag.wayOfDeliveryId = new SelectList(db.way_of_delivery, "wayOfDeliveryId", "text");
            return View();
        } 

        //
        // POST: /CustomerSite/Create

        [HttpPost]
        public ActionResult Create(customer_site customer_site)
        {
            if (ModelState.IsValid)
            {
                db.customer_site.AddObject(customer_site);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.deliveryAddressId = new SelectList(db.addresses, "addressId", "town", customer_site.deliveryAddressId);
            ViewBag.postalAddressId = new SelectList(db.addresses, "addressId", "town", customer_site.postalAddressId);
            ViewBag.contactPersonId = new SelectList(db.contact_person, "personId", "fName", customer_site.contactPersonId);
            ViewBag.contractId = new SelectList(db.contracts, "contractId", "contractId", customer_site.contractId);
            ViewBag.customerId = new SelectList(db.customers, "customerId", "name", customer_site.customerId);
            ViewBag.termOfDeliveryId = new SelectList(db.term_of_delivery, "termOfDeliveryId", "text", customer_site.termOfDeliveryId);
            ViewBag.wayOfDeliveryId = new SelectList(db.way_of_delivery, "wayOfDeliveryId", "text", customer_site.wayOfDeliveryId);
            return View(customer_site);
        }
        
        //
        // GET: /CustomerSite/Edit/5
 
        public ActionResult Edit(int id)
        {
            customer_site customer_site = db.customer_site.Single(c => c.customerSiteId == id);
            ViewBag.deliveryAddressId = new SelectList(db.addresses, "addressId", "town", customer_site.deliveryAddressId);
            ViewBag.postalAddressId = new SelectList(db.addresses, "addressId", "town", customer_site.postalAddressId);
            ViewBag.contactPersonId = new SelectList(db.contact_person, "personId", "fName", customer_site.contactPersonId);
            ViewBag.contractId = new SelectList(db.contracts, "contractId", "contractId", customer_site.contractId);
            ViewBag.customerId = new SelectList(db.customers, "customerId", "name", customer_site.customerId);
            ViewBag.termOfDeliveryId = new SelectList(db.term_of_delivery, "termOfDeliveryId", "text", customer_site.termOfDeliveryId);
            ViewBag.wayOfDeliveryId = new SelectList(db.way_of_delivery, "wayOfDeliveryId", "text", customer_site.wayOfDeliveryId);
            return View(customer_site);
        }

        //
        // POST: /CustomerSite/Edit/5

        [HttpPost]
        public ActionResult Edit(customer_site customer_site)
        {
            if (ModelState.IsValid)
            {
                db.customer_site.Attach(customer_site);
                db.ObjectStateManager.ChangeObjectState(customer_site, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.deliveryAddressId = new SelectList(db.addresses, "addressId", "town", customer_site.deliveryAddressId);
            ViewBag.postalAddressId = new SelectList(db.addresses, "addressId", "town", customer_site.postalAddressId);
            ViewBag.contactPersonId = new SelectList(db.contact_person, "personId", "fName", customer_site.contactPersonId);
            ViewBag.contractId = new SelectList(db.contracts, "contractId", "contractId", customer_site.contractId);
            ViewBag.customerId = new SelectList(db.customers, "customerId", "name", customer_site.customerId);
            ViewBag.termOfDeliveryId = new SelectList(db.term_of_delivery, "termOfDeliveryId", "text", customer_site.termOfDeliveryId);
            ViewBag.wayOfDeliveryId = new SelectList(db.way_of_delivery, "wayOfDeliveryId", "text", customer_site.wayOfDeliveryId);
            return View(customer_site);
        }

        //
        // GET: /CustomerSite/Delete/5
 
        public ActionResult Delete(int id)
        {
            customer_site customer_site = db.customer_site.Single(c => c.customerSiteId == id);
            return View(customer_site);
        }

        //
        // POST: /CustomerSite/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            customer_site customer_site = db.customer_site.Single(c => c.customerSiteId == id);
            db.customer_site.DeleteObject(customer_site);
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