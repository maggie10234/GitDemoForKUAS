using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace eSaleX.Controllers
{
    public class orderController : Controller
    {
        //
        // GET: /order/
        public ActionResult Index()
        {
            Models.OrderService orderService = new Models.OrderService();
            var order = orderService.GetorderById("111");
            ViewBag.CustId = order.CustID;
            ViewBag.CustName = order.CustName;
            return View();
        }
	}
}