using BasicWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasicWebAPI.Controllers
{
    [ApiController]
    [Route("coffee")]
    public class BasicController : Controller
    {
        [HttpGet]
        [Route("order")]
        public IActionResult OrderCoffee()
        {
            var order = new CoffeeOrder() { Drink = "Hot Chocolate", Price = 5.00M };

            var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(order);

            var result = new OkObjectResult(order);
            result.ContentTypes.Add(new Microsoft.Net.Http.Headers.MediaTypeHeaderValue("application/json"));
            //result.StatusCode = 200;

            return result;
        }

        [HttpPost]
        [Route("order")]
        public IActionResult OrderCoffee([FromBody]CoffeeOrder model=null)
        {
            if (model == null)
            {
                return BadRequest();
            }
            else
            {
                return StatusCode(204);
            }
        }
    }
}
