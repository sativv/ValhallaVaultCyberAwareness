using Microsoft.AspNetCore.Mvc;
using ValhallaVaultCyberAwareness.Data;
using ValhallaVaultCyberAwareness.Models;
using ValhallaVaultCyberAwareness.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ValhallaVaultCyberAwareness.Api
{
	[Route("api/[controller]")]
	[ApiController]
	public class CategoriesController(ApplicationDbContext context) : ControllerBase
	{
		private readonly ValhallaUow uow = new(context);

		// GET: api/<CategoriesController>
		[HttpGet]
		public async Task<ActionResult<List<CategoryModel>>> Get()
		{
			return Ok(await uow.CategoryRepo.GetAllAsync());
		}

		// GET api/<CategoriesController>/5
		[HttpGet("{id}")]
		public async Task<ActionResult<CategoryModel>> Get(int id)
		{
			return Ok(await uow.CategoryRepo.GetByIdAsync(id));
		}

		// POST api/<CategoriesController>
		public async Task<ActionResult> Post([FromBody] CategoryModel category)
		{
			try
			{
				await uow.CategoryRepo.AddAsync(category);
				return Ok();
			}
			catch
			{
				return BadRequest();
			}
		}

		// PUT api/<CategoriesController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<CategoriesController>/5
		[HttpDelete("{id}")]
		public async Task<ActionResult> Delete(int id)
		{
			try
			{
				await uow.CategoryRepo.RemoveByIdAsync(id);
				return Ok();
			}
			catch
			{
				return BadRequest();
			}
		}
	}
}
