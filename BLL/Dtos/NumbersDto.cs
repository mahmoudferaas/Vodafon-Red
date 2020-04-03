using System.Collections.Generic;

namespace BLL.Dtos
{
    public class NumbersDto
    {
        public int ID { get; set; }
        public string No { get; set; }
        public bool? IsChoosen { get; set; }
        public bool? IsPrivate { get; set; }
        public string UserId { get; set; }
        public List<SalesDto> Sales { get; set; }
    }
}
