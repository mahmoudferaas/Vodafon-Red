using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public class Status
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
