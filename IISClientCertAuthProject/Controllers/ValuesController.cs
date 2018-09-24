using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace IISClientCertAuth.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            foreach (System.Collections.Generic.KeyValuePair<string, Microsoft.Extensions.Primitives.StringValues> h in Request.Headers)
            {
                Console.WriteLine($"\"{h.Key}\" = \"{h.Value}\"");
            }
            return Ok(new
            {
                User?.Identity?.IsAuthenticated,
                User?.Identity?.AuthenticationType,
                User?.Identity?.Name,
                ContextIsAuthenticated = HttpContext.User?.Identity?.IsAuthenticated,
                ContextAuthType = HttpContext.User?.Identity?.AuthenticationType,
                ContextName = HttpContext?.User?.Identity?.Name
            });
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
            // For more information on protecting this API from Cross Site Request Forgery (CSRF) attacks, see https://go.microsoft.com/fwlink/?LinkID=717803
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            // For more information on protecting this API from Cross Site Request Forgery (CSRF) attacks, see https://go.microsoft.com/fwlink/?LinkID=717803
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            // For more information on protecting this API from Cross Site Request Forgery (CSRF) attacks, see https://go.microsoft.com/fwlink/?LinkID=717803
        }
    }
}
