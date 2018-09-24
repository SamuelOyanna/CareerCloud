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
    public class CompanyJobController : ApiController
    {
        private CompanyJobLogic logic;
        public CompanyJobController()
        {
            CompanyJobRepository repository = new CompanyJobRepository();
            logic = new CompanyJobLogic(repository);
        }

        [HttpGet]
        [Route("job/{CompanyJobId}")]
        [ResponseType(typeof(CompanyJobPoco))]
        public IHttpActionResult GetCompanyJob(Guid CompanyJobId)
        {
            CompanyJobPoco poco = logic.Get(CompanyJobId);
            if (poco == null)
            {
                return NotFound();
            }
            return Ok(poco);
        }

        [HttpGet]
        [Route("job")]
        [ResponseType(typeof(List<CompanyJobPoco>))]
        public IHttpActionResult GetAllCompanyJob()
        {
            List<CompanyJobPoco> results = logic.GetAll();

            if (results == null)
            {
                return NotFound();
            }

            return Ok(results);
        }

        [HttpPost]
        [Route("job")]
        public IHttpActionResult PostCompanyJob([FromBody] CompanyJobPoco[] pocos)
        {
            logic.Add(pocos);
            return Ok();
        }

        [HttpPut]
        [Route("job")]
        public IHttpActionResult PutCompanyJob([FromBody] CompanyJobPoco[] pocos)
        {
            logic.Update(pocos);
            return Ok();
        }


        [HttpDelete]
        [Route("job")]
        public IHttpActionResult DeleteCompanyJob([FromBody] CompanyJobPoco[] pocos)
        {
            logic.Delete(pocos);
            return Ok();
        }
    }
}
