using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Tables.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            // Start with a base quote of $50 / month
            int quote = 50;
            
            if (ModelState.IsValid)
            {
                // If the user is 18 or under, add $100 to the monthly total
                if ((DateTime.Now.Year - table.DateOfBirth.Year) < 18)
                {
                    quote += 100;
                    table.Quote = quote;
                }
                // If the user is from 19 to 25, add $50 to the monthly total
                if ((DateTime.Now.Year - table.DateOfBirth.Year) > 18 && (DateTime.Now.Year - table.DateOfBirth.Year) <= 25)
                {
                    quote += 50;
                    table.Quote = quote;
                }
                // If the user is 26 or older, add $25 to the monthly total
                if ((DateTime.Now.Year - table.DateOfBirth.Year) >= 26)
                {
                    quote += 25;
                    table.Quote = quote;
                }
                // If the car's year is before 2000, add $25 to the monthly total
                if (table.CarYear < 2000)
                {
                    quote += 25;
                    table.Quote = quote;
                }
                // If the car's year is after 2015, add $25 to the monthly total
                if (table.CarYear > 2015)
                {
                    quote += 25;
                    table.Quote = quote;
                }
                // If the car's Make is a Porsche, add $25 to the price
                if (table.CarMake.ToLower() == "porsche")
                {
                    quote += 25;
                    table.Quote = quote;
                }
                // If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price. (Meaning, this specific car will add a total of $50 to the price.)
                if (table.CarMake.ToLower() == "porsche" && table.CarModel.ToLower() == "911 carrera")
                {
                    quote += 25;
                    table.Quote = quote;
                }
                // Add $10 to the monthly total for every speeding ticket the user has
                if (table.SpeedingTickets > 0)
                {
                    quote += table.SpeedingTickets * 10;
                    table.Quote = quote;
                }
                // If the user has ever had a DUI, add 25% to the total
                if (table.DUI)
                {
                    quote +=  (quote * 25) / 100;
                    table.Quote = quote;
                }
                // If it's full coverage, add 50% to the total
                if (table.CoverageType)
                {
                    quote += (quote * 50) / 100;
                    table.Quote = quote;
                }
                db.Tables.Add(table);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Table table)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table table = db.Tables.Find(id);
            if (table == null)
            {
                return HttpNotFound();
            }
            return View(table);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Table table = db.Tables.Find(id);
            db.Tables.Remove(table);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
