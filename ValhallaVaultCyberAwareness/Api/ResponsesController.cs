using Microsoft.AspNetCore.Mvc;
using ValhallaVaultCyberAwareness.Data;
using ValhallaVaultCyberAwareness.Models;
using ValhallaVaultCyberAwareness.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ValhallaVaultCyberAwareness.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResponsesController(ApplicationDbContext context) : ControllerBase
    {
        private readonly ValhallaUow uow = new(context);

        // GET: api/<ResponsesController>
        [HttpGet]
        public async Task<ActionResult<List<ResponseModel>>> Get()
        {
            throw new NotImplementedException();
            //return Ok(await uow.GetAllAsync());
        }

        // GET api/<ResponsesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ResponsesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ResponsesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ResponsesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
