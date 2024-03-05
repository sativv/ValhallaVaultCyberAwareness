using System.ComponentModel.DataAnnotations;

namespace ValhallaVaultCyberAwareness.Models
{
    public class QuestionModel
    {
        [Key]
        public int Id { get; set; }
        public string? Text { get; set; }
        public string Title { get; set; } = null!;

        public string? ExplanationText { get; set; }
        //public int SubCategoryId { get; set; }
        //public SubCategoryModel? SubCategory { get; set; }

        public int SegmentId { get; set; }
        public SegmentModel? Segment { get; set; }
        public List<AnswerModel> Answers { get; set; } = new();
        public List<ResponseModel> Responses { get; } = new();

    }
}
