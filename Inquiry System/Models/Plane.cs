using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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
        public int PlaneTypeID { get; set; }

        [ForeignKey("PlaneTypeID")]
        public PlaneType PlaneType { get; set; }

        public string Availability { get; set; }

        public byte[] Photo { get; set; }
        public string PhotoContentType { get; set; }
    }

}
