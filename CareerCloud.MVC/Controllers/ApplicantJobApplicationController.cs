using CareerCloud.Pocos;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CareerCloud.MVC.Controllers
{
    public class ApplicantJobApplicationController : Controller
    {
        private RestClient client;
        public ApplicantJobApplicationController()
        {
           client = new RestClient("http://localhost:52106/");
        }
        // GET: ApplicantJobApplication
        public ActionResult Index()
        {
            var request = new RestRequest("api/careercloud/applicant/v1/jobapplication");
            var response = client.Execute<ApplicantJobApplicationPoco>(request);
            var companyProfiles = JsonConvert.DeserializeObject<IEnumerable<ApplicantJobApplicationPoco>>(response.Content);
            return View(companyProfiles);
        }
    }
}