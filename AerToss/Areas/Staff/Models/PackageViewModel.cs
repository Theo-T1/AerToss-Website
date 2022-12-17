using System.ComponentModel.DataAnnotations;

namespace AerToss.Areas.Shippments.Models
{
    public class PackageViewModel
    {
        public int Id { get; set; }

        public int Name { get; set; }

        public double Latitude { get; set; }

        public double Longitude { get; set; }

        public bool IsDelivered { get; set; } = false;

        public DateTime Date { get; set; }
    }
}
