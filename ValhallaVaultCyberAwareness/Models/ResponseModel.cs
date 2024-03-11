using System.Text.Json.Serialization;
using ValhallaVaultCyberAwareness.Data;

namespace ValhallaVaultCyberAwareness.Models
{
    public class ResponseModel
    {
        public string UserId { get; set; } = null!;
        [JsonIgnore]
        public ApplicationUser User { get; set; } = null!;
        public int QuestionId { get; set; }
        [JsonIgnore]
        public QuestionModel Question { get; set; } = null!;
        public bool IsAnsweredCorrectly { get; set; }
    }
}
