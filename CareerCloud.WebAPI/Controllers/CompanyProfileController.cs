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
    public class CompanyProfileController : ApiController
    {
        private CompanyProfileLogic logic;
        public CompanyProfileController()
        {
            CompanyProfileRepository companyProfileRepository = new CompanyProfileRepository();
            logic = new CompanyProfileLogic(companyProfileRepository);
        }

        [HttpGet]
        [Route("profile/{CompanyProfileId}")]
        [ResponseType(typeof(CompanyProfilePoco))]
        public IHttpActionResult GetCompanyProfile(Guid CompanyProfileId)
        {
            CompanyProfilePoco poco = logic.Get(CompanyProfileId);
            if (poco == null)
            {
                return NotFound();
            }
            return Ok(poco);
        }

        [HttpGet]
        [Route("profile")]
        [ResponseType(typeof(List<CompanyProfilePoco>))]
        public IHttpActionResult GetAllCompanyProfile()
        {
            List<CompanyProfilePoco> results = logic.GetAll();

            if (results == null)
            {
                return NotFound();
            }

            return Ok(results);
        }

        [HttpPost]
        [Route("profile")]
        public IHttpActionResult PostCompanyProfile([FromBody] CompanyProfilePoco[] pocos)
        {
            logic.Add(pocos);
            return Ok();
        }

        [HttpPut]
        [Route("profile")]
        public IHttpActionResult PutCompanyProfile([FromBody] CompanyProfilePoco[] pocos)
        {
            logic.Update(pocos);
            return Ok();
        }


        [HttpDelete]
        [Route("profile")]
        public IHttpActionResult DeleteCompanyProfile([FromBody] CompanyProfilePoco[] pocos)
        {
            logic.Delete(pocos);
            return Ok();
        }
    }
}
