using Microsoft.AspNetCore.Mvc;
using ValhallaVaultCyberAwareness.Data;
using ValhallaVaultCyberAwareness.Models;
using ValhallaVaultCyberAwareness.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ValhallaVaultCyberAwareness.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionsController(ApplicationDbContext context) : ControllerBase
    {
        private readonly ValhallaUow uow = new(context);

        // GET: api/<QuestionsController>
        [HttpGet]
        public async Task<ActionResult<List<QuestionModel>>> Get()
        {
            return Ok(await uow.QuestionRepo.GetAllAsync());
        }

        // GET api/<QuestionsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<QuestionModel>> Get(int id)
        {
            return Ok(await uow.QuestionRepo.GetByIdAsync(id));
        }

        // POST api/<QuestionsController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] QuestionModel question)
        {
            try
            {
                await uow.QuestionRepo.AddAsync(question);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        // PUT api/<QuestionsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] QuestionModel question)
        {
            throw new NotImplementedException();
        }

        // DELETE api/<QuestionsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await uow.QuestionRepo.RemoveByIdAsync(id);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
