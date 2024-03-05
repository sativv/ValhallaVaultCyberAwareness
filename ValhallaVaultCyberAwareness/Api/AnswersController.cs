using Microsoft.AspNetCore.Mvc;
using ValhallaVaultCyberAwareness.Data;
using ValhallaVaultCyberAwareness.Models;
using ValhallaVaultCyberAwareness.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ValhallaVaultCyberAwareness.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswersController(ApplicationDbContext context) : ControllerBase
    {
        private readonly ValhallaUow uow = new(context);

        // GET: api/<AnswersController>
        [HttpGet]
        public async Task<ActionResult<List<AnswerModel>>> Get()
        {
            return Ok(await uow.AnswerRepo.GetAllAsync());
        }

        // GET api/<AnswersController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AnswerModel>> Get(int id)
        {
            return Ok(await uow.AnswerRepo.GetByIdAsync(id));
        }

        // POST api/<AnswersController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] AnswerModel answer)
        {
            try
            {
                await uow.AnswerRepo.AddAsync(answer);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        // PUT api/<AnswersController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] AnswerModel answer)
        {
            try
            {
                await uow.AnswerRepo.UpdateAsync(id, answer);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        // DELETE api/<AnswersController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await uow.AnswerRepo.RemoveByIdAsync(id);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
