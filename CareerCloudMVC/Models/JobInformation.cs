using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CareerCloudMVC.Models
{
    public class JobInformation
    {
        public string companyName { get; set; }
        public string jobName { get; set; }
        public string jobDescription { get; set; }
        public DateTime profileCreated { get; set; }

        
        public CompanyJobPoco companyJobPoco { get; set; }
        public ApplicantProfilePoco applicantProfilePoco { get; set; }
       
    }
}