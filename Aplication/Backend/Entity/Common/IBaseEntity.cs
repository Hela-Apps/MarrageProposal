using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Common
{
    public interface IBaseEntity:IEntity
    {
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int LastUpdateBy { get; set; }
        public DateTime LastUpdatedDate { get; set; }
    }
}
