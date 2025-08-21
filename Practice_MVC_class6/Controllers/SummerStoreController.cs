using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Practice_MVC_class6.Models;
using System.Collections.Generic;


namespace Practice_MVC_class6.Controllers
{
    public class SummerStoreController : Controller
    {
        // Shared static list to store all orders
        private static List<PopsciclesOrder> Orders = new List<PopsciclesOrder>();


        [HttpGet]
        public IActionResult Welcome()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Order()
        {
            return View();
        }


        public IActionResult AdminOrders()
        {
            return View(Orders); // Show all past orders
        }


        [HttpPost]
        public IActionResult CheckOut(string CustomerName, int NumPopscicles, string IceCreamFlavour)
        {
            Debug.WriteLine("I have received data from a POST request");
            Debug.WriteLine(CustomerName);
            Debug.WriteLine(NumPopscicles);
            Debug.WriteLine(IceCreamFlavour);


            // Create a single order from form input
            PopsciclesOrder NewOrder = new PopsciclesOrder
            {
                CustomerName = CustomerName,
                IceCreamFlavour = IceCreamFlavour,
                PopsciclesCost = 1.5M,
                NumPopscicles = NumPopscicles,
                Taxrate = 0.13M
            };


            NewOrder.SubTotal = NewOrder.NumPopscicles * NewOrder.PopsciclesCost;
            NewOrder.HstAmt = NewOrder.SubTotal * NewOrder.Taxrate;
            NewOrder.OrderTotal = NewOrder.SubTotal + NewOrder.HstAmt;


            // Add order to shared list for AdminOrders
            Orders.Add(NewOrder);


            return View(NewOrder); // Show single order summary
        }
    }
}