using CareerCloud.ADODataAccessLayer;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.Pocos;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CareerCloudMVC.Controllers
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
            Guid applicantProfile = (Guid)Session["Applicant"];
            
            ApplicantJobApplicationRepository applicantJobApplicationRepository = new ApplicantJobApplicationRepository();
            ApplicantJobApplicationLogic applicantJobApplicationLogic = new ApplicantJobApplicationLogic(applicantJobApplicationRepository);
            var applicantJobApplicationPocos = applicantJobApplicationLogic.GetAll().Where(s => s.Applicant == applicantProfile);


            return View(applicantJobApplicationPocos);
        }

        public ActionResult Details (Guid id)
        {
            var request = new RestRequest("api/careercloud/applicant/v1/jobapplication/" + id, Method.GET);
            
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);
            var poco = response.Content;

            return View(poco);
        }
    }
}