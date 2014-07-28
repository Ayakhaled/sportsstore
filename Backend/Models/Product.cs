using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Product
    {
        [Required]
        public string name { get; set; }
        [Required]
        public string description { get; set; }
        [Required]
        public string category { get; set; }
        [Required]
        public double price { get; set; }
    }
}