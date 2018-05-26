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
    [RoutePrefix("api/installedticket")]
    public class InstalledTicketController : ApiController
    {
        InstalledTicketManager  installedTticketManager = null;
        public InstalledTicketController()
        {
            if (installedTticketManager == null)
            {
                installedTticketManager = new InstalledTicketManager();
            }
        }
        [Route("",Name = "GetAllInstalledTicket")]
        //Get
        public IHttpActionResult Get()
        {
            var res = installedTticketManager.GetQuery().ToList() ?? null;
            if (res != null)
            {
                return Ok(res);
            }
            return NotFound();
        }
        [Route("", Name = "AddInstalledTicket")]
        //Post
        public HttpResponseMessage Post (InstalledTicket ticket)
        {
            ticket.TicketId = Guid.NewGuid().ToString();
            ticket.CreatedInstalledTicketDateTime = DateTime.Now;
            installedTticketManager.AddTicket(ticket);
            installedTticketManager.Save();
            return Request.CreateResponse(HttpStatusCode.Accepted);
        }
        [Route("", Name = "UpdateInstalledTicket")]
        //Put
        public HttpResponseMessage Put(InstalledTicket ticket)
        {
            installedTticketManager.UpdateTicket(ticket);
            installedTticketManager.Save();
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [Route("", Name = "DeleteInstalledTicket")]
        //Delete
        public HttpResponseMessage Delete(InstalledTicket ticket)
        {
            installedTticketManager.DeleteTicket(ticket);
            installedTticketManager.Save();
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
