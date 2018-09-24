using CareerCloud.ADODataAccessLayer;
using CareerCloud.BusinessLogicLayer;
using CareerCloud.EntityFrameworkDataAccess;
using CareerCloud.Pocos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace CareerCloud.WebAPI.Controllers
{
    [RoutePrefix("api/careercloud/applicant/v1")]
    public class ApplicantProfileController : ApiController
    {
        private ApplicantProfileLogic logic;
        public ApplicantProfileController()
        {
            var repository = new ApplicantProfileRepository();
            logic = new ApplicantProfileLogic(repository);
        }

        [HttpGet]
        [Route("profile/{applicantProfileId}")]
        [ResponseType(typeof(ApplicantProfilePoco))]
        public IHttpActionResult GetApplicantProfile(Guid applicantProfileId)
        {
            ApplicantProfilePoco poco = logic.Get(applicantProfileId);
            if (poco == null)
            {
                return NotFound();
            }
            return Ok(poco);
        }

        [HttpGet]
        [Route("profile")]
        [ResponseType(typeof(List<ApplicantProfilePoco>))]
        public IHttpActionResult GetAllApplicantProfile()
        {
            List<ApplicantProfilePoco> results = logic.GetAll();

            if (results == null)
            {
                return NotFound();
            }

            return Ok(results);
        }

        [HttpPost]
        [Route("profile")]
        public IHttpActionResult PostApplicantProfile([FromBody] ApplicantProfilePoco[] pocos)
        {
            logic.Add(pocos);
            return Ok();
        }

        [HttpPut]
        [Route("profile")]
        public IHttpActionResult PutApplicantProfile([FromBody] ApplicantProfilePoco[] pocos)
        {
            logic.Update(pocos);
            return Ok();
        }


        [HttpDelete]
        [Route("profile")]
        public IHttpActionResult DeleteApplicantProfile([FromBody] ApplicantProfilePoco[] pocos)
        {
            logic.Delete(pocos);
            return Ok();
        }
    }
}
