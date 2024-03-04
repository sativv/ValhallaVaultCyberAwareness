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
			return Ok(await uow.segmentRepo.GetAllAsync());
		}

		// GET api/<SegmentsController>/5
		[HttpGet("{id}")]
		public async Task<ActionResult<SegmentModel>> Get(int id)
		{
			return Ok(await uow.segmentRepo.GetByIdAsync(id));
		}

		// POST api/<SegmentsController>
		[HttpPost]
		public async Task<ActionResult> Post([FromBody] SegmentModel segment)
		{
			try
			{
				await uow.segmentRepo.AddAsync(segment);
				return Ok();
			}
			catch
			{
				return BadRequest();
			}
		}

		// PUT api/<SegmentsController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<SegmentsController>/5
		[HttpDelete("{id}")]
		public async Task<ActionResult> Delete(int id)
		{
			try
			{
				await uow.segmentRepo.RemoveByIdAsync(id);
				return Ok();
			}
			catch
			{
				return BadRequest();
			}
		}
	}
}
