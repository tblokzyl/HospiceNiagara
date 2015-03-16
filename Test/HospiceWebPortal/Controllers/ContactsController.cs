﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using HospiceWebPortal.DAL;
using HospiceWebPortal.Models;
using PagedList;

namespace HospiceWebPortal.Controllers
{
    public class ContactsController : Controller
    {
        private HospiceWebPortalEntities db = new HospiceWebPortalEntities();

        // GET: Contacts
        public ActionResult Index(string sortOrder, string searchString)
        {
            ////Steph Change Start
            ViewBag.FNameSortParm = sortOrder == "FName" ? "fname_desc" : "FName";
            ////Steph Change End
            ViewBag.LNameSortParm = sortOrder == "LName" ? "lname_desc" : "LName";
            ////Steph Change Start
            ViewBag.PositionSortParm = sortOrder == "Position" ? "Position_desc" : "Position";
            ////Steph Change End
            var contacts = from s in db.Contacts
                           select s;
                if (!String.IsNullOrEmpty(searchString))
                {
                    contacts = contacts.Where(s => s.LastName.Contains(searchString)
                                           || s.FirstName.Contains(searchString) || s.Position.Contains(searchString));
                }
                switch (sortOrder)
                {
                    //Steph Changes Start
                    case "FName":
                        contacts = contacts.OrderBy(s => s.FirstName);
                        break;
                    case "fname_desc":
                        contacts = contacts.OrderByDescending(s => s.FirstName);
                        break;
                    case "LName":
                        contacts = contacts.OrderBy(s => s.LastName);
                        break;
                    case "lname_desc":
                        contacts = contacts.OrderByDescending(s => s.LastName);
                        break;
                    case "Position":
                        contacts = contacts.OrderBy(s => s.Position);
                        break;
                    case "Position_desc":
                        contacts = contacts.OrderByDescending(s => s.Position);
                        break;
                    //Steph Changes End
                    default:
                        contacts = contacts.OrderBy(s => s.FirstName);
                        break;
                }

            return View(contacts.ToList());
        }

        // GET: Contacts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = db.Contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // GET: Contacts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Contacts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,FirstName,LastName,Position,Phone,EXT")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Contacts.Add(contact);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contact);
        }

        // GET: Contacts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = db.Contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // POST: Contacts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,FirstName,LastName,Position,Phone,EXT")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contact).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contact);
        }

        // GET: Contacts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = db.Contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // POST: Contacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contact contact = db.Contacts.Find(id);
            db.Contacts.Remove(contact);
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
