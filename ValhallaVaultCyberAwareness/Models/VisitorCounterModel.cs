using System.ComponentModel.DataAnnotations;

namespace ValhallaVaultCyberAwareness.Models
{
    public class VisitorCounterModel
    {
        [Key]
        public int VisitorNumber { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
