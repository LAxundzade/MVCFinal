using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Portfolio.Models.Entity
{
    public class PortfolioCatagory:BaseEntity
    {
        [Required]
       
        [StringLength(100)]
        public string Name { get; set; }

        
    }
}