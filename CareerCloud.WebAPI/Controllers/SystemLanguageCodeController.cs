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
    [RoutePrefix("api/careercloud/system/v1")]
    public class SystemLanguageCodeController : ApiController
    {
        private SystemLanguageCodeLogic logic;
        public SystemLanguageCodeController()
        {
            var repository = new ApplicantProfileRepository<SystemLanguageCodePoco>(false);
            logic = new SystemLanguageCodeLogic(repository);
        }

        [HttpGet]
        [Route("languagecode/{SystemLanguageCodeId}")]
        [ResponseType(typeof(SystemLanguageCodePoco))]
        public IHttpActionResult GetSystemLanguageCode(string SystemLanguageCodeId)
        {
            SystemLanguageCodePoco poco = logic.Get(SystemLanguageCodeId);
            if (poco == null)
            {
                return NotFound();
            }
            return Ok(poco);
        }

        [HttpGet]
        [Route("languagecode")]
        [ResponseType(typeof(List<SystemLanguageCodePoco>))]
        public IHttpActionResult GetAllSystemLanguageCode()
        {
            List<SystemLanguageCodePoco> results = logic.GetAll();

            if (results == null)
            {
                return NotFound();
            }

            return Ok(results);
        }

        [HttpPost]
        [Route("languagecode")]
        public IHttpActionResult PostSystemLanguageCode([FromBody] SystemLanguageCodePoco[] pocos)
        {
            logic.Add(pocos);
            return Ok();
        }

        [HttpPut]
        [Route("languagecode")]
        public IHttpActionResult PutSystemLanguageCode([FromBody] SystemLanguageCodePoco[] pocos)
        {
            logic.Update(pocos);
            return Ok();
        }


        [HttpDelete]
        [Route("languagecode")]
        public IHttpActionResult DeleteSystemLanguageCode([FromBody] SystemLanguageCodePoco[] pocos)
        {
            logic.Delete(pocos);
            return Ok();
        }
    }
}
