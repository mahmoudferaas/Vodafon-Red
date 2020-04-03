using System.Collections.Generic;

namespace BLL.Dtos
{
    public class StatusDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<SalesDto> Sales { get; set; }
    }
}
