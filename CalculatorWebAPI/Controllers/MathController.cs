using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Calculator;

namespace CalculatorWebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        //Simple math is method in calculator class library performing actual calculations
        SimpleMath math = new SimpleMath();

        [HttpGet]
        public double Add(int lVal, int rVal)
        {
            //CORS = to explicitly allow content sharing from different origns 
            Response.Headers.Add("Access-Control-Allow-Origin", "https://localhost:44362");

            //calling calculate function in calculator library 
            return math.Calculate(lVal, rVal, "Add");
        }
        [HttpGet]
        public double Subtract(int lVal, int rVal)
        {
            //CORS = to explicitly allow content sharing from different origns
            Response.Headers.Add("Access-Control-Allow-Origin", "https://localhost:44362");

            return math.Calculate(lVal, rVal, "Sub");
        }
        [HttpGet]
        public double Multiply(int lVal, int rVal)
        {
            //CORS = to explicitly allow content sharing from different origns
            Response.Headers.Add("Access-Control-Allow-Origin", "https://localhost:44362");

            return math.Calculate(lVal, rVal, "Mult");
        }
        [HttpGet]
        public double? Divide(int lVal, int rVal)
        {
            //check for denominator if equal to 0 then response "Bad Request"
            if(rVal == 0)
            {
                Response.StatusCode = 400;
                return null;
            }
            //CORS = to explicitly allow content sharing from different origns
            Response.Headers.Add("Access-Control-Allow-Origin", "https://localhost:44362");

            return math.Calculate(lVal, rVal, "Div");
        }
    }
}
