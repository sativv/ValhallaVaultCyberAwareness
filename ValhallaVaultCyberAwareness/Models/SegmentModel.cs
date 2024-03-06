using System.ComponentModel.DataAnnotations;

namespace ValhallaVaultCyberAwareness.Models
{
	public class SegmentModel
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; } = null!;
		public string? InfoText { get; set; }

		public int CategoryId { get; set; }
		public CategoryModel Category { get; set; } = null!;
		//public List<SubCategoryModel> SubCategories { get; set; } = new();

		public List<QuestionModel> Questions { get; set; } = new();
	}
}
