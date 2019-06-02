using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Portfolio.Models.Entity
{
    public class Portfolioss:BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string MediaUrl { get; set; }
        [Required]
        [StringLength(100)]
        public string Tags { get; set; }

        public int PcategoryId { get; set; }
        public virtual PortfolioCatagory Pcategory { get; set; }

        [Required]
        [StringLength(100)]
        public string Link { get; set; }
    }
}