using Microsoft.AspNetCore.Mvc;
using ValhallaVaultCyberAwareness.Data;
using ValhallaVaultCyberAwareness.Models;
using ValhallaVaultCyberAwareness.Repository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ValhallaVaultCyberAwareness.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoriesController(ApplicationDbContext context) : ControllerBase
    {
        private readonly ValhallaUow uow = new(context);

        // GET: api/<SubCategoriesController>
        [HttpGet]
        public async Task<ActionResult<List<SubCategoryModel>>> Get()
        {
            return Ok(await uow.SubcategoryRepo.GetAllAsync());
        }

        // GET api/<SubCategoriesController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SubCategoryModel>> Get(int id)
        {
            return Ok(await uow.SubcategoryRepo.GetByIdAsync(id));
        }

        // POST api/<SubCategoriesController>
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] SubCategoryModel subcategory)
        {
            try
            {
                await uow.SubcategoryRepo.AddAsync(subcategory);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        // PUT api/<SubCategoriesController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] SubCategoryModel subcategory)
        {
            throw new NotImplementedException();
        }

        // DELETE api/<SubCategoriesController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await uow.SubcategoryRepo.RemoveByIdAsync(id);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
