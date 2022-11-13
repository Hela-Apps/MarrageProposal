using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entity.Common
{
    public class BaseEntity : IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int CreatedBy { get; set; }
        [Required]
        public DateTime CreatedDate { get; set; }
        public int LastUpdateBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }


    }
}
