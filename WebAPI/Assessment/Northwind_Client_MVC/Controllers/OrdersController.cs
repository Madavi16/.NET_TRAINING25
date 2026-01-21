using Newtonsoft.Json;
using Northwind_Client_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Northwind_Client_MVC.Controllers
{
  
    public class OrdersController : Controller
    {
        // GET: Orders
        public ActionResult Index()
        {
            return View();
        }

       
        public ActionResult BuchananOrders()
        {
            IEnumerable<OrderVM> orders = null;

            using (var client =new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44398/");
                var response = client.GetAsync("api/orders/buchanan").Result;

                if(response.IsSuccessStatusCode)
                {
                    var json = response.Content.ReadAsStringAsync().Result;
                    orders = JsonConvert.DeserializeObject<List<OrderVM>>(json);
                }
            }
            return View(orders);
        }
    }
}