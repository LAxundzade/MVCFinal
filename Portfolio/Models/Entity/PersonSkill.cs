using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Portfolio.Models.Entity
{
    public class PersonSkill:BaseEntity
    {
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
        public int SkillsId { get; set; }
        public virtual Skill Skills { get; set; }

        [Required]

        public bool IsSoft { get; set; }
        [Required]
        
        [StringLength(500)]
        public string Content { get; set; }
        [Required]
        
        [StringLength(500)]
        public string Percentage { get; set; }

    }
}