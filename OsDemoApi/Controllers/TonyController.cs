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
            // Get the 'pod' host name.
            return $"{Environment.CustomMessage} - Host: '{Environment.MachineName}' - {DateTime.UtcNow}";
        }
    }
}
