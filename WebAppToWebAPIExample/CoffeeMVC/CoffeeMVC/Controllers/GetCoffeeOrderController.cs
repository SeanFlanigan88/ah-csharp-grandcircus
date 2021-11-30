using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace CoffeeMVC.Controllers
{
    public class GetCoffeeOrderController : Controller
    {
        public IActionResult Index()
        {
            ViewData["StoreName"] = "Starbucks";
            return View();
        }

        public async Task<IActionResult> GetOrder()
        {
            ViewData["StoreName"] = "Starbucks";

            using(HttpClient client = new HttpClient())
            {
                var url = "https://localhost:44312/coffee/order";
                HttpResponseMessage message = await client.GetAsync(url);
                dynamic result = JsonConvert.DeserializeObject(await message.Content.ReadAsStringAsync());

                ViewBag.drink = result.drink;
                ViewBag.price = result.price;
            }

            return View("Index");
        }

        public async Task<IActionResult> SendOrder()
        {
            ViewData["StoreName"] = "Starbucks";

            var model = new CoffeeOrder() { Drink = "Cold Brew", Price = 4.95M };

            using (HttpClient client = new HttpClient())
            {
                var url = "https://localhost:44312/coffee/order";

                var content = JsonContent.Create(model);
                HttpResponseMessage message = await client.PutAsync(url, content);
                dynamic result = JsonConvert.DeserializeObject(await message.Content.ReadAsStringAsync());

                ViewBag.drink = result.drink;
                ViewBag.price = result.price;
            }

            return View("Index");
        }
    }
}
