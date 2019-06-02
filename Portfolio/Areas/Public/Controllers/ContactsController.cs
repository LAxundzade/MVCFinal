using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Portfolio.Models;
using Portfolio.Models.Entity;

namespace Portfolio.Areas.Public.Controllers
{
    public class ContactsController : Controller
    {
        private PortfolioDbContext db = new PortfolioDbContext();

        // GET: Public/Contacts
        public ActionResult Index()
        {
            return View(db.contacts.Where(a=>a.DeletedDate==null).ToList());
        }

        // GET: Public/Contacts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = db.contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // GET: Public/Contacts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Public/Contacts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Subject,Email,Message,IsReady,Answered,AnsweredMessage,CreationDate,DeletedDate")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                db.contacts.Add(contact);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(contact);
        }

        // GET: Public/Contacts/Edit/5
        public ActionResult Answer(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = db.contacts.Find(id);
            
            if (contact == null)
            {
                return HttpNotFound();
            }
            contact.IsReady = true;
            db.SaveChanges();
            return View(contact);
        }

        // POST: Public/Contacts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Answer([Bind(Include = "Id,Name,Subject,Email,Message,IsReady,Answered,AnsweredMessage,CreationDate,DeletedDate")] Contact contact)
        {
            if (ModelState.IsValid)
            {
                contact.Email.SendMail(contact.Subject, contact.AnsweredMessage);
                contact.Answered = DateTime.Now;
                db.Entry(contact).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(contact);
        }

        // GET: Public/Contacts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Contact contact = db.contacts.Find(id);
            if (contact == null)
            {
                return HttpNotFound();
            }
            return View(contact);
        }

        // POST: Public/Contacts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Contact contact = db.contacts.Find(id);
            contact.DeletedDate = DateTime.Now;
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
