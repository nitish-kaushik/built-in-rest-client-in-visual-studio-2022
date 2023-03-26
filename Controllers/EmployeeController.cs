using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BuiltInRestToolInWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2","Nitish testing" };
        }

        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "This is get api for id = " + id;
        }

        [HttpPost]
        public IActionResult Post([FromBody] EmployeeModel value)
        {
            if (value != null)
            {
                value.Id += 2;
            }
            return Ok(value);
        }

        [HttpPut("{id}")]
        public string Put(int id, [FromBody] string value)
        {
            return "This is Put API and your input is = " + value;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
