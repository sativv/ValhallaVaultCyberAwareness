using ValhallaVaultCyberAwareness.Data;
using ValhallaVaultCyberAwareness.Models;

namespace ValhallaVaultCyberAwareness.Repository
{
    public class LogRepo
    {
        private readonly ApplicationDbContext context;

        public LogRepo(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task<LoggerModel> AddAsync(LoggerModel logToAdd)
        {
            await context.Logs.AddAsync(logToAdd);
            await SaveChangesAsync();
            return logToAdd;
        }


        public async Task SaveChangesAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
