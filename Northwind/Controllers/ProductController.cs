using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Northwind.Models;

namespace Northwind.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Category()
        {
            return View();
        }

        public ActionResult Discount()
        {
            return View();
        }

        public ActionResult Unit2Project()
        {
            ProductContext productContext = new ProductContext();
            return View(productContext.GetAll());
        }

        public ActionResult ProcessOrder(FormCollection form)
        {
            ProductContext productContext = new ProductContext();
            List<Order> orders = new List<Order>();
            int qty;
            double total = 0;
            foreach (var key in form.AllKeys)
            {
                if (int.TryParse(form[key], out qty) && qty > 0 && qty < 10000)
                {
                    int keyOut;
                    int.TryParse(key, out keyOut);
                    var p = productContext.Find(keyOut);
                    orders.Add(new Order{ OrderedProduct = p, Quantity = qty});
                    total += p.Price * qty;
                }

                if (key.Equals("firstName"))
                {
                    ViewBag.firstName = form[key];
                }else if (key.Equals("lastName"))
                {
                    ViewBag.lastName = form[key];
                }else if (key.Equals("address"))
                {
                    ViewBag.address = form[key];
                }else if (key.Equals("city"))
                {
                    ViewBag.city = form[key];
                }else if (key.Equals("state"))
                {
                    ViewBag.state = form[key];
                }else if (key.Equals("zipCode"))
                {
                    ViewBag.zipCode = form[key];
                }
            }

            ViewBag.total = total;
            return View(orders);
        }
    }
}