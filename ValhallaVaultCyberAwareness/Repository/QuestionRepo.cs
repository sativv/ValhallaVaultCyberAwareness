using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwareness.Data;
using ValhallaVaultCyberAwareness.Models;

namespace ValhallaVaultCyberAwareness.Repository
{
	public class QuestionRepo
	{
		private readonly ApplicationDbContext context;

		public QuestionRepo(ApplicationDbContext context)
		{
			this.context = context;
		}

		public async Task<List<QuestionModel>> GetAllAsync()
		{
			return await context.Questions.ToListAsync();
		}

		public async Task<QuestionModel?> GetByIdAsync(int id)
		{
			return await context.Questions.FirstOrDefaultAsync(a => a.Id == id);
		}

		public async Task RemoveByIdAsync(int id)
		{
			QuestionModel modelToRemove = await context.Questions.FirstOrDefaultAsync(a => a.Id == id);
			if (modelToRemove != null)
			{
				context.Questions.Remove(modelToRemove);
				await SaveChangesAsync();
			}

		}

		public async Task<QuestionModel> AddAsync(QuestionModel questionToAdd)
		{
			await context.Questions.AddAsync(questionToAdd);
			await SaveChangesAsync();
			return questionToAdd;
		}

		public async Task SaveChangesAsync()
		{
			await context.SaveChangesAsync();
		}
	}
}
