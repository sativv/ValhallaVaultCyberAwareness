using System.ComponentModel.DataAnnotations;

namespace ValhallaVaultCyberAwareness.Models
{
	public class SubCategoryModel
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public int SegmentId { get; set; }
		public SegmentModel Segment { get; set; } = null!;
		public List<QuestionModel> Questions { get; set; } = new();
	}
}
