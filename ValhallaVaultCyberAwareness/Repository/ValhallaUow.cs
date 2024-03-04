using ValhallaVaultCyberAwareness.Data;

namespace ValhallaVaultCyberAwareness.Repository
{
    public class ValhallaUow
    {
        private readonly ApplicationDbContext context;

        public ValhallaUow(ApplicationDbContext context)
        {
            this.context = context;
            CategoryRepo = new(context);
            AnswerRepo = new(context);
            QuestionRepo = new(context);
            SubcategoryRepo = new(context);
            segmentRepo = new(context);
        }

        public AnswerRepo AnswerRepo { get; set; }
        public CategoryRepo CategoryRepo { get; set; }
        public QuestionRepo QuestionRepo { get; set; }

        public SubcategoryRepo SubcategoryRepo { get; set; }
        public SegmentRepo segmentRepo { get; set; }


    }
}
