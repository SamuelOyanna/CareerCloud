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
    public class SecurityRoleController : ApiController
    {
        private SecurityRoleLogic logic;
        public SecurityRoleController()
        {
            var repository = new ApplicantProfileRepository<SecurityRolePoco>(false);
            logic = new SecurityRoleLogic(repository);
        }

        [HttpGet]
        [Route("role/{SecurityRoleId}")]
        [ResponseType(typeof(SecurityRolePoco))]
        public IHttpActionResult GetSecurityRole(Guid SecurityRoleId)
        {
            SecurityRolePoco poco = logic.Get(SecurityRoleId);
            if (poco == null)
            {
                return NotFound();
            }
            return Ok(poco);
        }

        [HttpGet]
        [Route("role")]
        [ResponseType(typeof(List<SecurityRolePoco>))]
        public IHttpActionResult GetAllSecurityRole()
        {
            List<SecurityRolePoco> results = logic.GetAll();

            if (results == null)
            {
                return NotFound();
            }

            return Ok(results);
        }

        [HttpPost]
        [Route("role")]
        public IHttpActionResult PostSecurityRole([FromBody] SecurityRolePoco[] pocos)
        {
            logic.Add(pocos);
            return Ok();
        }

        [HttpPut]
        [Route("role")]
        public IHttpActionResult PutSecurityRole([FromBody] SecurityRolePoco[] pocos)
        {
            logic.Update(pocos);
            return Ok();
        }


        [HttpDelete]
        [Route("role")]
        public IHttpActionResult DeleteSecurityRole([FromBody] SecurityRolePoco[] pocos)
        {
            logic.Delete(pocos);
            return Ok();
        }
    }
}
