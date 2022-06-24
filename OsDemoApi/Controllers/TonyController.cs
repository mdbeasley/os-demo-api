using Microsoft.AspNetCore.Mvc;

namespace OsDemoApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TonyController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            string customMessage = Environment.GetEnvironmentVariable('CustomMessage');
            
            // Get the 'pod' host name.
            return $"{customMessage} - Host: '{Environment.MachineName}' - {DateTime.UtcNow}";
        }
    }
}
