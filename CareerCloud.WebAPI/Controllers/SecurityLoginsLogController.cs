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
    [RoutePrefix("api/careercloud/security/v1")]
    public class SecurityLoginsLogController : ApiController
    {
        private SecurityLoginsLogLogic logic;
        public SecurityLoginsLogController()
        {
            var repository = new ApplicantProfileRepository<SecurityLoginsLogPoco>(false);
            logic = new SecurityLoginsLogLogic(repository);
        }

        [HttpGet]
        [Route("loginslog/{SecurityLoginsLogId}")]
        [ResponseType(typeof(SecurityLoginsLogPoco))]
        public IHttpActionResult GetSecurityLoginLog(Guid SecurityLoginsLogId)
        {
            SecurityLoginsLogPoco poco = logic.Get(SecurityLoginsLogId);
            if (poco == null)
            {
                return NotFound();
            }
            return Ok(poco);
        }

        [HttpGet]
        [Route("loginslog")]
        [ResponseType(typeof(List<SecurityLoginsLogPoco>))]
        public IHttpActionResult GetAllSecurityLoginsLog()
        {
            List<SecurityLoginsLogPoco> results = logic.GetAll();

            if (results == null)
            {
                return NotFound();
            }

            return Ok(results);
        }

        [HttpPost]
        [Route("loginslog")]
        public IHttpActionResult PostSecurityLoginLog([FromBody] SecurityLoginsLogPoco[] pocos)
        {
            logic.Add(pocos);
            return Ok();
        }

        [HttpPut]
        [Route("loginslog")]
        public IHttpActionResult PutSecurityLoginLog([FromBody] SecurityLoginsLogPoco[] pocos)
        {
            logic.Update(pocos);
            return Ok();
        }


        [HttpDelete]
        [Route("loginslog")]
        public IHttpActionResult DeleteSecurityLoginLog([FromBody] SecurityLoginsLogPoco[] pocos)
        {
            logic.Delete(pocos);
            return Ok();
        }
    }
}
