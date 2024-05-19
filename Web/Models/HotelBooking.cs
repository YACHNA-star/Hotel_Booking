using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Web.Models
{
    public class HotelBooking
    {

        public int Id { get; set; }
        public int APP_ID { get; set; }
        public string? Name { get; set; }
        
        public DateOnly DateStart { get; set; }

        public DateOnly DateEnd { get; set; }

    }
}
