﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("System_Country_Code")]
    public class SystemCountryCodePoco
    {
        public string Code { get; set; }
        public string Name { get; set; }
       
    }
}