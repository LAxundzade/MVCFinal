using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Portfolio.Models.Entity
{
    public class Person:BaseEntity
    {
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        public int Age { get; set; }
        [Required]
        [StringLength(200)]
        public string Location { get; set; }
        [Required]
        [StringLength(200)]
        public string ExperienceYears { get; set; }
        [Required]
        [StringLength(200)]
        public string Phone { get; set; }
        [Required]
        [StringLength(200)]
        public string FAX { get; set; }
        [Required]
        [EmailAddress]
        [StringLength(200)]
        public string EMail { get; set; }
        [Required]
        [StringLength(200)]
        public string Website { get; set; }

        public int DegreesId { get; set; }
        public virtual Degree Degrees { get; set; }
        public int LevelsId { get; set; }
        public virtual CareerLevel Levels { get; set; }
        [StringLength(200)]
        public string MediaUrl { get; set; }



    }
}