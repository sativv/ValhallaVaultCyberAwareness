using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwareness.Data;
using ValhallaVaultCyberAwareness.Models;

namespace ValhallaVaultCyberAwareness.Repository
{
    public class SubcategoryRepo
    {
        private readonly ApplicationDbContext context;

        public SubcategoryRepo(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<List<SubCategoryModel>> GetAllAsync()
        {
            return await context.SubCategories.ToListAsync();
        }

        public async Task<SubCategoryModel?> GetByIdAsync(int id)
        {
            return await context.SubCategories.Include(s => s.Questions).FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task RemoveByIdAsync(int id)
        {
            SubCategoryModel modelToRemove = await context.SubCategories.FirstOrDefaultAsync(a => a.Id == id);
            if (modelToRemove != null)
            {
                context.SubCategories.Remove(modelToRemove);
                await SaveChangesAsync();
            }

        }

        public async Task<SubCategoryModel> AddAsync(SubCategoryModel subCategoryModel)
        {
            await context.SubCategories.AddAsync(subCategoryModel);
            await SaveChangesAsync();
            return subCategoryModel;
        }
        public async Task<List<SubCategoryModel>> GetSubcategoriesInSegmentAsync(int segmentid)
        {
            return await context.SubCategories.Where(s => s.SegmentId == segmentid).Include(s => s.Questions).ToListAsync();
        }


        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
