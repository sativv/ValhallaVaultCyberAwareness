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
            return await context.Questions.FirstOrDefaultAsync(q => q.Id == id);
        }

        public async Task RemoveByIdAsync(int id)
        {
            QuestionModel modelToRemove = await context.Questions.FirstOrDefaultAsync(q => q.Id == id);
            if (modelToRemove != null)
            {
                context.Questions.Remove(modelToRemove);
                await SaveChangesAsync();
            }

        }
        public async Task<List<QuestionModel>> GetQuestionsInSubcategoryAsnyc(int subcategoryId)
        {
            return await context.Questions.Where(q => q.SubCategoryId == subcategoryId).ToListAsync();
        }

        public async Task<QuestionModel> AddAsync(QuestionModel questionToAdd)
        {
            await context.Questions.AddAsync(questionToAdd);
            await SaveChangesAsync();
            return questionToAdd;
        }

        public async Task UpdateAsync(int id, QuestionModel newQuestion)
        {
            QuestionModel questionToUpdate = await context.Questions.FirstOrDefaultAsync(c => c.Id == id);
            if (questionToUpdate != null)
            {
                questionToUpdate.Text = newQuestion.Text;
                questionToUpdate.Answers = newQuestion.Answers;
                questionToUpdate.SubCategory = newQuestion.SubCategory;
                questionToUpdate.SubCategoryId = newQuestion.SubCategoryId;


            }
            await SaveChangesAsync();

        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
