using Microsoft.EntityFrameworkCore;
using ValhallaVaultCyberAwareness.Data;

namespace ValhallaVaultCyberAwareness.Repository
{
    public class UserRepo(ApplicationDbContext context)
    {
        private readonly ApplicationDbContext context = context;

        public async Task<List<ApplicationUser>> GetAllAsync()
        {
            return await context.Users.ToListAsync();
        }

        public async Task<ApplicationUser?> GetUserByUsernameAsync(string username)
        {
            string upperUsername = username.ToUpper();

            return await context.Users.FirstOrDefaultAsync(u => u.NormalizedUserName == upperUsername);
        }



    }
}
