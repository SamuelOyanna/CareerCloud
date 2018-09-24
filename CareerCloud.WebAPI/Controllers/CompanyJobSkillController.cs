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
    [RoutePrefix("api/careercloud/company/v1")]
    public class CompanyJobSkillController : ApiController
    {
        private CompanyJobSkillLogic logic;
        public CompanyJobSkillController()
        {
            var repository = new ApplicantProfileRepository<CompanyJobSkillPoco>(false);
            logic = new CompanyJobSkillLogic(repository);
        }

        [HttpGet]
        [Route("jobskill/{CompanyJobSkillId}")]
        [ResponseType(typeof(CompanyJobSkillPoco))]
        public IHttpActionResult GetCompanyJobSkill(Guid CompanyJobSkillId)
        {
            CompanyJobSkillPoco poco = logic.Get(CompanyJobSkillId);
            if (poco == null)
            {
                return NotFound();
            }
            return Ok(poco);
        }

        [HttpGet]
        [Route("jobskill")]
        [ResponseType(typeof(List<CompanyJobSkillPoco>))]
        public IHttpActionResult GetAllCompanyJobSkill()
        {
            List<CompanyJobSkillPoco> results = logic.GetAll();

            if (results == null)
            {
                return NotFound();
            }

            return Ok(results);
        }

        [HttpPost]
        [Route("jobskill")]
        public IHttpActionResult PostCompanyJobSkill([FromBody] CompanyJobSkillPoco[] pocos)
        {
            logic.Add(pocos);
            return Ok();
        }

        [HttpPut]
        [Route("jobskill")]
        public IHttpActionResult PutCompanyJobSkill([FromBody] CompanyJobSkillPoco[] pocos)
        {
            logic.Update(pocos);
            return Ok();
        }


        [HttpDelete]
        [Route("jobskill")]
        public IHttpActionResult DeleteCompanyJobSkill([FromBody] CompanyJobSkillPoco[] pocos)
        {
            logic.Delete(pocos);
            return Ok();
        }
    }
}
