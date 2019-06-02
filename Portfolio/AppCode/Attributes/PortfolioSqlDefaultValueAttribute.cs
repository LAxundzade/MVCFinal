using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Portfolio.AppCode.Attributes
{
    public class PortfolioSqlDefaultValueAttribute:Attribute
    {
        public string PortfolioSqlDefaultValue { get; set; }
        
    }
}