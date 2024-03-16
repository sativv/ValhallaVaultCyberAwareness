using Microsoft.AspNetCore.Mvc;
using ValhallaVaultCyberAwareness.Data;
using ValhallaVaultCyberAwareness.Models;
using ValhallaVaultCyberAwareness.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ValhallaVaultCyberAwareness.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class SegmentsController(ApplicationDbContext context) : ControllerBase
    {
        private readonly ValhallaUow uow = new(context);

        // GET: api/<SegmentsController>
        [HttpGet]
        public async Task<ActionResult<List<SegmentModel>>> Get()
        {
            return Ok(await uow.SegmentRepo.GetAllAsync());
        }

        // GET api/<SegmentsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SegmentModel>> Get(int id)
        {
            SegmentModel? segment = await uow.SegmentRepo.GetByIdAsync(id);

            if (segment == null) return BadRequest();

            SegmentModel projSegment = new()
            {
                Id = segment.Id,
                Name = segment.Name,
                InfoText = segment.InfoText,
                CategoryId = segment.CategoryId,
            };

            return Ok(projSegment);
        }

        // POST api/<SegmentsController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] SegmentModel segment)
        {
            try
            {
                await uow.SegmentRepo.AddAsync(segment);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        // PUT api/<SegmentsController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] SegmentModel segment)
        {
            try
            {
                await uow.SegmentRepo.UpdateAsync(id, segment);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        // DELETE api/<SegmentsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await uow.SegmentRepo.RemoveByIdAsync(id);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
