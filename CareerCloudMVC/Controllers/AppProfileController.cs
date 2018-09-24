using CareerCloud.ADODataAccessLayer;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.Pocos;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CareerCloudMVC.Controllers
{
    public class AppProfileController : Controller
    {
        private RestClient client;
        public AppProfileController()
        {
            client = new RestClient("http://localhost:52106/");
        }

        // GET: ApplicantProfile
        public ActionResult Index()
        {
            var request = new RestRequest("api/careercloud/applicant/v1/profile");
            var response = client.Execute<ApplicantProfilePoco>(request);
            var ApplicantProfiles = JsonConvert.DeserializeObject<ApplicantProfilePoco>(response.Content);
            return View(ApplicantProfiles);

        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Login,CurrentSalary,CurrentRate,Currency,Country,Province,Street,City,PostalCode,TimeStamp")] ApplicantProfilePoco applicantProfilePoco)
        {

            ApplicantProfilePoco[] pocos = new ApplicantProfilePoco[] { applicantProfilePoco };
            var request = new RestRequest("api/careercloud/applicant/v1/profile", Method.PUT);
            request.AddJsonBody(pocos);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);

            if (Session["Applicant"] == null)
            {
                Session["Applicant"] = applicantProfilePoco.Id;
            }




            return RedirectToAction("Index", "CompanyJob");
        }

        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ApplicantProfilePoco poco;
            var logic = new ApplicantProfileLogic(new ApplicantProfileRepository());
            poco = logic.GetAll().Where(s => s.Id == id).FirstOrDefault();
            if (poco == null)
            {
                return HttpNotFound();
            }
            id = poco.Id;
           // ViewBag.Login = new SelectList(db.SecurityLogins, "Id", "Login", poco.Login);
            //ViewBag.Country = new SelectList(db.SystemCountryCodes, "Code", "Name", poco.Country);
            return View(poco);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Login,CurrentSalary,CurrentRate,Currency,Country,Province,Street,City,PostalCode,TimeStamp")] ApplicantProfilePoco applicantProfilePoco)
        {

            ApplicantProfilePoco[] pocos = new ApplicantProfilePoco[] { applicantProfilePoco };
            var request = new RestRequest("api/careercloud/applicant/v1/profile", Method.PUT);
            request.AddJsonBody(pocos);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);
            
            if (Session["Applicant"] == null)
            {
                Session["Applicant"] = applicantProfilePoco.Id;
            }
                    
            return RedirectToAction("Index", "CompanyJob");
        }
    }
}