using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwareness.Data;
using ValhallaVaultCyberAwareness.Models;

namespace ValhallaVaultCyberAwareness.Repository
{
    public class ResponseRepo
    {
        private readonly ApplicationDbContext context;

        public ResponseRepo(ApplicationDbContext context)
        {
            this.context = context;
        }


        public async Task<List<ResponseModel>> GetAllAsync()
        {
            return await context.Responses.ToListAsync();
        }

        public async Task<ResponseModel?> GetByIdAsync(ApplicationUser user, int questionId)
        {
            return await context.Responses.FirstOrDefaultAsync(r => r.User == user && r.QuestionId == questionId);
        }

        public async Task<List<ResponseModel>> GetAllResponsesToQuestion(ApplicationUser user, int questionId)
        {
            return await context.Responses.Where(r => r.User == user && r.QuestionId == questionId).ToListAsync();
        }

        public async Task RemoveByIdAsync(ApplicationUser user, int questionId)
        {
            ResponseModel modelToRemove = await context.Responses.FirstOrDefaultAsync(r => r.User == user && r.QuestionId == questionId);
            if (modelToRemove != null)
            {
                context.Responses.Remove(modelToRemove);
                await SaveChangesAsync();
            }

        }

        public async Task UpdateAsync(int questionId, ApplicationUser user, ResponseModel newResponse)
        {
            ResponseModel responseToUpdate = await context.Responses.FirstOrDefaultAsync(r => r.User == user && r.QuestionId == questionId);
            if (responseToUpdate != null)
            {
                responseToUpdate.QuestionId = newResponse.QuestionId;
                responseToUpdate.UserId = newResponse.UserId;
                responseToUpdate.IsAnsweredCorrectly = newResponse.IsAnsweredCorrectly;
            }
            await SaveChangesAsync();

        }

        public async Task<ResponseModel> AddAsync(ResponseModel responseToAdd)
        {
            await context.Responses.AddAsync(responseToAdd);
            await SaveChangesAsync();
            return responseToAdd;
        }

        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}

