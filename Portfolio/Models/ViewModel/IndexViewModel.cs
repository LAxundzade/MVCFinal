using Portfolio.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.Models.ViewModel
{
    public class IndexViewModel
    {
        public Person Person { get; set; }
        public List<PersonSkill> PersonSkill { get; set; }
        public List<ProfessionalExperience> Experience { get; set; }
        public List<EducationHistory> History { get; set; }
    }
}