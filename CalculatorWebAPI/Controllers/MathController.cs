using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Calculator;

namespace CalculatorWebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        SimpleMath math = new SimpleMath();
        [HttpGet]
        public double Add(int lVal, int rVal)
        {
            Response.Headers.Add("Access-Control-Allow-Origin", "https://localhost:44362");
            return math.Calculate(lVal, rVal, "Add");
        }
        [HttpGet]
        public double Subtract(int lVal, int rVal)
        {
            Response.Headers.Add("Access-Control-Allow-Origin", "https://localhost:44362");
            return math.Calculate(lVal, rVal, "Sub");
        }
        [HttpGet]
        public double Multiply(int lVal, int rVal)
        {
            Response.Headers.Add("Access-Control-Allow-Origin", "https://localhost:44362");
            return math.Calculate(lVal, rVal, "Mult");
        }
        [HttpGet]
        public double? Divide(int lVal, int rVal)
        {
            if(rVal == 0)
            {
                Response.StatusCode = 400;
                return null;
            }
            Response.Headers.Add("Access-Control-Allow-Origin", "https://localhost:44362");
            return math.Calculate(lVal, rVal, "Div");
        }
    }
}
