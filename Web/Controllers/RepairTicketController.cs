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
    [RoutePrefix("api/repairticket")]
    public class RepairTicketController : ApiController
    {
        RepairTicketManager repairTicketManager = null;
        public RepairTicketController()
        {
            if (repairTicketManager == null)
            {
                repairTicketManager = new RepairTicketManager();
            }
        }
        [Route("", Name = "GetAllRepairTicket")]
        //Get
        public IHttpActionResult Get()
        {
            var res = repairTicketManager.GetAllQuery().ToList() ?? null;
            if (res != null)
            {
                return Ok(res);
            }
            return NotFound();
        }
        [Route("", Name = "AddRepairTicket")]
        //Post
        public HttpResponseMessage Post(RepairTicket ticket)
        {
            ticket.TicketId = Guid.NewGuid().ToString();
            ticket.CreatedRepairTicketDateTime = DateTime.Now;
            repairTicketManager.AddTicket(ticket);
            repairTicketManager.Save();
            return Request.CreateResponse(HttpStatusCode.Accepted);
        }
        [Route("", Name = "UpdateRepairTicket")]
        //Put
        public HttpResponseMessage Put(RepairTicket ticket)
        {
            repairTicketManager.UpdateTicket(ticket);
            repairTicketManager.Save();
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [Route("",Name = "DeleteRepairTicket")]
        //Delete
        public HttpResponseMessage Delete(RepairTicket ticket)
        {
            repairTicketManager.DeleteTicket(ticket);
            repairTicketManager.Save();
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
