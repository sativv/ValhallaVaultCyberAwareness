namespace ValhallaVaultCyberAwareness.Models
{
    public class SubCategoryViewModel
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Image { get; set; }
        public string? InfoText { get; set; }
        public double? SubCategoryProgress { get; set; }
        public bool IsAvailable { get; set; }
        public int SegmentId { get; set; }
        public SegmentModel? Segment { get; set; }
    }
}
