using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Northwind_WebAPI.Models;

namespace Northwind_WebAPI.Controllers
{
    [RoutePrefix("api")]
    public class NorthwindController : ApiController
    {
        Northwind_Task2_DBEntities1 db = new Northwind_Task2_DBEntities1();

        [HttpGet]
       [Route("orders/buchanan")]
        public IHttpActionResult GetOrdersOfBuchanan()
        {
            var orders = db.Orders
                .Where(o => o.EmployeeID == 5)
                .Select(o => new
                {
                    o.OrderID,
                    o.CustomerID,
                    o.OrderDate
                }).ToList();
            return Ok(orders);
        }

        [HttpGet]
        [Route("api/customers/bycountry")]
        public IHttpActionResult GetCustomerByCountry(string country)
        {
            var res = db.GetCustomersByCountry(country).ToList();
            return Ok(res);
        }
    }
}
