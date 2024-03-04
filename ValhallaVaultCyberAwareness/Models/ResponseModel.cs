using ValhallaVaultCyberAwareness.Data;

namespace ValhallaVaultCyberAwareness.Models
{
	public class ResponseModel
	{
		public string UserId { get; set; } = null!;
		public ApplicationUser User { get; set; } = null!;
		public int QuestionId { get; set; }
		public QuestionModel Question { get; set; } = null!;
		public bool IsAnsweredCorrectly { get; set; }
	}
}
