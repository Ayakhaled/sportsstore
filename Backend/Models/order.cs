using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Backend.Models
{
    public class Order
    {
        // ReSharper disable InconsistentNaming  JSON likes lower case
        public Guid id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string street { get; set; }
        [Required]
        public string city { get; set; }
        [Required]
        public string state { get; set; }
        [Required]
        public string zip { get; set; }
        [Required]
        public string country { get; set; }
        public bool giftwrap { get; set; }
        [Required]
        public IEnumerable<Product> products { get; set; }
        // ReSharper restore InconsistentNaming
    }
}