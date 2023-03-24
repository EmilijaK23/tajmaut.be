using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using tajmautAPI.Models.EntityClasses;

namespace tajmautAPI.Models
{
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        [Required]
        public string Email { get; set; } = null!;
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string Address { get; set; } = null!;
        [Required]
        public string City { get; set; } = null!;
        [Required]
        public string Phone { get; set; } = null!;
        [Required]
        public DateTime ModifiedAt { get; set; }
        [Required]
        public DateTime CreatedAt { get; set; }

        [Required]
        public int CreatedBy { get; set; }

        [Required]
        public int ModifiedBy { get; set; }


        //1-N Relationships

        public List<Comment> Comments { get; set; }
        public List<Restaurant> Events { get; set; }
        public List<CategoryEvent> CategoryEvents { get; set; }
        public List<OnlineReservation> OnlineReservations { get; set; }
    }
}
