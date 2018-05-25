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
        [Route("", Name = "")]
        //Get
        public IHttpActionResult Get()
        {
            return Ok();
        }
        [Route("", Name = "")]
        //Post
        public HttpResponseMessage Post()
        {
            return null;
        }
        [Route("", Name = "")]
        //Put
        public void Put()
        {

        }
        [Route("", Name = "")]
        //Delete
        public void Delete()
        {

        }
    }


}
