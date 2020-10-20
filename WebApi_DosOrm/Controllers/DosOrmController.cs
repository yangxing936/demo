using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dos.ORM;
using Newtonsoft.Json;
using WebApi_DosOrm.Models;

namespace WebApi_DosOrm.Controllers
{
    public class DosOrmController : ApiController
    {
        [Route("api/DosOrm/GetOrderData")]
        [HttpPost]
        public string GetOrderData()
        {
            var orderinfo = new DosOrmContext().db.From<order_info>().ToList();
            return JsonConvert.SerializeObject(orderinfo);
        }
    }
}
