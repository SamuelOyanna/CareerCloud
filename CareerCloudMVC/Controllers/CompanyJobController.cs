using CareerCloud.ADODataAccessLayer;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.Pocos;
using CareerCloudMVC.Models;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CareerCloudMVC.Controllers
{
    public class CompanyJobController : Controller
    {

        private RestClient client;
        public CompanyJobController()
        {
            client = new RestClient("http://localhost:52106/");
        }

        // GET: CompanyJob
        public ActionResult Index()
        {
            List<JobInformation> jobInfoList = new List<JobInformation>();
            //Company Job via WebAPI
            var request = new RestRequest("api/careercloud/company/v1/job");
            var response = client.Execute<CompanyJobPoco>(request);
            var companyJobs = JsonConvert.DeserializeObject<IEnumerable<CompanyJobPoco>>(response.Content);

            foreach (var companyJob in companyJobs)
            {
                JobInformation jobInformation = new JobInformation();
                
                CompanyJobDescriptionPoco companyJobDescriptionPoco;

                jobInformation.profileCreated = companyJob.ProfileCreated;
                jobInformation.companyJobPoco = companyJob;

                
                CompanyJobDescriptionRepository companyJobDescriptionRepository = new CompanyJobDescriptionRepository();
                CompanyJobDescriptionLogic companyJobDescriptionLogic = new CompanyJobDescriptionLogic(companyJobDescriptionRepository);
                companyJobDescriptionPoco = companyJobDescriptionLogic.GetAll().Where(s => s.Job == companyJob.Id).FirstOrDefault();

                if(companyJobDescriptionPoco == null)
                {
                    continue;
                }
                
                    jobInformation.jobName = companyJobDescriptionPoco.JobName;
                    jobInformation.jobDescription = companyJobDescriptionPoco.JobDescriptions;
               

                CompanyProfilePoco companyProfilePoco;
                CompanyProfileRepository companyProfileRepository = new CompanyProfileRepository();
                CompanyProfileLogic companyProfileLogic = new CompanyProfileLogic(companyProfileRepository);
                companyProfilePoco = companyProfileLogic.GetAll().Where(s => s.Id == companyJob.Company).FirstOrDefault();

                if(companyProfilePoco == null)
                {
                    continue;
                }



                CompanyDescriptionPoco companyDescriptionPoco;
                CompanyDescriptionRepository companyDescriptionRepository = new CompanyDescriptionRepository();
                CompanyDescriptionLogic companyDescriptionLogic = new CompanyDescriptionLogic(companyDescriptionRepository);
                companyDescriptionPoco = companyDescriptionLogic.GetAll().Where(s => s.Company == companyProfilePoco.Id).FirstOrDefault();
                
                if(companyDescriptionPoco == null)
                {
                    continue;
                }

                jobInformation.companyName = companyDescriptionPoco.CompanyName;
                jobInfoList.Add(jobInformation);
            }

            return View(jobInfoList);

        }


      //  public ActionResult Edit([Bind(Include = "Id,Applicant,Major,CertificateDiploma,StartDate,COmpletionDate,CompletionPercent")] ApplicantEducationPoco poco)
        
        public ActionResult Apply(Guid companyJobPoco)
        {
            var applicantPoco = Session["Applicant"];
            


            ApplicantJobApplicationPoco applicantJobApplicationPoco = new ApplicantJobApplicationPoco();
            applicantJobApplicationPoco.Applicant = (Guid)applicantPoco;
            applicantJobApplicationPoco.Job = companyJobPoco;
            applicantJobApplicationPoco.ApplicationDate = DateTime.Now;

            ApplicantJobApplicationPoco[] pocos = new ApplicantJobApplicationPoco[] { applicantJobApplicationPoco };
            var request = new RestRequest("api/careercloud/applicant/v1/jobapplication", Method.POST);
            request.AddJsonBody(pocos);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);

            return RedirectToAction("Index", "ApplicantJobApplication");

        }

        public ActionResult Edit(string s)
        {
            return View();
        }

        public ActionResult Details(string companyName, string jobName, string jobDescription, DateTime profileCreated)
        {
            JobInformation jobInformation = new JobInformation();
            jobInformation.companyName = companyName;
            jobInformation.jobName = jobName;
            jobInformation.jobDescription = jobDescription;
            jobInformation.profileCreated = profileCreated;
            return View(jobInformation);
        }


        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create([Bind(Include = "ProfileCreated,IsInactive,IsCompanyHidden")] CompanyJobPoco poco)
        {
            var companyId = Session["Company"];
            poco.Company = (Guid)companyId;
            CompanyJobPoco[] pocos = new CompanyJobPoco[] { poco };
            var request = new RestRequest("api/careercloud/company/v1/job", Method.POST);
            request.AddJsonBody(pocos);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);


            //Get Job
            //Get Back The Job just saved and add to session

            CompanyJobRepository repository = new CompanyJobRepository();
            CompanyJobLogic logic = new CompanyJobLogic(repository);
            var companyJob = logic.GetAll().Where(s => s.Company == poco.Company).FirstOrDefault();

            if (Session["Job"] == null)
            {
                Session["Job"] = companyJob.Id;
            }

            return RedirectToAction("JobDescription");

        }

        public ActionResult JobDescription()
        {
            return View();
        }

        [HttpPost]
        public ActionResult JobDescription([Bind(Include = "JobName,JobDescriptions")] CompanyJobDescriptionPoco poco)
        {
            var jobId = Session["Job"];
            poco.Job = (Guid)jobId;
            CompanyJobDescriptionPoco[] pocos = new CompanyJobDescriptionPoco[] { poco };
            var request = new RestRequest("api/careercloud/company/v1/jobdescription", Method.POST);
            request.AddJsonBody(pocos);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);

            return RedirectToAction("JobsCreatedByCompany");

        }

        public ActionResult JobsCreatedByCompany()
        {
            Guid companyId = (Guid) Session["Company"];

            CompanyJobRepository repository = new CompanyJobRepository();
            CompanyJobLogic logic = new CompanyJobLogic(repository);
            var companyJobs = logic.GetAll().Where(s => s.Company == companyId);

            List<JobInformation> jobInfoList = new List<JobInformation>();

            foreach (var companyJob in companyJobs)
            {
                JobInformation jobInformation = new JobInformation();

                CompanyJobDescriptionPoco companyJobDescriptionPoco;

                jobInformation.profileCreated = companyJob.ProfileCreated;
                jobInformation.companyJobPoco = companyJob;


                CompanyJobDescriptionRepository companyJobDescriptionRepository = new CompanyJobDescriptionRepository();
                CompanyJobDescriptionLogic companyJobDescriptionLogic = new CompanyJobDescriptionLogic(companyJobDescriptionRepository);
                companyJobDescriptionPoco = companyJobDescriptionLogic.GetAll().Where(s => s.Job == companyJob.Id).FirstOrDefault();

                if (companyJobDescriptionPoco == null)
                {
                    continue;
                }

                jobInformation.jobName = companyJobDescriptionPoco.JobName;
                jobInformation.jobDescription = companyJobDescriptionPoco.JobDescriptions;

                
                jobInfoList.Add(jobInformation);
            }

            return View(jobInfoList);

        }

    }
}