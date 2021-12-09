using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBlogAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBlogAPI.Controllers
{
    [Route("api")]
    [ApiController]
    public class PingController : ControllerBase
    {
        [HttpGet]
        [Route("/ping")]
        public async Task<IActionResult> Ping()
        {
            var task = Task.Run(() =>
            {
                var response = new PingResponse()
                {
                    Ticks = DateTime.UnixEpoch.Ticks,
                    Status = "success"
                };

                var result = new OkObjectResult(response);

                return result;
            });

            return await task;
        }
    }
}
