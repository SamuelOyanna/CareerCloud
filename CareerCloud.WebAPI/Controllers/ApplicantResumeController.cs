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
    public class ApplicantResumeController : ApiController
    {
        private ApplicantResumeLogic logic;
        public ApplicantResumeController()
        {
            var repository = new ApplicantProfileRepository<ApplicantResumePoco>(false);
            logic = new ApplicantResumeLogic(repository);
        }

        [HttpGet]
        [Route("resume/{applicantResumeId}")]
        [ResponseType(typeof(ApplicantResumePoco))]
        public IHttpActionResult GetApplicantResume(Guid applicantResumeId)
        {
            ApplicantResumePoco poco = logic.Get(applicantResumeId);
            if (poco == null)
            {
                return NotFound();
            }
            return Ok(poco);
        }

        [HttpGet]
        [Route("resume")]
        [ResponseType(typeof(List<ApplicantResumePoco>))]
        public IHttpActionResult GetAllApplicantResume()
        {
            List<ApplicantResumePoco> results = logic.GetAll();

            if (results == null)
            {
                return NotFound();
            }

            return Ok(results);
        }

        [HttpPost]
        [Route("resume")]
        public IHttpActionResult PostApplicantResume([FromBody] ApplicantResumePoco[] pocos)
        {
            logic.Add(pocos);
            return Ok();
        }

        [HttpPut]
        [Route("resume")]
        public IHttpActionResult PutApplicantResume([FromBody] ApplicantResumePoco[] pocos)
        {
            logic.Update(pocos);
            return Ok();
        }


        [HttpDelete]
        [Route("resume")]
        public IHttpActionResult DeleteApplicantResume([FromBody] ApplicantResumePoco[] pocos)
        {
            logic.Delete(pocos);
            return Ok();
        }
    }
}
