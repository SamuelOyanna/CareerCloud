﻿using CareerCloud.BusinessLogicLayer;
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
    public class CompanyJobEducationController : ApiController
    {
        private CompanyJobEducationLogic logic;
        public CompanyJobEducationController()
        {
            var repository = new ApplicantProfileRepository<CompanyJobEducationPoco>(false);
            logic = new CompanyJobEducationLogic(repository);
        }

        [HttpGet]
        [Route("jobeducation/{CompanyJobEducationId}")]
        [ResponseType(typeof(CompanyJobEducationPoco))]
        public IHttpActionResult GetCompanyJobEducation(Guid CompanyJobEducationId)
        {
            CompanyJobEducationPoco poco = logic.Get(CompanyJobEducationId);
            if (poco == null)
            {
                return NotFound();
            }
            return Ok(poco);
        }

        [HttpGet]
        [Route("jobeducation")]
        [ResponseType(typeof(List<CompanyJobEducationPoco>))]
        public IHttpActionResult GetAllCompanyJobEducation()
        {
            List<CompanyJobEducationPoco> results = logic.GetAll();

            if (results == null)
            {
                return NotFound();
            }

            return Ok(results);
        }

        [HttpPost]
        [Route("jobeducation")]
        public IHttpActionResult PostCompanyJobEducation([FromBody] CompanyJobEducationPoco[] pocos)
        {
            logic.Add(pocos);
            return Ok();
        }

        [HttpPut]
        [Route("jobeducation")]
        public IHttpActionResult PutCompanyJobEducation([FromBody] CompanyJobEducationPoco[] pocos)
        {
            logic.Update(pocos);
            return Ok();
        }


        [HttpDelete]
        [Route("jobeducation")]
        public IHttpActionResult DeleteCompanyJobEducation([FromBody] CompanyJobEducationPoco[] pocos)
        {
            logic.Delete(pocos);
            return Ok();
        }
    }
}
