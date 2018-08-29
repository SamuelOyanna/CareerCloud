using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarerrCloud.UnitTests.Assignment4
{
    class Class1
    {
        public static void main (String [] args)
        {
            string s = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
            Console.WriteLine(s);
        }
    }
}
