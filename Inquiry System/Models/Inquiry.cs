using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Inquiry_System.Models
{
    public class Inquiry
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Title { get; set; }

        [Required]
        public int PlaneId { get; set; }

        [ForeignKey("PlaneId")]
        public Plane Plane { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [MaxLength(100)]
        public string FirmName { get; set; }

        [MaxLength(20)]
        public string EIK { get; set; }

        [MaxLength(50)]
        public string MOL { get; set; }

        public string City { get; set; }
        public string Address { get; set; }
        public string Country { get; set; }

        [MaxLength(500)]
        public string Content { get; set; }

        [MaxLength(50)]
        public string Status { get; set; }
    }

}
