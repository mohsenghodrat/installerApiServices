using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using Business;
using Common;


namespace Web.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [RoutePrefix("api/installer")]
    public class InstallerController : ApiController
    {
        InstallerManager installerManager = null;
        public InstallerController()
        {
            if (installerManager == null)
            {
                installerManager = new InstallerManager();
            }
        }
        [Route("", Name = "GetAllTickets")]
        // GET: api/Installer
        public IHttpActionResult Get()
        {
            var res = installerManager.GetQuery().ToList() ?? null;
            if(res != null)
            {
                return Ok(res);
            }
            return NotFound();
        }
        [Route("", Name = "AddInstallerTicket")]
        // POST: api/Installer
        public HttpResponseMessage Post(Installer ticket)
        {
            if(ticket == null)
            {
                return Request.CreateResponse(HttpStatusCode.NotAcceptable,"PLease Enter True Object");
            }

            ticket.UserId = Guid.NewGuid().ToString();
            ticket.CreatedUserDateTime = DateTime.Now;
            installerManager.AddTicket(ticket);
            installerManager.Save();
            return Request.CreateResponse(HttpStatusCode.Accepted);
        }
        [Route("", Name = "UpdateINstallerTicket")]
        // PUT: api/Installer/5
        public HttpResponseMessage Put(Installer ticket)
        {
            installerManager.UpdateTicket(ticket);
            installerManager.Save();
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [Route("", Name = "DeleteInstallerTicket")]
        // DELETE: api/Installer/5
        public HttpResponseMessage Delete(Installer ticket)
        {
            installerManager.DeleteTicket(ticket);
            installerManager.Save();
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
