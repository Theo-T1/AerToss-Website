using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AerToss.Infrastructure.Data
{
	public class Package
	{
        [Key]
        public int Id { get; set; }

        [Required]
        public int Name { get; set; }

        [Required]
        [Range(-90, 90)]
        public double Latitude { get; set; }

        [Required]
        [Range(-180, 180)]
        public double Longitude { get; set; }

        public bool IsDelivered { get; set; } = false;

        [Required]
        public DateTime Date { get; set; }

        public string? UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public ApplicationUser? User { get; set; }
    }
}
