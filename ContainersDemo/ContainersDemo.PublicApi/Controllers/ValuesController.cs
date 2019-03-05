using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ContainersDemo.PublicApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly HttpClient _client;

        public ValuesController(HttpClient client)
        {
            _client = client;
        }

        [HttpGet]
        public async Task<ActionResult<string>> Get()
        {
            _client.BaseAddress = new Uri($"http://{Environment.GetEnvironmentVariable("privateapi")}");
            var response = await _client.GetAsync("api/values");
            var str = await response.Content.ReadAsStringAsync();
            return str;
        }
    }
}

