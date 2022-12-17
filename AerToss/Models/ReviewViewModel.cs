using System.ComponentModel.DataAnnotations;

namespace AerToss.Models
{
    public class ReviewViewModel
    {
        public string Text { get; set; }

        public int Rating { get; set; }

        public DateTime Date { get; set; }
    }
}
