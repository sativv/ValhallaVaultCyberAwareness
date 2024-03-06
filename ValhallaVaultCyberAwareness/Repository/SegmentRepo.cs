using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwareness.Data;
using ValhallaVaultCyberAwareness.Models;

namespace ValhallaVaultCyberAwareness.Repository
{
	public class SegmentRepo
	{
		private readonly ApplicationDbContext context;

		public SegmentRepo(ApplicationDbContext context)
		{
			this.context = context;
		}

		public async Task<List<SegmentModel>> GetAllAsync()
		{
			return await context.Segments.ToListAsync();
		}

		public async Task<SegmentModel?> GetByIdAsync(int id)
		{
			return await context.Segments.Include(s => s.Questions).FirstOrDefaultAsync(a => a.Id == id);
		}

		public async Task RemoveByIdAsync(int id)
		{
			SegmentModel modelToRemove = await context.Segments.FirstOrDefaultAsync(a => a.Id == id);
			if (modelToRemove != null)
			{
				context.Segments.Remove(modelToRemove);
				await SaveChangesAsync();
			}

		}

		public async Task<SegmentModel> AddAsync(SegmentModel segmentToAdd)
		{
			await context.Segments.AddAsync(segmentToAdd);
			await SaveChangesAsync();
			return segmentToAdd;
		}
		public async Task<List<SegmentModel>> GetSegmentsInCategoryAsync(int categoryId)
		{
			return await context.Segments.Where(s => s.CategoryId == categoryId).Include(s => s.Questions).ToListAsync();
		}

		public async Task UpdateAsync(int id, SegmentModel newSegment)
		{
			SegmentModel segmentToUpdate = await context.Segments.FirstOrDefaultAsync(s => s.Id == id);
			if (segmentToUpdate != null)
			{
				//segmentToUpdate.SubCategories = newSegment.SubCategories;
				segmentToUpdate.InfoText = newSegment.InfoText;
				segmentToUpdate.Category = newSegment.Category;
				segmentToUpdate.CategoryId = newSegment.CategoryId;
				segmentToUpdate.Name = newSegment.Name;


			}
			await SaveChangesAsync();

		}

		public async Task SaveChangesAsync()
		{
			await context.SaveChangesAsync();
		}
	}
}
