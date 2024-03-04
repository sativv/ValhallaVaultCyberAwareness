using ValhallaVaultCyberAwareness.Data;

namespace ValhallaVaultCyberAwareness.Repository
{
    public class QuestionRepo
    {
        private readonly ApplicationDbContext context;

        public QuestionRepo(ApplicationDbContext context)
        {
            this.context = context;
        }
    }
}
