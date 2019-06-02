using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Portfolio.Models.Entity
{
    public class Contact:BaseEntity
    {
        [Required]
        
        [StringLength(70)]
        public string Name { get; set; }
        

        [StringLength(70)]
        public string Subject { get; set; }
        [EmailAddress]
        [Required]
        [StringLength(300)]
        public string Email { get; set; }
        [Required]
        [StringLength(300)]
        
        public string Message { get; set; }
        [ScaffoldColumn(false)]
        public bool IsReady { get; set; }

        [ScaffoldColumn(false)]
        public DateTime? Answered { get; set; }
        
        public string AnsweredMessage { get; set; }
    }
}