using CareerCloud.ADODataAccessLayer;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.Pocos;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace CareerCloudMVC.Controllers
{
    public class ApplicantHomeController : Controller
    {

        private RestClient client;
        public ApplicantHomeController()
        {
            client = new RestClient("http://localhost:52106/");
        }

        // GET: ApplicantHome
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SecurityLogin()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SecurityLogin([Bind(Include = "Login,Password")] SecurityLoginPoco poco)
        {
            if (poco.Login == null || poco.Password == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            SecurityLoginPoco[] pocos = new SecurityLoginPoco[] { poco };
            SecurityLoginRepository securityLoginRepository = new SecurityLoginRepository();
            SecurityLoginLogic logic = new SecurityLoginLogic(securityLoginRepository);
            poco = logic.GetAll().Where(s => s.Login == poco.Login && s.Password == poco.Password).FirstOrDefault();


            ApplicantProfileLogic applicantProfileLogic = new ApplicantProfileLogic(new ApplicantProfileRepository());
            ApplicantProfilePoco applicantProfilePoco = applicantProfileLogic.GetAll().Where(s => s.Login == poco.Id).FirstOrDefault();
            
            return RedirectToAction("Edit/" + applicantProfilePoco.Id, "AppProfile");

        }
    }
}