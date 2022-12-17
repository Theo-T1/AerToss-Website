using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AerToss.Core.Models.Shared
{
    public class ReviewModel
    {
        [Required]
        public string? Description { get; set; }

        [Required]
        [Range(1, 10)]
        public int Rating { get; set; }

        [Required]
        public DateTime Date { get; set; }
    }
}
