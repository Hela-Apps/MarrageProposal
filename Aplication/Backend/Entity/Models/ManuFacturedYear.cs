using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Models
{
    public class ManuFacturedYear
    {
        [Key]
        public int Id { get; set; }
        public string Year { get; set; }
        public bool IsActive { get; set; }
    }
}
