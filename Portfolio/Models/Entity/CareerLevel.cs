﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Portfolio.Models.Entity
{
    public class CareerLevel:BaseEntity
    {
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
    }
}