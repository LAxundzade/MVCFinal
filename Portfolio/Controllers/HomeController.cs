using Portfolio.AppCode.Constant;

using Portfolio.Models;
using Portfolio.Models.Entity;
using Portfolio.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
       
        private PortfolioDbContext db = new PortfolioDbContext();
        // GET: Home 
        [Authorize]
        public ActionResult Index()
        {
            IndexViewModel index = new IndexViewModel {
                Person = db.Person.Where(a=>a.Id==1).FirstOrDefault(),
                PersonSkill = db.PersonSkills.Where(a => a.Id == 1).ToList(),
                Experience = db.Experiences.ToList(),
                History = db.EduHistory.ToList(),

            };
            return View(index);
        }
        public ActionResult Index1()
        {
            return View("Index");
        }
        public ActionResult Index2()
        {
            return View("Index");
        }
        public ActionResult Index3()
        {
            return View("Index");
        }
        public ActionResult AboutMe()
        {
            return View();
        }
        public ActionResult Blog()
        {
            return View();
        }
        public ActionResult blogSingle()
        {
            return View();
        }
        public ActionResult contact()
        {

            return View(new Contact());
        }
        [HttpPost, ActionName("Contact")]
        public ActionResult Contactx(Contact contact)
        {

            //SmtpClient smtp = new SmtpClient();
            //smtp.Host = GMailer.GmailHost;
            //smtp.Port = GMailer.GmailPort;
            //smtp.EnableSsl = GMailer.GmailSSL;
            //smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            //smtp.UseDefaultCredentials = false;
            //smtp.Credentials = new NetworkCredential("lamanaa@code.edu.az", "asdfghjkl1995");

            //using (var message = new MailMessage("lamanaa@code.edu.az", "jamlessperson99@code.edu.az"))
            //{
            //    message.Subject = contact.Subject;
            //    message.Body = contact.Email;
            //    message.IsBodyHtml = true;
            //    smtp.Send(message);
            //}
            
            contact.IsReady = false;
            if (ModelState.IsValid)
            {
                contact.Email.SendMail(contact.Subject, contact.Message);
                db.contacts.Add(contact);
                db.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(contact);
        }


        public ActionResult index04b9()
        {
            return View();
        }
        public ActionResult portfolio()
        {
            return View();
        }
        public ActionResult resume()
        {
            resumeViewModel resumeViewModel = new resumeViewModel
            {
                PersonSkill=db.PersonSkills.ToList(),
                Experience=db.Experiences.ToList(),
                history=db.EduHistory.ToList(),
            };
            return View(resumeViewModel);
        }
        public ActionResult resumeEditMode()
        {
            return View();
        }
        public ActionResult resumeEditProfessionalExperience()
        {
            return View();
        }
        [ChildActionOnly]
        public ActionResult AboutPerson()
        {
           var person= db.Person.Where(a => a.Name == "John Doe").FirstOrDefault();
            return View(person);
        }

       
        // GET: Account
        [AllowAnonymous]
        [HttpGet]

        public ActionResult LogIn()
        {
            return View();
        }
        [HttpPost]
        public ActionResult LogIn(string email, string password)
        {
            var user = db.User.Where(a => a.Email == email).FirstOrDefault();
            if (user != null)
            {
                if (Extension.getHashPassword(password) == user.Password)
                {
                    Session[SessionKey.SessionDate] = DateTime.Now;
                    Session[SessionKey.SessionUser] = user;
                    IndexViewModel index = new IndexViewModel
                    {
                        Person = db.Person.Where(a => a.Id == 1).FirstOrDefault(),
                        PersonSkill = db.PersonSkills.Where(a => a.Id == 1).ToList(),
                        Experience = db.Experiences.ToList(),
                        History = db.EduHistory.ToList(),

                    };

                    return View("Index",index);

                }


            }
            return View();
        }




    }
}