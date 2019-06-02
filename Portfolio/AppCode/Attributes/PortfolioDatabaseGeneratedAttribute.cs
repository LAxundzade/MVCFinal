using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Portfolio.AppCode.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class PortfolioDatabaseGeneratedAttribute: DatabaseGeneratedAttribute
    {
        public string PortfolioDatabaseGeneratedValue { get; set; }
        public PortfolioDatabaseGeneratedAttribute(DatabaseGeneratedOption databaseGeneratedOption)
            : base(databaseGeneratedOption)
        {

        }
    }
}