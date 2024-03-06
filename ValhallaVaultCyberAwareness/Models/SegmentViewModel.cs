namespace ValhallaVaultCyberAwareness.Models
{
    public class SegmentViewModel
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? InfoText { get; set; }
        public double? SegmentProgress { get; set; }
        public bool IsAvailable { get; set; }
        public int CategoryId { get; set; }
        public List<QuestionModel>? Questions { get; set; }
    }
}
