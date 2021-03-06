﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace ContainersDemo.PrivateApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2", Environment.GetEnvironmentVariable("HOSTNAME") };
        }
    }
}
