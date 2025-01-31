using System.ComponentModel.DataAnnotations;

namespace Inquiry_System.Models
{
    public class PlaneType
    {
        public int Id { get; set; }

        [Required]
        public string Type { get; set; }
        public string Description { get; set; }
    }
}
