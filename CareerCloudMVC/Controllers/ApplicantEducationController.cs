using CareerCloud.Pocos;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CareerCloudMVC.Controllers
{
    public class ApplicantEducationController : Controller
    {
       
      
         private RestClient client;
        public ApplicantEducationController()
        {
            client = new RestClient("http://localhost:52106/");
        }
        // GET: ApplicantEducation
        public ActionResult Index()
        {
            var request = new RestRequest("api/careercloud/applicant/v1/education");
            var response = client.Execute<ApplicantEducationPoco>(request);
            var companyProfiles = JsonConvert.DeserializeObject<IEnumerable<ApplicantEducationPoco>>(response.Content);
            return View(companyProfiles);
       
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "Applicant,Major,CertificateDiploma,StartDate,COmpletionDate,CompletionPercent")] ApplicantEducationPoco poco)
        {
            ApplicantEducationPoco[] pocos = new ApplicantEducationPoco[] { poco };
            var request = new RestRequest("api/careercloud/applicant/v1/education", Method.POST);
            request.AddBody(pocos);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);
            return RedirectToAction("Index");

        }

        public ActionResult Edit(Guid id)
        {
            var request = new RestRequest($"api/careercloud/applicant/v1/education/{id}");
            var response = client.Execute<ApplicantEducationPoco>(request);
            var poco = JsonConvert.DeserializeObject<ApplicantEducationPoco>(response.Content);
            return View(poco);
        }
         
        [HttpPut]
        public ActionResult Edit([Bind(Include ="Id,Applicant,Major,CertificateDiploma,StartDate,COmpletionDate,CompletionPercent")] ApplicantEducationPoco poco)
        { 
            ApplicantEducationPoco[] pocos = new ApplicantEducationPoco[] { poco };
            var request = new RestRequest("api/careercloud/applicant/v1/education", Method.PUT);
            request.AddBody(pocos);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);
            return RedirectToAction("Index");

        }

    }
}