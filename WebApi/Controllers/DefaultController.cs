using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    public class DefaultController : ApiController
    {
        [Route("api/Default/Get")]
        [HttpGet]
        public object Get()
        {
            return null;
        }


    }
}
