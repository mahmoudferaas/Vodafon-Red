using System;
using System.Collections.Generic;

namespace DAL.Entities
{
    public class Number
    {
        public int ID { get; set; }
        public string No { get; set; }
        public Nullable<bool> IsChoosen { get; set; }
        public Nullable<bool> IsPrivate { get; set; }
        public string UserId { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
