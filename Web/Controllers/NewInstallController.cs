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
    [RoutePrefix("api/newinstallticket")]
    public class NewInstallController : ApiController
    {
        NewInstallManager  installedTticketManager = null;
        public NewInstallController()
        {
            if (installedTticketManager == null)
            {
                installedTticketManager = new NewInstallManager();
            }
        }
        [Route("",Name = "GetAllNewInstallTicket")]
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
        [Route("", Name = "AddNewInstallTicket")]
        //Post
        public HttpResponseMessage Post (NewInstall ticket)
        {
            ticket.TicketId = Guid.NewGuid().ToString();
            ticket.CreatedInstalledTicketDateTime = DateTime.Now;
            installedTticketManager.AddTicket(ticket);
            installedTticketManager.Save();
            return Request.CreateResponse(HttpStatusCode.Accepted);
        }
        [Route("", Name = "UpdateNewInstallTicket")]
        //Put
        public HttpResponseMessage Put(NewInstall ticket)
        {
            installedTticketManager.UpdateTicket(ticket);
            installedTticketManager.Save();
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [Route("", Name = "DeleteNewInstallTicket")]
        //Delete
        public HttpResponseMessage Delete(NewInstall ticket)
        {
            installedTticketManager.DeleteTicket(ticket);
            installedTticketManager.Save();
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
