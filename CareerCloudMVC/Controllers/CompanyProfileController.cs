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
    public class CompanyProfileController : Controller
    {
        private RestClient client;
        public CompanyProfileController()
        {
            client = new RestClient("http://localhost:52106/");
        }

        // GET: CompanyProfile
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index([Bind(Include = "RegistrationDate,CompanyWebsite,ContactPhone,ContactName")] CompanyProfilePoco poco)
        {
            // Put random bytes into this array.
            byte[] array = new byte[8];
            // Use Random class and NextBytes method.
            // ... Display the bytes with following method.
            Random random = new Random();
            random.NextBytes(array);

            poco.CompanyLogo = array;
            CompanyProfilePoco[] pocos = new CompanyProfilePoco[] { poco };
            var request = new RestRequest("api/careercloud/company/v1/profile", Method.POST);
            request.AddJsonBody(pocos);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);

            //Get Back The Company just saved and add to session

            CompanyProfileRepository repository = new CompanyProfileRepository();
            CompanyProfileLogic logic = new CompanyProfileLogic(repository);
            var companyProfile = logic.GetAll().Where(s => s.CompanyWebsite == poco.CompanyWebsite && s.ContactPhone == poco.ContactPhone && s.ContactName == poco.ContactName).FirstOrDefault();

            if (Session["Company"] == null)
            {
                Session["Company"] = companyProfile.Id;
            }

            return RedirectToAction("Description");

        }

        public ActionResult Description()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Description([Bind(Include = "LanguageId,CompanyName,CompanyDescription")] CompanyDescriptionPoco poco)
        {
            var companyId = Session["Company"];
            poco.Company = (Guid)companyId;
            CompanyDescriptionPoco[] pocos = new CompanyDescriptionPoco[] { poco };

            var request = new RestRequest("api/careercloud/company/v1/description", Method.POST);
            request.AddJsonBody(pocos);
            request.RequestFormat = DataFormat.Json;
            var response = client.Execute(request);

           

            return RedirectToAction("Create", "CompanyJob");

        }

    }
}