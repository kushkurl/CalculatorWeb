using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorWebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        [HttpGet]
        public double Add(int lVal, int rVal)
        {
            Response.Headers.Add("Access-Control-Allow-Origin", "https://localhost:44362");
            return lVal + rVal;
        }
        [HttpGet]
        public double Subtract(int lVal, int rVal)
        {
            Response.Headers.Add("Access-Control-Allow-Origin", "https://localhost:44362");
            return lVal - rVal;
        }
        [HttpGet]
        public double Multiply(int lVal, int rVal)
        {
            Response.Headers.Add("Access-Control-Allow-Origin", "https://localhost:44362");
            return lVal * rVal;
        }
        [HttpGet]
        public double Divide(int lVal, int rVal)
        {
            Response.Headers.Add("Access-Control-Allow-Origin", "https://localhost:44362");
            return lVal/rVal;
        }
    }
}
