using Portfolio.Models;
using Portfolio.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Areas.Public.Controllers
{
    public class ResumeController : Controller
    {
        private PortfolioDbContext db = new PortfolioDbContext();
        // GET: Public/Resume
        public ActionResult resumeEditMode()
        {
            ResumeEditViewModel model = new ResumeEditViewModel();
            model.Person = db.Person.FirstOrDefault();
            model.Degrees = db.Degrees.ToList();
            model.Levels = db.Levels.ToList();
            model.Experience = db.Experiences.ToList();
            model.history = db.EduHistory.ToList();

            return View(model);
        }

    }
}