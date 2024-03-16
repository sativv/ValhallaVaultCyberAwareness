using System.ComponentModel.DataAnnotations;

namespace ValhallaVaultCyberAwareness.Models
{
    public class LoggerModel
    {

        [Key]
        public int Id { get; set; }
        public string? user { get; set; }
        public DateTime dateTimeAccessed { get; set; }
        public string Page { get; set; }
    }
}
