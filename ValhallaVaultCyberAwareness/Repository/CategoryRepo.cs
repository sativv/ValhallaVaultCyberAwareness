using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwareness.Data;
using ValhallaVaultCyberAwareness.Models;

namespace ValhallaVaultCyberAwareness.Repository
{
    public class CategoryRepo
    {
        private readonly ApplicationDbContext context;

        public CategoryRepo(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<CategoryModel>?> GetAllAsync()
        {
            return await context.Categories.ToListAsync();
        }

        public async Task<CategoryModel?> GetByIdAsync(int id)
        {
            return await context.Categories.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task RemoveByIdAsync(int id)
        {
            CategoryModel modelToRemove = await context.Categories.FirstOrDefaultAsync(a => a.Id == id);
            if (modelToRemove != null)
            {
                context.Categories.Remove(modelToRemove);
                await SaveChangesAsync();
            }

        }

        public async Task<CategoryModel> AddAsync(CategoryModel categoryToAdd)
        {
            await context.Categories.AddAsync(categoryToAdd);
            await SaveChangesAsync();
            return categoryToAdd;
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
