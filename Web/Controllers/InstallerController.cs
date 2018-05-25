using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Business;
namespace Web.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/installer")]
    public class InstallerController : ApiController
    {
        // GET: api/Installer
        public IHttpActionResult Get()
        {
            
            return Ok();
        }

        // GET: api/Installer/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Installer
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Installer/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Installer/5
        public void Delete(int id)
        {
        }
    }
}
