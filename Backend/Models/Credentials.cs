using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Credentials
    {
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
    }
}