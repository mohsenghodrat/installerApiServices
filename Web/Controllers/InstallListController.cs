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
    [RoutePrefix("api/installlist")]
    public class InstallListController : ApiController
    {
        InstallListManager installLIstManager = null;
        public InstallListController()
        {
            if (installLIstManager == null)
            {
                installLIstManager = new InstallListManager();
            }
        }
        [Route("", Name = "GetAllInstallList")]
        //Get
        public IHttpActionResult Get()
        {
            var res = installLIstManager.GetQuery().ToList() ?? null;
            if(res != null)
            {
                return Ok(res);
            }
            return NotFound();
        }
        [Route("", Name = "AddInstallList")]
        //Post
        public HttpResponseMessage Post(InstallList ticket)
        {
            ticket.CreatedInstallListDateTime = DateTime.Now;
            ticket.TicketId = Guid.NewGuid().ToString();
            installLIstManager.AddTicket(ticket);
            installLIstManager.Save();
            return Request.CreateResponse(HttpStatusCode.Accepted);
        }
        [Route("", Name = "UpdateInstallList")]
        //Put
        public HttpResponseMessage Put(InstallList ticket)
        {
            installLIstManager.UpdateTicket(ticket);
            installLIstManager.Save();
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [Route("", Name = "DeleteInstallList")]
        //Delete
        public HttpResponseMessage Delete(InstallList ticket)
        {
            installLIstManager.DeleteTicket(ticket);
            installLIstManager.Save();
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }


}
