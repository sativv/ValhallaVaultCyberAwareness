using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwareness.Data;
using ValhallaVaultCyberAwareness.Models;

namespace ValhallaVaultCyberAwareness.Repository
{
    public class AnswerRepo
    {
        private readonly ApplicationDbContext context;

        public AnswerRepo(ApplicationDbContext context)
        {
            this.context = context;
        }


        public async Task<List<AnswerModel>> GetAllAsync()
        {
            return await context.Answers.ToListAsync();
        }

        public async Task<List<AnswerModel>> GetAnswersToQuestionsAsync(int questionId)
        {
            return await context.Answers.Where(a => a.QuestionId == questionId).ToListAsync();
        }

        public async Task<AnswerModel?> GetByIdAsync(int id)
        {
            return await context.Answers.FirstOrDefaultAsync(a => a.Id == id);
        }

        public async Task RemoveByIdAsync(int id)
        {
            AnswerModel modelToRemove = await context.Answers.FirstOrDefaultAsync(a => a.Id == id);
            if (modelToRemove != null)
            {
                context.Answers.Remove(modelToRemove);
                await SaveChangesAsync();
            }

        }

        public async Task UpdateAsync(int id, AnswerModel newAnswer)
        {
            AnswerModel answerToUpdate = await context.Answers.FirstOrDefaultAsync(a => a.Id == id);
            if (answerToUpdate != null)
            {
                if (newAnswer.Text != null)
                {
                    answerToUpdate.Text = newAnswer.Text;

                }
                if (newAnswer.IsCorrectAnswer != null)
                {

                    answerToUpdate.IsCorrectAnswer = newAnswer.IsCorrectAnswer;
                }
            }
            await SaveChangesAsync();

        }

        public async Task<AnswerModel> AddAsync(AnswerModel answerToAdd)
        {
            await context.Answers.AddAsync(answerToAdd);
            await SaveChangesAsync();
            return answerToAdd;
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }

}
