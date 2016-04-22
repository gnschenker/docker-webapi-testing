using Microsoft.AspNet.Mvc;

namespace api.Controllers
{
    [Route("api/[controller]")]
    public class PrimesController : Controller
    {
        [HttpGet("{number}")]
        public string Get(int number)
        {
            var isPrime = number > 1;
            for(var i = 2; i < number/2; i++) {
                if(number % i == 0) {
                    isPrime = false;
                    break;
                }
            }
            var val = isPrime ? "" : "NOT ";
            return "The number is " + val + "a prime.";
        }
    }
}
