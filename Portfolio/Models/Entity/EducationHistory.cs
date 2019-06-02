using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Portfolio.Models.Entity
{
    public class EducationHistory:BaseEntity
    {
        [Required]
        [StringLength(200)]
        public string YearRange { get; set; }
        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Profession { get; set; }
        [Required]
        [StringLength(200)]
        public string Place { get; set; }
        [Required]
        [StringLength(500)]
        public string Content { get; set; }
    }
}