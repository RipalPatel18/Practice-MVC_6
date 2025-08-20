using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Practice_MVC_class6.Controllers
{
    public class SummerStoreController : Controller
    {

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

        [HttpPost]
        public IActionResult CheckOut(string CustomerName, int NumPopscicles, string IceCreamFlavour)
        {
            Debug.WriteLine("I have received data from a POST request");
            Debug.WriteLine(CustomerName);
            Debug.WriteLine(NumPopscicles);
            Debug.WriteLine(IceCreamFlavour);

            ViewData["CustomerName"] = CustomerName;
            ViewData["NumPopscicles"] = NumPopscicles;
            ViewData["IceCreamFlavour"] = IceCreamFlavour;

            decimal PopsciclesCost = 1.5M;

            decimal SubTotal = NumPopscicles * PopsciclesCost;
            decimal Taxrate = 0.13M;
            decimal HST = SubTotal * Taxrate;

            ViewData["SubTotal"] = SubTotal;
            ViewData["HstAmt"] = HST;
            ViewData["HstRate"] = "13%";
            ViewData["OrderTotal"] = SubTotal + HST;


            return View();
        }
    }
}
