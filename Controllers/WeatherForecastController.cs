using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace OpenaAPIBadTS.Controllers
{
    public class QueryResponse
    {
        public int Data { get; set; }
    }

    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpPost]
        public ActionResult<IDictionary<string, IEnumerable<QueryResponse>>> Query()
        {
            return NoContent();
        }
    }
}
