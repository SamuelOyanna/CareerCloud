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
    [RoutePrefix("api/careercloud/company/v1")]
    public class CompanyJobsDescriptionController : ApiController
    {
        private CompanyJobDescriptionLogic logic;
        public CompanyJobsDescriptionController()
        {
            logic = new CompanyJobDescriptionLogic(new CompanyJobDescriptionRepository());
        }

        [HttpGet]
        [Route("jobdescription/{CompanyJobDescriptionId}")]
        [ResponseType(typeof(CompanyJobDescriptionPoco))]
        public IHttpActionResult GetCompanyJobsDescription(Guid CompanyJobDescriptionId)
        {
            CompanyJobDescriptionPoco poco = logic.Get(CompanyJobDescriptionId);
            if (poco == null)
            {
                return NotFound();
            }
            return Ok(poco);
        }

        [HttpGet]
        [Route("jobdescription")]
        [ResponseType(typeof(List<CompanyJobDescriptionPoco>))]
        public IHttpActionResult GetAllCompanyJobDescription()
        {
            List<CompanyJobDescriptionPoco> results = logic.GetAll();

            if (results == null)
            {
                return NotFound();
            }

            return Ok(results);
        }

        [HttpPost]
        [Route("jobdescription")]
        public IHttpActionResult PostCompanyJobsDescription([FromBody] CompanyJobDescriptionPoco[] pocos)
        {
            logic.Add(pocos);
            return Ok();
        }

        [HttpPut]
        [Route("jobdescription")]
        public IHttpActionResult PutCompanyJobsDescription([FromBody] CompanyJobDescriptionPoco[] pocos)
        {
            logic.Update(pocos);
            return Ok();
        }


        [HttpDelete]
        [Route("jobdescription")]
        public IHttpActionResult DeleteCompanyJobsDescription([FromBody] CompanyJobDescriptionPoco[] pocos)
        {
            logic.Delete(pocos);
            return Ok();
        }
    }
}
