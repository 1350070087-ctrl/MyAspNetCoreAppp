using System.ComponentModel.DataAnnotations;

namespace FlightBookingCore.Models
{
    public class ChuyenBay
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string DiemDi { get; set; }

        [Required]
        public string DiemDen { get; set; }

        public DateTime NgayBay { get; set; }

        public decimal GiaVe { get; set; }
    }
}