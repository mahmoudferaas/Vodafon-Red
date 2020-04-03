using System;

namespace BLL.Dtos
{
    public class SalesDto
    {
        public int ID { get; set; }
        public long Serial { get; set; }
        public string CustomerName { get; set; }
        public string Mobile1 { get; set; }
        public string Mobile2 { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string UserId { get; set; }
        public DateTime CreationDate { get; set; }
        public string CustomerId { get; set; }
        public string Comment { get; set; }
        public Nullable<DateTime> ActivationDate { get; set; }
        public Nullable<DateTime> RejectDate { get; set; }
        public Nullable<DateTime> VisitDate { get; set; }

        public int? NumberId { get; set; }
        public virtual NumbersDto Number { get; set; }
        public int? PackageId { get; set; }
        public virtual PackagesDto Package { get; set; }
        public int? StatusId { get; set; }
        public virtual StatusDto Status { get; set; }
    }
}
