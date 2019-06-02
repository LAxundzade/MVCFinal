using Portfolio.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.Models.ViewModel
{
    public class ResumeEditViewModel
    {
        public Person Person { get; set; }
        public List<Degree> Degrees { get; set; }
        public List<CareerLevel> Levels { get; set; }
        public List<PersonSkill> PersonSkill { get; set; }
        public List<ProfessionalExperience> Experience { get; set; }
        public List<EducationHistory> history { get; set; }
    }
}