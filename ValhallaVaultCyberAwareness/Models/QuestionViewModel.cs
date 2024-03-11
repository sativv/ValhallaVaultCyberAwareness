namespace ValhallaVaultCyberAwareness.Models
{
    public class QuestionViewModel
    {
        public int? Id { get; set; }
        public string? Title { get; set; }
        public bool IsAnsweredCorrectly { get; set; }
        public int SubCategoryId { get; set; }
    }
}
