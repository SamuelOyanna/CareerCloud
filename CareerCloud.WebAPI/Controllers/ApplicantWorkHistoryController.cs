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
    public class ApplicantWorkHistoryController : ApiController
    {
        private ApplicantWorkHistoryLogic logic;
        public ApplicantWorkHistoryController()
        {
            var repository = new ApplicantProfileRepository<ApplicantWorkHistoryPoco>(false);
            logic = new ApplicantWorkHistoryLogic(repository);
        }

        [HttpGet]
        [Route("workhistory/{applicantWorkHistoryId}")]
        [ResponseType(typeof(ApplicantWorkHistoryPoco))]
        public IHttpActionResult GetApplicantWorkHistory(Guid applicantWorkHistoryId)
        {
            ApplicantWorkHistoryPoco poco = logic.Get(applicantWorkHistoryId);
            if (poco == null)
            {
                return NotFound();
            }
            return Ok(poco);
        }

        [HttpGet]
        [Route("workhistory")]
        [ResponseType(typeof(List<ApplicantWorkHistoryPoco>))]
        public IHttpActionResult GetAllApplicantWorkHistory()
        {
            List<ApplicantWorkHistoryPoco> results = logic.GetAll();

            if (results == null)
            {
                return NotFound();
            }

            return Ok(results);
        }

        [HttpPost]
        [Route("workhistory")]
        public IHttpActionResult PostApplicantWorkHistory([FromBody] ApplicantWorkHistoryPoco[] pocos)
        {
            logic.Add(pocos);
            return Ok();
        }

        [HttpPut]
        [Route("workhistory")]
        public IHttpActionResult PutApplicantWorkHistory([FromBody] ApplicantWorkHistoryPoco[] pocos)
        {
            logic.Update(pocos);
            return Ok();
        }


        [HttpDelete]
        [Route("workhistory")]
        public IHttpActionResult DeleteApplicantWorkHistory([FromBody] ApplicantWorkHistoryPoco[] pocos)
        {
            logic.Delete(pocos);
            return Ok();
        }
    }
}
