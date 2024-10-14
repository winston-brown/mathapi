using Microsoft.AspNetCore.Mvc;

namespace MathApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MathController : ControllerBase
    {
        // POST: api/math/average
        [HttpPost("average")]
        public IActionResult CalculateAverage([FromBody] double[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return BadRequest("Please provide an array of numbers.");
            }

            double average = numbers.Average();
            return Ok(new { operation = "average", result = average });
        }
    }
}
