﻿using Microsoft.AspNetCore.Mvc;

namespace OsDemoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TonyController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            // Get the 'pod' host name.
            return $"Hello World - ITS FRIDAY - Host: '{Environment.MachineName}' - {DateTime.UtcNow}";
        }
    }
}