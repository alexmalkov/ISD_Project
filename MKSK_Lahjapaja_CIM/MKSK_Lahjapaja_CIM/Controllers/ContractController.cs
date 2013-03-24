using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MKSK_Lahjapaja_CIM.Models;

namespace MKSK_Lahjapaja_CIM.Controllers
{ 
    public class ContractController : Controller
    {
        private CIM_dbEntities db = new CIM_dbEntities();

        //
        // GET: /Contract/

        public ViewResult Index()
        {
            var contracts = db.contracts.Include("payment_disorder").Include("term_of_delivery").Include("term_of_payment").Include("way_of_delivery");
            return View(contracts.ToList());
        }

        //
        // GET: /Contract/Details/5

        public ViewResult Details(int id)
        {
            contract contract = db.contracts.Single(c => c.contractId == id);
            return View(contract);
        }

        //
        // GET: /Contract/Create

        public ActionResult Create()
        {
            ViewBag.paymentDisorderId = new SelectList(db.payment_disorder, "paymentDisorderId", "creditabilityCode");
            ViewBag.termOfDeliveryId = new SelectList(db.term_of_delivery, "termOfDeliveryId", "text");
            ViewBag.termOfPaymentId = new SelectList(db.term_of_payment, "termOfPaymentId", "termOfPaymentId");
            ViewBag.wayOfDeliveryId = new SelectList(db.way_of_delivery, "wayOfDeliveryId", "text");
            return View();
        } 

        //
        // POST: /Contract/Create

        [HttpPost]
        public ActionResult Create(contract contract)
        {
            if (ModelState.IsValid)
            {
                db.contracts.AddObject(contract);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            ViewBag.paymentDisorderId = new SelectList(db.payment_disorder, "paymentDisorderId", "creditabilityCode", contract.paymentDisorderId);
            ViewBag.termOfDeliveryId = new SelectList(db.term_of_delivery, "termOfDeliveryId", "text", contract.termOfDeliveryId);
            ViewBag.termOfPaymentId = new SelectList(db.term_of_payment, "termOfPaymentId", "termOfPaymentId", contract.termOfPaymentId);
            ViewBag.wayOfDeliveryId = new SelectList(db.way_of_delivery, "wayOfDeliveryId", "text", contract.wayOfDeliveryId);
            return View(contract);
        }
        
        //
        // GET: /Contract/Edit/5
 
        public ActionResult Edit(int id)
        {
            contract contract = db.contracts.Single(c => c.contractId == id);
            ViewBag.paymentDisorderId = new SelectList(db.payment_disorder, "paymentDisorderId", "creditabilityCode", contract.paymentDisorderId);
            ViewBag.termOfDeliveryId = new SelectList(db.term_of_delivery, "termOfDeliveryId", "text", contract.termOfDeliveryId);
            ViewBag.termOfPaymentId = new SelectList(db.term_of_payment, "termOfPaymentId", "termOfPaymentId", contract.termOfPaymentId);
            ViewBag.wayOfDeliveryId = new SelectList(db.way_of_delivery, "wayOfDeliveryId", "text", contract.wayOfDeliveryId);
            return View(contract);
        }

        //
        // POST: /Contract/Edit/5

        [HttpPost]
        public ActionResult Edit(contract contract)
        {
            if (ModelState.IsValid)
            {
                db.contracts.Attach(contract);
                db.ObjectStateManager.ChangeObjectState(contract, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.paymentDisorderId = new SelectList(db.payment_disorder, "paymentDisorderId", "creditabilityCode", contract.paymentDisorderId);
            ViewBag.termOfDeliveryId = new SelectList(db.term_of_delivery, "termOfDeliveryId", "text", contract.termOfDeliveryId);
            ViewBag.termOfPaymentId = new SelectList(db.term_of_payment, "termOfPaymentId", "termOfPaymentId", contract.termOfPaymentId);
            ViewBag.wayOfDeliveryId = new SelectList(db.way_of_delivery, "wayOfDeliveryId", "text", contract.wayOfDeliveryId);
            return View(contract);
        }

        //
        // GET: /Contract/Delete/5
 
        public ActionResult Delete(int id)
        {
            contract contract = db.contracts.Single(c => c.contractId == id);
            return View(contract);
        }

        //
        // POST: /Contract/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            contract contract = db.contracts.Single(c => c.contractId == id);
            db.contracts.DeleteObject(contract);
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