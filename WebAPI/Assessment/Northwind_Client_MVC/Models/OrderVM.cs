using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Northwind_Client_MVC.Models
{
    public class OrderVM
    {
        public int OrderID { get; set; }
        public string CustomerID { get; set; }
        public DateTime? OrderDate { get; set; }
    }
}