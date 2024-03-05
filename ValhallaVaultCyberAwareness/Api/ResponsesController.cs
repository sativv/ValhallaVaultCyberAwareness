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
            return Ok(await uow.ResponseRepo.GetAllAsync());
        }

        // GET api/<ResponsesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ResponseModel>> Get(int id, [FromBody] ApplicationUser user)
        {
            return Ok(await uow.ResponseRepo.GetByIdAsync(user, id));
        }

        // POST api/<ResponsesController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ResponseModel response)
        {
            try
            {
                await uow.ResponseRepo.AddAsync(response);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        // PUT api/<ResponsesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ResponsesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id, [FromBody] ApplicationUser user)
        {
            try
            {
                await uow.ResponseRepo.RemoveByIdAsync(user, id);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
