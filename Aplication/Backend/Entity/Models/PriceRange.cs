using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Models
{
    public class PriceRange
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public double Value { get; set; }
        public bool IsActive { get; set; }
    }
}
