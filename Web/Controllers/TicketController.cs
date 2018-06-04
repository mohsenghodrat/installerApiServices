using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Common;
using Business;

namespace Web.Controllers
{
    [RoutePrefix("api/ticket")]
    public class TicketController : ApiController
    {
        TicketManager ticketManager = null;
        
        public TicketController()
        {
            if (ticketManager == null)
            {
                ticketManager = new TicketManager();
            }
        }
        [Route("", Name = "GetAllTickets")]
        // GET: api/Ticket
        public IHttpActionResult Get()
        {
            var res = ticketManager.GetQuery().ToList() ?? null;
            if (res != null)
            {
                return Ok(res);
            }
            return NotFound();
        }
        //[Route("", Name = "GetTicketBy")]
        //// GET: api/Ticket/5
        //public string Get(int id)
        //{
        //    return "value";
        //}
        [Route("", Name = "AddTicket")]
        // POST: api/Ticket
        public HttpResponseMessage Post(Ticket ticket)
        {
            ticket.TicketId = Guid.NewGuid().ToString();
            ticket.CreatedTicketDateTime = DateTime.Now;
            ticketManager.AddTicket(ticket);
            ticketManager.Save();
            return Request.CreateResponse(HttpStatusCode.Created);
        }
        [Route("", Name = "UpdateTicket")]
        // PUT: api/Ticket/5
        public HttpResponseMessage Put(Ticket ticket)
        {
            ticketManager.UpdateTicket(ticket);
            ticketManager.Save();
            return Request.CreateResponse(HttpStatusCode.OK);
        }
        [Route("", Name = "DeleteTicket")]
        // DELETE: api/Ticket/5
        public HttpResponseMessage Delete(Ticket ticket)
        {
            ticketManager.DeleteTicket(ticket);
            ticketManager.Save();
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}
