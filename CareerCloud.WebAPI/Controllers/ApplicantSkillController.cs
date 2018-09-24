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
    public class ApplicantSkillController : ApiController
    {
        private ApplicantSkillLogic logic;
        public ApplicantSkillController()
        {
            var repository = new ApplicantProfileRepository<ApplicantSkillPoco>(false);
            logic = new ApplicantSkillLogic(repository);
        }

        [HttpGet]
        [Route("skill/{applicantSkillId}")]
        [ResponseType(typeof(ApplicantSkillPoco))]
        public IHttpActionResult GetApplicantSkill(Guid applicantSkillId)
        {
            ApplicantSkillPoco poco = logic.Get(applicantSkillId);
            if (poco == null)
            {
                return NotFound();
            }
            return Ok(poco);
        }

        [HttpGet]
        [Route("skill")]
        [ResponseType(typeof(List<ApplicantSkillPoco>))]
        public IHttpActionResult GetAllApplicantSkill()
        {
            List<ApplicantSkillPoco> results = logic.GetAll();

            if (results == null)
            {
                return NotFound();
            }

            return Ok(results);
        }

        [HttpPost]
        [Route("skill")]
        public IHttpActionResult PostApplicantSkill([FromBody] ApplicantSkillPoco[] pocos)
        {
            logic.Add(pocos);
            return Ok();
        }

        [HttpPut]
        [Route("skill")]
        public IHttpActionResult PutApplicantSkill([FromBody] ApplicantSkillPoco[] pocos)
        {
            logic.Update(pocos);
            return Ok();
        }


        [HttpDelete]
        [Route("skill")]
        public IHttpActionResult DeleteApplicantSkill([FromBody] ApplicantSkillPoco[] pocos)
        {
            logic.Delete(pocos);
            return Ok();
        }
    }
}
