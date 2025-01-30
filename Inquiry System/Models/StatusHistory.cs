using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Inquiry_System.Models
{
    public class StatusHistory
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        [Required]
        public int InquiryId { get; set; }

        [ForeignKey("InquiryId")]
        public Inquiry Inquiry { get; set; }

        [Required]
        [MaxLength(100)]
        public string NewStatus { get; set; }

        [Required]
        [MaxLength(100)]
        public string Status { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }

}
