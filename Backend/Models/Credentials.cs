using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Credentials
    {
        // ReSharper disable InconsistentNaming  JSON likes lower case
        [Required]
        public string username { get; set; }
        [Required]
        public string password { get; set; }
        // ReSharper restore InconsistentNaming
    }
}