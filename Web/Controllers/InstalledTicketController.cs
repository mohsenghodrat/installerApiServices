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
    [RoutePrefix("api/installedticket")]
    public class InstalledTicketController : ApiController
    {
        InstalledTicketManager  installTticketManager = null;
        public InstalledTicketController()
        {
            if (installTticketManager == null)
            {
                installTticketManager = new InstalledTicketManager();
            }
        }
        [Route("",Name = "")]
        //Get
        public IHttpActionResult Get()
        {
            return Ok();
        }
        [Route("", Name = "")]
        //Post
        public HttpResponseMessage Post ()
        {
            return null;
        }
        [Route("", Name = "")]
        //Put
        public void Put()
        {
           
        }
        //Delete
        public void Delete()
        {

        }
    }
}
