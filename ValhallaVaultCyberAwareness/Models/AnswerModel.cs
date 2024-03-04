using System.ComponentModel.DataAnnotations;

namespace ValhallaVaultCyberAwareness.Models
{
	public class AnswerModel
	{
		[Key]
		public int Id { get; set; }
		public string Text { get; set; } = null!;
		public bool IsCorrectAnswer { get; set; }
		public int QuestionId { get; set; }
		public QuestionModel Question { get; set; } = null!;
	}
}
