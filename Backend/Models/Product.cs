using System;
using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Product
    {
        // ReSharper disable InconsistentNaming  JSON likes lower case
        public Guid id { get; set; }
        [Required]
        public string name { get; set; }
        public string description { get; set; }
        public string category { get; set; }
        [Required]
        public double price { get; set; }
        // ReSharper restore InconsistentNaming
    }
}