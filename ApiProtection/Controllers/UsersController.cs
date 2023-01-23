using ApiProtection.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ApiProtection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET: api/<UsersController>
        [HttpGet]
        [ResponseCache(Duration = 10, Location = ResponseCacheLocation.Any, NoStore = false)]
        public IActionResult Get()
        {
            return  Ok(Random.Shared.Next(1,101).ToString()) ;
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        [ResponseCache(Duration = 10, Location = ResponseCacheLocation.Any, NoStore = false)]
        public IActionResult Get(int id)
        {
            return Ok($"Value for id: {id}  is {Random.Shared.Next(1, 101).ToString()}");
        }

        // POST api/<UsersController>
        [HttpPost]
        public IActionResult Post([FromBody] UserModel model)
        {
            if(ModelState.IsValid)
            {
                return Ok("The model was valid");
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
