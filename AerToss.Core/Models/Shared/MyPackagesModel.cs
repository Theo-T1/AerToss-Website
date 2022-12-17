using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerToss.Core.Models.Shared
{
    public class MyPackagesModel
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
    }
}
