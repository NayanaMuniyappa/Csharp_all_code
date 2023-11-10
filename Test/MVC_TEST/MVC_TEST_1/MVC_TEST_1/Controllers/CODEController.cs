using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_TEST_1.Models;


namespace MVC_TEST_1.Controllers
{
    public class CODEController : Controller
    {
        // GET: CODE

        public NorthwindContext con = new NorthwindContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Method1()
        {

            var customersInGermany = con.Customers.Where(c => c.Country == "Germany").ToList();
            return View(customersInGermany);

        }
        public ActionResult method2()
        {
            var customer =con.Orders.FirstOrDefault(c => c.OrderID== 10248);
            return View(customer);
        }
    }
}