using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareerCloud.Pocos
{
    [Table("System_Language_Code")]
    public class SystemLanguageCodePoco
    {
        public string LanguageID { get; set; }
        public string Name { get; set; }
        [Column("Native_Name")]
        public string NativeName { get; set; }
    }
}
