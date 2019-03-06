using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ContainersDemo.PublicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            var client = new HttpClient
            {
                BaseAddress = new Uri($"http://{Environment.GetEnvironmentVariable("privateapi")}")
            };
            var response = await client.GetAsync("api/values");
            var str = await response.Content.ReadAsStringAsync();
            return str;
        }
    }
}

