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
    public class CompanyLocationController : ApiController
    {
        private CompanyLocationLogic logic;
        public CompanyLocationController()
        {
            var repository = new ApplicantProfileRepository<CompanyLocationPoco>(false);
            logic = new CompanyLocationLogic(repository);
        }

        [HttpGet]
        [Route("location/{CompanyLocationId}")]
        [ResponseType(typeof(CompanyLocationPoco))]
        public IHttpActionResult GetCompanyLocation(Guid CompanyLocationId)
        {
            CompanyLocationPoco poco = logic.Get(CompanyLocationId);
            if (poco == null)
            {
                return NotFound();
            }
            return Ok(poco);
        }

        [HttpGet]
        [Route("location")]
        [ResponseType(typeof(List<CompanyLocationPoco>))]
        public IHttpActionResult GetAllCompanyLocation()
        {
            List<CompanyLocationPoco> results = logic.GetAll();

            if (results == null)
            {
                return NotFound();
            }

            return Ok(results);
        }

        [HttpPost]
        [Route("location")]
        public IHttpActionResult PostCompanyLocation([FromBody] CompanyLocationPoco[] pocos)
        {
            logic.Add(pocos);
            return Ok();
        }

        [HttpPut]
        [Route("location")]
        public IHttpActionResult PutCompanyLocation([FromBody] CompanyLocationPoco[] pocos)
        {
            logic.Update(pocos);
            return Ok();
        }


        [HttpDelete]
        [Route("location")]
        public IHttpActionResult DeleteCompanyLocation([FromBody] CompanyLocationPoco[] pocos)
        {
            logic.Delete(pocos);
            return Ok();
        }
    }
}
