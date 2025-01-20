using System.ComponentModel.DataAnnotations;

namespace Inquiry_System.Models
{
    public class Plane
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        public string Specifications { get; set; }

        [Required]
        [MaxLength(50)]
        public string Type { get; set; }

        public string Availability { get; set; }

        public byte[] Photo { get; set; }
        public string PhotoContentType { get; set; }
    }

}
